using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfWithDelegates
{
    /// <summary>
    /// Interaction logic for UserInfoCtrl.xaml
    /// </summary>
    public partial class UserInfoCtrl : UserControl
    {
        public delegate void SaveHandler(string fname, string lname, string cellPhone);
        public event SaveHandler OnUserInfoSave;

        public delegate void CancelHandler();
        public event CancelHandler OnUserInfoCancel;

        public UserInfoCtrl()
        {
            InitializeComponent();
            this.tbFirstName.Focus();
        }

        internal void InitComponetWithData(YTSubscriber ytSubscriber)
        {
            this.tbFirstName.Text = ytSubscriber.FirstName;
            this.tbLastName.Text = ytSubscriber.LastName;
            this.tbCellPhone.Text = ytSubscriber.CellPhone;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (OnUserInfoSave != null)
            {
                OnUserInfoSave(this.tbFirstName.Text,
                                this.tbLastName.Text,
                                this.tbCellPhone.Text);
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            if (OnUserInfoCancel != null)
                OnUserInfoCancel();
        }
    }
}
