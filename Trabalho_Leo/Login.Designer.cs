namespace Trabalho_Leo
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            btn_SairLogin = new Button();
            txt_UsuarioLogin = new TextBox();
            txt_SenhaLogin = new TextBox();
            btn_EntrarLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(749, 466);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_SairLogin
            // 
            btn_SairLogin.Location = new Point(704, 12);
            btn_SairLogin.Name = "btn_SairLogin";
            btn_SairLogin.Size = new Size(30, 29);
            btn_SairLogin.TabIndex = 4;
            btn_SairLogin.Text = "X";
            btn_SairLogin.UseVisualStyleBackColor = true;
            btn_SairLogin.Click += btn_SairLogin_Click;
            // 
            // txt_UsuarioLogin
            // 
            txt_UsuarioLogin.Location = new Point(204, 252);
            txt_UsuarioLogin.MaxLength = 100;
            txt_UsuarioLogin.Name = "txt_UsuarioLogin";
            txt_UsuarioLogin.Size = new Size(326, 27);
            txt_UsuarioLogin.TabIndex = 1;
            txt_UsuarioLogin.TextChanged += txt_UsuarioLogin_TextChanged;
            // 
            // txt_SenhaLogin
            // 
            txt_SenhaLogin.Location = new Point(204, 326);
            txt_SenhaLogin.Name = "txt_SenhaLogin";
            txt_SenhaLogin.Size = new Size(326, 27);
            txt_SenhaLogin.TabIndex = 2;
            txt_SenhaLogin.TextChanged += txt_SenhaLogin_TextChanged;
            // 
            // btn_EntrarLogin
            // 
            btn_EntrarLogin.BackColor = Color.SlateBlue;
            btn_EntrarLogin.FlatStyle = FlatStyle.Flat;
            btn_EntrarLogin.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EntrarLogin.ForeColor = Color.WhiteSmoke;
            btn_EntrarLogin.Location = new Point(320, 380);
            btn_EntrarLogin.Name = "btn_EntrarLogin";
            btn_EntrarLogin.Size = new Size(113, 31);
            btn_EntrarLogin.TabIndex = 3;
            btn_EntrarLogin.Text = "Entrar";
            btn_EntrarLogin.UseVisualStyleBackColor = false;
            btn_EntrarLogin.Click += btn_EntrarLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 464);
            Controls.Add(btn_EntrarLogin);
            Controls.Add(txt_SenhaLogin);
            Controls.Add(txt_UsuarioLogin);
            Controls.Add(btn_SairLogin);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_SairLogin;
        private TextBox txt_UsuarioLogin;
        private TextBox txt_SenhaLogin;
        private Button btn_EntrarLogin;
    }
}