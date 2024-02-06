namespace Somma_listbox_Matteo_Sirotti
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
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnPulisci = new System.Windows.Forms.Button();
            this.btnSomma = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(38, 50);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungi.TabIndex = 0;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnPulisci
            // 
            this.btnPulisci.Location = new System.Drawing.Point(38, 79);
            this.btnPulisci.Name = "btnPulisci";
            this.btnPulisci.Size = new System.Drawing.Size(75, 23);
            this.btnPulisci.TabIndex = 1;
            this.btnPulisci.Text = "Pulisci";
            this.btnPulisci.UseVisualStyleBackColor = true;
            this.btnPulisci.Click += new System.EventHandler(this.btnPulisci_Click);
            // 
            // btnSomma
            // 
            this.btnSomma.Location = new System.Drawing.Point(38, 108);
            this.btnSomma.Name = "btnSomma";
            this.btnSomma.Size = new System.Drawing.Size(75, 23);
            this.btnSomma.TabIndex = 2;
            this.btnSomma.Text = "Somma";
            this.btnSomma.UseVisualStyleBackColor = true;
            this.btnSomma.Click += new System.EventHandler(this.btnSomma_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(55, 148);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "label1";
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(182, 50);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(120, 95);
            this.lst1.TabIndex = 4;
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(27, 24);
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(100, 20);
            this.tbx1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbx1);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnSomma);
            this.Controls.Add(this.btnPulisci);
            this.Controls.Add(this.btnAggiungi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnPulisci;
        private System.Windows.Forms.Button btnSomma;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.TextBox tbx1;
    }
}

