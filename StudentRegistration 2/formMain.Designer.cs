
namespace StudentRegistration_2
{
    partial class formMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentLoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addeExspenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ıncomeStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expensesStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administartorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPersonelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyAccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbDormitoryRegistrationDataSet1 = new StudentRegistration_2.DbDormitoryRegistrationDataSet1();
            this.tblStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStudentTableAdapter = new StudentRegistration_2.DbDormitoryRegistrationDataSet1TableAdapters.TblStudentTableAdapter();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentRoomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDormitoryRegistrationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.menuStrip1.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem,
            this.departmentsToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.paymentsToolStripMenuItem,
            this.expensesToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.administartorToolStripMenuItem,
            this.easyAccessToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1118, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.studentListToolStripMenuItem,
            this.updateStudentListToolStripMenuItem});
            this.studentsToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(109, 30);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.addNewStudentToolStripMenuItem.Text = "Add new student";
            // 
            // studentListToolStripMenuItem
            // 
            this.studentListToolStripMenuItem.Name = "studentListToolStripMenuItem";
            this.studentListToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.studentListToolStripMenuItem.Text = "Student List";
            // 
            // updateStudentListToolStripMenuItem
            // 
            this.updateStudentListToolStripMenuItem.Name = "updateStudentListToolStripMenuItem";
            this.updateStudentListToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.updateStudentListToolStripMenuItem.Text = "Update student list";
            // 
            // departmentsToolStripMenuItem
            // 
            this.departmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentUpdateToolStripMenuItem});
            this.departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            this.departmentsToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.departmentsToolStripMenuItem.Text = "Departments";
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentLoanToolStripMenuItem});
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(120, 30);
            this.paymentsToolStripMenuItem.Text = "Payments";
            // 
            // studentLoanToolStripMenuItem
            // 
            this.studentLoanToolStripMenuItem.Name = "studentLoanToolStripMenuItem";
            this.studentLoanToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.studentLoanToolStripMenuItem.Text = "Student loan";
            // 
            // expensesToolStripMenuItem
            // 
            this.expensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addeExspenseToolStripMenuItem});
            this.expensesToolStripMenuItem.Name = "expensesToolStripMenuItem";
            this.expensesToolStripMenuItem.Size = new System.Drawing.Size(116, 30);
            this.expensesToolStripMenuItem.Text = "Expenses";
            // 
            // addeExspenseToolStripMenuItem
            // 
            this.addeExspenseToolStripMenuItem.Name = "addeExspenseToolStripMenuItem";
            this.addeExspenseToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addeExspenseToolStripMenuItem.Text = "Add exspense";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ıncomeStatisticsToolStripMenuItem,
            this.expensesStatisticsToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(111, 30);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // ıncomeStatisticsToolStripMenuItem
            // 
            this.ıncomeStatisticsToolStripMenuItem.Name = "ıncomeStatisticsToolStripMenuItem";
            this.ıncomeStatisticsToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.ıncomeStatisticsToolStripMenuItem.Text = "Income statistics";
            // 
            // expensesStatisticsToolStripMenuItem
            // 
            this.expensesStatisticsToolStripMenuItem.Name = "expensesStatisticsToolStripMenuItem";
            this.expensesStatisticsToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.expensesStatisticsToolStripMenuItem.Text = "Expenses statistics";
            // 
            // administartorToolStripMenuItem
            // 
            this.administartorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPasswordToolStripMenuItem,
            this.newUserToolStripMenuItem,
            this.newPersonelToolStripMenuItem});
            this.administartorToolStripMenuItem.Name = "administartorToolStripMenuItem";
            this.administartorToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.administartorToolStripMenuItem.Text = "Administrator";
            // 
            // newPasswordToolStripMenuItem
            // 
            this.newPasswordToolStripMenuItem.Name = "newPasswordToolStripMenuItem";
            this.newPasswordToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.newPasswordToolStripMenuItem.Text = "New password";
            // 
            // newUserToolStripMenuItem
            // 
            this.newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            this.newUserToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.newUserToolStripMenuItem.Text = "New user";
            // 
            // newPersonelToolStripMenuItem
            // 
            this.newPersonelToolStripMenuItem.Name = "newPersonelToolStripMenuItem";
            this.newPersonelToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.newPersonelToolStripMenuItem.Text = "Personel update";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(93, 30);
            this.roomsToolStripMenuItem.Text = "Rooms";
            // 
            // departmentUpdateToolStripMenuItem
            // 
            this.departmentUpdateToolStripMenuItem.Name = "departmentUpdateToolStripMenuItem";
            this.departmentUpdateToolStripMenuItem.Size = new System.Drawing.Size(302, 34);
            this.departmentUpdateToolStripMenuItem.Text = "Department update";
            // 
            // easyAccessToolStripMenuItem
            // 
            this.easyAccessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.panintToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.easyAccessToolStripMenuItem.Name = "easyAccessToolStripMenuItem";
            this.easyAccessToolStripMenuItem.Size = new System.Drawing.Size(140, 30);
            this.easyAccessToolStripMenuItem.Text = "Easy Access";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            // 
            // panintToolStripMenuItem
            // 
            this.panintToolStripMenuItem.Name = "panintToolStripMenuItem";
            this.panintToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.panintToolStripMenuItem.Text = "Panint";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.studentRoomNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblStudentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 343);
            this.dataGridView1.TabIndex = 1;
            // 
            // dbDormitoryRegistrationDataSet1
            // 
            this.dbDormitoryRegistrationDataSet1.DataSetName = "DbDormitoryRegistrationDataSet1";
            this.dbDormitoryRegistrationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudentBindingSource
            // 
            this.tblStudentBindingSource.DataMember = "TblStudent";
            this.tblStudentBindingSource.DataSource = this.dbDormitoryRegistrationDataSet1;
            // 
            // tblStudentTableAdapter
            // 
            this.tblStudentTableAdapter.ClearBeforeFill = true;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.FillWeight = 80F;
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 7;
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
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(824, 268);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 26);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "date";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHour.Location = new System.Drawing.Point(875, 328);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(70, 26);
            this.lblHour.TabIndex = 3;
            this.lblHour.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(1118, 508);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMain";
            this.Text = "formMain";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDormitoryRegistrationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentLoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addeExspenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ıncomeStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expensesStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administartorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPersonelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyAccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbDormitoryRegistrationDataSet1 dbDormitoryRegistrationDataSet1;
        private System.Windows.Forms.BindingSource tblStudentBindingSource;
        private DbDormitoryRegistrationDataSet1TableAdapters.TblStudentTableAdapter tblStudentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentRoomNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Timer timer1;
    }
}