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
    public partial class formStudenUpdate : Form
    {
        public formStudenUpdate()
        {
            InitializeComponent();
        }

        public string id, name, surname, roomNumber, nationalNumber, phoneNumber, birtDay, departmentName, mail, parentName, parentPhone, parentAdress;

        private void formStudenUpdate_Load(object sender, EventArgs e)
        {
            txBoxStudentID.Text = id;
            txBoxStudentName.Text = name;
            txBoxStudentSurname.Text = surname;
            txBoxRoomNo.Text = roomNumber;
            mskdTxBoxStudentNatioanlNumber.Text = nationalNumber;
            mskdTxBoxStudentPhone.Text = phoneNumber;
            mskdTxBoxStudentBirth.Text = birtDay;
            txBoxDepartmenName.Text = departmentName;
            txBoxStudentMail.Text = mail;
            txBoxStudentParentName.Text = parentName;
            mskdTxBoxStudentparentPhone.Text = parentPhone;
            rchTxBoxParentAdress.Text = parentAdress;


        }
    }
}
