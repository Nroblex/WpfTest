﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfTest.ViewModel
{
    public class DelegateCommand : ICommand
    {
        private readonly Action action;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            action();
        }

        public DelegateCommand(Action action)
        {
            this.action = action;
        }
    }
}
