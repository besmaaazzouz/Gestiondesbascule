namespace Gestiondesbascules
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
            panel1 = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            login_btn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            close = new Button();
            label3 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label5 = new Label();
            register_label = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 436);
            panel1.Name = "panel1";
            panel1.Size = new Size(562, 73);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(135, 125);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 2;
            label1.Text = "CONNEXION";
            // 
            // login_username
            // 
            login_username.Location = new Point(135, 193);
            login_username.Name = "login_username";
            login_username.Size = new Size(333, 31);
            login_username.TabIndex = 3;
            // 
            // login_password
            // 
            login_password.Location = new Point(135, 252);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(333, 31);
            login_password.TabIndex = 4;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.LightGray;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.Location = new Point(183, 306);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(210, 46);
            login_btn.TabIndex = 5;
            login_btn.Text = "Se Connecter";
            login_btn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(79, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.prf;
            pictureBox2.Location = new Point(103, 193);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.padlock;
            pictureBox3.Location = new Point(103, 252);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(260, 374);
            label2.Name = "label2";
            label2.Size = new Size(0, 23);
            label2.TabIndex = 9;
            // 
            // close
            // 
            close.Location = new Point(513, 12);
            close.Name = "close";
            close.Size = new Size(37, 38);
            close.TabIndex = 0;
            close.Text = "x";
            close.UseVisualStyleBackColor = true;
            close.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 34);
            label3.Name = "label3";
            label3.Size = new Size(0, 26);
            label3.TabIndex = 1;
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(close);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(562, 94);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(123, 34);
            label4.Name = "label4";
            label4.Size = new Size(302, 26);
            label4.TabIndex = 2;
            label4.Text = "Systeme De Gestion De Bascules";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(112, 386);
            label5.Name = "label5";
            label5.Size = new Size(192, 20);
            label5.TabIndex = 10;
            label5.Text = "vous n'avez pas de compte?";
            label5.Click += label5_Click;
            // 
            // register_label
            // 
            register_label.AutoSize = true;
            register_label.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_label.ForeColor = Color.MidnightBlue;
            register_label.Location = new Point(301, 383);
            register_label.Name = "register_label";
            register_label.Size = new Size(148, 23);
            register_label.TabIndex = 11;
            register_label.Text = "Inscrivez-vous ici";
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(562, 509);
            Controls.Add(register_label);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(login_btn);
            Controls.Add(login_password);
            Controls.Add(login_username);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Connexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connexion";
            Load += Connexion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private TextBox login_username;
        private TextBox login_password;
        private Button login_btn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private Button close;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private Label label5;
        private Label register_label;
    }
}