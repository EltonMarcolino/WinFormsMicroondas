namespace WinFormsMicroondas.Telas
{
    partial class CadastreSe
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
            btnCadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txbLogin = new TextBox();
            txbSenha = new TextBox();
            txbConfirmaSenha = new TextBox();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(368, 109);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(97, 23);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 75);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 1;
            label1.Text = "EMAIL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 109);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 2;
            label2.Text = "SENHA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 173);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 3;
            label3.Text = "CONFIRMA SENHA";
            // 
            // txbLogin
            // 
            txbLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbLogin.Location = new Point(95, 75);
            txbLogin.Name = "txbLogin";
            txbLogin.Size = new Size(267, 25);
            txbLogin.TabIndex = 4;
            // 
            // txbSenha
            // 
            txbSenha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbSenha.Location = new Point(95, 109);
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new Size(267, 25);
            txbSenha.TabIndex = 5;
            // 
            // txbConfirmaSenha
            // 
            txbConfirmaSenha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbConfirmaSenha.Location = new Point(159, 170);
            txbConfirmaSenha.Name = "txbConfirmaSenha";
            txbConfirmaSenha.PasswordChar = '*';
            txbConfirmaSenha.Size = new Size(203, 25);
            txbConfirmaSenha.TabIndex = 6;
            txbConfirmaSenha.TextChanged += txbConfirmaSenha_TextChanged;
            // 
            // CadastreSe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(494, 264);
            Controls.Add(txbConfirmaSenha);
            Controls.Add(txbSenha);
            Controls.Add(txbLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CadastreSe";
            Text = "CadastreSe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txbLogin;
        private TextBox txbSenha;
        private TextBox txbConfirmaSenha;
    }
}