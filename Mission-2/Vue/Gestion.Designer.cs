namespace Connecte
{
    partial class Gestion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxSecteur = new System.Windows.Forms.ListBox();
            this.listBoxLiaison = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonLiaison = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelNombreLiaisons = new System.Windows.Forms.Label();
            this.listBoxTraversee = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSecteur
            // 
            this.listBoxSecteur.FormattingEnabled = true;
            this.listBoxSecteur.ItemHeight = 16;
            this.listBoxSecteur.Location = new System.Drawing.Point(181, 36);
            this.listBoxSecteur.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.listBoxSecteur.Name = "listBoxSecteur";
            this.listBoxSecteur.Size = new System.Drawing.Size(304, 324);
            this.listBoxSecteur.TabIndex = 0;
            this.listBoxSecteur.SelectedIndexChanged += new System.EventHandler(this.listBoxSecteur_SelectedIndexChanged_1);
            // 
            // listBoxLiaison
            // 
            this.listBoxLiaison.FormattingEnabled = true;
            this.listBoxLiaison.ItemHeight = 16;
            this.listBoxLiaison.Location = new System.Drawing.Point(587, 36);
            this.listBoxLiaison.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.listBoxLiaison.Name = "listBoxLiaison";
            this.listBoxLiaison.Size = new System.Drawing.Size(544, 324);
            this.listBoxLiaison.TabIndex = 1;
            this.listBoxLiaison.SelectedIndexChanged += new System.EventHandler(this.listBoxLiaison_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonModifier);
            this.groupBox1.Location = new System.Drawing.Point(181, 422);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox1.Size = new System.Drawing.Size(304, 145);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mise à jour";
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(68, 49);
            this.buttonModifier.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(176, 49);
            this.buttonModifier.TabIndex = 0;
            this.buttonModifier.Text = "Modifier la durée de la liaison sélectionnée";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSupprimer);
            this.groupBox2.Location = new System.Drawing.Point(587, 422);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox2.Size = new System.Drawing.Size(545, 145);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Suppression";
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(219, 49);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(147, 49);
            this.buttonSupprimer.TabIndex = 4;
            this.buttonSupprimer.Text = "Supprimer la liaison sélectionnée";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click_1);
            // 
            // buttonLiaison
            // 
            this.buttonLiaison.Location = new System.Drawing.Point(23, 57);
            this.buttonLiaison.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonLiaison.Name = "buttonLiaison";
            this.buttonLiaison.Size = new System.Drawing.Size(101, 47);
            this.buttonLiaison.TabIndex = 5;
            this.buttonLiaison.Text = "Insérer une liaison :";
            this.buttonLiaison.UseVisualStyleBackColor = true;
            this.buttonLiaison.Click += new System.EventHandler(this.buttonLiaison_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonLiaison);
            this.groupBox3.Location = new System.Drawing.Point(1210, 422);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox3.Size = new System.Drawing.Size(143, 145);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insertion";
            // 
            // labelNombreLiaisons
            // 
            this.labelNombreLiaisons.AutoSize = true;
            this.labelNombreLiaisons.Location = new System.Drawing.Point(511, 145);
            this.labelNombreLiaisons.Name = "labelNombreLiaisons";
            this.labelNombreLiaisons.Size = new System.Drawing.Size(44, 16);
            this.labelNombreLiaisons.TabIndex = 7;
            this.labelNombreLiaisons.Text = "label1";
            // 
            // listBoxTraversee
            // 
            this.listBoxTraversee.FormattingEnabled = true;
            this.listBoxTraversee.ItemHeight = 16;
            this.listBoxTraversee.Location = new System.Drawing.Point(1210, 36);
            this.listBoxTraversee.Name = "listBoxTraversee";
            this.listBoxTraversee.Size = new System.Drawing.Size(264, 324);
            this.listBoxTraversee.TabIndex = 8;            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1543, 614);
            this.Controls.Add(this.listBoxTraversee);
            this.Controls.Add(this.labelNombreLiaisons);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxLiaison);
            this.Controls.Add(this.listBoxSecteur);
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "Gestion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Gestion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSecteur;
        private System.Windows.Forms.ListBox listBoxLiaison;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonLiaison;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelNombreLiaisons;
        private System.Windows.Forms.ListBox listBoxTraversee;
    }
}

