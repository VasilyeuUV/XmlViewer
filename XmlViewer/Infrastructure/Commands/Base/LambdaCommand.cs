using System;

namespace XmlViewer.Infrastructure.Commands.Base
{
    internal class LambdaCommand : CommandBase
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;


        #region CTOR

        public LambdaCommand(Action execute, Func<bool> canExecute = null) : this(
          execute: p => execute(),
          canExecute: canExecute is null ? (Func<object, bool>)null : p => canExecute()
          )
        { }
        public LambdaCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this._execute = execute ?? throw new ArgumentNullException(nameof(execute));
            this._canExecute = canExecute;
        } 

        #endregion


        #region CommandBase

        protected override bool CanExecute(object parameter) => _canExecute?.Invoke(parameter) ?? true;

        protected override void Execute(object parameter) => _execute(parameter);        

        #endregion

    }
}
