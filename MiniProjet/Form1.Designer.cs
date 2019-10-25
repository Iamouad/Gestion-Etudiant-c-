namespace MiniProjet
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.deleteFiliere = new System.Windows.Forms.Button();
            this.ModifierFiliere = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.validerNom = new System.Windows.Forms.Button();
            this.nouveauNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ajouterFiliere = new System.Windows.Forms.Button();
            this.nomFiliere = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.triDecroissant = new System.Windows.Forms.Button();
            this.triCroissant = new System.Windows.Forms.Button();
            this.chargerDonnees = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.importer = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateN = new System.Windows.Forms.TextBox();
            this.filiere = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.telephone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cne = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listeCne = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(902, 483);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.deleteFiliere);
            this.tabPage1.Controls.Add(this.ModifierFiliere);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(894, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filière";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // deleteFiliere
            // 
            this.deleteFiliere.Location = new System.Drawing.Point(636, 203);
            this.deleteFiliere.Name = "deleteFiliere";
            this.deleteFiliere.Size = new System.Drawing.Size(75, 23);
            this.deleteFiliere.TabIndex = 6;
            this.deleteFiliere.Text = "Supprimer";
            this.deleteFiliere.UseVisualStyleBackColor = true;
            this.deleteFiliere.Click += new System.EventHandler(this.deleteFiliere_Click);
            // 
            // ModifierFiliere
            // 
            this.ModifierFiliere.Location = new System.Drawing.Point(476, 203);
            this.ModifierFiliere.Name = "ModifierFiliere";
            this.ModifierFiliere.Size = new System.Drawing.Size(75, 23);
            this.ModifierFiliere.TabIndex = 5;
            this.ModifierFiliere.Text = "Modifier";
            this.ModifierFiliere.UseVisualStyleBackColor = true;
            this.ModifierFiliere.Click += new System.EventHandler(this.ModifierFiliere_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.validerNom);
            this.panel2.Controls.Add(this.nouveauNom);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(442, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 104);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // validerNom
            // 
            this.validerNom.Location = new System.Drawing.Point(91, 72);
            this.validerNom.Name = "validerNom";
            this.validerNom.Size = new System.Drawing.Size(114, 23);
            this.validerNom.TabIndex = 2;
            this.validerNom.Text = "Valider";
            this.validerNom.UseVisualStyleBackColor = true;
            this.validerNom.Click += new System.EventHandler(this.button1_Click);
            // 
            // nouveauNom
            // 
            this.nouveauNom.Location = new System.Drawing.Point(147, 30);
            this.nouveauNom.Name = "nouveauNom";
            this.nouveauNom.Size = new System.Drawing.Size(150, 20);
            this.nouveauNom.TabIndex = 1;
            this.nouveauNom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nouveau nom";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName});
            this.dataGridView1.Location = new System.Drawing.Point(424, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id_Filière";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Width = 150;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Nom_Filière";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ajouterFiliere);
            this.panel1.Controls.Add(this.nomFiliere);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(33, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 130);
            this.panel1.TabIndex = 2;
            // 
            // ajouterFiliere
            // 
            this.ajouterFiliere.Location = new System.Drawing.Point(106, 93);
            this.ajouterFiliere.Name = "ajouterFiliere";
            this.ajouterFiliere.Size = new System.Drawing.Size(100, 23);
            this.ajouterFiliere.TabIndex = 3;
            this.ajouterFiliere.Text = "Ajouter";
            this.ajouterFiliere.UseVisualStyleBackColor = true;
            this.ajouterFiliere.Click += new System.EventHandler(this.ajouterFiliere_Click);
            // 
            // nomFiliere
            // 
            this.nomFiliere.Location = new System.Drawing.Point(170, 38);
            this.nomFiliere.Name = "nomFiliere";
            this.nomFiliere.Size = new System.Drawing.Size(142, 20);
            this.nomFiliere.TabIndex = 2;
            this.nomFiliere.TextChanged += new System.EventHandler(this.nomFiliere_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom Filière";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter une filière";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.triDecroissant);
            this.tabPage2.Controls.Add(this.triCroissant);
            this.tabPage2.Controls.Add(this.chargerDonnees);
            this.tabPage2.Controls.Add(this.modifier);
            this.tabPage2.Controls.Add(this.supprimer);
            this.tabPage2.Controls.Add(this.importer);
            this.tabPage2.Controls.Add(this.ajouter);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.listeCne);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(894, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Etudiant";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // triDecroissant
            // 
            this.triDecroissant.Location = new System.Drawing.Point(745, 43);
            this.triDecroissant.Name = "triDecroissant";
            this.triDecroissant.Size = new System.Drawing.Size(114, 23);
            this.triDecroissant.TabIndex = 10;
            this.triDecroissant.Text = "Tri Décroissant";
            this.triDecroissant.UseVisualStyleBackColor = true;
            this.triDecroissant.Click += new System.EventHandler(this.triDecroissant_Click);
            // 
            // triCroissant
            // 
            this.triCroissant.Location = new System.Drawing.Point(606, 43);
            this.triCroissant.Name = "triCroissant";
            this.triCroissant.Size = new System.Drawing.Size(114, 23);
            this.triCroissant.TabIndex = 9;
            this.triCroissant.Text = "Tri Croissant";
            this.triCroissant.UseVisualStyleBackColor = true;
            this.triCroissant.Click += new System.EventHandler(this.triCroissant_Click);
            // 
            // chargerDonnees
            // 
            this.chargerDonnees.Location = new System.Drawing.Point(465, 43);
            this.chargerDonnees.Name = "chargerDonnees";
            this.chargerDonnees.Size = new System.Drawing.Size(114, 23);
            this.chargerDonnees.TabIndex = 8;
            this.chargerDonnees.Text = "Charger données";
            this.chargerDonnees.UseVisualStyleBackColor = true;
            this.chargerDonnees.Click += new System.EventHandler(this.chargerDonnees_Click);
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(263, 428);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(75, 23);
            this.modifier.TabIndex = 6;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(371, 428);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(75, 23);
            this.supprimer.TabIndex = 5;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            // 
            // importer
            // 
            this.importer.Location = new System.Drawing.Point(504, 428);
            this.importer.Name = "importer";
            this.importer.Size = new System.Drawing.Size(75, 23);
            this.importer.TabIndex = 4;
            this.importer.Text = "Importer";
            this.importer.UseVisualStyleBackColor = true;
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(150, 428);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(75, 23);
            this.ajouter.TabIndex = 3;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dateN);
            this.panel3.Controls.Add(this.filiere);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.telephone);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.adresse);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.male);
            this.panel3.Controls.Add(this.female);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.prenom);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.Nom);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cne);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(23, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 314);
            this.panel3.TabIndex = 2;
            // 
            // dateN
            // 
            this.dateN.Location = new System.Drawing.Point(134, 165);
            this.dateN.Name = "dateN";
            this.dateN.Size = new System.Drawing.Size(200, 20);
            this.dateN.TabIndex = 18;
            // 
            // filiere
            // 
            this.filiere.Location = new System.Drawing.Point(134, 267);
            this.filiere.Name = "filiere";
            this.filiere.Size = new System.Drawing.Size(200, 20);
            this.filiere.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Filière:";
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(134, 234);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(200, 20);
            this.telephone.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Téléphone:";
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(134, 197);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(200, 20);
            this.adresse.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Adresse:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Date de naissance:";
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(284, 132);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(34, 17);
            this.male.TabIndex = 9;
            this.male.TabStop = true;
            this.male.Text = "M";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(155, 134);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(31, 17);
            this.female.TabIndex = 8;
            this.female.TabStop = true;
            this.female.Text = "F";
            this.female.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Sex:";
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(134, 102);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(200, 20);
            this.prenom.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Prénom:";
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(134, 67);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(200, 20);
            this.Nom.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nom:";
            // 
            // cne
            // 
            this.cne.Location = new System.Drawing.Point(134, 34);
            this.cne.Name = "cne";
            this.cne.Size = new System.Drawing.Size(200, 20);
            this.cne.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "CNE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Informations Etudiant";
            // 
            // listeCne
            // 
            this.listeCne.FormattingEnabled = true;
            this.listeCne.Location = new System.Drawing.Point(180, 48);
            this.listeCne.Name = "listeCne";
            this.listeCne.Size = new System.Drawing.Size(183, 21);
            this.listeCne.TabIndex = 1;
            this.listeCne.SelectedIndexChanged += new System.EventHandler(this.listeCne_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Checher un étudiant";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(894, 457);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Statistique";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(894, 457);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Reporting";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(451, 83);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(423, 323);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 499);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ajouterFiliere;
        private System.Windows.Forms.TextBox nomFiliere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deleteFiliere;
        private System.Windows.Forms.Button ModifierFiliere;
        private System.Windows.Forms.TextBox nouveauNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button validerNom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox filiere;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cne;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox listeCne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button importer;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button triDecroissant;
        private System.Windows.Forms.Button triCroissant;
        private System.Windows.Forms.Button chargerDonnees;
        private System.Windows.Forms.TextBox dateN;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

