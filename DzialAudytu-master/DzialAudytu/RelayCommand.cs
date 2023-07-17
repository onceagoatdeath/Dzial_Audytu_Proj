using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DzialAudytu
{

    /// A command implementation that wraps an action to be executed when the command is invoked.

    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;
        public event EventHandler? CanExecuteChanged;

        public RelayCommand(Action execute) : this(execute, null)
        {
        }

        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        /// Determines whether the command can execute in its current state.
        /// <param name="parameter">The data used by the command. If the command does not require data to be passed, this object can be set to null.</param>
        /// true if this command can be executed; otherwise, false.
        public bool CanExecute(object parameter)
        {
            return _canExecute?.Invoke() ?? true;
        }


        /// Executes the command.
        /// <param name="parameter">The data used by the command. If the command does not require data to be passed, this object can be set to null.</param>
        public void Execute(object parameter)
        {
            _execute();
        }
    }
}
