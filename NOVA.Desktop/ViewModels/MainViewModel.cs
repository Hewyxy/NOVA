using System;
using System.Collections.Generic;
using System.Text;


using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

using NOVA.Desktop.Commands;
using System.Windows.Input;

namespace NOVA.Desktop.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ICommand InitializeCommand { get; }
        private string _status = "Status: Idle";

        public string Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            InitializeCommand = new AsyncRelayCommand(InitializeAsync);
        }

        public async Task InitializeAsync()
        {
            Status = "Status: Initializing NOVA...";

            await Task.Delay(2000);

            Status = "Status: NOVA is now live!";
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(
            [CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(
                this,
                new PropertyChangedEventArgs(propertyName));
        }

        private bool _isInitializing;
        public bool CanInitialize()
        {
            return !_isInitializing;
        }
    }
}
