using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class DataGridView : Form
    {
        private DataGridViewModel _viewModel;
        
        public DataGridView()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            _viewModel = new DataGridViewModel();
            // DataGridControl.DataBindings.Add(nameof(DataGridControl.DataSource), _viewModel,
            //    nameof(_viewModel.Persons), true, DataSourceUpdateMode.OnPropertyChanged);
            ConnectionStringTxt.DataBindings.Add(nameof(ConnectionStringTxt.Text), _viewModel,
                nameof(_viewModel.ConnectionString), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            _viewModel.Connect();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            _viewModel.Read();
            DataGridControl.DataSource = _viewModel.Persons;

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
