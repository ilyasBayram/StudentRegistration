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
    }
}
