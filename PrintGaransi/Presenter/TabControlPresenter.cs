﻿using PrintPackingLabel._Repositories;
using PrintPackingLabel.Model;
using PrintPackingLabel.View;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace PrintPackingLabel.Presenter
{
    public class TabControlPresenter
    {
        private readonly ITabControlView _view;
        private IEnumerable<GaransiModel> _model;
        private readonly GaransiModel _garansiModel;
        private readonly SettingModel _smodel;
        private readonly ProductTypeModel _productType;
        private readonly PrinterTypeModel _printerType;
        private readonly IModelNumberRepository _modelNumberRepository;
        private readonly IGaransiRepository _garansiRepository;
        private BindingSource _dataBindingSource;
        private BindingSource _dataBindingSource2;
        private DateTime _lastScanTime;
        private readonly PrintModeModel _printMode;
        private readonly LoginModel _login;

        public TabControlPresenter(TabControlDataPresenter Data)
        {
            _login = Data._User;
            _view = Data.View;
            _garansiRepository = Data.GaransiRepository;
            _smodel = new SettingModel();
            _productType = new ProductTypeModel();
            _garansiModel = new GaransiModel();
            _modelNumberRepository = new ModelNumberRepository();
            _printMode = new PrintModeModel();
            _printerType = new PrinterTypeModel();

            _view.SearchModelNumber += SearchModelNumber;
            _view.SearchFilter += SearchFilter;
            _view.CheckProperties += CheckProperties;
            _view.CellClicked += CellClicked;
            _view.Inspector = _login.Name;
            _view.InspectorId = _login.Nik;

            _dataBindingSource = new BindingSource();
            _dataBindingSource2 = new BindingSource();
            _view.SetDefectListBindingSource(_dataBindingSource);
            LoadAllDataList();
        }

        private void CellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (sender is DataGridView dataGridView && e.RowIndex >= 0)
            {
                var selectedRow = dataGridView.Rows[e.RowIndex];
                var selectedData = (GaransiModel)selectedRow.DataBoundItem;


                var model = new GaransiModel
                {
                    JenisProduk = selectedData.JenisProduk,
                    ModelCode = selectedData.ModelCode,
                    ModelNumber = selectedData.ModelNumber,
                    GlobalCodeId = selectedData.GlobalCodeId,
                    NoReg = selectedData.NoReg,
                    NoSeri = selectedData.NoSeri,
                    Date = selectedData.Date,
                    ScanTime = selectedData.ScanTime,
                    Location = selectedData.Location
                };

                DialogResult dialogResult = CustomeMessageBox.Show("Apakah ingin melakukan print ulang?", "Re-Print", MessageBoxButtons.OKCancel, MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.OK)
                {
                    string printerType = _printerType.GetPrinterType();
                    _view.ShowPrintPreviewDialog(model, printerType);
                }
            }
        }

        private void CheckProperties(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_view.SerialNumber))
            {
                _view.Status = "Serial Number harus terisi";
                _view.StatusBackColor = Color.Yellow;
                _view.StatusForeColor = Color.Black;
                return;
            }

            if (string.IsNullOrWhiteSpace(_view.ModelCode))
            {
                _view.Status = "Model Code harus terisi";
                _view.StatusBackColor = Color.Yellow;
                _view.StatusForeColor = Color.Black;
                return;
            }

            var existingRecords = _garansiRepository.GetExists(_view.SerialNumber, _view.ModelCode);
            string mode = _printMode.GetMode();

            if (existingRecords != null && existingRecords.Any())
            {
                string printerType = _printerType.GetPrinterType();

                if ( mode == "off")
               {
                    _view.Register = "";
                   _view.Status = "Data sudah tersimpan dalam database, Print dalam mode Off";
                   _view.StatusBackColor = Color.Yellow;
                   _view.StatusForeColor = Color.Black;
                   return;
               }
               else if(mode == "preview")
                {
                    _view.Register = "";
                    _view.Status = "Print dalam mode Preview";
                    _view.StatusBackColor = Color.Yellow;
                    _view.StatusForeColor = Color.Black;
                    return;
                }
               else if( mode == "on")
               {
                    _view.Register = "";
                   _view.Status = "Data sudah tersimpan dalam database";
                   _view.StatusBackColor = Color.Yellow;
                   _view.StatusForeColor = Color.Black;
                   return;
               }
            }

            CreateModel();
            LoadAllDataList();
        }

        private void CreateModel()
        {
            DateTime currentTime = DateTime.Now;
            string date = currentTime.ToString("d");
            string time;
            string mode = _printMode.GetMode();
            var existingRecords = _garansiRepository.GetExists(_view.SerialNumber, _view.ModelCode);

            // Mengatur waktu ketika sudah ganti hari
            if (_lastScanTime.Date != currentTime.Date)
            {
                time = currentTime.ToString("HH:mm:ss");
                //_lastScanTime = currentTime;
            }
            else
            {
                time = currentTime.ToString(@"T");
            }

            string printerType = _printerType.GetPrinterType();

            var model = new GaransiModel
            {
                JenisProduk = _productType.LoadProductType(),
                ModelCode = _view.ModelCode,
                ModelNumber = _view.ModelNumber,
                GlobalCodeId = _view.GlobalCodeId,
                NoReg = _view.Register,
                NoSeri = _view.SerialNumber,
                Date = date,
                ScanTime = time,
                Location = _smodel.LoadLocationID(),
                inspectorId = _view.InspectorId
            };

            if (mode == "off")
            {
                if (existingRecords == null || !existingRecords.Any())
                {
                    // Data belum ada dalam database
                    _view.Status = "Data berhasil tersimpan, print dalam mode OFF.";
                    _view.StatusBackColor = Color.Green;
                    _view.StatusForeColor = Color.White;
                    _garansiRepository.Add(model);
                    _view.SerialNumber = "";
                }
                else
                {
                    // Data sudah ada dalam database
                    _view.Status = "Data sudah tersimpan dalam database, Print dalam mode OFF";
                    _view.StatusBackColor = Color.Yellow;
                    _view.StatusForeColor = Color.Black;
                }
            }
            else if (mode == "preview")
            {             
                // Data sudah ada dalam database
                _view.Status = "Print dalam mode Preview";
                _view.StatusBackColor = Color.Yellow;
                _view.StatusForeColor = Color.Black;
                _view.ShowPrintPreviewDialog(model, printerType);
            }
            else if (mode == "on")
            {
                if (existingRecords == null || !existingRecords.Any())
                {
                    // Data belum ada dalam database, print diizinkan
                    _view.ShowPrintPreviewDialog(model, printerType);
                    _view.Status = "Data berhasil di simpan";
                    _view.StatusBackColor = Color.Green;
                    _view.StatusForeColor = Color.White;
                    _garansiRepository.Add(model);
                }
                else
                {
                    // Data sudah ada dalam database
                    _view.Status = "Data sudah tersimpan dalam database.";
                    _view.StatusBackColor = Color.Yellow;
                    _view.StatusForeColor = Color.Black;
                }
            }

            LoadAllDataList();

            // Save Last Scan
            _garansiModel.SaveScanTime(_lastScanTime.ToString("O"));
        }

        public void LoadAllDataList()
        {
            string loc = _smodel.LoadLocation();

            _model = _garansiRepository.GetAll(loc);
            _dataBindingSource.DataSource = _model;
            _dataBindingSource2.DataSource = _model;
            _view.SetDefectListBindingSource(_dataBindingSource);
        }

        public void SearchFilter(object sender, EventArgs e)
        {
            string loc = _smodel.LoadLocation();

            _model = _garansiRepository.GetFilter(_view.Search, _view.SelectedDate, loc);
            _dataBindingSource2.DataSource = _model;
            _view.ShowFilter(_dataBindingSource2);
        }

        public void ChangeTabPage(int index)
        {
            _view.SelectTabPageByIndex(index);
        }

        private void SearchModelNumber(object sender, ModelEventArgs e)
        {
           var model = new GaransiModel
           {
               ModelCode = _view.ModelCode.ToString()
           };

           var searchModel = _modelNumberRepository.GetByModelCode(model);

           if (searchModel != null)
           {
                _view.ModelNumber = searchModel.ModelNumber;
                _view.GlobalCodeId = searchModel.GlobalCodeId;
                _view.Register = searchModel.NoReg;
            }
           else
           {
               ClearViewFields();
                _view.Status = "Hasil scan tidak terbaca";
                _view.StatusBackColor = Color.Yellow;
                _view.StatusForeColor = Color.Black;
           }
        }

        private void ClearViewFields()
        {
            _view.SerialNumber = "";
            _view.ModelCode = "";
            _view.ModelNumber = "";
            _view.Register = "";
            _view.Status = "";
            _view.GlobalCodeId = "";
            _view.StatusBackColor = SystemColors.Control;
        } 
        
        public void ResetDataBinding()
        {
            _dataBindingSource.DataSource = null;
            _dataBindingSource2.DataSource = null;
            _view.SetDefectListBindingSource(null);
            _view.SetDefectListBindingSource(_dataBindingSource);
            ClearViewFields();
            LoadAllDataList();
        }

        public void UnassociateViewEvents()
        {
            _view.SearchModelNumber -= SearchModelNumber;
            _view.SearchFilter -= SearchFilter;
            _view.CheckProperties -= CheckProperties;
            _view.CellClicked -= CellClicked;
        }
    }
}
