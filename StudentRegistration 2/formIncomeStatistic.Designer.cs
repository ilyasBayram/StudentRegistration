
namespace StudentRegistration_2
{
    partial class formIncomeStatistic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblMoneyInBank = new System.Windows.Forms.Label();
            this.cmBoxChoosenMounth = new System.Windows.Forms.ComboBox();
            this.lblMounthChoose = new System.Windows.Forms.Label();
            this.lblChoosenMounth = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblMoneyForMounth = new System.Windows.Forms.Label();
            this.lblMoneyChoosenMounth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMoney.Location = new System.Drawing.Point(687, 23);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(0, 26);
            this.lblMoney.TabIndex = 0;
            // 
            // lblMoneyInBank
            // 
            this.lblMoneyInBank.AutoSize = true;
            this.lblMoneyInBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMoneyInBank.Location = new System.Drawing.Point(499, 23);
            this.lblMoneyInBank.Name = "lblMoneyInBank";
            this.lblMoneyInBank.Size = new System.Drawing.Size(165, 26);
            this.lblMoneyInBank.TabIndex = 1;
            this.lblMoneyInBank.Text = "Money in bank :";
            // 
            // cmBoxChoosenMounth
            // 
            this.cmBoxChoosenMounth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.cmBoxChoosenMounth.FormattingEnabled = true;
            this.cmBoxChoosenMounth.Location = new System.Drawing.Point(256, 25);
            this.cmBoxChoosenMounth.Name = "cmBoxChoosenMounth";
            this.cmBoxChoosenMounth.Size = new System.Drawing.Size(193, 28);
            this.cmBoxChoosenMounth.TabIndex = 2;
            this.cmBoxChoosenMounth.Text = "Mounths";
            this.cmBoxChoosenMounth.SelectedIndexChanged += new System.EventHandler(this.cmBoxChoosenMounth_SelectedIndexChanged);
            // 
            // lblMounthChoose
            // 
            this.lblMounthChoose.AutoSize = true;
            this.lblMounthChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMounthChoose.Location = new System.Drawing.Point(26, 27);
            this.lblMounthChoose.Name = "lblMounthChoose";
            this.lblMounthChoose.Size = new System.Drawing.Size(196, 26);
            this.lblMounthChoose.TabIndex = 3;
            this.lblMounthChoose.Text = "Choose a mounth :";
            // 
            // lblChoosenMounth
            // 
            this.lblChoosenMounth.AutoSize = true;
            this.lblChoosenMounth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChoosenMounth.Location = new System.Drawing.Point(498, 70);
            this.lblChoosenMounth.Name = "lblChoosenMounth";
            this.lblChoosenMounth.Size = new System.Drawing.Size(199, 26);
            this.lblChoosenMounth.TabIndex = 5;
            this.lblChoosenMounth.Text = "Money for mounth :";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 196);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(592, 256);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // lblMoneyForMounth
            // 
            this.lblMoneyForMounth.AutoSize = true;
            this.lblMoneyForMounth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMoneyForMounth.Location = new System.Drawing.Point(589, 135);
            this.lblMoneyForMounth.Name = "lblMoneyForMounth";
            this.lblMoneyForMounth.Size = new System.Drawing.Size(0, 26);
            this.lblMoneyForMounth.TabIndex = 7;
            // 
            // lblMoneyChoosenMounth
            // 
            this.lblMoneyChoosenMounth.AutoSize = true;
            this.lblMoneyChoosenMounth.Location = new System.Drawing.Point(724, 80);
            this.lblMoneyChoosenMounth.Name = "lblMoneyChoosenMounth";
            this.lblMoneyChoosenMounth.Size = new System.Drawing.Size(51, 20);
            this.lblMoneyChoosenMounth.TabIndex = 8;
            this.lblMoneyChoosenMounth.Text = "label1";
            // 
            // formIncomeStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMoneyChoosenMounth);
            this.Controls.Add(this.lblMoneyForMounth);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblChoosenMounth);
            this.Controls.Add(this.lblMounthChoose);
            this.Controls.Add(this.cmBoxChoosenMounth);
            this.Controls.Add(this.lblMoneyInBank);
            this.Controls.Add(this.lblMoney);
            this.Name = "formIncomeStatistic";
            this.Text = "formIncomeStatistic";
            this.Load += new System.EventHandler(this.formIncomeStatistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblMoneyInBank;
        private System.Windows.Forms.ComboBox cmBoxChoosenMounth;
        private System.Windows.Forms.Label lblMounthChoose;
        private System.Windows.Forms.Label lblChoosenMounth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblMoneyForMounth;
        private System.Windows.Forms.Label lblMoneyChoosenMounth;
    }
}