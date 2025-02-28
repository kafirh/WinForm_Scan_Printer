using PrintPackingLabel._Repositories;
using PrintPackingLabel.Model;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PrintPackingLabel.View.IMainFormView;
using PrintPackingLabel.Presenter;
using System.Runtime.CompilerServices;

namespace PrintPackingLabel.View
{
    public partial class TabControlView : UserControl, ITabControlView
    {
        private PrintPackingLabelLayout _printLayout;
        private TCPConnection connection;
        private bool disableEvent = false;
        private bool buttonClickedOnce = false;
        private string inspectorId;
        private PrintModeModel _printMode;

        public TabControlView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            _printLayout = new PrintPackingLabelLayout();
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            InitializeDateTimePicker();
            _printMode = new PrintModeModel();
        }

        private void InitializeDateTimePicker()
        {
            dtFromDate.CustomFormat = "dd MMMM yyyy";
        }

        public string SerialNumber
        {
            get { return textBoxSerial.Text; }
            set { textBoxSerial.Text = value; }
        }
        public string LastInput
        {
            get { return textBoxLastInput.Text; }
            set { textBoxLastInput.Text = value; }
        }
        public string ModelNumber
        {
            get { return textBoxModelNumber.Text; }
            set { textBoxModelNumber.Text = value; }
        }
        public string ModelCode
        {
            get { return textBoxCode.Text; }
            set { textBoxCode.Text = value; }
        }
        public string GlobalCodeId
        {
            get { return textBoxGlobalCode.Text; }
            set { textBoxGlobalCode.Text = value; }
        }
        public string Register
        {
            get { return textBoxRegister.Text; }
            set { textBoxRegister.Text = value; }
        }

        public string Search
        {
            get { return textBoxSearch.Text; }
            set { textBoxSearch.Text = value; }
        }
        public string Status
        {
            get { return textBoxStatus.Text; }
            set { textBoxStatus.Text = value; }
        }
        public Color StatusBackColor
        {
            get { return textBoxStatus.BackColor; }
            set { textBoxStatus.BackColor = value; }
        }
        public Color StatusForeColor
        {
            get { return textBoxStatus.ForeColor; }
            set { textBoxStatus.ForeColor = value; }
        }

        public DateTime SelectedDate => dtFromDate.Value;

        public string InspectorId
        {
            get { return inspectorId; }
            set { inspectorId = value; }
        }
        public string Inspector
        {
            get { return textBoxInspector.Text; }
            set { textBoxInspector.Text = value; }
        }

        //event
        public event EventHandler<ModelEventArgs> SearchModelNumber;
        public event EventHandler SearchFilter;
        public event EventHandler CheckProperties;
        public event EventHandler<DataGridViewCellEventArgs> CellClicked;

        private async void TabControlView_Load(object sender, EventArgs e)
        {
            timer1.Start();
            connection = new TCPConnection(UpdateCodeBox, UpdateSerialBox); // Passing both update methods
            await connection.ConnectToServerAsync();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnPrint.Click += delegate
            {
                CheckProperties?.Invoke(this, EventArgs.Empty);
            };

            btnSearch.Click += delegate
            {
                SearchFilter?.Invoke(this, EventArgs.Empty);
            };

            dataGridView2.CellContentClick += (sender, e) =>
            {
                CellClicked?.Invoke(sender, e);
            };

            dataGridView1.RowPostPaint += (sender, e) =>
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int totalRows = dataGridView1.Rows.Count;
                row.Cells["No1"].Value = (totalRows - e.RowIndex).ToString();
                row.Cells["No1"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                row.Cells["No1"].Style.BackColor = Color.FromArgb(21, 136, 50);
                row.Cells["No1"].Style.ForeColor = Color.White;
            };

            dataGridView2.RowPostPaint += (sender, e) =>
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                int totalRows = dataGridView2.Rows.Count;
                row.Cells["No2"].Value = (totalRows - e.RowIndex).ToString();
                row.Cells["No2"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                row.Cells["No2"].Style.BackColor = Color.FromArgb(21, 136, 50);
                row.Cells["No2"].Style.ForeColor = Color.White;
            };

            btnManual.Click += delegate
            {
                if (!buttonClickedOnce)
                {
                    btnManual.BackColor = Color.FromArgb(52, 199, 89);
                    // Logic to execute when button is clicked for the first time
                    btnPrint.Visible = true;
                    btnClear.Visible = true;
                    disableEvent = true;
                    btnManual.Text = "Auto Print";

                    textBoxSerial.ReadOnly = false;
                    textBoxSerial.Focus();

                    textBoxStatus.BackColor = SystemColors.Control;

                    SerialNumber = "";
                    LastInput = "";
                    ModelCode = "";
                    ModelNumber = "";
                    GlobalCodeId = "";
                    Register = "";
                    Status = "";

                    buttonClickedOnce = true; // Update button state
                }
                else
                {
                    btnManual.BackColor = Color.FromArgb(52, 199, 89);
                    btnPrint.Visible = false;
                    btnClear.Visible = false;
                    textBoxSerial.ReadOnly = true;
                    textBoxCode.ReadOnly = true;
                    textBoxModelNumber.ReadOnly = true;
                    textBoxRegister.ReadOnly = true;
                    btnManual.Text = "Input Manual";
                    textBoxStatus.BackColor = SystemColors.Control;


                    SerialNumber = "";
                    LastInput = "";
                    ModelCode = "";
                    ModelNumber = "";
                    GlobalCodeId = "";
                    Register = "";
                    Status = "";

                    disableEvent = false;
                    buttonClickedOnce = false;
                }
            };

            btnClear.Click += delegate
            {
                SerialNumber = "";
                LastInput = "";
                ModelCode = "";
                ModelNumber = "";
                GlobalCodeId = "";
                Register = "";
                Status = "";
                textBoxStatus.BackColor = SystemColors.Control;
                textBoxSerial.Focus();
            };

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(21, 136, 50);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 16);
            dataGridView1.RowTemplate.Height = 50;

            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Bold);
            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.ColumnHeadersHeight = 40;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(21, 136, 50);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView2.DefaultCellStyle.Font = new Font("Arial", 16);
            dataGridView2.RowTemplate.Height = 50;

            timer1.Tick += delegate
            {
                timeHeader.Text = DateTime.Now.ToLongTimeString();
                DateHeader.Text = DateTime.Now.ToLongDateString();
            };

            btnClear2.Click += delegate
            {
                textBoxSearch.Text = "";
                textBoxSearch.Focus();
                dtFromDate.Text = DateTime.Now.ToString();
                SearchFilter?.Invoke(this, EventArgs.Empty);
            };
        }

        public void ShowFilter(BindingSource model)
        {
            dataGridView2.DataSource = model;
        }

        public void ShowPrintPreviewDialog(GaransiModel model, string printerName)
        {
            string mode = _printMode.GetMode();

            // Membuat PrintDocument baru
            PrintDocument pd = new PrintDocument();

            // Menetapkan printer yang akan digunakan
            if (!string.IsNullOrEmpty(printerName))
            {
                pd.PrinterSettings.PrinterName = printerName;
            }

            // Menambahkan event handler untuk PrintPage
            if (Properties.Settings.Default.PrinterCode == "Barcode")
            {
                pd.PrintPage += (s, e) => _printLayout.PrintBarcode(e, model);
            }
            else
            {
                pd.PrintPage += (s, e) => _printLayout.PrintQRcode(e, model);
            }

            if (mode == "preview")
            {
                // Membuat PrintPreviewDialog dan menetapkan PrintDocument-nya
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = pd;

                printPreviewDialog.Load += (s, e) =>
                {
                    // Mengakses PrintPreviewControl menggunakan refleksi
                    PrintPreviewControl printPreviewControl = FindPrintPreviewControl(printPreviewDialog);

                    if (printPreviewControl != null)
                    {
                        printPreviewControl.Zoom = 1.0; // Mengatur zoom 100%
                    }

                    // Mengatur posisi jendela ke tengah layar
                    printPreviewDialog.StartPosition = FormStartPosition.CenterScreen;
                    printPreviewDialog.WindowState = FormWindowState.Maximized;
                };

                // Menampilkan dialog preview cetak
                printPreviewDialog.ShowDialog();
            }
            else
            {
                pd.Print();
            }
        }

        private PrintPreviewControl FindPrintPreviewControl(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is PrintPreviewControl previewControl)
                {
                    return previewControl;
                }
                else
                {
                    PrintPreviewControl foundControl = FindPrintPreviewControl(control);
                    if (foundControl != null)
                    {
                        return foundControl;
                    }
                }
            }
            return null;
        }

        public void UpdateSerialBox(string message)
        {
            // Invoke UI updates on the UI thread
            if (textBoxSerial.InvokeRequired)
            {
                textBoxSerial.Invoke((MethodInvoker)(() => UpdateSerialBox(message)));
            }
            else
            {
                textBoxSerial.Text = message;
            }
            PerformModelSearch();
            CheckProperties?.Invoke(this, EventArgs.Empty);
        }

        public void UpdateCodeBox(string message)
        {
            // Invoke UI updates on the UI thread
            if (textBoxCode.InvokeRequired)
            {
                textBoxCode.Invoke((MethodInvoker)(() => UpdateCodeBox(message)));
            }
            else
            {
                textBoxCode.Text = message;
            }
        }

        private void PerformModelSearch()
        {
            // Raise the event with the data from the view
            SearchModelNumber?.Invoke(this, new ModelEventArgs(SerialNumber));
        }

        public void SelectTabPageByIndex(int data)
        {
            if (data >= 0 && data < tabControl1.TabPages.Count)
            {
                tabControl1.SelectedIndex = data;
            }
        }

        public void SetDefectListBindingSource(BindingSource model)
        {
            dataGridView1.DataSource = model;
            dataGridView2.DataSource = model;
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchFilter?.Invoke(this, EventArgs.Empty);
            }
        }

        private void textBoxRegister_TextChanged(object sender, EventArgs e)
        {
            if (!disableEvent)
            {
                if (textBoxCode.Text == null)
                {
                    MessageBox.Show("Data Product tidak ditemukan", "Pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                else
                {
                }
            }
        }

        private void textBoxSerial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (textBoxSerial.Text.Length >= 2)
                {
                    string code = textBoxSerial.Text;
                    textBoxCode.Text = textBoxSerial.Text.Substring(0, 2);
                    textBoxSerial.Text = code.Substring(2);
                    PerformModelSearch();
                    CheckProperties?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void dtFromDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchFilter?.Invoke(this, EventArgs.Empty);
            }
        }

        private void textBoxSerial_TextChanged(object sender, EventArgs e)
        {
            textBoxSerial.Text = textBoxSerial.Text.ToUpper();
            textBoxSerial.SelectionStart = textBoxSerial.Text.Length;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            textBoxSearch.Text = textBoxSearch.Text.ToUpper();
            textBoxSearch.SelectionStart = textBoxSearch.Text.Length;
        }

        private void btnManual_Click(object sender, EventArgs e)
        {

        }

        private void DateHeader_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)

        {

            if (e.RowIndex != -1)

            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                row.DefaultCellStyle.BackColor = Color.FromArgb(40, 167, 69);

            }

        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)

        {

            if (e.RowIndex != -1)

            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                row.DefaultCellStyle.BackColor = Color.Empty;

            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timeHeader_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxGlobalCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
