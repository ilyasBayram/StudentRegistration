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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        mySqlConnection connection = new mySqlConnection();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Department name from depertment table is taken with that connection
            SqlCommand commendDep = new SqlCommand("select departmentName from TblDepartment ", connection.connection());
            SqlDataReader readDep = commendDep.ExecuteReader();
            while (readDep.Read())
            {
                cmbBoxStudentDepartment.Items.Add(readDep[0].ToString());
            }
            connection.connection().Close();

            //Number of rooms which is available for antoher person is taken from room table
            //with that connection
            SqlCommand commendRoom= new SqlCommand("select roomno from TblRoom where roomcapacity!=roomactive", connection.connection());
            SqlDataReader readRoom = commendRoom.ExecuteReader();
            while (readRoom.Read())
            {
                cmbBoxStudentRoomNo.Items.Add(readRoom[0].ToString());
            }
            connection.connection().Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //this connection adds informations coming from registration form to database
            //when save button is clicked.

            try
            {

                SqlCommand save = new SqlCommand("insert into tblstudent (StudentName,StudentSurname," +
                    "StudentNationalNumber,StudentPhone,StudentBirthDay,StudentDepartment," +
                    "StudentMail,StudentRoomNo,StudentParentName,StudentParentPhone,StudentParentAdress) " +
                    "values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", connection.connection());

                save.Parameters.AddWithValue("@p1", txBoxStudentName.Text);
                save.Parameters.AddWithValue("@p2", txBoxStudentSurname.Text);
                save.Parameters.AddWithValue("@p3", mskdTxBoxStudentNatioanlNumber.Text);
                save.Parameters.AddWithValue("@p4", mskdTxBoxStudentPhone.Text);
                save.Parameters.AddWithValue("@p5", mskdTxBoxStudentBirth.Text);
                save.Parameters.AddWithValue("@p6", cmbBoxStudentDepartment.Text);
                save.Parameters.AddWithValue("@p7", txBoxStudentMail.Text);
                save.Parameters.AddWithValue("@p8", cmbBoxStudentRoomNo.Text);
                save.Parameters.AddWithValue("@p9", txBoxStudentParentName.Text);
                save.Parameters.AddWithValue("@p10", mskdTxBoxStudentparentPhone.Text);
                save.Parameters.AddWithValue("@p11", rchTxBoxParentAdress.Text);

                save.ExecuteNonQuery();

                connection.connection().Close();

                MessageBox.Show("Successfull resgistration.");
            }
            catch (Exception)
            {

                MessageBox.Show("Warninng!!!. Please check informations.");
            }
            
        }
    }
}
