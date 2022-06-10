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
    public partial class formDebt : Form
    {
        public formDebt()
        {
            InitializeComponent();
        }

        mySqlConnection connection = new mySqlConnection();
        private void formDebt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDormitoryRegistrationDataSet3.TblDebt' table. You can move, or remove it, as needed.
            this.tblDebtTableAdapter1.Fill(this.dbDormitoryRegistrationDataSet3.TblDebt);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //when you select a cell in a row data on that row appars on txboxes.
            int choosen;

            string studentID, studentName, studentSurname, remainingdDebt;
            choosen = dataGridView1.SelectedCells[0].RowIndex;
            studentID = dataGridView1.Rows[choosen].Cells[0].Value.ToString();
            studentName = dataGridView1.Rows[choosen].Cells[1].Value.ToString();
            studentSurname = dataGridView1.Rows[choosen].Cells[2].Value.ToString();
            remainingdDebt = dataGridView1.Rows[choosen].Cells[3].Value.ToString();
            txBoxStudentID.Text = studentID;
            txBoxStudenName.Text = studentName;
            txBoxStudentSurname.Text = studentSurname;
            txBoxRemain.Text = remainingdDebt;

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            //it calculates remaining debt after a payment amount enter.
            int paid, remain, newDebt;
            paid = Convert.ToInt32(txBoxPaid.Text);
            remain = Convert.ToInt32(txBoxRemain.Text);
            newDebt = remain - paid;
            txBoxRemain.Text = newDebt.ToString();

           

            try
            {
                //it updates remaining debt column vith data on remaning textbox.
                SqlCommand command = new SqlCommand("update TblDebt set studentRemainingDebt=@p1 where studentID=@p2", connection.connection());
                command.Parameters.AddWithValue("@p1", txBoxRemain.Text);
                command.Parameters.AddWithValue("@p2", txBoxStudentID.Text);
                command.ExecuteNonQuery();
                connection.connection().Close();
                MessageBox.Show("New payment updated..");
                this.tblDebtTableAdapter1.Fill(this.dbDormitoryRegistrationDataSet3.TblDebt);
            }
            catch (Exception)
            {
                MessageBox.Show("Warning!! Problem occured. Please try again", "Warning");
            }
            
        }

    }
}
