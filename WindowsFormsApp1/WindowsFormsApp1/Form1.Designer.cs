namespace WindowsFormsApp1
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
            this.btnZgjedhFile = new System.Windows.Forms.Button();
            this.btnZgjedhCertifikaten = new System.Windows.Forms.Button();
            this.btnEnkripto = new System.Windows.Forms.Button();
            this.btnDekripto = new System.Windows.Forms.Button();
            this.txtShteguFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnZgjedhFile
            // 
            this.btnZgjedhFile.Location = new System.Drawing.Point(114, 89);
            this.btnZgjedhFile.Name = "btnZgjedhFile";
            this.btnZgjedhFile.Size = new System.Drawing.Size(210, 46);
            this.btnZgjedhFile.TabIndex = 0;
            this.btnZgjedhFile.Text = "Zgjedh File";
            this.btnZgjedhFile.UseVisualStyleBackColor = true;
            this.btnZgjedhFile.Click += new System.EventHandler(this.btnZgjedhFile_Click);
            // 
            // btnZgjedhCertifikaten
            // 
            this.btnZgjedhCertifikaten.Location = new System.Drawing.Point(114, 161);
            this.btnZgjedhCertifikaten.Name = "btnZgjedhCertifikaten";
            this.btnZgjedhCertifikaten.Size = new System.Drawing.Size(210, 45);
            this.btnZgjedhCertifikaten.TabIndex = 1;
            this.btnZgjedhCertifikaten.Text = "Zgjedh Certifikaten";
            this.btnZgjedhCertifikaten.UseVisualStyleBackColor = true;
            this.btnZgjedhCertifikaten.Click += new System.EventHandler(this.btnZgjedhCertifikaten_Click);
            // 
            // btnEnkripto
            // 
            this.btnEnkripto.Location = new System.Drawing.Point(114, 243);
            this.btnEnkripto.Name = "btnEnkripto";
            this.btnEnkripto.Size = new System.Drawing.Size(210, 45);
            this.btnEnkripto.TabIndex = 2;
            this.btnEnkripto.Text = "Enkripto";
            this.btnEnkripto.UseVisualStyleBackColor = true;
            this.btnEnkripto.Click += new System.EventHandler(this.btnEnkripto_Click);
            // 
            // btnDekripto
            // 
            this.btnDekripto.Location = new System.Drawing.Point(114, 312);
            this.btnDekripto.Name = "btnDekripto";
            this.btnDekripto.Size = new System.Drawing.Size(210, 45);
            this.btnDekripto.TabIndex = 3;
            this.btnDekripto.Text = "Dekripto";
            this.btnDekripto.UseVisualStyleBackColor = true;
            this.btnDekripto.Click += new System.EventHandler(this.btnDekripto_Click);
            // 
            // txtShteguFile
            // 
            this.txtShteguFile.Location = new System.Drawing.Point(67, 45);
            this.txtShteguFile.Name = "txtShteguFile";
            this.txtShteguFile.Size = new System.Drawing.Size(306, 26);
            this.txtShteguFile.TabIndex = 4;
            this.txtShteguFile.TextChanged += new System.EventHandler(this.txtShteguFile_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Shtegu i File-it";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtShteguFile);
            this.Controls.Add(this.btnDekripto);
            this.Controls.Add(this.btnEnkripto);
            this.Controls.Add(this.btnZgjedhCertifikaten);
            this.Controls.Add(this.btnZgjedhFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZgjedhFile;
        private System.Windows.Forms.Button btnZgjedhCertifikaten;
        private System.Windows.Forms.Button btnEnkripto;
        private System.Windows.Forms.Button btnDekripto;
        private System.Windows.Forms.TextBox txtShteguFile;
        private System.Windows.Forms.Label label1;
    }
}

