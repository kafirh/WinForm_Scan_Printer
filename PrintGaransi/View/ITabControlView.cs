﻿using System;
using System.Reflection;
using System.Windows.Forms;
using PrintPackingLabel.Model;

namespace PrintPackingLabel.View
{
    public interface ITabControlView
    {
        // Properties
        string SerialNumber { get; set; }
        string ModelCode { get; set; }
        string ModelNumber { get; set; }
        string GlobalCodeId { get; set; }
        string Register { get; set; }
        string InspectorId { get; set; }
        string Inspector { get; set; }
        string Search { get; set; }
        DateTime SelectedDate { get; }
        string Status { get; set; }
        Color StatusBackColor { get; set; }
        Color StatusForeColor { get; set; }

        // Events
        event EventHandler<ModelEventArgs> SearchModelNumber;
        event EventHandler SearchFilter;
        event EventHandler CheckProperties;
        event EventHandler<DataGridViewCellEventArgs> CellClicked;

        // Methods
        void ShowFilter(BindingSource model);
        void ShowPrintPreviewDialog(GaransiModel model, string printerType);
        void SetDefectListBindingSource(BindingSource model);
        void SelectTabPageByIndex(int data);
    }

    public class ModelEventArgs : EventArgs
    {
        public string Message { get; set; }

        public ModelEventArgs(string message)
        {
            Message = message;
        }
    }

    public enum TabControlAction
    {
        Selected,
        Deselected,
        // Other actions as needed
    }
}
