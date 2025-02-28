namespace PrintPackingLabel.View
{
    partial class SettingView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingView));
            textBoxIP = new TextBox();
            textBoxPort = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            label4 = new Label();
            locationBox = new ComboBox();
            btnConnect = new Resource.RDButton();
            label5 = new Label();
            JPComboBox = new ComboBox();
            label6 = new Label();
            btnOn = new RadioButton();
            btnOff = new RadioButton();
            btnClose = new Resource.RDButton();
            label7 = new Label();
            btnPreview = new RadioButton();
            label8 = new Label();
            printerBox = new ComboBox();
            checkBox = new CheckBox();
            label9 = new Label();
            panelTop = new Panel();
            panelBottom = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label10 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnBarcode = new RadioButton();
            btnQRcode = new RadioButton();
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxIP
            // 
            textBoxIP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxIP.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxIP.Location = new Point(284, 186);
            textBoxIP.Margin = new Padding(3, 4, 3, 4);
            textBoxIP.Name = "textBoxIP";
            textBoxIP.Size = new Size(442, 41);
            textBoxIP.TabIndex = 0;
            // 
            // textBoxPort
            // 
            textBoxPort.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPort.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPort.Location = new Point(284, 238);
            textBoxPort.Margin = new Padding(3, 4, 3, 4);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(442, 41);
            textBoxPort.TabIndex = 1;
            textBoxPort.TextChanged += textBoxPort_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(43, 182);
            label1.Name = "label1";
            label1.Size = new Size(235, 52);
            label1.TabIndex = 2;
            label1.Text = "Camera IP";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label2.Location = new Point(43, 234);
            label2.Name = "label2";
            label2.Size = new Size(235, 52);
            label2.TabIndex = 3;
            label2.Text = "Camera Port";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(3, 10, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(770, 100);
            label3.TabIndex = 5;
            label3.Text = "Setting";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label4.Location = new Point(43, 338);
            label4.Name = "label4";
            label4.Size = new Size(235, 52);
            label4.TabIndex = 6;
            label4.Text = "Location";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // locationBox
            // 
            locationBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            locationBox.DropDownStyle = ComboBoxStyle.DropDownList;
            locationBox.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            locationBox.FormattingEnabled = true;
            locationBox.Location = new Point(284, 342);
            locationBox.Margin = new Padding(3, 4, 3, 4);
            locationBox.Name = "locationBox";
            locationBox.Size = new Size(442, 41);
            locationBox.TabIndex = 7;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.FromArgb(27, 60, 115);
            btnConnect.BackgroundColor = Color.FromArgb(27, 60, 115);
            btnConnect.BorderColor = Color.PaleVioletRed;
            btnConnect.BorderRadius = 8;
            btnConnect.BorderSize = 0;
            btnConnect.Cursor = Cursors.Hand;
            btnConnect.FlatAppearance.BorderSize = 0;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConnect.ForeColor = Color.White;
            btnConnect.Image = (Image)resources.GetObject("btnConnect.Image");
            btnConnect.Location = new Point(123, 62);
            btnConnect.Margin = new Padding(3, 4, 3, 4);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(200, 75);
            btnConnect.TabIndex = 8;
            btnConnect.Text = "Connect";
            btnConnect.TextColor = Color.White;
            btnConnect.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConnect.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label5.Location = new Point(43, 390);
            label5.Name = "label5";
            label5.Size = new Size(235, 52);
            label5.TabIndex = 9;
            label5.Text = "Jenis Produk";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // JPComboBox
            // 
            JPComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            JPComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            JPComboBox.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JPComboBox.FormattingEnabled = true;
            JPComboBox.Location = new Point(284, 394);
            JPComboBox.Margin = new Padding(3, 4, 3, 4);
            JPComboBox.Name = "JPComboBox";
            JPComboBox.Size = new Size(442, 41);
            JPComboBox.TabIndex = 10;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(43, 78);
            label6.Name = "label6";
            label6.Size = new Size(235, 52);
            label6.TabIndex = 2;
            label6.Text = "Print Mode";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            label6.Click += label6_Click;
            // 
            // btnOn
            // 
            btnOn.AutoSize = true;
            btnOn.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOn.Location = new Point(3, 4);
            btnOn.Margin = new Padding(3, 4, 3, 4);
            btnOn.Name = "btnOn";
            btnOn.Size = new Size(83, 43);
            btnOn.TabIndex = 11;
            btnOn.TabStop = true;
            btnOn.Text = "On";
            btnOn.UseVisualStyleBackColor = true;
            btnOn.CheckedChanged += btnOn_CheckedChanged;
            // 
            // btnOff
            // 
            btnOff.AutoSize = true;
            btnOff.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOff.Location = new Point(92, 4);
            btnOff.Margin = new Padding(3, 4, 3, 4);
            btnOff.Name = "btnOff";
            btnOff.Size = new Size(83, 43);
            btnOff.TabIndex = 11;
            btnOff.TabStop = true;
            btnOff.Text = "Off";
            btnOff.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.BackgroundColor = Color.Red;
            btnClose.BorderColor = Color.PaleVioletRed;
            btnClose.BorderRadius = 8;
            btnClose.BorderSize = 0;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(427, 62);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(200, 75);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.TextColor = Color.White;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(284, 286);
            label7.Name = "label7";
            label7.Size = new Size(399, 22);
            label7.TabIndex = 12;
            label7.Text = "*Click button Connect after change IP/Port";
            // 
            // btnPreview
            // 
            btnPreview.AutoSize = true;
            btnPreview.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPreview.Location = new Point(181, 4);
            btnPreview.Margin = new Padding(3, 4, 3, 4);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(155, 43);
            btnPreview.TabIndex = 11;
            btnPreview.TabStop = true;
            btnPreview.Text = "Preview";
            btnPreview.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label8.Location = new Point(43, 442);
            label8.Name = "label8";
            label8.Size = new Size(235, 52);
            label8.TabIndex = 9;
            label8.Text = "Printer";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // printerBox
            // 
            printerBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            printerBox.DropDownStyle = ComboBoxStyle.DropDownList;
            printerBox.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            printerBox.FormattingEnabled = true;
            printerBox.Location = new Point(284, 446);
            printerBox.Margin = new Padding(3, 4, 3, 4);
            printerBox.Name = "printerBox";
            printerBox.Size = new Size(442, 41);
            printerBox.TabIndex = 10;
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Cursor = Cursors.Hand;
            checkBox.Dock = DockStyle.Fill;
            checkBox.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox.ImageAlign = ContentAlignment.MiddleLeft;
            checkBox.Location = new Point(284, 30);
            checkBox.Margin = new Padding(3, 4, 3, 4);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(442, 44);
            checkBox.TabIndex = 13;
            checkBox.Text = "checklist";
            checkBox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(43, 26);
            label9.Name = "label9";
            label9.Size = new Size(235, 52);
            label9.TabIndex = 2;
            label9.Text = "Actived Setting";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(label3);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(770, 100);
            panelTop.TabIndex = 14;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(btnConnect);
            panelBottom.Controls.Add(btnClose);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 634);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(770, 223);
            panelBottom.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Controls.Add(checkBox, 2, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 2, 2);
            tableLayoutPanel1.Controls.Add(label8, 1, 10);
            tableLayoutPanel1.Controls.Add(label5, 1, 9);
            tableLayoutPanel1.Controls.Add(label4, 1, 8);
            tableLayoutPanel1.Controls.Add(label2, 1, 5);
            tableLayoutPanel1.Controls.Add(label7, 2, 6);
            tableLayoutPanel1.Controls.Add(label9, 1, 1);
            tableLayoutPanel1.Controls.Add(label6, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 1, 4);
            tableLayoutPanel1.Controls.Add(label10, 1, 3);
            tableLayoutPanel1.Controls.Add(printerBox, 2, 10);
            tableLayoutPanel1.Controls.Add(JPComboBox, 2, 9);
            tableLayoutPanel1.Controls.Add(locationBox, 2, 8);
            tableLayoutPanel1.Controls.Add(textBoxPort, 2, 5);
            tableLayoutPanel1.Controls.Add(textBoxIP, 2, 4);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 2, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 100);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Size = new Size(770, 534);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnOn);
            flowLayoutPanel1.Controls.Add(btnOff);
            flowLayoutPanel1.Controls.Add(btnPreview);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(284, 81);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(442, 46);
            flowLayoutPanel1.TabIndex = 17;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label10.ImageAlign = ContentAlignment.MiddleLeft;
            label10.Location = new Point(43, 130);
            label10.Name = "label10";
            label10.Size = new Size(235, 52);
            label10.TabIndex = 18;
            label10.Text = "Print Code";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(btnBarcode);
            flowLayoutPanel2.Controls.Add(btnQRcode);
            flowLayoutPanel2.Location = new Point(284, 133);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(442, 46);
            flowLayoutPanel2.TabIndex = 19;
            // 
            // btnBarcode
            // 
            btnBarcode.AutoSize = true;
            btnBarcode.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBarcode.Location = new Point(3, 4);
            btnBarcode.Margin = new Padding(3, 4, 3, 4);
            btnBarcode.Name = "btnBarcode";
            btnBarcode.Size = new Size(161, 43);
            btnBarcode.TabIndex = 12;
            btnBarcode.TabStop = true;
            btnBarcode.Text = "Barcode";
            btnBarcode.UseVisualStyleBackColor = true;
            // 
            // btnQRcode
            // 
            btnQRcode.AutoSize = true;
            btnQRcode.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQRcode.Location = new Point(170, 4);
            btnQRcode.Margin = new Padding(3, 4, 3, 4);
            btnQRcode.Name = "btnQRcode";
            btnQRcode.Size = new Size(160, 43);
            btnQRcode.TabIndex = 13;
            btnQRcode.TabStop = true;
            btnQRcode.Text = "QRcode";
            btnQRcode.UseVisualStyleBackColor = true;
            // 
            // SettingView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 857);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SettingView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Setting";
            Load += SettingView_Load;
            panelTop.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxIP;
        private TextBox textBoxPort;
        private Label label1;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button button3;
        private Button button2;
        private Label label4;
        private ComboBox locationBox;
        private Resource.RDButton btnConnect;
        private Label label5;
        private ComboBox JPComboBox;
        private Label label6;
        private RadioButton btnOn;
        private RadioButton btnOff;
        private Resource.RDButton btnClose;
        private Label label7;
        private RadioButton btnPreview;
        private Label label8;
        private ComboBox printerBox;
        private CheckBox checkBox;
        private Label label9;
        private Panel panelTop;
        private Panel panelBottom;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label10;
        private FlowLayoutPanel flowLayoutPanel2;
        private RadioButton btnBarcode;
        private RadioButton btnQRcode;
    }
}