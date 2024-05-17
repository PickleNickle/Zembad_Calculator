namespace prjzwombat
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtRandafstand = new System.Windows.Forms.TextBox();
            this.txtBreedte = new System.Windows.Forms.TextBox();
            this.txtLengte = new System.Windows.Forms.TextBox();
            this.txtDiepte = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(13, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(66, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Diepte (in m)";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(13, 100);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(72, 13);
            this.lbl3.TabIndex = 1;
            this.lbl3.Text = "Breedte (in m)";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(13, 54);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(68, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Lengte (in m)";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(13, 146);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(96, 13);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Randafstand (in m)";
            // 
            // txtRandafstand
            // 
            this.txtRandafstand.Location = new System.Drawing.Point(126, 139);
            this.txtRandafstand.Name = "txtRandafstand";
            this.txtRandafstand.Size = new System.Drawing.Size(100, 20);
            this.txtRandafstand.TabIndex = 4;
            // 
            // txtBreedte
            // 
            this.txtBreedte.Location = new System.Drawing.Point(126, 93);
            this.txtBreedte.Name = "txtBreedte";
            this.txtBreedte.Size = new System.Drawing.Size(100, 20);
            this.txtBreedte.TabIndex = 5;
            // 
            // txtLengte
            // 
            this.txtLengte.Location = new System.Drawing.Point(126, 47);
            this.txtLengte.Name = "txtLengte";
            this.txtLengte.Size = new System.Drawing.Size(100, 20);
            this.txtLengte.TabIndex = 6;
            // 
            // txtDiepte
            // 
            this.txtDiepte.Location = new System.Drawing.Point(126, 10);
            this.txtDiepte.Name = "txtDiepte";
            this.txtDiepte.Size = new System.Drawing.Size(100, 20);
            this.txtDiepte.TabIndex = 7;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(126, 178);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Bereken";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(13, 220);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtDiepte);
            this.Controls.Add(this.txtLengte);
            this.Controls.Add(this.txtBreedte);
            this.Controls.Add(this.txtRandafstand);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtRandafstand;
        private System.Windows.Forms.TextBox txtBreedte;
        private System.Windows.Forms.TextBox txtLengte;
        private System.Windows.Forms.TextBox txtDiepte;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblOutput;
    }
}

