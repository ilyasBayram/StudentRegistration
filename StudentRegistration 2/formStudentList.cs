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
            this.tblStudentTableAdapter.Fill(this.dbDormitoryRegistrationDataSet8.TblStudent);
        }

        int choosen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //it prevents form opening a second time. if form is open already to check another perso data open one should be closed first.
            bool isOpen = false;
           
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text== "formStudenUpdate")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
           
            //When a cell is clicked it brings data from list to  studen update form. 
            if (isOpen==false)
            {
                formStudenUpdate form = new formStudenUpdate();
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
                form.Show();
            }
            
        }
    }
}
