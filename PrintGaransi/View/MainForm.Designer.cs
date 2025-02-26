namespace PrintPackingLabel
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            btnMinimized = new PictureBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnAbtUs = new Button();
            btnLogOut = new Button();
            btnRePrint = new Button();
            btnHome = new Button();
            btnSetting = new Button();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimized).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(40, 167, 69);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 623F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnMinimized, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 0, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1446, 119);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(40, 167, 69);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Arial", 30F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(785, 0);
            label2.Name = "label2";
            label2.Size = new Size(617, 119);
            label2.TabIndex = 2;
            label2.Text = "Laundry System Business Unit";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Margin = new Padding(3, 0, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(779, 119);
            label1.TabIndex = 1;
            label1.Text = "PACKING LABEL PRINTING";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnMinimized
            // 
            btnMinimized.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimized.Cursor = Cursors.Hand;
            btnMinimized.Image = (Image)resources.GetObject("btnMinimized.Image");
            btnMinimized.Location = new Point(1409, 0);
            btnMinimized.Margin = new Padding(0);
            btnMinimized.Name = "btnMinimized";
            btnMinimized.Size = new Size(37, 43);
            btnMinimized.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimized.TabIndex = 3;
            btnMinimized.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.FromArgb(40, 167, 69);
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(btnAbtUs, 0, 4);
            tableLayoutPanel4.Controls.Add(btnLogOut, 0, 5);
            tableLayoutPanel4.Controls.Add(btnRePrint, 0, 1);
            tableLayoutPanel4.Controls.Add(btnHome, 0, 0);
            tableLayoutPanel4.Controls.Add(btnSetting, 0, 2);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(3, 0, 3, 7);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 7;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 148F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel4.Size = new Size(171, 854);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // btnAbtUs
            // 
            btnAbtUs.BackColor = Color.FromArgb(40, 167, 69);
            btnAbtUs.Cursor = Cursors.Hand;
            btnAbtUs.Dock = DockStyle.Fill;
            btnAbtUs.FlatAppearance.BorderColor = Color.PaleGreen;
            btnAbtUs.FlatAppearance.BorderSize = 2;
            btnAbtUs.FlatStyle = FlatStyle.Flat;
            btnAbtUs.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAbtUs.ForeColor = Color.White;
            btnAbtUs.Image = (Image)resources.GetObject("btnAbtUs.Image");
            btnAbtUs.Location = new Point(0, 586);
            btnAbtUs.Margin = new Padding(0, 3, 2, 3);
            btnAbtUs.Name = "btnAbtUs";
            btnAbtUs.Size = new Size(169, 90);
            btnAbtUs.TabIndex = 5;
            btnAbtUs.Text = "\r\nAbout";
            btnAbtUs.TextAlign = ContentAlignment.BottomCenter;
            btnAbtUs.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAbtUs.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(220, 40, 30);
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.Dock = DockStyle.Fill;
            btnLogOut.FlatAppearance.BorderColor = Color.Salmon;
            btnLogOut.FlatAppearance.BorderSize = 2;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.Location = new Point(0, 679);
            btnLogOut.Margin = new Padding(0, 0, 2, 0);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(169, 148);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "Log Out";
            btnLogOut.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnRePrint
            // 
            btnRePrint.BackColor = Color.FromArgb(40, 167, 69);
            btnRePrint.Cursor = Cursors.Hand;
            btnRePrint.Dock = DockStyle.Fill;
            btnRePrint.FlatAppearance.BorderColor = Color.PaleGreen;
            btnRePrint.FlatAppearance.BorderSize = 2;
            btnRePrint.FlatStyle = FlatStyle.Flat;
            btnRePrint.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRePrint.ForeColor = Color.White;
            btnRePrint.Image = (Image)resources.GetObject("btnRePrint.Image");
            btnRePrint.Location = new Point(0, 91);
            btnRePrint.Margin = new Padding(0, 3, 2, 3);
            btnRePrint.Name = "btnRePrint";
            btnRePrint.Size = new Size(169, 82);
            btnRePrint.TabIndex = 3;
            btnRePrint.Text = "\r\nRe-Print\r\n";
            btnRePrint.TextAlign = ContentAlignment.BottomCenter;
            btnRePrint.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRePrint.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(40, 167, 69);
            btnHome.Cursor = Cursors.Hand;
            btnHome.Dock = DockStyle.Fill;
            btnHome.FlatAppearance.BorderColor = Color.PaleGreen;
            btnHome.FlatAppearance.BorderSize = 2;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(0, 3);
            btnHome.Margin = new Padding(0, 3, 2, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(169, 82);
            btnHome.TabIndex = 2;
            btnHome.Text = "\r\nHome";
            btnHome.TextImageRelation = TextImageRelation.ImageAboveText;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = Color.FromArgb(40, 167, 69);
            btnSetting.Cursor = Cursors.Hand;
            btnSetting.Dock = DockStyle.Fill;
            btnSetting.FlatAppearance.BorderColor = Color.PaleGreen;
            btnSetting.FlatAppearance.BorderSize = 2;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSetting.ForeColor = Color.White;
            btnSetting.Image = (Image)resources.GetObject("btnSetting.Image");
            btnSetting.Location = new Point(0, 179);
            btnSetting.Margin = new Padding(0, 3, 2, 3);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(169, 82);
            btnSetting.TabIndex = 1;
            btnSetting.Text = "\r\nSetting";
            btnSetting.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSetting.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 119);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(224, 235, 245);
            splitContainer1.Size = new Size(1446, 854);
            splitContainer1.SplitterDistance = 171;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 14;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1446, 973);
            Controls.Add(splitContainer1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "MainForm";
            Text = "WARRANTY CARD PRINTING";
            WindowState = FormWindowState.Maximized;
            FormClosed += PrintPackingLabelView_FormClosed;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimized).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnLogOut;
        private Button btnRePrint;
        private Button btnHome;
        private Button btnSetting;
        private SplitContainer splitContainer1;
        private Label label1;
        private Label label2;
        private Button btnAbtUs;
        private PictureBox btnMinimized;
    }
}
