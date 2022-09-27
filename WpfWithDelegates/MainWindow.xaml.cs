using System;
using System.Windows;

namespace WpfWithDelegates
{
    public partial class MainWindow : Window
    {
        public UserInfoCtrl? _UserInfoControl;
        public PickLanguageCtrl? _PickLanguageControl;
        public Viewer? _viewer = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPage1_Click(object sender, RoutedEventArgs e)
        {
            MyStack.Children.Clear();

            _UserInfoControl = new UserInfoCtrl();
            if (_viewer != null)
                _UserInfoControl.InitComponetWithData(_viewer);

            _UserInfoControl.OnUserInfoSave += _UserInfoControl_OnUserInfoSave;
            _UserInfoControl.OnUserInfoCancel += _UserInfoControl_OnUserInfoCancel;

            MyStack.Children.Add(_UserInfoControl);

        }

        private void _UserInfoControl_OnUserInfoSave(string fname, string lname, string cellPhone)
        {
            if (_viewer == null)
            {
                _viewer = new Viewer();
            }

            _viewer.FirstName = fname;
            _viewer.LastName = lname;
            _viewer.CellPhone = cellPhone;

            MyStack.Children.Remove(_UserInfoControl);
            _UserInfoControl = null;

            this.fullName.Content = _viewer.ShowUserInfo();
        }

        private void _UserInfoControl_OnUserInfoCancel()
        {
            MyStack.Children.Remove(_UserInfoControl);
            _UserInfoControl = null;
        }

        private void btnPage2_Click(object sender, RoutedEventArgs e)
        {
            MyStack.Children.Clear();

            _PickLanguageControl = new PickLanguageCtrl();
            _PickLanguageControl.OnPickLanguageCancel += _PickLanguageControl_OnPickLanguageCancel;
            
            MyStack.Children.Add(_PickLanguageControl);
        }

        private void _PickLanguageControl_OnPickLanguageCancel()
        {
            MyStack.Children.Remove(_PickLanguageControl);
            _PickLanguageControl = null;
        }
    }
}
