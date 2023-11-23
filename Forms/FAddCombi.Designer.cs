namespace GestionMatériels.Forms
{
    partial class FAddCombi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAddCombi));
            label1 = new Label();
            boxMarque = new TextBox();
            boxTaille = new TextBox();
            boxSaison = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            boutonAddCombi = new Button();
            boutonretour = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(150, 30);
            label1.Name = "label1";
            label1.Size = new Size(348, 45);
            label1.TabIndex = 0;
            label1.Text = "Ajout Combinaison";
            label1.Click += label1_Click;
            // 
            // boxMarque
            // 
            boxMarque.BorderStyle = BorderStyle.None;
            boxMarque.Cursor = Cursors.IBeam;
            boxMarque.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            boxMarque.Location = new Point(202, 131);
            boxMarque.Name = "boxMarque";
            boxMarque.Size = new Size(231, 27);
            boxMarque.TabIndex = 1;
            // 
            // boxTaille
            // 
            boxTaille.BorderStyle = BorderStyle.None;
            boxTaille.Cursor = Cursors.IBeam;
            boxTaille.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            boxTaille.Location = new Point(202, 202);
            boxTaille.Name = "boxTaille";
            boxTaille.Size = new Size(231, 27);
            boxTaille.TabIndex = 2;
            boxTaille.TextChanged += textBox1_TextChanged;
            // 
            // boxSaison
            // 
            boxSaison.Cursor = Cursors.IBeam;
            boxSaison.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            boxSaison.FormattingEnabled = true;
            boxSaison.Items.AddRange(new object[] { "Été", "Automne", "Hiver", "Printemps" });
            boxSaison.Location = new Point(202, 279);
            boxSaison.Name = "boxSaison";
            boxSaison.Size = new Size(231, 35);
            boxSaison.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.No;
            label2.ForeColor = Color.White;
            label2.Location = new Point(202, 108);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 5;
            label2.Text = "Marque";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.No;
            label3.ForeColor = Color.White;
            label3.Location = new Point(202, 179);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 6;
            label3.Text = "Taille";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.No;
            label4.ForeColor = Color.White;
            label4.Location = new Point(202, 256);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 7;
            label4.Text = "Saison";
            // 
            // boutonAddCombi
            // 
            boutonAddCombi.FlatStyle = FlatStyle.Flat;
            boutonAddCombi.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            boutonAddCombi.ForeColor = Color.White;
            boutonAddCombi.Location = new Point(202, 348);
            boutonAddCombi.Margin = new Padding(4);
            boutonAddCombi.Name = "boutonAddCombi";
            boutonAddCombi.Size = new Size(231, 64);
            boutonAddCombi.TabIndex = 8;
            boutonAddCombi.Text = "Ajouter";
            boutonAddCombi.UseVisualStyleBackColor = true;
            boutonAddCombi.Click += boutonAddCombi_Click;
            // 
            // boutonretour
            // 
            boutonretour.FlatStyle = FlatStyle.Flat;
            boutonretour.Font = new Font("Microsoft YaHei", 15F, FontStyle.Bold, GraphicsUnit.Point);
            boutonretour.ForeColor = Color.White;
            boutonretour.Location = new Point(17, 17);
            boutonretour.Name = "boutonretour";
            boutonretour.Size = new Size(40, 40);
            boutonretour.TabIndex = 9;
            boutonretour.Text = "←";
            boutonretour.UseVisualStyleBackColor = true;
            boutonretour.Click += boutonretour_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(582, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 49);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LimeGreen;
            label5.Location = new Point(223, 422);
            label5.Name = "label5";
            label5.Size = new Size(0, 24);
            label5.TabIndex = 11;
            label5.Click += label5_Click;
            // 
            // FAddCombi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(92, 51, 127);
            ClientSize = new Size(643, 455);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(boutonretour);
            Controls.Add(boutonAddCombi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(boxSaison);
            Controls.Add(boxTaille);
            Controls.Add(boxMarque);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FAddCombi";
            Text = "FAddCombi";
            Load += FAddCombi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox boxMarque;
        private TextBox boxTaille;
        private ComboBox boxSaison;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button boutonAddCombi;
        private Button boutonretour;
        private PictureBox pictureBox1;
        private Label label5;
    }
}