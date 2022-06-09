
namespace StudentRegistration_2
{
    partial class Departments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departments));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblDepartmenID = new System.Windows.Forms.Label();
            this.txBoxDepartmentID = new System.Windows.Forms.TextBox();
            this.txBoxDepartmentName = new System.Windows.Forms.TextBox();
            this.lblDepartmentNmae = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbDormitoryRegistrationDataSet = new StudentRegistration_2.DbDormitoryRegistrationDataSet();
            this.tblDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDepartmentTableAdapter = new StudentRegistration_2.DbDormitoryRegistrationDataSetTableAdapters.TblDepartmentTableAdapter();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDormitoryRegistrationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(494, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(598, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(698, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblDepartmenID
            // 
            this.lblDepartmenID.AutoSize = true;
            this.lblDepartmenID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartmenID.Location = new System.Drawing.Point(27, 22);
            this.lblDepartmenID.Name = "lblDepartmenID";
            this.lblDepartmenID.Size = new System.Drawing.Size(172, 26);
            this.lblDepartmenID.TabIndex = 3;
            this.lblDepartmenID.Text = "Department ID : ";
            // 
            // txBoxDepartmentID
            // 
            this.txBoxDepartmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBoxDepartmentID.Location = new System.Drawing.Point(249, 22);
            this.txBoxDepartmentID.Name = "txBoxDepartmentID";
            this.txBoxDepartmentID.Size = new System.Drawing.Size(203, 30);
            this.txBoxDepartmentID.TabIndex = 1;
            // 
            // txBoxDepartmentName
            // 
            this.txBoxDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBoxDepartmentName.Location = new System.Drawing.Point(249, 73);
            this.txBoxDepartmentName.Name = "txBoxDepartmentName";
            this.txBoxDepartmentName.Size = new System.Drawing.Size(203, 30);
            this.txBoxDepartmentName.TabIndex = 2;
            // 
            // lblDepartmentNmae
            // 
            this.lblDepartmentNmae.AutoSize = true;
            this.lblDepartmentNmae.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartmentNmae.Location = new System.Drawing.Point(27, 73);
            this.lblDepartmentNmae.Name = "lblDepartmentNmae";
            this.lblDepartmentNmae.Size = new System.Drawing.Size(203, 26);
            this.lblDepartmentNmae.TabIndex = 5;
            this.lblDepartmentNmae.Text = "Department Name :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentIDDataGridViewTextBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDepartmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(799, 286);
            this.dataGridView1.TabIndex = 7;
            // 
            // dbDormitoryRegistrationDataSet
            // 
            this.dbDormitoryRegistrationDataSet.DataSetName = "DbDormitoryRegistrationDataSet";
            this.dbDormitoryRegistrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDepartmentBindingSource
            // 
            this.tblDepartmentBindingSource.DataMember = "TblDepartment";
            this.tblDepartmentBindingSource.DataSource = this.dbDormitoryRegistrationDataSet;
            // 
            // tblDepartmentTableAdapter
            // 
            this.tblDepartmentTableAdapter.ClearBeforeFill = true;
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            this.departmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            // 
            // Departments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txBoxDepartmentName);
            this.Controls.Add(this.lblDepartmentNmae);
            this.Controls.Add(this.txBoxDepartmentID);
            this.Controls.Add(this.lblDepartmenID);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Departments";
            this.Text = "Departments";
            this.Load += new System.EventHandler(this.Departments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDormitoryRegistrationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblDepartmenID;
        private System.Windows.Forms.TextBox txBoxDepartmentID;
        private System.Windows.Forms.TextBox txBoxDepartmentName;
        private System.Windows.Forms.Label lblDepartmentNmae;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbDormitoryRegistrationDataSet dbDormitoryRegistrationDataSet;
        private System.Windows.Forms.BindingSource tblDepartmentBindingSource;
        private DbDormitoryRegistrationDataSetTableAdapters.TblDepartmentTableAdapter tblDepartmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
    }
}