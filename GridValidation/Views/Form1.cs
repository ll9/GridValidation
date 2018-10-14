using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridValidation
{
    public partial class Form1 : Form
    {
        private ErrorProvider _errorProvider = new ErrorProvider();
        public Form1()
        {
            InitializeComponent();
        }

        private void personDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Control edit = personDataGridView.EditingControl;
            _errorProvider.SetError(edit, "Invalid Value");
            _errorProvider.SetIconAlignment(edit, ErrorIconAlignment.MiddleRight);
            _errorProvider.SetIconPadding(edit, -20); // icon displays on left side of cell

            personDataGridView[e.ColumnIndex, e.RowIndex].Value = "";




        }

        private void personDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _errorProvider.Clear();
        }
    }
}
