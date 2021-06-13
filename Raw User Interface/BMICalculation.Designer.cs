
namespace Raw_User_Interface
{
    partial class BMICalculation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMICalculation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBodyMassIndex = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblBMIResult = new System.Windows.Forms.Label();
            this.tbBMIResult = new System.Windows.Forms.TextBox();
            this.btnDietForYou = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pbHumanBody = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHumanBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.pbBack);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblBodyMassIndex);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 70);
            this.panel1.TabIndex = 0;
            // 
            // lblBodyMassIndex
            // 
            this.lblBodyMassIndex.AutoSize = true;
            this.lblBodyMassIndex.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodyMassIndex.ForeColor = System.Drawing.Color.White;
            this.lblBodyMassIndex.Location = new System.Drawing.Point(324, 22);
            this.lblBodyMassIndex.Name = "lblBodyMassIndex";
            this.lblBodyMassIndex.Size = new System.Drawing.Size(231, 27);
            this.lblBodyMassIndex.TabIndex = 1;
            this.lblBodyMassIndex.Text = "BODY MASS INDEX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(84, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "BODY";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblWeight.Location = new System.Drawing.Point(319, 100);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(107, 27);
            this.lblWeight.TabIndex = 4;
            this.lblWeight.Text = "WEIGHT";
            // 
            // tbWeight
            // 
            this.tbWeight.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWeight.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbWeight.Location = new System.Drawing.Point(324, 138);
            this.tbWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(231, 34);
            this.tbWeight.TabIndex = 5;
            this.tbWeight.TextChanged += new System.EventHandler(this.tbWeight_TextChanged);
            // 
            // tbHeight
            // 
            this.tbHeight.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHeight.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbHeight.Location = new System.Drawing.Point(572, 138);
            this.tbHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(231, 34);
            this.tbHeight.TabIndex = 7;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblHeight.Location = new System.Drawing.Point(567, 100);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(101, 27);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "HEIGHT";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(324, 191);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(478, 36);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblBMIResult
            // 
            this.lblBMIResult.AutoSize = true;
            this.lblBMIResult.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMIResult.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblBMIResult.Location = new System.Drawing.Point(322, 253);
            this.lblBMIResult.Name = "lblBMIResult";
            this.lblBMIResult.Size = new System.Drawing.Size(151, 27);
            this.lblBMIResult.TabIndex = 11;
            this.lblBMIResult.Text = "BMI RESULT";
            // 
            // tbBMIResult
            // 
            this.tbBMIResult.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBMIResult.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbBMIResult.Location = new System.Drawing.Point(324, 289);
            this.tbBMIResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBMIResult.Name = "tbBMIResult";
            this.tbBMIResult.ReadOnly = true;
            this.tbBMIResult.Size = new System.Drawing.Size(159, 34);
            this.tbBMIResult.TabIndex = 12;
            // 
            // btnDietForYou
            // 
            this.btnDietForYou.BackColor = System.Drawing.Color.Red;
            this.btnDietForYou.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDietForYou.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDietForYou.ForeColor = System.Drawing.Color.White;
            this.btnDietForYou.Location = new System.Drawing.Point(324, 343);
            this.btnDietForYou.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDietForYou.Name = "btnDietForYou";
            this.btnDietForYou.Size = new System.Drawing.Size(197, 36);
            this.btnDietForYou.TabIndex = 17;
            this.btnDietForYou.Text = "Diet Reference";
            this.btnDietForYou.UseVisualStyleBackColor = false;
            this.btnDietForYou.Click += new System.EventHandler(this.btnDietForYou_Click);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHide.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.ForeColor = System.Drawing.Color.White;
            this.btnHide.Location = new System.Drawing.Point(572, 343);
            this.btnHide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(167, 36);
            this.btnHide.TabIndex = 19;
            this.btnHide.Text = "Penjadwalan";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbHumanBody
            // 
            this.pbHumanBody.Image = global::Raw_User_Interface.Properties.Resources.Badan_Tutup;
            this.pbHumanBody.Location = new System.Drawing.Point(-13, 129);
            this.pbHumanBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbHumanBody.Name = "pbHumanBody";
            this.pbHumanBody.Size = new System.Drawing.Size(278, 271);
            this.pbHumanBody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHumanBody.TabIndex = 18;
            this.pbHumanBody.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(826, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbBack
            // 
            this.pbBack.Image = global::Raw_User_Interface.Properties.Resources.Back_Button__Finish_;
            this.pbBack.Location = new System.Drawing.Point(15, 17);
            this.pbBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(41, 36);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 5;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // BMICalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.pbHumanBody);
            this.Controls.Add(this.btnDietForYou);
            this.Controls.Add(this.tbBMIResult);
            this.Controls.Add(this.lblBMIResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BMICalculation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMICalculation";
            this.Load += new System.EventHandler(this.BMICalculation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHumanBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBodyMassIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblBMIResult;
        private System.Windows.Forms.TextBox tbBMIResult;
        private System.Windows.Forms.Button btnDietForYou;
        private System.Windows.Forms.PictureBox pbHumanBody;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbBack;
    }
}

