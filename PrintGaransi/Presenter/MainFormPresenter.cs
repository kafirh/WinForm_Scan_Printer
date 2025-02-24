using PrintPackingLabel.Model;
using PrintPackingLabel.Presenter;
using PrintPackingLabel.View;
using static PrintPackingLabel.View.IMainFormView;
using System.Drawing.Printing;
using Microsoft.VisualBasic.ApplicationServices;
using PrintPackingLabel._Repositories;

public class MainFormPresenter
{
    private IMainFormView _view;
    private GaransiModel _model;
    private PrintPackingLabelLayout _printLayout;
    private IGaransiRepository GaransiRepository;
    public LoginModel _login { get; }

    public MainFormPresenter(IMainFormView view, IGaransiRepository garansiRepository, LoginModel login)
    {
        _view = view;
        GaransiRepository = garansiRepository;
        _printLayout = new PrintPackingLabelLayout();
        this._view.Show();
        _login = login;
    }
}
