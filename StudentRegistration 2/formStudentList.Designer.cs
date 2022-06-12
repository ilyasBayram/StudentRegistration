
namespace StudentRegistration_2
{
    partial class formStudentList
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
            this.dbDormitoryRegistrationDataSet8 = new StudentRegistration_2.DbDormitoryRegistrationDataSet8();
            this.tblStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStudentTableAdapter = new StudentRegistration_2.DbDormitoryRegistrationDataSet8TableAdapters.TblStudentTableAdapter();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentRoomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNationalNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBirthDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentParentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentParentPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentParentAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDormitoryRegistrationDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.studentRoomNoDataGridViewTextBoxColumn,
            this.studentNationalNumberDataGridViewTextBoxColumn,
            this.studentPhoneDataGridViewTextBoxColumn,
            this.studentBirthDayDataGridViewTextBoxColumn,
            this.studentDepartmentDataGridViewTextBoxColumn,
            this.studentMailDataGridViewTextBoxColumn,
            this.studentParentNameDataGridViewTextBoxColumn,
            this.studentParentPhoneDataGridViewTextBoxColumn,
            this.studentParentAdressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblStudentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1491, 514);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dbDormitoryRegistrationDataSet8
            // 
            this.dbDormitoryRegistrationDataSet8.DataSetName = "DbDormitoryRegistrationDataSet8";
            this.dbDormitoryRegistrationDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudentBindingSource
            // 
            this.tblStudentBindingSource.DataMember = "TblStudent";
            this.tblStudentBindingSource.DataSource = this.dbDormitoryRegistrationDataSet8;
            // 
            // tblStudentTableAdapter
            // 
            this.tblStudentTableAdapter.ClearBeforeFill = true;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentSurnameDataGridViewTextBoxColumn
            // 
            this.studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.HeaderText = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
            this.studentSurnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentRoomNoDataGridViewTextBoxColumn
            // 
            this.studentRoomNoDataGridViewTextBoxColumn.DataPropertyName = "StudentRoomNo";
            this.studentRoomNoDataGridViewTextBoxColumn.HeaderText = "StudentRoomNo";
            this.studentRoomNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentRoomNoDataGridViewTextBoxColumn.Name = "studentRoomNoDataGridViewTextBoxColumn";
            this.studentRoomNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentNationalNumberDataGridViewTextBoxColumn
            // 
            this.studentNationalNumberDataGridViewTextBoxColumn.DataPropertyName = "StudentNationalNumber";
            this.studentNationalNumberDataGridViewTextBoxColumn.HeaderText = "StudentNationalNumber";
            this.studentNationalNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentNationalNumberDataGridViewTextBoxColumn.Name = "studentNationalNumberDataGridViewTextBoxColumn";
            this.studentNationalNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentPhoneDataGridViewTextBoxColumn
            // 
            this.studentPhoneDataGridViewTextBoxColumn.DataPropertyName = "StudentPhone";
            this.studentPhoneDataGridViewTextBoxColumn.HeaderText = "StudentPhone";
            this.studentPhoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentPhoneDataGridViewTextBoxColumn.Name = "studentPhoneDataGridViewTextBoxColumn";
            this.studentPhoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentBirthDayDataGridViewTextBoxColumn
            // 
            this.studentBirthDayDataGridViewTextBoxColumn.DataPropertyName = "StudentBirthDay";
            this.studentBirthDayDataGridViewTextBoxColumn.HeaderText = "StudentBirthDay";
            this.studentBirthDayDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentBirthDayDataGridViewTextBoxColumn.Name = "studentBirthDayDataGridViewTextBoxColumn";
            this.studentBirthDayDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentDepartmentDataGridViewTextBoxColumn
            // 
            this.studentDepartmentDataGridViewTextBoxColumn.DataPropertyName = "StudentDepartment";
            this.studentDepartmentDataGridViewTextBoxColumn.HeaderText = "StudentDepartment";
            this.studentDepartmentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentDepartmentDataGridViewTextBoxColumn.Name = "studentDepartmentDataGridViewTextBoxColumn";
            this.studentDepartmentDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentMailDataGridViewTextBoxColumn
            // 
            this.studentMailDataGridViewTextBoxColumn.DataPropertyName = "StudentMail";
            this.studentMailDataGridViewTextBoxColumn.HeaderText = "StudentMail";
            this.studentMailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentMailDataGridViewTextBoxColumn.Name = "studentMailDataGridViewTextBoxColumn";
            this.studentMailDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentParentNameDataGridViewTextBoxColumn
            // 
            this.studentParentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentParentName";
            this.studentParentNameDataGridViewTextBoxColumn.HeaderText = "StudentParentName";
            this.studentParentNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentParentNameDataGridViewTextBoxColumn.Name = "studentParentNameDataGridViewTextBoxColumn";
            this.studentParentNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentParentPhoneDataGridViewTextBoxColumn
            // 
            this.studentParentPhoneDataGridViewTextBoxColumn.DataPropertyName = "StudentParentPhone";
            this.studentParentPhoneDataGridViewTextBoxColumn.HeaderText = "StudentParentPhone";
            this.studentParentPhoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentParentPhoneDataGridViewTextBoxColumn.Name = "studentParentPhoneDataGridViewTextBoxColumn";
            this.studentParentPhoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentParentAdressDataGridViewTextBoxColumn
            // 
            this.studentParentAdressDataGridViewTextBoxColumn.DataPropertyName = "StudentParentAdress";
            this.studentParentAdressDataGridViewTextBoxColumn.HeaderText = "StudentParentAdress";
            this.studentParentAdressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentParentAdressDataGridViewTextBoxColumn.Name = "studentParentAdressDataGridViewTextBoxColumn";
            this.studentParentAdressDataGridViewTextBoxColumn.Width = 150;
            // 
            // formStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1491, 504);
            this.Controls.Add(this.dataGridView1);
            this.Name = "formStudentList";
            this.Text = "formStudentList";
            this.Load += new System.EventHandler(this.formStudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDormitoryRegistrationDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DbDormitoryRegistrationDataSet8 dbDormitoryRegistrationDataSet8;
        private System.Windows.Forms.BindingSource tblStudentBindingSource;
        private DbDormitoryRegistrationDataSet8TableAdapters.TblStudentTableAdapter tblStudentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentRoomNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNationalNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentBirthDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentParentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentParentPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentParentAdressDataGridViewTextBoxColumn;
    }
}