
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
            this.lblDepartmenID = new System.Windows.Forms.Label();
            this.txBoxDepartmentID = new System.Windows.Forms.TextBox();
            this.txBoxDepartmentName = new System.Windows.Forms.TextBox();
            this.lblDepartmentNmae = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDormitoryRegistrationDataSet = new StudentRegistration_2.DbDormitoryRegistrationDataSet();
            this.tblDepartmentTableAdapter = new StudentRegistration_2.DbDormitoryRegistrationDataSetTableAdapters.TblDepartmentTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDormitoryRegistrationDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.txBoxDepartmentID.Enabled = false;
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
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // tblDepartmentBindingSource
            // 
            this.tblDepartmentBindingSource.DataMember = "TblDepartment";
            this.tblDepartmentBindingSource.DataSource = this.dbDormitoryRegistrationDataSet;
            // 
            // dbDormitoryRegistrationDataSet
            // 
            this.dbDormitoryRegistrationDataSet.DataSetName = "DbDormitoryRegistrationDataSet";
            this.dbDormitoryRegistrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDepartmentTableAdapter
            // 
            this.tblDepartmentTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Location = new System.Drawing.Point(689, 29);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 62);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.Location = new System.Drawing.Point(594, 29);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 62);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Location = new System.Drawing.Point(494, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 62);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Departments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txBoxDepartmentName);
            this.Controls.Add(this.lblDepartmentNmae);
            this.Controls.Add(this.txBoxDepartmentID);
            this.Controls.Add(this.lblDepartmenID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Departments";
            this.Text = "Departments";
            this.Load += new System.EventHandler(this.Departments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDormitoryRegistrationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}