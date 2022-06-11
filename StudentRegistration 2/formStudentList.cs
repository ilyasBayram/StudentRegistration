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
    public partial class formStudentList : Form
    {
        public formStudentList()
        {
            InitializeComponent();
        }

        private void formStudentList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDormitoryRegistrationDataSet6.TblStudent' table. You can move, or remove it, as needed.
            this.tblStudentTableAdapter2.Fill(this.dbDormitoryRegistrationDataSet6.TblStudent);
            // TODO: This line of code loads data into the 'dbDormitoryRegistrationDataSet5.TblStudent' table. You can move, or remove it, as needed.
            this.tblStudentTableAdapter1.Fill(this.dbDormitoryRegistrationDataSet5.TblStudent);
            // TODO: This line of code loads data into the 'dbDormitoryRegistrationDataSet4.TblStudent' table. You can move, or remove it, as needed.
            this.tblStudentTableAdapter.Fill(this.dbDormitoryRegistrationDataSet4.TblStudent);

        }

        int choosen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            choosen = dataGridView1.SelectedCells[0].RowIndex;
            formStudenUpdate form = new formStudenUpdate();
            form.id = dataGridView1.Rows[choosen].Cells[0].Value.ToString();
            form.name = dataGridView1.Rows[choosen].Cells[1].Value.ToString();
            form.surname = dataGridView1.Rows[choosen].Cells[2].Value.ToString();
            form.nationalNumber = dataGridView1.Rows[choosen].Cells[3].Value.ToString();
            form.Show();
        }
    }
}
