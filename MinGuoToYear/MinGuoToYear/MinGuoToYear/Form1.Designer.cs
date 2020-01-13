namespace MinGuoToYear
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinGuo = new System.Windows.Forms.TextBox();
            this.txtYearsOld = new System.Windows.Forms.TextBox();
            this.btnConverToMinGuo = new System.Windows.Forms.Button();
            this.btnConvertToYear = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "民國: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Years Old:";
            // 
            // txtMinGuo
            // 
            this.txtMinGuo.Location = new System.Drawing.Point(89, 35);
            this.txtMinGuo.MaxLength = 2;
            this.txtMinGuo.Name = "txtMinGuo";
            this.txtMinGuo.Size = new System.Drawing.Size(100, 20);
            this.txtMinGuo.TabIndex = 2;
            this.txtMinGuo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinGuo_KeyPress);
            // 
            // txtYearsOld
            // 
            this.txtYearsOld.Location = new System.Drawing.Point(89, 76);
            this.txtYearsOld.MaxLength = 3;
            this.txtYearsOld.Name = "txtYearsOld";
            this.txtYearsOld.Size = new System.Drawing.Size(100, 20);
            this.txtYearsOld.TabIndex = 3;
            this.txtYearsOld.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnYearsOld_KeyPress);
            // 
            // btnConverToMinGuo
            // 
            this.btnConverToMinGuo.Location = new System.Drawing.Point(29, 115);
            this.btnConverToMinGuo.Name = "btnConverToMinGuo";
            this.btnConverToMinGuo.Size = new System.Drawing.Size(125, 23);
            this.btnConverToMinGuo.TabIndex = 4;
            this.btnConverToMinGuo.Text = "Convert To MinGuo";
            this.btnConverToMinGuo.UseVisualStyleBackColor = true;
            this.btnConverToMinGuo.Click += new System.EventHandler(this.btnConverToMinGuo_Click);
            // 
            // btnConvertToYear
            // 
            this.btnConvertToYear.Location = new System.Drawing.Point(174, 115);
            this.btnConvertToYear.Name = "btnConvertToYear";
            this.btnConvertToYear.Size = new System.Drawing.Size(118, 23);
            this.btnConvertToYear.TabIndex = 5;
            this.btnConvertToYear.Text = "Convert To Years Old";
            this.btnConvertToYear.UseVisualStyleBackColor = true;
            this.btnConvertToYear.Click += new System.EventHandler(this.btnConvertToYear_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(299, 115);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 150);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvertToYear);
            this.Controls.Add(this.btnConverToMinGuo);
            this.Controls.Add(this.txtYearsOld);
            this.Controls.Add(this.txtMinGuo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "民國轉換器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinGuo;
        private System.Windows.Forms.TextBox txtYearsOld;
        private System.Windows.Forms.Button btnConverToMinGuo;
        private System.Windows.Forms.Button btnConvertToYear;
        private System.Windows.Forms.Button btnClear;
    }
}

