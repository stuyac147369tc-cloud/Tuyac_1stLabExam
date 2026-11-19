namespace Tuyac_1stLabEam
{
    partial class Form2
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
            this.lbl_Danielle = new System.Windows.Forms.Label();
            this.lbl_Edward = new System.Windows.Forms.Label();
            this.lbl_Fatima = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.Btn_Close_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALES SUMMARY";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Danielle
            // 
            this.lbl_Danielle.AutoSize = true;
            this.lbl_Danielle.Location = new System.Drawing.Point(210, 88);
            this.lbl_Danielle.Name = "lbl_Danielle";
            this.lbl_Danielle.Size = new System.Drawing.Size(74, 20);
            this.lbl_Danielle.TabIndex = 1;
            this.lbl_Danielle.Text = "Danielle: ";
            // 
            // lbl_Edward
            // 
            this.lbl_Edward.AutoSize = true;
            this.lbl_Edward.Location = new System.Drawing.Point(210, 141);
            this.lbl_Edward.Name = "lbl_Edward";
            this.lbl_Edward.Size = new System.Drawing.Size(67, 20);
            this.lbl_Edward.TabIndex = 2;
            this.lbl_Edward.Text = "Edward:";
            // 
            // lbl_Fatima
            // 
            this.lbl_Fatima.AutoSize = true;
            this.lbl_Fatima.Location = new System.Drawing.Point(210, 193);
            this.lbl_Fatima.Name = "lbl_Fatima";
            this.lbl_Fatima.Size = new System.Drawing.Size(62, 20);
            this.lbl_Fatima.TabIndex = 3;
            this.lbl_Fatima.Text = "Fatima:";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(210, 249);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(101, 20);
            this.lbl_Total.TabIndex = 4;
            this.lbl_Total.Text = "Grand Total: ";
            // 
            // Btn_Close_Click
            // 
            this.Btn_Close_Click.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Close_Click.Location = new System.Drawing.Point(346, 310);
            this.Btn_Close_Click.Name = "Btn_Close_Click";
            this.Btn_Close_Click.Size = new System.Drawing.Size(85, 43);
            this.Btn_Close_Click.TabIndex = 5;
            this.Btn_Close_Click.Text = "Close";
            this.Btn_Close_Click.UseVisualStyleBackColor = false;
            this.Btn_Close_Click.Click += new System.EventHandler(this.Btn_Close_Click_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Close_Click);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Fatima);
            this.Controls.Add(this.lbl_Edward);
            this.Controls.Add(this.lbl_Danielle);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Danielle;
        private System.Windows.Forms.Label lbl_Edward;
        private System.Windows.Forms.Label lbl_Fatima;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Button Btn_Close_Click;
    }
}