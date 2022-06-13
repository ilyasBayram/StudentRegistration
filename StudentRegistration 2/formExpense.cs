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
    public partial class formExpense : Form
    {
        public formExpense()
        {
            InitializeComponent();
        }

        mySqlConnection connection = new mySqlConnection();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("insert into tblexpenses (electric, water, naturalgas, internet, food, personel, other) Values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", connection.connection());
                command.Parameters.AddWithValue("@p1", txBoxElectric.Text);
                command.Parameters.AddWithValue("@p2", txBoxWater.Text);
                command.Parameters.AddWithValue("@p3", txBoxNaturalGas.Text);
                command.Parameters.AddWithValue("@p4", txBoxInternet.Text);
                command.Parameters.AddWithValue("@p5", txBoxFood.Text);
                command.Parameters.AddWithValue("@p6", txBoxPersonal.Text);
                command.Parameters.AddWithValue("@p7", txBoxOther.Text);
                command.ExecuteNonQuery();
                connection.connection().Close();
                MessageBox.Show("Saving is successgfull");

            }
            catch (Exception)
            {
                MessageBox.Show("Some thing is wrong. Please try again.", "Warning");
            }
               
        }
    }
}