using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentRegistration_2
{
    public partial class formStudenUpdate : Form
    {
        //we add "this" parameter to "form" object on studenlist form and when we careate form2 on this form we equals them. otherwise when we call
        // updatedata method it does not work. with that way you can refresh data on a form from another form.
        // In this case it refresh grid on studentlist form when you click update button on this form.
        public formStudenUpdate(formStudentList form)
        {
            InitializeComponent();

            form2 = form;
        }

        formStudentList form2 = new formStudentList();

        mySqlConnection conection = new mySqlConnection();
        // we try to reach those variables from student list form. that is why it starts with public. it must be reachable from everywhere.
        public string id, name, surname, roomNumber, nationalNumber, phoneNumber, birtDay, departmentName, mail, parentName, parentPhone, parentAdress;

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand command = new SqlCommand("update Tblstudent set studentName=@p1, studentSurname=@p2, studentRoomNo= @p3, studentNationalNumber=@p4," +
                "studentPhone=@p5, studentBirthDay=@p6, studentDepartment=@p7, studentMail=@p8, studentParentName=@p9, studentParentPhone=@p10," +
                "studentParentAdress=@p11 where studentID=@p12", conection.connection());
                command.Parameters.AddWithValue("@p1", txBoxStudentName.Text);
                command.Parameters.AddWithValue("@p2", txBoxStudentSurname.Text);
                command.Parameters.AddWithValue("@p3", txBoxRoomNo.Text);
                command.Parameters.AddWithValue("@p4", mskdTxBoxStudentNatioanlNumber.Text);
                command.Parameters.AddWithValue("@p5", mskdTxBoxStudentPhone.Text);
                command.Parameters.AddWithValue("@p6", mskdTxBoxStudentBirth.Text);
                command.Parameters.AddWithValue("@p7", txBoxDepartmenName.Text);
                command.Parameters.AddWithValue("@p8", txBoxStudentMail.Text);
                command.Parameters.AddWithValue("@p9", txBoxStudentParentName.Text);
                command.Parameters.AddWithValue("@p10", mskdTxBoxStudentparentPhone.Text);
                command.Parameters.AddWithValue("@p11", rchTxBoxParentAdress.Text);
                command.Parameters.AddWithValue("@p12", txBoxStudentID.Text);
                command.ExecuteNonQuery();
                conection.connection().Close();
                form2.updatedata();
                MessageBox.Show("Update is successfull.");
               

            }
            catch (Exception)
            {
                MessageBox.Show("Something is wrong. please check again.", "Warning.");
            }


            
        }

        private void formStudenUpdate_Load(object sender, EventArgs e)
        {
            // it addes informations to boxes.
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
