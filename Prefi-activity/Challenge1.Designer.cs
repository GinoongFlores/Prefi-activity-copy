namespace Prefi_activity
{
    partial class Challenge1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkPremium = new System.Windows.Forms.CheckBox();
            this.btn_Calcuate = new System.Windows.Forms.Button();
            this.txt_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Days Overdue";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(69, 97);
            this.txtDays.Multiline = true;
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(193, 42);
            this.txtDays.TabIndex = 2;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(73, 191);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 28);
            this.cmbCategory.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category";
            // 
            // chkPremium
            // 
            this.chkPremium.AutoSize = true;
            this.chkPremium.Location = new System.Drawing.Point(257, 191);
            this.chkPremium.Name = "chkPremium";
            this.chkPremium.Size = new System.Drawing.Size(159, 24);
            this.chkPremium.TabIndex = 5;
            this.chkPremium.Text = "Premium Member";
            this.chkPremium.UseVisualStyleBackColor = true;
            // 
            // btn_Calcuate
            // 
            this.btn_Calcuate.Location = new System.Drawing.Point(69, 270);
            this.btn_Calcuate.Name = "btn_Calcuate";
            this.btn_Calcuate.Size = new System.Drawing.Size(184, 41);
            this.btn_Calcuate.TabIndex = 6;
            this.btn_Calcuate.Text = "Calcuate Fine";
            this.btn_Calcuate.UseVisualStyleBackColor = true;
            this.btn_Calcuate.Click += new System.EventHandler(this.btn_Calcuate_Click);
            // 
            // txt_Result
            // 
            this.txt_Result.AutoSize = true;
            this.txt_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Result.Location = new System.Drawing.Point(533, 185);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(87, 29);
            this.txt_Result.TabIndex = 7;
            this.txt_Result.Text = "Result";
            // 
            // Challenge1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.btn_Calcuate);
            this.Controls.Add(this.chkPremium);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDays);
            this.Name = "Challenge1";
            this.Text = "Challenge1";
            this.Load += new System.EventHandler(this.Challenge1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkPremium;
        private System.Windows.Forms.Button btn_Calcuate;
        private System.Windows.Forms.Label txt_Result;
    }
}