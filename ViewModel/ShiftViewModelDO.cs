using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationProject.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using GraduationProject.View;

namespace GraduationProject.ViewModel
{
    /// <summary>
    /// Логика взаимодействия для ShiftView.xaml
    /// </summary>
    public class ShiftViewModelDO : DependencyObject
    {
        public decimal CurrentCash
        {
            get { return (decimal)GetValue(CurrentCashProperty); }
            set { SetValue(CurrentCashProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentCash.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentCashProperty =
            DependencyProperty.Register("CurrentCash", typeof(decimal), typeof(ShiftViewModel), new PropertyMetadata(0));


        //#region Constructors
        //#endregion
        //#region Events
        //#endregion
        //#region Fields
        //private AuthorizationWindow _wnd;
        //private bool _buttonIsEnabled = false;
        //private RelayCommand _authWndOpenCommand;
        //private RelayCommand _authorizationCommand;
        //private IUser<User> _currentUser;
        //private Shift _previousShift;
        //private Shift _currentShift;
        //private string _userName;
        //#endregion
        //#region Properties
        //public decimal CurrentCash
        //{
        //    get { return CurrentShift.CurrentCash; }
        //    set { CurrentShift.CurrentCash = value; OnPropertyChanged(); MessageBox.Show("F1-2"); }
        //}

        //public decimal CashReceived
        //{
        //    get { return CurrentShift.CashReceived; }
        //    set { CurrentShift.CashReceived = value; OnPropertyChanged(); }
        //}

        //public decimal CashReturned
        //{
        //    get { return CurrentShift.CashReturned; }
        //    set { CurrentShift.CashReturned = value; OnPropertyChanged(); }
        //}

        //public decimal CashAdded
        //{
        //    get { return CurrentShift.CashAdded; }
        //    set { CurrentShift.CashAdded = value; OnPropertyChanged(); }
        //}

        //public decimal CashWithdrawn
        //{
        //    get { return CurrentShift.CashWithdrawn; }
        //    set { CurrentShift.CashWithdrawn = value; OnPropertyChanged(); }
        //}
        ////////////////////////////////////////////////////////////////////
        //public bool ButtonIsEnabled
        //{
        //    get { return _buttonIsEnabled; }
        //    private set
        //    {
        //        if (_buttonIsEnabled != value)
        //        {
        //            _buttonIsEnabled = value; OnPropertyChanged();
        //        }
        //    }
        //}
        //public IUser<User> CurrentUser
        //{
        //    get { return _currentUser; }
        //    private set { _currentUser = value; OnPropertyChanged(); }
        //}
        //public string EnteredLogin { get; set; }
        //public string EnteredPassword { get; set; }
        //public string UserName
        //{
        //    get { return _userName; }
        //    private set { _userName = value; OnPropertyChanged(); }
        //}
        //public Shift CurrentShift
        //{
        //    get { return _currentShift; }
        //    private set { _currentShift = value; OnPropertyChanged(); }
        //}
        //#endregion
        //#region Commands
        //public RelayCommand AuthWndOpenCommand
        //{
        //    get
        //    {
        //        return _authWndOpenCommand ??
        //            (_authWndOpenCommand = new RelayCommand(obj =>
        //            {
        //                 _wnd= new AuthorizationWindow();
        //                _wnd.ShowDialog();
        //            }));
        //    }
        //}
        //public RelayCommand AuthorizationCommand
        //{
        //    get
        //    {
        //        return _authorizationCommand ??
        //            (_authorizationCommand = new RelayCommand(obj =>
        //            {
        //                //TODO: логика авторизации
        //                if (_wnd.DialogResult == true)
        //                {
        //                    using (CashboxModel db = new CashboxModel())
        //                    {
        //                        CurrentUser = db.Users.FirstOrDefault(u => EnteredLogin == u.UId && EnteredPassword == u.Password);
        //                        if (CurrentUser != null)
        //                        {
        //                            UserName = string.Format("{0} {1}. {2}.", 
        //                                _currentUser.GetInstance().SurName,
        //                                _currentUser.GetInstance().Name[0],
        //                                _currentUser.GetInstance().FatherName[0]);
        //                            ButtonIsEnabled = true;
        //                            _previousShift = db.Shifts.OrderByDescending(sh => sh.SId).FirstOrDefault();
        //                            if(_previousShift == null)
        //                            {
        //                                CurrentShift.UId = _currentUser.GetInstance().UId;
        //                                //CurrentShift = null;
        //                                //CurrentShift = new Shift(_currentUser, 0);
        //                                //CurrentShift.PropertyChanged += Model_PropertyChanged;
        //                                db.Shifts.Add(CurrentShift);
        //                                db.SaveChanges();
        //                            }
        //                            else
        //                            {
        //                                CurrentShift.UId = _currentUser.GetInstance().UId;
        //                                CurrentShift.CurrentCash = _previousShift.CurrentCash;
        //                                //CurrentShift = null;
        //                                //CurrentShift = new Shift(_currentUser, _previousShift.CurrentCash);
        //                                //MessageBox.Show(CurrentCash.ToString());
        //                                db.Shifts.Add(CurrentShift);
        //                                db.SaveChanges();
        //                            }
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Неверный логин или пароль!");
        //                        }
        //                    }
        //                }
        //            }));
        //    }
        //}
        //#endregion
        //#region Methods
        //private void Model_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        //{
        //    switch (e.PropertyName)
        //    {
        //        case nameof(CurrentShift.CurrentCash):
        //            MessageBox.Show("F1");
        //            OnPropertyChanged(nameof(CurrentCash));
        //            break;
        //        case nameof(CurrentShift.CashReceived):
        //            MessageBox.Show("F2");
        //            OnPropertyChanged(nameof(CashReceived));
        //            break;
        //        case nameof(CurrentShift.CashReturned):
        //            MessageBox.Show("F3");
        //            OnPropertyChanged(nameof(CashReturned));
        //            break;
        //        case nameof(CurrentShift.CashAdded):
        //            MessageBox.Show("F4");
        //            OnPropertyChanged(nameof(CashAdded));
        //            break;
        //        case nameof(CurrentShift.CashWithdrawn):
        //            MessageBox.Show("F5");
        //            OnPropertyChanged(nameof(CashWithdrawn));
        //            break;
        //    }
        //}
        //#endregion
    }
}
