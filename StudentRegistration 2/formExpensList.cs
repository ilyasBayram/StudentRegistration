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

        public void updateData()
        {
            // TODO: This line of code loads data into the 'dbDormitoryRegistrationDataSet9.TblExpenses' table. You can move, or remove it, as needed.
            this.tblExpensesTableAdapter.Fill(this.dbDormitoryRegistrationDataSet9.TblExpenses);
        }
        private void formExpensList_Load(object sender, EventArgs e)
        {
            updateData();

        }

        int choosen;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            formExpenseUpdate form = new formExpenseUpdate(this);
            choosen = dataGridView1.SelectedCells[0].RowIndex;

            form.id = dataGridView1.Rows[choosen].Cells[0].Value.ToString();
            form.electric = dataGridView1.Rows[choosen].Cells[1].Value.ToString();
            form.water = dataGridView1.Rows[choosen].Cells[2].Value.ToString();
            form.naturalGas = dataGridView1.Rows[choosen].Cells[3].Value.ToString();
            form.internet = dataGridView1.Rows[choosen].Cells[4].Value.ToString();
            form.food = dataGridView1.Rows[choosen].Cells[5].Value.ToString();
            form.personel= dataGridView1.Rows[choosen].Cells[6].Value.ToString();
            form.other = dataGridView1.Rows[choosen].Cells[7].Value.ToString();
            form.ShowDialog(); // instead of "show" we use "showdialog". it prevents a second click to studenlist form.
        }
    }
}
