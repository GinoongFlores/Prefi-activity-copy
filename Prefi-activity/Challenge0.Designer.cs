namespace Prefi_activity
{
    partial class Challenge0
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
            this.txt_SalesAmount = new System.Windows.Forms.TextBox();
            this.txt_YearsOfService = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Bonus = new System.Windows.Forms.Button();
            this.btn_Commission = new System.Windows.Forms.Button();
            this.txt_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_SalesAmount
            // 
            this.txt_SalesAmount.Location = new System.Drawing.Point(148, 125);
            this.txt_SalesAmount.Multiline = true;
            this.txt_SalesAmount.Name = "txt_SalesAmount";
            this.txt_SalesAmount.Size = new System.Drawing.Size(193, 42);
            this.txt_SalesAmount.TabIndex = 0;
            this.txt_SalesAmount.TextChanged += new System.EventHandler(this.txt_SalesAmount_TextChanged);
            // 
            // txt_YearsOfService
            // 
            this.txt_YearsOfService.Location = new System.Drawing.Point(473, 125);
            this.txt_YearsOfService.Multiline = true;
            this.txt_YearsOfService.Name = "txt_YearsOfService";
            this.txt_YearsOfService.Size = new System.Drawing.Size(193, 38);
            this.txt_YearsOfService.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Years of Service";
            // 
            // btn_Bonus
            // 
            this.btn_Bonus.Location = new System.Drawing.Point(473, 202);
            this.btn_Bonus.Name = "btn_Bonus";
            this.btn_Bonus.Size = new System.Drawing.Size(184, 41);
            this.btn_Bonus.TabIndex = 2;
            this.btn_Bonus.Text = "Compute Bonus";
            this.btn_Bonus.UseVisualStyleBackColor = true;
            this.btn_Bonus.Click += new System.EventHandler(this.btn_Bonus_Click);
            // 
            // btn_Commission
            // 
            this.btn_Commission.Location = new System.Drawing.Point(157, 202);
            this.btn_Commission.Name = "btn_Commission";
            this.btn_Commission.Size = new System.Drawing.Size(184, 41);
            this.btn_Commission.TabIndex = 2;
            this.btn_Commission.Text = "Compute Commission";
            this.btn_Commission.UseVisualStyleBackColor = true;
            this.btn_Commission.Click += new System.EventHandler(this.btn_Commission_Click);
            // 
            // txt_Result
            // 
            this.txt_Result.AutoSize = true;
            this.txt_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Result.Location = new System.Drawing.Point(354, 302);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(87, 29);
            this.txt_Result.TabIndex = 3;
            this.txt_Result.Text = "Result";
            this.txt_Result.Click += new System.EventHandler(this.txt_Result_Click);
            // 
            // Challenge0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.btn_Commission);
            this.Controls.Add(this.btn_Bonus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_YearsOfService);
            this.Controls.Add(this.txt_SalesAmount);
            this.Name = "Challenge0";
            this.Text = "Challenge0";
            this.Load += new System.EventHandler(this.Challenge0_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SalesAmount;
        private System.Windows.Forms.TextBox txt_YearsOfService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Bonus;
        private System.Windows.Forms.Button btn_Commission;
        private System.Windows.Forms.Label txt_Result;
    }
}