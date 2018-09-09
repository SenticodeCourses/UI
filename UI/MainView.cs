using System;
using System.Windows.Forms;

namespace UI
{
    public partial class MainView : Form
    {
        private Person _person;

        public MainView()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            _person = new Person();
            LastName.DataBindings.Add(nameof(LastName.Text), _person, nameof(_person.LastName), true, DataSourceUpdateMode.OnPropertyChanged);
            FirstName.DataBindings.Add(nameof(FirstName.Text), _person, nameof(_person.FisrtName), true, DataSourceUpdateMode.OnPropertyChanged);
            DublicateTxt.DataBindings.Add(nameof(DublicateTxt.Text), _person, nameof(_person.LastName), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Initialize();
            FirstName.Text = _person.FisrtName;
            LastName.Text = _person.LastName;
            DublicateTxt.Text = _person.LastName;
        }

        private void DublicateTxt_TextChanged(object sender, EventArgs e)
        {
            //_person.LastName = DublicateTxt.Text;
            //LastName.Text = _person.LastName;
        }


        private void LastName_TextChanged(object sender, EventArgs e)
        {
            //_person.LastName = LastName.Text;
            //DublicateTxt.Text = _person.LastName;
        }

        private void Dublicate_Enter(object sender, EventArgs e)
        {

        }

    }

}
