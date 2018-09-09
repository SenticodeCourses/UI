using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UI.Annotations;
using UI.Services;

namespace UI
{
    class DataGridViewModel : INotifyPropertyChanged
    {
        private readonly DataBaseServices<Person> _personDataService;

        public DataGridViewModel()
        {
            _personDataService = PersonDataService.Instance;
        }

        public ObservableCollection<Person> Persons { get; set; } =
            new ObservableCollection<Person>();

        public string ConnectionString { get; set; } = "Default string";
        public void Connect()
        {
            _personDataService.Connect(ConnectionString);
        }

        public void Disconect()
        {
        }

        public void Create()
        {
           
        }

        public void Delete(Person person)
        {
            
        }
        public void Delete(IEnumerable<Person> persons)
        {
           
        }

        public void Read()
        {
            if (!_personDataService.IsOpen) return;
            Persons.Clear();
            foreach (var person in _personDataService.Read())
            {
                Persons.Add(person);
            }
            OnPropertyChanged(nameof(Persons));
        }

        public void Update(IEnumerable<Person> persons)
        {
           
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
