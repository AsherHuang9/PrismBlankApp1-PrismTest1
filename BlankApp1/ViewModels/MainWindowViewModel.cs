using System;
using System.Windows.Controls.Primitives;
using Prism.Commands;
using Prism.Mvvm;

namespace BlankApp1.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "1111";
        private string fieldName;
        private DelegateCommand _btnClickCommand;
        public DelegateCommand SubmitCommand { get; private set; }

        public DelegateCommand BtnClickCommand =>
            _btnClickCommand ?? (_btnClickCommand = new DelegateCommand(ExecuteCommand));

        void ExecuteCommand()
        {

        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {
            SubmitCommand = new DelegateCommand(Submit, CanSubmit);
        }
        void Submit()
        {
            //implement logic
        }
        bool CanSubmit()
        {
            return true;
        }
    }
}
