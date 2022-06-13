using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistration_2
{
    public partial class formExpensList : Form
    {
        public formExpensList()
        {
            InitializeComponent();
        }

        private void formExpensList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDormitoryRegistrationDataSet9.TblExpenses' table. You can move, or remove it, as needed.
            this.tblExpensesTableAdapter.Fill(this.dbDormitoryRegistrationDataSet9.TblExpenses);

        }
    }
}
