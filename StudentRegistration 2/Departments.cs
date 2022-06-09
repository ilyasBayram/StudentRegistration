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

        private void emptyTxBox()
        {
            if (txBoxDepartmentName==null)
            {

            }
        }

        private void Departments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDormitoryRegistrationDataSet.TblDepartment' table. You can move, or remove it, as needed.
            this.tblDepartmentTableAdapter.Fill(this.dbDormitoryRegistrationDataSet.TblDepartment);

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txBoxDepartmentName.Text=="")
            {
                MessageBox.Show("Department name con not be empty", "Warning");
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand commandAdd = new SqlCommand("insert into TblDepartment (DepartmentName) values (@p1)", connection);
                    commandAdd.Parameters.AddWithValue("@p1", txBoxDepartmentName.Text);
                    commandAdd.ExecuteNonQuery();
                    MessageBox.Show("New departmen is added");
                    this.tblDepartmentTableAdapter.Fill(this.dbDormitoryRegistrationDataSet.TblDepartment);
                }
                catch (Exception)
                {

                    MessageBox.Show("Warning!! Problem occured. Please try again");
                }
            }
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand commandDelete = new SqlCommand("delete from TblDepartment where departmentID =@p1", connection);
                commandDelete.Parameters.AddWithValue("@p1", txBoxDepartmentID.Text);
                commandDelete.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Deletion is successfull");
                this.tblDepartmentTableAdapter.Fill(this.dbDormitoryRegistrationDataSet.TblDepartment);
            }
            catch (Exception)
            {
                MessageBox.Show("Warning!! Problem occured. Please try again");

            }
            

        }
        int choosen;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string departmentID, departmentName;
            choosen = dataGridView1.SelectedCells[0].RowIndex;
            departmentID = dataGridView1.Rows[choosen].Cells[0].Value.ToString();
            departmentName = dataGridView1.Rows[choosen].Cells[1].Value.ToString();
            txBoxDepartmentID.Text = departmentID;
            txBoxDepartmentName.Text = departmentName;

        }
    }
}
