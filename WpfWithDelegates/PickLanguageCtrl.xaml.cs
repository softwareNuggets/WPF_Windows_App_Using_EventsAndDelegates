using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfWithDelegates
{
    /// <summary>
    /// Interaction logic for PickLanguageCtrl.xaml
    /// </summary>
    public partial class PickLanguageCtrl : UserControl
    {
        public delegate void SaveHandler(List<string> selectedLanguages);
        public event SaveHandler OnPickLanguageSave;

        public delegate void CancelHandler();
        public event CancelHandler OnPickLanguageCancel;

        List<string> languages = new List<string>
        {
            {"C Programming"},
            "C# Programming",
            "Python",
            "Node",
            "Javascript",
            "Typescript",
            "SQL"
        };
        public PickLanguageCtrl()
        {
            InitializeComponent();
            SupportedLanguages.ItemsSource = languages;
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            if (OnPickLanguageCancel != null)
                OnPickLanguageCancel?.Invoke();
        }
    }
}
