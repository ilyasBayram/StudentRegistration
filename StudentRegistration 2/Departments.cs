using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistration_2
{
    public partial class Departments : Form
    {
        public Departments()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=NB3401-0011;Initial Catalog=DbDormitoryRegistration;Integrated Security=True");

        private void Departments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDormitoryRegistrationDataSet.TblDepartment' table. You can move, or remove it, as needed.
            this.tblDepartmentTableAdapter.Fill(this.dbDormitoryRegistrationDataSet.TblDepartment);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insert into TblDepartment (DepartmentName) values (@p1)", connection);
                command.Parameters.AddWithValue("@p1", txBoxDepartmentName.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("New departmen is added");
            }
            catch (Exception)
            {

                MessageBox.Show("Warning!! Problem occured. Please try again");
            }
            
        }
    }
}
