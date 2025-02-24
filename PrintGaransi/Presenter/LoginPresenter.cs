using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrintPackingLabel.Model;
using PrintPackingLabel.View;
using PrintPackingLabel._Repositories;

namespace PrintPackingLabel.Presenter
{
    public class LoginPresenter
    {
        private ILoginView _view;
        private ILoginRepository _repository;

        public LoginPresenter(ILoginView view, ILoginRepository repository)
        {
            _view = view;
            _repository = repository;
            _view.Login += Login;
            this._view.Show();
        }

        private void Login(object sender, EventArgs e)
        {
            string nik = _view.Nik;
            string password = _view.Password;

            LoginModel user = _repository.GetUserByUsername(nik);

            if (user != null)
            {

                bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, user.Password);
                if(isPasswordValid)
                {
                    _view.CloseView();
                    IMainFormView PrintPackingLabelView = MainForm.GetInstance(user);
                    PrintPackingLabelView.Show();
                }
                else
                {
                    _view.ShowMessage("Invalid username or password");
                }

            }
            else
            {
                _view.ShowMessage("User not found");
            }
        }
    }
}
