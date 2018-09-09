using System.ComponentModel;
using System.Runtime.CompilerServices;
using UI.Annotations;

namespace UI
{
    public class Person : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;

        public string FisrtName
        {
            get => _firstName;
            set
            {
                if (_firstName != value) 
                {
                    _firstName = value;
                    OnPropertyChanged();
                }
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}