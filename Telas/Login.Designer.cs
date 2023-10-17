namespace WinFormsMicroondas.Telas
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
            btnEntrar = new Button();
            btnSair = new Button();
            btnCadastreSe = new Button();
            lblLogin = new Label();
            lblSenha = new Label();
            txbLogin = new TextBox();
            txbSenha = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEntrar.Location = new Point(288, 155);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(88, 23);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.Location = new Point(382, 155);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(97, 23);
            btnSair.TabIndex = 2;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnCadastreSe
            // 
            btnCadastreSe.Location = new Point(288, 189);
            btnCadastreSe.Name = "btnCadastreSe";
            btnCadastreSe.Size = new Size(191, 23);
            btnCadastreSe.TabIndex = 3;
            btnCadastreSe.Text = "CADASTRE-SE";
            btnCadastreSe.UseVisualStyleBackColor = false;
            btnCadastreSe.Click += btnCadastreSe_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(222, 82);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(54, 21);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "EMAIL";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSenha.Location = new Point(222, 114);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(60, 21);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "SENHA";
            // 
            // txbLogin
            // 
            txbLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbLogin.Location = new Point(288, 80);
            txbLogin.Name = "txbLogin";
            txbLogin.Size = new Size(191, 25);
            txbLogin.TabIndex = 6;
            // 
            // txbSenha
            // 
            txbSenha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbSenha.Location = new Point(288, 114);
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new Size(191, 25);
            txbSenha.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 24);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 8;
            label1.Text = "MICROONDAS DO ELTON";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(589, 307);
            Controls.Add(label1);
            Controls.Add(txbSenha);
            Controls.Add(txbLogin);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            Controls.Add(btnCadastreSe);
            Controls.Add(btnSair);
            Controls.Add(btnEntrar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnEntrar;
        private Button btnSair;
        private Button btnCadastreSe;
        private Label lblLogin;
        private Label lblSenha;
        private TextBox txbLogin;
        private TextBox txbSenha;
        private Label label1;
    }
}