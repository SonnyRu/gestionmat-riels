namespace GestionMatériels.Forms
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            logo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            passwordBox = new TextBox();
            usernameBox = new TextBox();
            boutonConnexion = new Button();
            authentif = new Label();
            authentifmdp = new Label();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.BackColor = Color.White;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(60, 19);
            logo.Name = "logo";
            logo.Size = new Size(275, 85);
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(79, 197);
            label1.Name = "label1";
            label1.Size = new Size(89, 16);
            label1.TabIndex = 1;
            label1.Text = "Mot de passe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.No;
            label2.ForeColor = Color.White;
            label2.Location = new Point(79, 123);
            label2.Name = "label2";
            label2.Size = new Size(40, 16);
            label2.TabIndex = 1;
            label2.Text = "Login";
            // 
            // passwordBox
            // 
            passwordBox.BorderStyle = BorderStyle.None;
            passwordBox.Cursor = Cursors.IBeam;
            passwordBox.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passwordBox.ForeColor = Color.FromArgb(0, 126, 249);
            passwordBox.Location = new Point(82, 216);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(231, 27);
            passwordBox.TabIndex = 3;
            // 
            // usernameBox
            // 
            usernameBox.BorderStyle = BorderStyle.None;
            usernameBox.Cursor = Cursors.IBeam;
            usernameBox.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            usernameBox.ForeColor = Color.FromArgb(0, 126, 249);
            usernameBox.Location = new Point(82, 142);
            usernameBox.Name = "usernameBox";
            usernameBox.RightToLeft = RightToLeft.No;
            usernameBox.Size = new Size(231, 27);
            usernameBox.TabIndex = 4;
            // 
            // boutonConnexion
            // 
            boutonConnexion.FlatStyle = FlatStyle.Flat;
            boutonConnexion.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            boutonConnexion.ForeColor = Color.White;
            boutonConnexion.Location = new Point(86, 272);
            boutonConnexion.Margin = new Padding(4);
            boutonConnexion.Name = "boutonConnexion";
            boutonConnexion.Size = new Size(224, 64);
            boutonConnexion.TabIndex = 0;
            boutonConnexion.Text = "Connexion";
            boutonConnexion.UseVisualStyleBackColor = true;
            boutonConnexion.Click += boutonConnexion_Click;
            // 
            // authentif
            // 
            authentif.AutoSize = true;
            authentif.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            authentif.ForeColor = Color.Red;
            authentif.Location = new Point(125, 123);
            authentif.Name = "authentif";
            authentif.Size = new Size(0, 19);
            authentif.TabIndex = 5;
            authentif.Click += authentif_Click;
            // 
            // authentifmdp
            // 
            authentifmdp.AutoSize = true;
            authentifmdp.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            authentifmdp.ForeColor = Color.Red;
            authentifmdp.Location = new Point(174, 197);
            authentifmdp.Name = "authentifmdp";
            authentifmdp.Size = new Size(0, 19);
            authentifmdp.TabIndex = 6;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(92, 51, 127);
            ClientSize = new Size(397, 389);
            Controls.Add(authentifmdp);
            Controls.Add(authentif);
            Controls.Add(boutonConnexion);
            Controls.Add(usernameBox);
            Controls.Add(passwordBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(logo);
            Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Connexion";
            Text = "Connexion";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logo;
        private Label label1;
        private Label label2;
        private TextBox passwordBox;
        private TextBox usernameBox;
        private Button boutonConnexion;
        private Label authentif;
        private Label authentifmdp;
    }
}