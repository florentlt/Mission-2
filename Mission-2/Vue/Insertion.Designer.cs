namespace Connecte
{
    partial class Insertion
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxLiaison = new System.Windows.Forms.TextBox();
            this.TextBoxSecteur = new System.Windows.Forms.TextBox();
            this.TextBoxDuree = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.cBPortDepart = new System.Windows.Forms.ComboBox();
            this.cBPortArrivee = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liaison";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Secteur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port départ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port arrivée";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Durée";
            // 
            // TextBoxLiaison
            // 
            this.TextBoxLiaison.Location = new System.Drawing.Point(149, 42);
            this.TextBoxLiaison.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxLiaison.Name = "TextBoxLiaison";
            this.TextBoxLiaison.ReadOnly = true;
            this.TextBoxLiaison.Size = new System.Drawing.Size(100, 22);
            this.TextBoxLiaison.TabIndex = 5;
            // 
            // TextBoxSecteur
            // 
            this.TextBoxSecteur.Location = new System.Drawing.Point(149, 98);
            this.TextBoxSecteur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxSecteur.Name = "TextBoxSecteur";
            this.TextBoxSecteur.ReadOnly = true;
            this.TextBoxSecteur.Size = new System.Drawing.Size(100, 22);
            this.TextBoxSecteur.TabIndex = 6;
            // 
            // TextBoxDuree
            // 
            this.TextBoxDuree.Location = new System.Drawing.Point(149, 274);
            this.TextBoxDuree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxDuree.Name = "TextBoxDuree";
            this.TextBoxDuree.Size = new System.Drawing.Size(100, 22);
            this.TextBoxDuree.TabIndex = 9;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(121, 350);
            this.btnValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(153, 57);
            this.btnValider.TabIndex = 10;
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.inserer_Click);
            // 
            // cBPortDepart
            // 
            this.cBPortDepart.Enabled = false;
            this.cBPortDepart.FormattingEnabled = true;
            this.cBPortDepart.Location = new System.Drawing.Point(149, 159);
            this.cBPortDepart.Name = "cBPortDepart";
            this.cBPortDepart.Size = new System.Drawing.Size(100, 24);
            this.cBPortDepart.TabIndex = 12;
            // 
            // cBPortArrivee
            // 
            this.cBPortArrivee.Enabled = false;
            this.cBPortArrivee.FormattingEnabled = true;
            this.cBPortArrivee.Location = new System.Drawing.Point(149, 214);
            this.cBPortArrivee.Name = "cBPortArrivee";
            this.cBPortArrivee.Size = new System.Drawing.Size(100, 24);
            this.cBPortArrivee.TabIndex = 13;
            // 
            // Insertion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 465);
            this.Controls.Add(this.cBPortArrivee);
            this.Controls.Add(this.cBPortDepart);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.TextBoxDuree);
            this.Controls.Add(this.TextBoxSecteur);
            this.Controls.Add(this.TextBoxLiaison);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Insertion";
            this.Load += new System.EventHandler(this.Insertion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxLiaison;
        private System.Windows.Forms.TextBox TextBoxSecteur;
        private System.Windows.Forms.TextBox TextBoxDuree;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox cBPortDepart;
        private System.Windows.Forms.ComboBox cBPortArrivee;
    }
}