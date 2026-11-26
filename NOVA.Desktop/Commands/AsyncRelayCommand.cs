using System;
using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NOVA.Desktop.Commands
{
    public class AsyncRelayCommand : ICommand
    {
        private readonly Func<Task> _execute;
        private bool _isRunning;

        public AsyncRelayCommand(Func<Task> execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object? parameter)
        {
            return !_isRunning;
        }

        public async void Execute(object? parameter)
        {
            if (!CanExecute(parameter))
                return;

            _isRunning = true;
            RaiseCanExecuteChanged();

            try
            {
                await _execute();
            }
            finally
            {
                _isRunning = false;
                RaiseCanExecuteChanged();
            }
        }

        public event EventHandler? CanExecuteChanged;

        private void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
