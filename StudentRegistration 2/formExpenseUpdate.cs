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
    public partial class formExpenseUpdate : Form
    {
        public formExpenseUpdate(formExpensList form)
        {
            InitializeComponent();

            form2 = form;
        }

        mySqlConnection connection = new mySqlConnection();
        formExpensList form2 = new formExpensList();

        public string electric, water, naturalGas, internet, food, personel, other, id;

        private void formExpenseUpdate_Load(object sender, EventArgs e)
        {
            txBoxExpenseID.Text = id;
            txBoxElectric.Text = electric;
            txBoxWater.Text = water;
            txBoxNaturalGas.Text = naturalGas;
            txBoxInternet.Text = internet;
            txBoxFood.Text = food;
            txBoxPersonal.Text = personel;
            txBoxOther.Text = other;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("update Tblexpenses set electric=@p1, water=@p2, naturalgas= @p3, internet=@p4," +
               "food=@p5, personel=@p6, other=@p7 where ExpensesID=@p8", connection.connection());
                command.Parameters.AddWithValue("@p1", txBoxElectric.Text);
                command.Parameters.AddWithValue("@p2", txBoxWater.Text);
                command.Parameters.AddWithValue("@p3", txBoxNaturalGas.Text);
                command.Parameters.AddWithValue("@p4", txBoxInternet.Text);
                command.Parameters.AddWithValue("@p5", txBoxFood.Text);
                command.Parameters.AddWithValue("@p6", txBoxPersonal.Text);
                command.Parameters.AddWithValue("@p7", txBoxOther.Text);
                command.Parameters.AddWithValue("@p8", txBoxExpenseID.Text);
                command.ExecuteNonQuery();
                connection.connection().Close();
                form2.updateData();
                MessageBox.Show("Update is successfull.");
            }
            catch (Exception)
            {

                MessageBox.Show("Something is wrong. please check again.", "Warning.");
            }

        }
    }
}
