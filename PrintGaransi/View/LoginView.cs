﻿using Microsoft.VisualBasic.Logging;
using PrintPackingLabel._Repositories;
using PrintPackingLabel.Model;
using PrintPackingLabel.Presenter;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace PrintPackingLabel.View
{
    public partial class LoginView : Form, ILoginView
    {
        public bool isClickedOnce = true;
        public LoginView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        public string Nik
        {
            get { return textBoxNik.Text; }
            set { textBoxNik.Text = value; }
        }

        public string Password
        {
            get { return textBoxPassword.Text; }
            set { textBoxPassword.Text = value; }
        }

        public bool IsLoginSuccessful { get; private set; }

        public event EventHandler Login;

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void CloseView()
        {
            this.Hide();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnConnect.Click += (sender, e) =>
            {
                if (!string.IsNullOrWhiteSpace(Nik))
                {
                    Login?.Invoke(this, EventArgs.Empty);
                }
            };

            btnExit.Click += delegate
            {
                Application.Exit();
            };

            hiddenPass.Click += delegate
            {
                if (isClickedOnce)
                {
                    hiddenPass.Image = Properties.Resources.show;
                    textBoxPassword.PasswordChar = '\0';
                    isClickedOnce = false;
                }
                else
                {
                    hiddenPass.Image = Properties.Resources.hide;
                    textBoxPassword.PasswordChar = '*';
                    isClickedOnce = true;
                }
            };
        }

        private void textBoxNik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(Nik))
            {
                Login?.Invoke(this, EventArgs.Empty);
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(Nik))
            {
                Login?.Invoke(this, EventArgs.Empty);
            }
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            textBoxNik.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
