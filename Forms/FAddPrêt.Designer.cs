namespace GestionMatériels.Forms
{
    partial class FAddPrêt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAddPrêt));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            dateemprunt = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            dateretour = new Label();
            idnageur = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            idmateriel = new NumericUpDown();
            boutonAddCombi = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)idnageur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)idmateriel).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft YaHei", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(17, 17);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 0;
            button1.Text = "←";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(582, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 49);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(180, 35);
            label1.Name = "label1";
            label1.Size = new Size(282, 45);
            label1.TabIndex = 2;
            label1.Text = "Ajouter un Prêt";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(206, 95);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 3;
            label2.Text = "Date d'Emprunt";
            label2.Click += label2_Click;
            // 
            // dateemprunt
            // 
            dateemprunt.CalendarFont = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateemprunt.CalendarForeColor = Color.FromArgb(92, 51, 127);
            dateemprunt.CalendarTitleForeColor = Color.FromArgb(92, 51, 127);
            dateemprunt.Cursor = Cursors.IBeam;
            dateemprunt.Font = new Font("Microsoft YaHei", 8F, FontStyle.Bold, GraphicsUnit.Point);
            dateemprunt.Location = new Point(206, 118);
            dateemprunt.Name = "dateemprunt";
            dateemprunt.Size = new Size(231, 25);
            dateemprunt.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.CalendarForeColor = Color.FromArgb(92, 51, 127);
            dateTimePicker1.CalendarTitleForeColor = Color.FromArgb(92, 51, 127);
            dateTimePicker1.Cursor = Cursors.IBeam;
            dateTimePicker1.Font = new Font("Microsoft YaHei", 8F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(206, 182);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(231, 25);
            dateTimePicker1.TabIndex = 6;
            // 
            // dateretour
            // 
            dateretour.AutoSize = true;
            dateretour.ForeColor = Color.White;
            dateretour.Location = new Point(206, 159);
            dateretour.Name = "dateretour";
            dateretour.Size = new Size(110, 20);
            dateretour.TabIndex = 5;
            dateretour.Text = "Date de Retour";
            // 
            // idnageur
            // 
            idnageur.Cursor = Cursors.IBeam;
            idnageur.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            idnageur.ForeColor = Color.FromArgb(92, 51, 127);
            idnageur.Location = new Point(206, 243);
            idnageur.Name = "idnageur";
            idnageur.Size = new Size(231, 34);
            idnageur.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(206, 220);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 8;
            label3.Text = "Numéro du Nageur";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(206, 291);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 10;
            label4.Text = "Numéro du Matériel";
            // 
            // idmateriel
            // 
            idmateriel.Cursor = Cursors.IBeam;
            idmateriel.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            idmateriel.ForeColor = Color.FromArgb(92, 51, 127);
            idmateriel.Location = new Point(206, 314);
            idmateriel.Name = "idmateriel";
            idmateriel.Size = new Size(231, 34);
            idmateriel.TabIndex = 9;
            idmateriel.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // boutonAddCombi
            // 
            boutonAddCombi.FlatStyle = FlatStyle.Flat;
            boutonAddCombi.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            boutonAddCombi.ForeColor = Color.White;
            boutonAddCombi.Location = new Point(206, 365);
            boutonAddCombi.Margin = new Padding(4);
            boutonAddCombi.Name = "boutonAddCombi";
            boutonAddCombi.Size = new Size(231, 64);
            boutonAddCombi.TabIndex = 11;
            boutonAddCombi.Text = "Ajouter";
            boutonAddCombi.UseVisualStyleBackColor = true;
            // 
            // FAddPrêt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(92, 51, 127);
            ClientSize = new Size(643, 455);
            Controls.Add(boutonAddCombi);
            Controls.Add(label4);
            Controls.Add(idmateriel);
            Controls.Add(label3);
            Controls.Add(idnageur);
            Controls.Add(dateTimePicker1);
            Controls.Add(dateretour);
            Controls.Add(dateemprunt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FAddPrêt";
            Text = "Ajouter Prêt";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)idnageur).EndInit();
            ((System.ComponentModel.ISupportInitialize)idmateriel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private DateTimePicker dateemprunt;
        private DateTimePicker dateTimePicker1;
        private Label dateretour;
        private NumericUpDown idnageur;
        private Label label3;
        private Label label4;
        private NumericUpDown idmateriel;
        private Button boutonAddCombi;
    }
}