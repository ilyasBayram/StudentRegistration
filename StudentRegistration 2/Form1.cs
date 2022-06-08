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

        SqlConnection connection = new SqlConnection(@"Data Source=NB3401-0011;Initial Catalog=DbDormitoryRegistration;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand commend = new SqlCommand("select departmentName from TblDepartment ", connection);
            SqlDataReader read = commend.ExecuteReader();
            while (read.Read())
            {
                cmbBoxStudentDepartment.Items.Add(read[0].ToString());
            }

            connection.Close();
        }
    }
}
