namespace GestionMatériels.Forms
{
    partial class FVPrêts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FVPrêts));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            listPret = new ListView();
            idpret = new ColumnHeader();
            nom = new ColumnHeader();
            prenom = new ColumnHeader();
            materiel = new ColumnHeader();
            marque = new ColumnHeader();
            dateemprunt = new ColumnHeader();
            dateretour = new ColumnHeader();
            actualisation = new Button();
            ajouterpret = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(92, 51, 127);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(745, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 52);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft YaHei", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(20, 12);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 1;
            button1.Text = "←";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(314, 29);
            label1.Name = "label1";
            label1.Size = new Size(157, 66);
            label1.TabIndex = 0;
            label1.Text = "Prêts";
            // 
            // listPret
            // 
            listPret.Columns.AddRange(new ColumnHeader[] { idpret, nom, prenom, materiel, marque, dateemprunt, dateretour });
            listPret.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            listPret.ForeColor = Color.FromArgb(92, 51, 127);
            listPret.Location = new Point(26, 190);
            listPret.Name = "listPret";
            listPret.Size = new Size(748, 248);
            listPret.TabIndex = 1;
            listPret.UseCompatibleStateImageBehavior = false;
            listPret.View = View.Details;
            listPret.SelectedIndexChanged += listPret_SelectedIndexChanged;
            // 
            // idpret
            // 
            idpret.Text = "N° Prêt";
            idpret.Width = 70;
            // 
            // nom
            // 
            nom.Text = "Nom";
            nom.TextAlign = HorizontalAlignment.Center;
            nom.Width = 100;
            // 
            // prenom
            // 
            prenom.Text = "Prénom";
            prenom.TextAlign = HorizontalAlignment.Center;
            prenom.Width = 100;
            // 
            // materiel
            // 
            materiel.Text = "Matériel";
            materiel.TextAlign = HorizontalAlignment.Center;
            materiel.Width = 120;
            // 
            // marque
            // 
            marque.Text = "Marque";
            marque.TextAlign = HorizontalAlignment.Center;
            marque.Width = 100;
            // 
            // dateemprunt
            // 
            dateemprunt.Text = "Date d'Emprunt";
            dateemprunt.TextAlign = HorizontalAlignment.Center;
            dateemprunt.Width = 130;
            // 
            // dateretour
            // 
            dateretour.Text = "Date de Retour";
            dateretour.TextAlign = HorizontalAlignment.Center;
            dateretour.Width = 130;
            // 
            // actualisation
            // 
            actualisation.BackColor = Color.White;
            actualisation.FlatAppearance.BorderColor = Color.FromArgb(92, 51, 127);
            actualisation.FlatStyle = FlatStyle.Flat;
            actualisation.Image = (Image)resources.GetObject("actualisation.Image");
            actualisation.Location = new Point(26, 130);
            actualisation.Name = "actualisation";
            actualisation.Size = new Size(56, 54);
            actualisation.TabIndex = 3;
            actualisation.UseVisualStyleBackColor = false;
            actualisation.Click += actualisation_Click;
            // 
            // ajouterpret
            // 
            ajouterpret.BackColor = Color.White;
            ajouterpret.FlatAppearance.BorderColor = Color.FromArgb(92, 51, 127);
            ajouterpret.FlatAppearance.BorderSize = 2;
            ajouterpret.FlatStyle = FlatStyle.Flat;
            ajouterpret.Font = new Font("Microsoft YaHei", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ajouterpret.ForeColor = Color.FromArgb(92, 51, 127);
            ajouterpret.Location = new Point(115, 137);
            ajouterpret.Name = "ajouterpret";
            ajouterpret.Size = new Size(108, 41);
            ajouterpret.TabIndex = 4;
            ajouterpret.Text = "Ajouter";
            ajouterpret.UseVisualStyleBackColor = false;
            ajouterpret.Click += ajouterpret_Click;
            // 
            // FVPrêts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ajouterpret);
            Controls.Add(actualisation);
            Controls.Add(listPret);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FVPrêts";
            Text = "Prêts";
            Load += FVPrêts_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListView listPret;
        private ColumnHeader idpret;
        private ColumnHeader nom;
        private ColumnHeader prenom;
        private ColumnHeader materiel;
        private ColumnHeader marque;
        private ColumnHeader dateemprunt;
        private ColumnHeader dateretour;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button actualisation;
        private Button ajouterpret;
    }
}