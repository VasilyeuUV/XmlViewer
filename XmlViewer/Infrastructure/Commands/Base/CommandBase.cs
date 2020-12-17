using System;
using System.Windows.Input;

namespace XmlViewer.Infrastructure.Commands.Base
{
    internal abstract class CommandBase : ICommand
    {

        #region Executable

        private bool _executable;

        public bool Executable
        {
            get => _executable;
            set
            {
                if (_executable == value) { return; }

                _executable = value;
                CommandManager.InvalidateRequerySuggested();
            }
        }

        #endregion

        #region ICommand

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        bool ICommand.CanExecute(object parameter) => _executable && CanExecute(parameter);

        void ICommand.Execute(object parameter)
        {
            if (CanExecute(parameter)) { Execute(parameter); }
        }

        #endregion

        protected virtual bool CanExecute(object parameter) => true;

        protected abstract void Execute(object parameter);


    }
}
