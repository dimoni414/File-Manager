using Mvvm.Core.Services;
using Mvvm.Core.ViewModels;
using System;
using System.Windows.Input;

namespace ViewModels
{
    internal class MainViewModel : ViewModelBase
    {
        #region Propertys

        public object BlankProperty
        {
            get { return _blank; }
            set { UpdateValue(value, ref _blank); }
        }

        #endregion Propertys

        #region Commands

        public ICommand BlankCommand { get; set; }

        #endregion Commands

        #region Constructor

        public MainViewModel(RelayCommandFactory commandFactory)
        {
        }

        #endregion Constructor

        #region Methods

       
        #endregion Methods

        #region Fields

        private object _blank;

        #endregion Fields
    }
}