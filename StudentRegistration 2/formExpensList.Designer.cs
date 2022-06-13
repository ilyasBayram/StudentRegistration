
namespace StudentRegistration_2
{
    partial class formExpensList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.expensesIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.electricDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naturalGasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblExpensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDormitoryRegistrationDataSet9 = new StudentRegistration_2.DbDormitoryRegistrationDataSet9();
            this.tblExpensesTableAdapter = new StudentRegistration_2.DbDormitoryRegistrationDataSet9TableAdapters.TblExpensesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblExpensesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDormitoryRegistrationDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.expensesIDDataGridViewTextBoxColumn,
            this.electricDataGridViewTextBoxColumn,
            this.waterDataGridViewTextBoxColumn,
            this.naturalGasDataGridViewTextBoxColumn,
            this.internetDataGridViewTextBoxColumn,
            this.foodDataGridViewTextBoxColumn,
            this.personelDataGridViewTextBoxColumn,
            this.otherDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblExpensesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1349, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // expensesIDDataGridViewTextBoxColumn
            // 
            this.expensesIDDataGridViewTextBoxColumn.DataPropertyName = "ExpensesID";
            this.expensesIDDataGridViewTextBoxColumn.HeaderText = "ExpensesID";
            this.expensesIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.expensesIDDataGridViewTextBoxColumn.Name = "expensesIDDataGridViewTextBoxColumn";
            this.expensesIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.expensesIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // electricDataGridViewTextBoxColumn
            // 
            this.electricDataGridViewTextBoxColumn.DataPropertyName = "Electric";
            this.electricDataGridViewTextBoxColumn.HeaderText = "Electric";
            this.electricDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.electricDataGridViewTextBoxColumn.Name = "electricDataGridViewTextBoxColumn";
            this.electricDataGridViewTextBoxColumn.Width = 150;
            // 
            // waterDataGridViewTextBoxColumn
            // 
            this.waterDataGridViewTextBoxColumn.DataPropertyName = "Water";
            this.waterDataGridViewTextBoxColumn.HeaderText = "Water";
            this.waterDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.waterDataGridViewTextBoxColumn.Name = "waterDataGridViewTextBoxColumn";
            this.waterDataGridViewTextBoxColumn.Width = 150;
            // 
            // naturalGasDataGridViewTextBoxColumn
            // 
            this.naturalGasDataGridViewTextBoxColumn.DataPropertyName = "NaturalGas";
            this.naturalGasDataGridViewTextBoxColumn.HeaderText = "NaturalGas";
            this.naturalGasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.naturalGasDataGridViewTextBoxColumn.Name = "naturalGasDataGridViewTextBoxColumn";
            this.naturalGasDataGridViewTextBoxColumn.Width = 150;
            // 
            // internetDataGridViewTextBoxColumn
            // 
            this.internetDataGridViewTextBoxColumn.DataPropertyName = "internet";
            this.internetDataGridViewTextBoxColumn.HeaderText = "internet";
            this.internetDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.internetDataGridViewTextBoxColumn.Name = "internetDataGridViewTextBoxColumn";
            this.internetDataGridViewTextBoxColumn.Width = 150;
            // 
            // foodDataGridViewTextBoxColumn
            // 
            this.foodDataGridViewTextBoxColumn.DataPropertyName = "Food";
            this.foodDataGridViewTextBoxColumn.HeaderText = "Food";
            this.foodDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.foodDataGridViewTextBoxColumn.Name = "foodDataGridViewTextBoxColumn";
            this.foodDataGridViewTextBoxColumn.Width = 150;
            // 
            // personelDataGridViewTextBoxColumn
            // 
            this.personelDataGridViewTextBoxColumn.DataPropertyName = "Personel";
            this.personelDataGridViewTextBoxColumn.HeaderText = "Personel";
            this.personelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.personelDataGridViewTextBoxColumn.Name = "personelDataGridViewTextBoxColumn";
            this.personelDataGridViewTextBoxColumn.Width = 150;
            // 
            // otherDataGridViewTextBoxColumn
            // 
            this.otherDataGridViewTextBoxColumn.DataPropertyName = "Other";
            this.otherDataGridViewTextBoxColumn.HeaderText = "Other";
            this.otherDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.otherDataGridViewTextBoxColumn.Name = "otherDataGridViewTextBoxColumn";
            this.otherDataGridViewTextBoxColumn.Width = 150;
            // 
            // tblExpensesBindingSource
            // 
            this.tblExpensesBindingSource.DataMember = "TblExpenses";
            this.tblExpensesBindingSource.DataSource = this.dbDormitoryRegistrationDataSet9;
            // 
            // dbDormitoryRegistrationDataSet9
            // 
            this.dbDormitoryRegistrationDataSet9.DataSetName = "DbDormitoryRegistrationDataSet9";
            this.dbDormitoryRegistrationDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblExpensesTableAdapter
            // 
            this.tblExpensesTableAdapter.ClearBeforeFill = true;
            // 
            // formExpensList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "formExpensList";
            this.Text = "formExpensList";
            this.Load += new System.EventHandler(this.formExpensList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblExpensesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDormitoryRegistrationDataSet9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DbDormitoryRegistrationDataSet9 dbDormitoryRegistrationDataSet9;
        private System.Windows.Forms.BindingSource tblExpensesBindingSource;
        private DbDormitoryRegistrationDataSet9TableAdapters.TblExpensesTableAdapter tblExpensesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn expensesIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn electricDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naturalGasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherDataGridViewTextBoxColumn;
    }
}