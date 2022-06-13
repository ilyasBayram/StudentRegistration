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

        public void updatedata()
        {
            this.tblStudentTableAdapter.Fill(this.dbDormitoryRegistrationDataSet8.TblStudent);
        }

        private void formStudentList_Load(object sender, EventArgs e)
        {
            updatedata();
        }

        int choosen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //When a cell is clicked it brings data from list to  studen update form. 

            formStudenUpdate form = new formStudenUpdate(this);
            choosen = dataGridView1.SelectedCells[0].RowIndex;

            form.id = dataGridView1.Rows[choosen].Cells[0].Value.ToString();
            form.name = dataGridView1.Rows[choosen].Cells[1].Value.ToString();
            form.surname = dataGridView1.Rows[choosen].Cells[2].Value.ToString();
            form.roomNumber = dataGridView1.Rows[choosen].Cells[3].Value.ToString();
            form.nationalNumber = dataGridView1.Rows[choosen].Cells[4].Value.ToString();
            form.phoneNumber = dataGridView1.Rows[choosen].Cells[5].Value.ToString();
            form.birtDay = dataGridView1.Rows[choosen].Cells[6].Value.ToString();
            form.departmentName = dataGridView1.Rows[choosen].Cells[7].Value.ToString();
            form.mail = dataGridView1.Rows[choosen].Cells[8].Value.ToString();
            form.parentName = dataGridView1.Rows[choosen].Cells[9].Value.ToString();
            form.parentPhone = dataGridView1.Rows[choosen].Cells[10].Value.ToString();
            form.parentAdress = dataGridView1.Rows[choosen].Cells[11].Value.ToString();
            form.ShowDialog(); // instead of "show" we use "showdialog". it prevents a second click to studenlist form.

        }
    }
}
