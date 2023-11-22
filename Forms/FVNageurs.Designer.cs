namespace GestionMatériels.Forms
{
    partial class FVNageurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FVNageurs));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            voirnageurs = new ListView();
            Nom = new ColumnHeader();
            Prénom = new ColumnHeader();
            Email = new ColumnHeader();
            Téléphone = new ColumnHeader();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(92, 51, 127);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-8, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(280, 31);
            label1.Name = "label1";
            label1.Size = new Size(239, 66);
            label1.TabIndex = 2;
            label1.Text = "Nageurs";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_mini;
            pictureBox1.Location = new Point(745, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 52);
            pictureBox1.TabIndex = 1;
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
            button1.TabIndex = 0;
            button1.Text = "←";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // voirnageurs
            // 
            voirnageurs.BackColor = SystemColors.Control;
            voirnageurs.Columns.AddRange(new ColumnHeader[] { Nom, Prénom, Email, Téléphone });
            voirnageurs.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            voirnageurs.ForeColor = Color.FromArgb(92, 51, 127);
            voirnageurs.Location = new Point(23, 138);
            voirnageurs.Name = "voirnageurs";
            voirnageurs.Size = new Size(756, 298);
            voirnageurs.TabIndex = 1;
            voirnageurs.UseCompatibleStateImageBehavior = false;
            voirnageurs.View = View.Details;
            voirnageurs.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Nom
            // 
            Nom.Text = "Nom";
            Nom.Width = 150;
            // 
            // Prénom
            // 
            Prénom.Text = "Prénom";
            Prénom.TextAlign = HorizontalAlignment.Center;
            Prénom.Width = 150;
            // 
            // Email
            // 
            Email.Text = "Email";
            Email.TextAlign = HorizontalAlignment.Center;
            Email.Width = 250;
            // 
            // Téléphone
            // 
            Téléphone.Text = "Téléphone";
            Téléphone.TextAlign = HorizontalAlignment.Center;
            Téléphone.Width = 200;
            // 
            // FVNageurs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(voirnageurs);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FVNageurs";
            Text = "Nageurs";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private ListView voirnageurs;
        private ColumnHeader Nom;
        private ColumnHeader Prénom;
        private ColumnHeader Email;
        private ColumnHeader Téléphone;
    }
}