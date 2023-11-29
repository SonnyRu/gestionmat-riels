namespace GestionMatériels.Forms
{
    partial class FAddMono
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAddMono));
            label1 = new Label();
            boxMarque = new TextBox();
            boxType = new ComboBox();
            boxPointure = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            boutonAddMono = new Button();
            button1 = new Button();
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
            label1.Size = new Size(331, 45);
            label1.TabIndex = 0;
            label1.Text = "Ajout Monopalme";
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
            // boxType
            // 
            boxType.Cursor = Cursors.IBeam;
            boxType.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            boxType.FormattingEnabled = true;
            boxType.Items.AddRange(new object[] { "Loisir", "Compétition", "Entraînement" });
            boxType.Location = new Point(202, 202);
            boxType.Name = "boxType";
            boxType.Size = new Size(231, 35);
            boxType.TabIndex = 3;
            // 
            // boxPointure
            // 
            boxPointure.BorderStyle = BorderStyle.None;
            boxPointure.Cursor = Cursors.IBeam;
            boxPointure.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            boxPointure.Location = new Point(202, 279);
            boxPointure.Name = "boxPointure";
            boxPointure.Size = new Size(231, 27);
            boxPointure.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(202, 108);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 6;
            label2.Text = "Marque";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(202, 179);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 7;
            label3.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(202, 256);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 8;
            label4.Text = "Pointure";
            // 
            // boutonAddMono
            // 
            boutonAddMono.FlatStyle = FlatStyle.Flat;
            boutonAddMono.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            boutonAddMono.ForeColor = Color.White;
            boutonAddMono.Location = new Point(202, 348);
            boutonAddMono.Margin = new Padding(4);
            boutonAddMono.Name = "boutonAddMono";
            boutonAddMono.Size = new Size(231, 64);
            boutonAddMono.TabIndex = 9;
            boutonAddMono.Text = "Ajouter";
            boutonAddMono.UseVisualStyleBackColor = true;
            boutonAddMono.Click += boutonAddMono_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft YaHei", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(17, 17);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 10;
            button1.Text = "←";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(582, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 49);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Lime;
            label5.Location = new Point(227, 422);
            label5.Name = "label5";
            label5.Size = new Size(0, 23);
            label5.TabIndex = 12;
            // 
            // FAddMono
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(92, 51, 127);
            ClientSize = new Size(643, 455);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(boutonAddMono);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(boxPointure);
            Controls.Add(boxType);
            Controls.Add(boxMarque);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FAddMono";
            Text = "Ajouter Monopalme";
            Load += FAddMono_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox boxMarque;
        private ComboBox boxType;
        private TextBox boxPointure;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button boutonAddMono;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label5;
    }
}