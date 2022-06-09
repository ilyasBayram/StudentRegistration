
namespace StudentRegistration_2
{
    partial class Form1
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStudentParentAdress = new System.Windows.Forms.Label();
            this.rchTxBoxParentAdress = new System.Windows.Forms.RichTextBox();
            this.mskdTxBoxStudentparentPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblStudentParentSurname = new System.Windows.Forms.Label();
            this.txBoxStudentParentName = new System.Windows.Forms.TextBox();
            this.lblStudentParentName = new System.Windows.Forms.Label();
            this.cmbBoxStudentRoomNo = new System.Windows.Forms.ComboBox();
            this.lblStudentRoomNo = new System.Windows.Forms.Label();
            this.lblStudentMail = new System.Windows.Forms.Label();
            this.txBoxStudentMail = new System.Windows.Forms.TextBox();
            this.cmbBoxStudentDepartment = new System.Windows.Forms.ComboBox();
            this.lblStudentDepartment = new System.Windows.Forms.Label();
            this.lblStudentBirtday = new System.Windows.Forms.Label();
            this.mskdTxBoxStudentBirth = new System.Windows.Forms.MaskedTextBox();
            this.lblStudentPhone = new System.Windows.Forms.Label();
            this.mskdTxBoxStudentPhone = new System.Windows.Forms.MaskedTextBox();
            this.mskdTxBoxStudentNatioanlNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblStudentNationalNumber = new System.Windows.Forms.Label();
            this.txBoxStudentSurname = new System.Windows.Forms.TextBox();
            this.lblStudentSurname = new System.Windows.Forms.Label();
            this.txBoxStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.btnSave.Location = new System.Drawing.Point(66, 619);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 58);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblStudentParentAdress
            // 
            this.lblStudentParentAdress.AutoSize = true;
            this.lblStudentParentAdress.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblStudentParentAdress.Location = new System.Drawing.Point(45, 544);
            this.lblStudentParentAdress.Name = "lblStudentParentAdress";
            this.lblStudentParentAdress.Size = new System.Drawing.Size(160, 30);
            this.lblStudentParentAdress.TabIndex = 44;
            this.lblStudentParentAdress.Text = "Parent Adress :";
            // 
            // rchTxBoxParentAdress
            // 
            this.rchTxBoxParentAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.rchTxBoxParentAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchTxBoxParentAdress.Location = new System.Drawing.Point(308, 558);
            this.rchTxBoxParentAdress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rchTxBoxParentAdress.Name = "rchTxBoxParentAdress";
            this.rchTxBoxParentAdress.Size = new System.Drawing.Size(252, 119);
            this.rchTxBoxParentAdress.TabIndex = 11;
            this.rchTxBoxParentAdress.Text = "";
            // 
            // mskdTxBoxStudentparentPhone
            // 
            this.mskdTxBoxStudentparentPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.mskdTxBoxStudentparentPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdTxBoxStudentparentPhone.Location = new System.Drawing.Point(308, 500);
            this.mskdTxBoxStudentparentPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskdTxBoxStudentparentPhone.Mask = "(999) 000-0000";
            this.mskdTxBoxStudentparentPhone.Name = "mskdTxBoxStudentparentPhone";
            this.mskdTxBoxStudentparentPhone.Size = new System.Drawing.Size(253, 30);
            this.mskdTxBoxStudentparentPhone.TabIndex = 10;
            // 
            // lblStudentParentSurname
            // 
            this.lblStudentParentSurname.AutoSize = true;
            this.lblStudentParentSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblStudentParentSurname.Location = new System.Drawing.Point(45, 499);
            this.lblStudentParentSurname.Name = "lblStudentParentSurname";
            this.lblStudentParentSurname.Size = new System.Drawing.Size(246, 30);
            this.lblStudentParentSurname.TabIndex = 41;
            this.lblStudentParentSurname.Text = "Parent Phone Number :";
            // 
            // txBoxStudentParentName
            // 
            this.txBoxStudentParentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.txBoxStudentParentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBoxStudentParentName.Location = new System.Drawing.Point(309, 451);
            this.txBoxStudentParentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txBoxStudentParentName.Name = "txBoxStudentParentName";
            this.txBoxStudentParentName.Size = new System.Drawing.Size(253, 30);
            this.txBoxStudentParentName.TabIndex = 9;
            // 
            // lblStudentParentName
            // 
            this.lblStudentParentName.AutoSize = true;
            this.lblStudentParentName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblStudentParentName.Location = new System.Drawing.Point(45, 451);
            this.lblStudentParentName.Name = "lblStudentParentName";
            this.lblStudentParentName.Size = new System.Drawing.Size(250, 30);
            this.lblStudentParentName.TabIndex = 39;
            this.lblStudentParentName.Text = "Parent Name/Surname :";
            // 
            // cmbBoxStudentRoomNo
            // 
            this.cmbBoxStudentRoomNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.cmbBoxStudentRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxStudentRoomNo.FormattingEnabled = true;
            this.cmbBoxStudentRoomNo.Location = new System.Drawing.Point(308, 396);
            this.cmbBoxStudentRoomNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBoxStudentRoomNo.Name = "cmbBoxStudentRoomNo";
            this.cmbBoxStudentRoomNo.Size = new System.Drawing.Size(253, 33);
            this.cmbBoxStudentRoomNo.TabIndex = 8;
            // 
            // lblStudentRoomNo
            // 
            this.lblStudentRoomNo.AutoSize = true;
            this.lblStudentRoomNo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblStudentRoomNo.Location = new System.Drawing.Point(49, 391);
            this.lblStudentRoomNo.Name = "lblStudentRoomNo";
            this.lblStudentRoomNo.Size = new System.Drawing.Size(118, 30);
            this.lblStudentRoomNo.TabIndex = 37;
            this.lblStudentRoomNo.Text = "Room No :";
            // 
            // lblStudentMail
            // 
            this.lblStudentMail.AutoSize = true;
            this.lblStudentMail.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblStudentMail.Location = new System.Drawing.Point(49, 340);
            this.lblStudentMail.Name = "lblStudentMail";
            this.lblStudentMail.Size = new System.Drawing.Size(67, 30);
            this.lblStudentMail.TabIndex = 36;
            this.lblStudentMail.Text = "Mail :";
            // 
            // txBoxStudentMail
            // 
            this.txBoxStudentMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.txBoxStudentMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBoxStudentMail.Location = new System.Drawing.Point(308, 344);
            this.txBoxStudentMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txBoxStudentMail.Name = "txBoxStudentMail";
            this.txBoxStudentMail.Size = new System.Drawing.Size(253, 30);
            this.txBoxStudentMail.TabIndex = 7;
            // 
            // cmbBoxStudentDepartment
            // 
            this.cmbBoxStudentDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.cmbBoxStudentDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxStudentDepartment.FormattingEnabled = true;
            this.cmbBoxStudentDepartment.Location = new System.Drawing.Point(308, 293);
            this.cmbBoxStudentDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBoxStudentDepartment.Name = "cmbBoxStudentDepartment";
            this.cmbBoxStudentDepartment.Size = new System.Drawing.Size(253, 33);
            this.cmbBoxStudentDepartment.TabIndex = 6;
            // 
            // lblStudentDepartment
            // 
            this.lblStudentDepartment.AutoSize = true;
            this.lblStudentDepartment.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblStudentDepartment.Location = new System.Drawing.Point(52, 291);
            this.lblStudentDepartment.Name = "lblStudentDepartment";
            this.lblStudentDepartment.Size = new System.Drawing.Size(145, 30);
            this.lblStudentDepartment.TabIndex = 33;
            this.lblStudentDepartment.Text = "Department :";
            // 
            // lblStudentBirtday
            // 
            this.lblStudentBirtday.AutoSize = true;
            this.lblStudentBirtday.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblStudentBirtday.Location = new System.Drawing.Point(52, 243);
            this.lblStudentBirtday.Name = "lblStudentBirtday";
            this.lblStudentBirtday.Size = new System.Drawing.Size(108, 30);
            this.lblStudentBirtday.TabIndex = 32;
            this.lblStudentBirtday.Text = "Birthday :";
            // 
            // mskdTxBoxStudentBirth
            // 
            this.mskdTxBoxStudentBirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.mskdTxBoxStudentBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdTxBoxStudentBirth.Location = new System.Drawing.Point(310, 243);
            this.mskdTxBoxStudentBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskdTxBoxStudentBirth.Mask = "00/00/0000";
            this.mskdTxBoxStudentBirth.Name = "mskdTxBoxStudentBirth";
            this.mskdTxBoxStudentBirth.Size = new System.Drawing.Size(253, 30);
            this.mskdTxBoxStudentBirth.TabIndex = 5;
            this.mskdTxBoxStudentBirth.ValidatingType = typeof(System.DateTime);
            // 
            // lblStudentPhone
            // 
            this.lblStudentPhone.AutoSize = true;
            this.lblStudentPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblStudentPhone.Location = new System.Drawing.Point(49, 191);
            this.lblStudentPhone.Name = "lblStudentPhone";
            this.lblStudentPhone.Size = new System.Drawing.Size(176, 30);
            this.lblStudentPhone.TabIndex = 30;
            this.lblStudentPhone.Text = "Phone Number :";
            // 
            // mskdTxBoxStudentPhone
            // 
            this.mskdTxBoxStudentPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.mskdTxBoxStudentPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdTxBoxStudentPhone.Location = new System.Drawing.Point(310, 192);
            this.mskdTxBoxStudentPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskdTxBoxStudentPhone.Mask = "(999) 000-0000";
            this.mskdTxBoxStudentPhone.Name = "mskdTxBoxStudentPhone";
            this.mskdTxBoxStudentPhone.Size = new System.Drawing.Size(253, 30);
            this.mskdTxBoxStudentPhone.TabIndex = 4;
            // 
            // mskdTxBoxStudentNatioanlNumber
            // 
            this.mskdTxBoxStudentNatioanlNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.mskdTxBoxStudentNatioanlNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdTxBoxStudentNatioanlNumber.Location = new System.Drawing.Point(308, 143);
            this.mskdTxBoxStudentNatioanlNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskdTxBoxStudentNatioanlNumber.Mask = "00000000000";
            this.mskdTxBoxStudentNatioanlNumber.Name = "mskdTxBoxStudentNatioanlNumber";
            this.mskdTxBoxStudentNatioanlNumber.Size = new System.Drawing.Size(253, 30);
            this.mskdTxBoxStudentNatioanlNumber.TabIndex = 3;
            this.mskdTxBoxStudentNatioanlNumber.ValidatingType = typeof(int);
            // 
            // lblStudentNationalNumber
            // 
            this.lblStudentNationalNumber.AutoSize = true;
            this.lblStudentNationalNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblStudentNationalNumber.Location = new System.Drawing.Point(48, 138);
            this.lblStudentNationalNumber.Name = "lblStudentNationalNumber";
            this.lblStudentNationalNumber.Size = new System.Drawing.Size(197, 30);
            this.lblStudentNationalNumber.TabIndex = 27;
            this.lblStudentNationalNumber.Text = "National Number :";
            // 
            // txBoxStudentSurname
            // 
            this.txBoxStudentSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.txBoxStudentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBoxStudentSurname.Location = new System.Drawing.Point(308, 92);
            this.txBoxStudentSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txBoxStudentSurname.Name = "txBoxStudentSurname";
            this.txBoxStudentSurname.Size = new System.Drawing.Size(253, 30);
            this.txBoxStudentSurname.TabIndex = 2;
            // 
            // lblStudentSurname
            // 
            this.lblStudentSurname.AutoSize = true;
            this.lblStudentSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblStudentSurname.Location = new System.Drawing.Point(49, 91);
            this.lblStudentSurname.Name = "lblStudentSurname";
            this.lblStudentSurname.Size = new System.Drawing.Size(196, 30);
            this.lblStudentSurname.TabIndex = 25;
            this.lblStudentSurname.Text = "Student Surname :";
            // 
            // txBoxStudentName
            // 
            this.txBoxStudentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.txBoxStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBoxStudentName.Location = new System.Drawing.Point(308, 42);
            this.txBoxStudentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txBoxStudentName.Name = "txBoxStudentName";
            this.txBoxStudentName.Size = new System.Drawing.Size(253, 30);
            this.txBoxStudentName.TabIndex = 1;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblStudentName.Location = new System.Drawing.Point(49, 42);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(167, 30);
            this.lblStudentName.TabIndex = 23;
            this.lblStudentName.Text = "Student Name :";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(664, 720);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblStudentParentAdress);
            this.Controls.Add(this.rchTxBoxParentAdress);
            this.Controls.Add(this.mskdTxBoxStudentparentPhone);
            this.Controls.Add(this.lblStudentParentSurname);
            this.Controls.Add(this.txBoxStudentParentName);
            this.Controls.Add(this.lblStudentParentName);
            this.Controls.Add(this.cmbBoxStudentRoomNo);
            this.Controls.Add(this.lblStudentRoomNo);
            this.Controls.Add(this.lblStudentMail);
            this.Controls.Add(this.txBoxStudentMail);
            this.Controls.Add(this.cmbBoxStudentDepartment);
            this.Controls.Add(this.lblStudentDepartment);
            this.Controls.Add(this.lblStudentBirtday);
            this.Controls.Add(this.mskdTxBoxStudentBirth);
            this.Controls.Add(this.lblStudentPhone);
            this.Controls.Add(this.mskdTxBoxStudentPhone);
            this.Controls.Add(this.mskdTxBoxStudentNatioanlNumber);
            this.Controls.Add(this.lblStudentNationalNumber);
            this.Controls.Add(this.txBoxStudentSurname);
            this.Controls.Add(this.lblStudentSurname);
            this.Controls.Add(this.txBoxStudentName);
            this.Controls.Add(this.lblStudentName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Student Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStudentParentAdress;
        private System.Windows.Forms.RichTextBox rchTxBoxParentAdress;
        private System.Windows.Forms.MaskedTextBox mskdTxBoxStudentparentPhone;
        private System.Windows.Forms.Label lblStudentParentSurname;
        private System.Windows.Forms.TextBox txBoxStudentParentName;
        private System.Windows.Forms.Label lblStudentParentName;
        private System.Windows.Forms.ComboBox cmbBoxStudentRoomNo;
        private System.Windows.Forms.Label lblStudentRoomNo;
        private System.Windows.Forms.Label lblStudentMail;
        private System.Windows.Forms.TextBox txBoxStudentMail;
        private System.Windows.Forms.ComboBox cmbBoxStudentDepartment;
        private System.Windows.Forms.Label lblStudentDepartment;
        private System.Windows.Forms.Label lblStudentBirtday;
        private System.Windows.Forms.MaskedTextBox mskdTxBoxStudentBirth;
        private System.Windows.Forms.Label lblStudentPhone;
        private System.Windows.Forms.MaskedTextBox mskdTxBoxStudentPhone;
        private System.Windows.Forms.MaskedTextBox mskdTxBoxStudentNatioanlNumber;
        private System.Windows.Forms.Label lblStudentNationalNumber;
        private System.Windows.Forms.TextBox txBoxStudentSurname;
        private System.Windows.Forms.Label lblStudentSurname;
        private System.Windows.Forms.TextBox txBoxStudentName;
        private System.Windows.Forms.Label lblStudentName;
    }
}