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


        mySqlConnection connection = new mySqlConnection();


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
                    //it adds new departmen names to table.
                    SqlCommand commandAdd = new SqlCommand("insert into TblDepartment (DepartmentName) values (@p1)", connection.connection());
                    commandAdd.Parameters.AddWithValue("@p1", txBoxDepartmentName.Text);
                    commandAdd.ExecuteNonQuery();
                    connection.connection().Close();
                    MessageBox.Show("New department is added");
                    this.tblDepartmentTableAdapter.Fill(this.dbDormitoryRegistrationDataSet.TblDepartment);
                }
                catch (Exception)
                {

                    MessageBox.Show("Warning!! Problem occured. Please try again", "Warning");
                }
            }
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // it deletes data from table of department.
                SqlCommand commandDelete = new SqlCommand("delete from TblDepartment where departmentID =@p1", connection.connection());
                commandDelete.Parameters.AddWithValue("@p1", txBoxDepartmentID.Text);
                commandDelete.ExecuteNonQuery();
                connection.connection().Close();

                MessageBox.Show("Deletion is successfull");
                this.tblDepartmentTableAdapter.Fill(this.dbDormitoryRegistrationDataSet.TblDepartment);
            }
            catch (Exception)
            {
                MessageBox.Show("Warning!! Problem occured. Please try again");

            }
            

        }
        int choosen;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // it reads data when the a row clicked and those datas will be appear on textboxes.
            string departmentID, departmentName;
            choosen = dataGridView1.SelectedCells[0].RowIndex;
            departmentID = dataGridView1.Rows[choosen].Cells[0].Value.ToString();
            departmentName = dataGridView1.Rows[choosen].Cells[1].Value.ToString();
            txBoxDepartmentID.Text = departmentID;
            txBoxDepartmentName.Text = departmentName;

        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //it edits department names on department name column.
                SqlCommand commandUpdate = new SqlCommand("update TblDepartment set DepartmentName=@p1 where DepartmentID=@p2", connection.connection());
                commandUpdate.Parameters.AddWithValue("@p1", txBoxDepartmentName.Text);
                commandUpdate.Parameters.AddWithValue("@p2", txBoxDepartmentID.Text);
                commandUpdate.ExecuteNonQuery();
                connection.connection().Close();
                MessageBox.Show("Department name is updated");
                this.tblDepartmentTableAdapter.Fill(this.dbDormitoryRegistrationDataSet.TblDepartment);
            }
            catch (Exception)
            {

                MessageBox.Show("Warning!! Problem occured. Please try again", "Warning");
            }
            
        }

       
    }
}
