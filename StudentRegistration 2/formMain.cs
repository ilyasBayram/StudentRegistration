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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDormitoryRegistrationDataSet1.TblStudent' table. You can move, or remove it, as needed.
            this.tblStudentTableAdapter.Fill(this.dbDormitoryRegistrationDataSet1.TblStudent);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblHour.Text = DateTime.Now.ToLongTimeString();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formStudentList form = new formStudentList();
            form.ShowDialog();
        }

        private void updateStudentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formStudenUpdate form3 = new formStudenUpdate();
            form3.ShowDialog();
        }

        private void departmentUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departments form = new Departments();
            form.ShowDialog();
        }

        private void studentLoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDebt form = new formDebt();
            form.ShowDialog();
        }

        private void expensListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formExpensList form = new formExpensList();
            form.ShowDialog();
        }

        private void updateExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }
    }
}
