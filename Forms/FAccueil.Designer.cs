namespace GestionMatériels.Forms
{
    partial class FAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAccueil));
            panel1 = new Panel();
            deconnexion = new Button();
            nageurs = new Button();
            monopalme = new Button();
            combi = new Button();
            btnPret = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            listtuba = new ListView();
            NOM = new ColumnHeader();
            MARQUE = new ColumnHeader();
            listlunette = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            listmono = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            TYPE = new ColumnHeader();
            POINTURE = new ColumnHeader();
            listcombi = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            SAISON = new ColumnHeader();
            TAILLE = new ColumnHeader();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            actualisation = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(92, 51, 127);
            panel1.Controls.Add(deconnexion);
            panel1.Controls.Add(nageurs);
            panel1.Controls.Add(monopalme);
            panel1.Controls.Add(combi);
            panel1.Controls.Add(btnPret);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 710);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // deconnexion
            // 
            deconnexion.FlatStyle = FlatStyle.Flat;
            deconnexion.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            deconnexion.ForeColor = Color.White;
            deconnexion.Location = new Point(51, 643);
            deconnexion.Name = "deconnexion";
            deconnexion.Size = new Size(140, 40);
            deconnexion.TabIndex = 1;
            deconnexion.Text = "Déconnexion";
            deconnexion.UseVisualStyleBackColor = true;
            deconnexion.Click += deconnexion_Click;
            // 
            // nageurs
            // 
            nageurs.FlatAppearance.BorderColor = Color.FromArgb(92, 51, 127);
            nageurs.FlatStyle = FlatStyle.Flat;
            nageurs.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            nageurs.ForeColor = Color.White;
            nageurs.Location = new Point(0, 364);
            nageurs.Margin = new Padding(4);
            nageurs.Name = "nageurs";
            nageurs.Size = new Size(238, 52);
            nageurs.TabIndex = 3;
            nageurs.Text = "Nageurs";
            nageurs.UseVisualStyleBackColor = true;
            nageurs.Click += nageurs_Click;
            // 
            // monopalme
            // 
            monopalme.FlatAppearance.BorderColor = Color.FromArgb(92, 51, 127);
            monopalme.FlatStyle = FlatStyle.Flat;
            monopalme.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            monopalme.ForeColor = Color.White;
            monopalme.Location = new Point(0, 313);
            monopalme.Margin = new Padding(4);
            monopalme.Name = "monopalme";
            monopalme.Size = new Size(238, 52);
            monopalme.TabIndex = 2;
            monopalme.Text = "Ajout Monopalme";
            monopalme.UseVisualStyleBackColor = true;
            // 
            // combi
            // 
            combi.FlatAppearance.BorderColor = Color.FromArgb(92, 51, 127);
            combi.FlatStyle = FlatStyle.Flat;
            combi.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            combi.ForeColor = Color.WhiteSmoke;
            combi.Location = new Point(0, 262);
            combi.Margin = new Padding(4);
            combi.Name = "combi";
            combi.Size = new Size(238, 52);
            combi.TabIndex = 2;
            combi.Text = "Ajout Combinaison";
            combi.UseVisualStyleBackColor = true;
            combi.Click += combi_Click;
            // 
            // btnPret
            // 
            btnPret.FlatAppearance.BorderColor = Color.FromArgb(92, 51, 127);
            btnPret.FlatStyle = FlatStyle.Flat;
            btnPret.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPret.ForeColor = Color.White;
            btnPret.Location = new Point(0, 211);
            btnPret.Margin = new Padding(4);
            btnPret.Name = "btnPret";
            btnPret.Size = new Size(238, 52);
            btnPret.TabIndex = 1;
            btnPret.Text = "Voir les Prêts";
            btnPret.UseVisualStyleBackColor = true;
            btnPret.Click += btnPret_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Image = Properties.Resources.logo_rond;
            pictureBox1.Location = new Point(22, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 204);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(92, 51, 127);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(238, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1042, 141);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 40F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(360, 26);
            label1.Name = "label1";
            label1.Size = new Size(348, 90);
            label1.TabIndex = 0;
            label1.Text = "Stockage";
            // 
            // listtuba
            // 
            listtuba.BackColor = SystemColors.Control;
            listtuba.Columns.AddRange(new ColumnHeader[] { NOM, MARQUE });
            listtuba.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            listtuba.ForeColor = SystemColors.InfoText;
            listtuba.Location = new Point(413, 215);
            listtuba.Margin = new Padding(4);
            listtuba.Name = "listtuba";
            listtuba.Size = new Size(164, 201);
            listtuba.TabIndex = 2;
            listtuba.UseCompatibleStateImageBehavior = false;
            listtuba.View = View.Details;
            listtuba.SelectedIndexChanged += liststock_SelectedIndexChanged;
            // 
            // NOM
            // 
            NOM.Text = "NOM";
            NOM.TextAlign = HorizontalAlignment.Center;
            NOM.Width = 80;
            // 
            // MARQUE
            // 
            MARQUE.Text = "MARQUE";
            MARQUE.TextAlign = HorizontalAlignment.Center;
            MARQUE.Width = 80;
            // 
            // listlunette
            // 
            listlunette.BackColor = SystemColors.Control;
            listlunette.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listlunette.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            listlunette.ForeColor = SystemColors.InfoText;
            listlunette.Location = new Point(413, 482);
            listlunette.Margin = new Padding(4);
            listlunette.Name = "listlunette";
            listlunette.Size = new Size(164, 201);
            listlunette.TabIndex = 3;
            listlunette.UseCompatibleStateImageBehavior = false;
            listlunette.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "NOM";
            columnHeader1.TextAlign = HorizontalAlignment.Center;
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "MARQUE";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 80;
            // 
            // listmono
            // 
            listmono.BackColor = SystemColors.Control;
            listmono.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, TYPE, POINTURE });
            listmono.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            listmono.ForeColor = SystemColors.InfoText;
            listmono.Location = new Point(702, 215);
            listmono.Margin = new Padding(4);
            listmono.Name = "listmono";
            listmono.Size = new Size(506, 201);
            listmono.TabIndex = 4;
            listmono.UseCompatibleStateImageBehavior = false;
            listmono.View = View.Details;
            listmono.SelectedIndexChanged += listmono_SelectedIndexChanged;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "NOM";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "MARQUE";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 150;
            // 
            // TYPE
            // 
            TYPE.Text = "TYPE";
            TYPE.TextAlign = HorizontalAlignment.Center;
            TYPE.Width = 150;
            // 
            // POINTURE
            // 
            POINTURE.Text = "POINTURE";
            POINTURE.TextAlign = HorizontalAlignment.Center;
            POINTURE.Width = 100;
            // 
            // listcombi
            // 
            listcombi.BackColor = SystemColors.Control;
            listcombi.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, SAISON, TAILLE });
            listcombi.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            listcombi.ForeColor = SystemColors.InfoText;
            listcombi.Location = new Point(702, 482);
            listcombi.Margin = new Padding(4);
            listcombi.Name = "listcombi";
            listcombi.Size = new Size(506, 201);
            listcombi.TabIndex = 5;
            listcombi.UseCompatibleStateImageBehavior = false;
            listcombi.View = View.Details;
            listcombi.SelectedIndexChanged += listcombi_SelectedIndexChanged;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "NOM";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "MARQUE";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 150;
            // 
            // SAISON
            // 
            SAISON.Text = "SAISON";
            SAISON.TextAlign = HorizontalAlignment.Center;
            SAISON.Width = 150;
            // 
            // TAILLE
            // 
            TAILLE.Text = "TAILLE";
            TAILLE.Width = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(92, 51, 127);
            label2.Location = new Point(458, 179);
            label2.Name = "label2";
            label2.Size = new Size(75, 31);
            label2.TabIndex = 6;
            label2.Text = "Tuba";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(92, 51, 127);
            label3.Location = new Point(438, 447);
            label3.Name = "label3";
            label3.Size = new Size(119, 31);
            label3.TabIndex = 7;
            label3.Text = "Lunettes";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(92, 51, 127);
            label4.Location = new Point(869, 179);
            label4.Name = "label4";
            label4.Size = new Size(162, 31);
            label4.TabIndex = 8;
            label4.Text = "Monopalme";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(92, 51, 127);
            label5.Location = new Point(869, 447);
            label5.Name = "label5";
            label5.Size = new Size(174, 31);
            label5.TabIndex = 9;
            label5.Text = "Combinaison";
            // 
            // actualisation
            // 
            actualisation.FlatStyle = FlatStyle.Flat;
            actualisation.Image = (Image)resources.GetObject("actualisation.Image");
            actualisation.Location = new Point(245, 148);
            actualisation.Name = "actualisation";
            actualisation.Size = new Size(56, 54);
            actualisation.TabIndex = 10;
            actualisation.UseVisualStyleBackColor = true;
            actualisation.Click += actualisation_Click;
            // 
            // FAccueil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 710);
            Controls.Add(actualisation);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listcombi);
            Controls.Add(listmono);
            Controls.Add(listlunette);
            Controls.Add(listtuba);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FAccueil";
            Text = "Accueil";
            Load += FAccueil_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnPret;
        private Button nageurs;
        private Button monopalme;
        private Button combi;
        private Panel panel2;
        private Label label1;
        private ListView listtuba;
        private ColumnHeader NOM;
        private ColumnHeader MARQUE;
        private ListView listlunette;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView listmono;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView listcombi;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ColumnHeader TYPE;
        private ColumnHeader POINTURE;
        private ColumnHeader SAISON;
        private ColumnHeader TAILLE;
        private Button deconnexion;
        private Button actualisation;
    }
}