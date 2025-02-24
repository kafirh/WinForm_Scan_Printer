using PrintPackingLabel.Model;
using PrintPackingLabel.Presenter;
using PrintPackingLabel.View;
using System.Drawing.Printing;
using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using static PrintPackingLabel.View.IMainFormView;
using PrintPackingLabel._Repositories;
using Microsoft.VisualBasic.ApplicationServices;

namespace PrintPackingLabel
{
    public partial class MainForm : Form, IMainFormView
    {
        private TabControlPresenter tabControlPresenter;
        private readonly GaransiModel _garansiModel;
        public LoginModel _user;
        private TabControlView tabControlView;
        private TCPConnection connection;

        public MainForm(LoginModel user)
        {
            InitializeComponent();
            _user = user;
            AssociateAndRaiseViewEvents();
            InitializeTabControl();
            btnHome.BackColor = Color.FromArgb(21, 136, 50);

            tabControlPresenter.LoadAllDataList();
        }

        public void InitializeTabControl()
        {

            if (tabControlPresenter != null)
            {
                tabControlPresenter.UnassociateViewEvents(); // Tambahkan ini untuk menghapus event handler yang ada
            }

            tabControlView = new TabControlView(); // Create the user control instance
            TabControlDataPresenter presenterData = new TabControlDataPresenter(tabControlView, new GaransiRepository(), _user); // Inisialisasi variabel instance
            tabControlPresenter = new TabControlPresenter(presenterData);
            splitContainer1.Panel2.Controls.Add(tabControlView);
            tabControlView.Dock = DockStyle.Fill;
            connection = new TCPConnection(tabControlView.UpdateCodeBox, tabControlView.UpdateSerialBox);
        }


        //event
        private void AssociateAndRaiseViewEvents()
        {
            btnHome.Click += delegate
            {
                int selectedTabPageIndex = 0;
                tabControlPresenter.ChangeTabPage(selectedTabPageIndex);
                btnHome.BackColor = Color.FromArgb(21, 136, 50);
                btnRePrint.BackColor = Color.FromArgb(40, 167, 69);
                btnAbtUs.BackColor = Color.FromArgb(40, 167, 69);
            };

            btnSetting.Click += delegate
            {
                ISettingView settingView = SettingView.GetInstance();
                SettingPresenter settingPresenter = new SettingPresenter(settingView, new SettingModel());
                (settingView as Form)?.Show();
            };

            btnRePrint.Click += delegate
            {
                int selectedTabPageIndex = 1;
                tabControlPresenter.ChangeTabPage(selectedTabPageIndex);
                btnHome.BackColor = Color.FromArgb(40, 167, 69);
                btnRePrint.BackColor = Color.FromArgb(21, 136, 50);
                btnAbtUs.BackColor = Color.FromArgb(40, 167, 69);
            };

            btnAbtUs.Click += delegate
            {
                int selectedTabPageIndex = 2;
                tabControlPresenter.ChangeTabPage(selectedTabPageIndex);
                btnAbtUs.BackColor = Color.FromArgb(21, 136, 50);
                btnRePrint.BackColor = Color.FromArgb(40, 167, 69);
                btnHome.BackColor = Color.FromArgb(40, 167, 69);
            };

            btnLogOut.Click += delegate
            {
                connection.CloseConnection();

                tabControlPresenter.UnassociateViewEvents();
                ResetBinding();

                this.Close();

                ILoginView loginView = new LoginView();
                LoginPresenter loginPresenter = new LoginPresenter(loginView, new LoginRepository());
                (loginView as Form)?.Show();
            };

            btnMinimized.Click += delegate
            {
                WindowState = FormWindowState.Minimized;
            };
        }

        private void ResetBinding()
        {
            tabControlPresenter.ResetDataBinding();
        }

        private void PrintPackingLabelView_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        //Singeleton pattern (open a single  from instance)
        private static MainForm instance;
        public static MainForm GetInstance(LoginModel loginModel)
        {
            // Dispose the old instance if it exists and is not disposed
            if (instance != null && !instance.IsDisposed)
            {
                instance.Dispose();
            }

            // Create a new instance
            instance = new MainForm(loginModel);

            // Set window state and bring to front if necessary
            if (instance.WindowState == FormWindowState.Minimized)
                instance.WindowState = FormWindowState.Normal;

            if (instance._user != loginModel)
            {
                instance._user = loginModel;
                instance.InitializeTabControl();
            }

            return instance;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }
    }
}
