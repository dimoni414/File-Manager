using Mvvm.Core.ViewModels;
using SimpleBlank.Interface;

namespace SimpleBlank.Models
{
    public abstract class DataElement : ViewModelBase, IDataElement
    {
        public string FullName
        {
            get { return _fullName; }

            set { UpdateValue(value, ref _fullName); }
        }

        public string Name
        {
            get { return _fullName; }

            set { UpdateValue(value, ref _name); }
        }

        public State State
        {
            get { return _state; }

            set
            { UpdateValue(value, ref _state); }
        }

        private string _name;
        private string _fullName;
        private State _state;
    }
}