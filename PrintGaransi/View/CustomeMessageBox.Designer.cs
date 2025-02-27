﻿namespace PrintPackingLabel.View
{
    partial class CustomeMessageBox
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
            panelTitleBar = new TableLayoutPanel();
            panelBody = new TableLayoutPanel();
            labelMessage = new Label();
            panelButtons = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            labelCaption = new Label();
            panelTitleBar.SuspendLayout();
            panelBody.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            panelTitleBar.ColumnCount = 1;
            panelTitleBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelTitleBar.Controls.Add(panelBody, 0, 1);
            panelTitleBar.Controls.Add(panelButtons, 0, 2);
            panelTitleBar.Controls.Add(labelCaption, 0, 0);
            panelTitleBar.Dock = DockStyle.Fill;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Margin = new Padding(0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.RowCount = 3;
            panelTitleBar.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7635527F));
            panelTitleBar.RowStyles.Add(new RowStyle(SizeType.Percent, 51.90311F));
            panelTitleBar.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            panelTitleBar.Size = new Size(771, 296);
            panelTitleBar.TabIndex = 0;
            // 
            // panelBody
            // 
            panelBody.ColumnCount = 1;
            panelBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.1833744F));
            panelBody.Controls.Add(labelMessage, 0, 0);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(6, 51);
            panelBody.Margin = new Padding(3, 4, 3, 4);
            panelBody.Name = "panelBody";
            panelBody.RowCount = 1;
            panelBody.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelBody.Size = new Size(759, 139);
            panelBody.TabIndex = 0;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.BackColor = SystemColors.ButtonHighlight;
            labelMessage.Dock = DockStyle.Fill;
            labelMessage.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMessage.Location = new Point(3, 0);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(753, 139);
            labelMessage.TabIndex = 2;
            labelMessage.Text = "label2";
            labelMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = SystemColors.ButtonHighlight;
            panelButtons.ColumnCount = 2;
            panelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelButtons.Controls.Add(button1, 0, 0);
            panelButtons.Controls.Add(button2, 1, 0);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(6, 201);
            panelButtons.Margin = new Padding(3, 4, 3, 4);
            panelButtons.Name = "panelButtons";
            panelButtons.RowCount = 1;
            panelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelButtons.Size = new Size(759, 88);
            panelButtons.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.MediumSeaGreen;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.icons8_yes_50;
            button1.Location = new Point(99, 15);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(180, 58);
            button1.TabIndex = 0;
            button1.Text = "Ok";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(255, 77, 77);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.icons8_no_50;
            button2.Location = new Point(479, 15);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(180, 58);
            button2.TabIndex = 0;
            button2.Text = "Cancel";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // labelCaption
            // 
            labelCaption.AutoSize = true;
            labelCaption.BackColor = Color.FromArgb(40, 167, 69);
            labelCaption.Dock = DockStyle.Fill;
            labelCaption.Font = new Font("Microsoft Sans Serif", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCaption.ForeColor = Color.White;
            labelCaption.Location = new Point(3, 3);
            labelCaption.Margin = new Padding(0);
            labelCaption.Name = "labelCaption";
            labelCaption.Size = new Size(765, 41);
            labelCaption.TabIndex = 2;
            labelCaption.Text = "title";
            labelCaption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomeMessageBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(771, 296);
            Controls.Add(panelTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomeMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomeMessageBox";
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel panelTitleBar;
        private TableLayoutPanel panelBody;
        private TableLayoutPanel panelButtons;
        private Button button1;
        private Label labelCaption;
        private Label labelMessage;
        private Button button2;
    }
}