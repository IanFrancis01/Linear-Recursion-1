namespace Factorial_Calculator
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
            this.btnFactorial = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnFibonacci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFactorial
            // 
            this.btnFactorial.Location = new System.Drawing.Point(109, 155);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(100, 44);
            this.btnFactorial.TabIndex = 0;
            this.btnFactorial.Text = "Factorial";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(59, 136);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(44, 13);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Number";
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtNumber.Location = new System.Drawing.Point(109, 129);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 2;
            // 
            // btnFibonacci
            // 
            this.btnFibonacci.Location = new System.Drawing.Point(109, 205);
            this.btnFibonacci.Name = "btnFibonacci";
            this.btnFibonacci.Size = new System.Drawing.Size(100, 44);
            this.btnFibonacci.TabIndex = 3;
            this.btnFibonacci.Text = "Fibonacci";
            this.btnFibonacci.UseVisualStyleBackColor = true;
            this.btnFibonacci.Click += new System.EventHandler(this.btnFibonacci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnFibonacci);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnFactorial);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factorial Caclculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnFibonacci;
    }
}

