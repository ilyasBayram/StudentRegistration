
namespace StudentRegistration_2
{
    partial class formDebt
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
            this.lblStudenID = new System.Windows.Forms.Label();
            this.txBoxStudentID = new System.Windows.Forms.TextBox();
            this.txBoxPaid = new System.Windows.Forms.TextBox();
            this.lblPaid = new System.Windows.Forms.Label();
            this.txBoxRemain = new System.Windows.Forms.TextBox();
            this.lblRemain = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentRemainingDebtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDebtBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbDormitoryRegistrationDataSet3 = new StudentRegistration_2.DbDormitoryRegistrationDataSet3();
            this.btnPayment = new System.Windows.Forms.Button();
            this.txBoxStudentSurname = new System.Windows.Forms.TextBox();
            this.lblStudentSurname = new System.Windows.Forms.Label();
            this.txBoxStudenName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.tblDebtTableAdapter1 = new StudentRegistration_2.DbDormitoryRegistrationDataSet3TableAdapters.TblDebtTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDebtBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDormitoryRegistrationDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudenID
            // 
            this.lblStudenID.AutoSize = true;
            this.lblStudenID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudenID.Location = new System.Drawing.Point(7, 42);
            this.lblStudenID.Name = "lblStudenID";
            this.lblStudenID.Size = new System.Drawing.Size(127, 26);
            this.lblStudenID.TabIndex = 0;
            this.lblStudenID.Text = "Student ID :";
            // 
            // txBoxStudentID
            // 
            this.txBoxStudentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.txBoxStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBoxStudentID.Location = new System.Drawing.Point(196, 38);
            this.txBoxStudentID.Name = "txBoxStudentID";
            this.txBoxStudentID.Size = new System.Drawing.Size(165, 30);
            this.txBoxStudentID.TabIndex = 1;
            // 
            // txBoxPaid
            // 
            this.txBoxPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.txBoxPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBoxPaid.Location = new System.Drawing.Point(196, 182);
            this.txBoxPaid.Name = "txBoxPaid";
            this.txBoxPaid.Size = new System.Drawing.Size(165, 30);
            this.txBoxPaid.TabIndex = 3;
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPaid.Location = new System.Drawing.Point(7, 184);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(116, 26);
            this.lblPaid.TabIndex = 2;
            this.lblPaid.Text = "Paid debt :";
            // 
            // txBoxRemain
            // 
            this.txBoxRemain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.txBoxRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBoxRemain.Location = new System.Drawing.Point(196, 231);
            this.txBoxRemain.Name = "txBoxRemain";
            this.txBoxRemain.Size = new System.Drawing.Size(165, 30);
            this.txBoxRemain.TabIndex = 5;
            // 
            // lblRemain
            // 
            this.lblRemain.AutoSize = true;
            this.lblRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRemain.Location = new System.Drawing.Point(7, 231);
            this.lblRemain.Name = "lblRemain";
            this.lblRemain.Size = new System.Drawing.Size(148, 26);
            this.lblRemain.TabIndex = 4;
            this.lblRemain.Text = "Remain debt :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.studentRemainingDebtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDebtBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(374, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(859, 426);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
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
            // studentRemainingDebtDataGridViewTextBoxColumn
            // 
            this.studentRemainingDebtDataGridViewTextBoxColumn.DataPropertyName = "StudentRemainingDebt";
            this.studentRemainingDebtDataGridViewTextBoxColumn.HeaderText = "StudentRemainingDebt";
            this.studentRemainingDebtDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentRemainingDebtDataGridViewTextBoxColumn.Name = "studentRemainingDebtDataGridViewTextBoxColumn";
            this.studentRemainingDebtDataGridViewTextBoxColumn.Width = 150;
            // 
            // tblDebtBindingSource1
            // 
            this.tblDebtBindingSource1.DataMember = "TblDebt";
            this.tblDebtBindingSource1.DataSource = this.dbDormitoryRegistrationDataSet3;
            // 
            // dbDormitoryRegistrationDataSet3
            // 
            this.dbDormitoryRegistrationDataSet3.DataSetName = "DbDormitoryRegistrationDataSet3";
            this.dbDormitoryRegistrationDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPayment.Location = new System.Drawing.Point(55, 321);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(173, 72);
            this.btnPayment.TabIndex = 7;
            this.btnPayment.Text = "Except payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // txBoxStudentSurname
            // 
            this.txBoxStudentSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.txBoxStudentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBoxStudentSurname.Location = new System.Drawing.Point(196, 135);
            this.txBoxStudentSurname.Name = "txBoxStudentSurname";
            this.txBoxStudentSurname.Size = new System.Drawing.Size(165, 30);
            this.txBoxStudentSurname.TabIndex = 11;
            // 
            // lblStudentSurname
            // 
            this.lblStudentSurname.AutoSize = true;
            this.lblStudentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentSurname.Location = new System.Drawing.Point(7, 137);
            this.lblStudentSurname.Name = "lblStudentSurname";
            this.lblStudentSurname.Size = new System.Drawing.Size(194, 26);
            this.lblStudentSurname.TabIndex = 10;
            this.lblStudentSurname.Text = "Student Surname :";
            // 
            // txBoxStudenName
            // 
            this.txBoxStudenName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.txBoxStudenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBoxStudenName.Location = new System.Drawing.Point(196, 85);
            this.txBoxStudenName.Name = "txBoxStudenName";
            this.txBoxStudenName.Size = new System.Drawing.Size(165, 30);
            this.txBoxStudenName.TabIndex = 9;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentName.Location = new System.Drawing.Point(7, 89);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(164, 26);
            this.lblStudentName.TabIndex = 8;
            this.lblStudentName.Text = "Student Name :";
            // 
            // tblDebtTableAdapter1
            // 
            this.tblDebtTableAdapter1.ClearBeforeFill = true;
            // 
            // formDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(1231, 424);
            this.Controls.Add(this.txBoxStudentSurname);
            this.Controls.Add(this.lblStudentSurname);
            this.Controls.Add(this.txBoxStudenName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txBoxRemain);
            this.Controls.Add(this.lblRemain);
            this.Controls.Add(this.txBoxPaid);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.txBoxStudentID);
            this.Controls.Add(this.lblStudenID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formDebt";
            this.Text = "Debts";
            this.Load += new System.EventHandler(this.formDebt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDebtBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDormitoryRegistrationDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudenID;
        private System.Windows.Forms.TextBox txBoxStudentID;
        private System.Windows.Forms.TextBox txBoxPaid;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.TextBox txBoxRemain;
        private System.Windows.Forms.Label lblRemain;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentRemainingDebtDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.TextBox txBoxStudentSurname;
        private System.Windows.Forms.Label lblStudentSurname;
        private System.Windows.Forms.TextBox txBoxStudenName;
        private System.Windows.Forms.Label lblStudentName;
        private DbDormitoryRegistrationDataSet3 dbDormitoryRegistrationDataSet3;
        private System.Windows.Forms.BindingSource tblDebtBindingSource1;
        private DbDormitoryRegistrationDataSet3TableAdapters.TblDebtTableAdapter tblDebtTableAdapter1;
    }
}