namespace WinFormsMicroondas
{

    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxTempo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxPotencia = new TextBox();
            btnPipoca = new Button();
            btnLeite = new Button();
            btnCarnes = new Button();
            btnFrango = new Button();
            btnFeijao = new Button();
            btnIniciar = new Button();
            btnCancelar = new Button();
            btnCustomizado = new Button();
            SuspendLayout();
            // 
            // textBoxTempo
            // 
            textBoxTempo.Location = new Point(135, 70);
            textBoxTempo.Margin = new Padding(4);
            textBoxTempo.Name = "textBoxTempo";
            textBoxTempo.Size = new Size(143, 27);
            textBoxTempo.TabIndex = 0;
          
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(44, 70);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "Tempo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(44, 123);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Potência:";
            // 
            // textBoxPotencia
            // 
            textBoxPotencia.Location = new Point(135, 116);
            textBoxPotencia.Margin = new Padding(4);
            textBoxPotencia.Name = "textBoxPotencia";
            textBoxPotencia.Size = new Size(143, 27);
            textBoxPotencia.TabIndex = 3;
         
       
            // 
            // btnPipoca
            // 
            btnPipoca.Location = new Point(314, 70);
            btnPipoca.Margin = new Padding(4);
            btnPipoca.Name = "btnPipoca";
            btnPipoca.Size = new Size(96, 30);
            btnPipoca.TabIndex = 4;
            btnPipoca.Text = "PIPOCA";
            btnPipoca.UseVisualStyleBackColor = true;
            btnPipoca.Click += btnPipoca_Click;
            // 
            // btnLeite
            // 
            btnLeite.Location = new Point(314, 118);
            btnLeite.Margin = new Padding(4);
            btnLeite.Name = "btnLeite";
            btnLeite.Size = new Size(96, 30);
            btnLeite.TabIndex = 5;
            btnLeite.Text = "LEITE";
            btnLeite.UseVisualStyleBackColor = true;
            btnLeite.Click += btnLeite_Click;
            // 
            // btnCarnes
            // 
            btnCarnes.Location = new Point(314, 173);
            btnCarnes.Margin = new Padding(4);
            btnCarnes.Name = "btnCarnes";
            btnCarnes.Size = new Size(96, 30);
            btnCarnes.TabIndex = 6;
            btnCarnes.Text = "CARNES ";
            btnCarnes.UseVisualStyleBackColor = true;
            btnCarnes.Click += btnCarnes_Click;
            // 
            // btnFrango
            // 
            btnFrango.Location = new Point(314, 226);
            btnFrango.Margin = new Padding(4);
            btnFrango.Name = "btnFrango";
            btnFrango.Size = new Size(96, 30);
            btnFrango.TabIndex = 7;
            btnFrango.Text = "FRANGO";
            btnFrango.UseVisualStyleBackColor = true;
            btnFrango.Click += btnFrango_Click;
            // 
            // btnFeijao
            // 
            btnFeijao.Location = new Point(314, 273);
            btnFeijao.Margin = new Padding(4);
            btnFeijao.Name = "btnFeijao";
            btnFeijao.Size = new Size(96, 30);
            btnFeijao.TabIndex = 8;
            btnFeijao.Text = "FEIJÃO";
            btnFeijao.UseVisualStyleBackColor = true;
            btnFeijao.Click += btnFeijao_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciar.Location = new Point(135, 163);
            btnIniciar.Margin = new Padding(4);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(143, 40);
            btnIniciar.TabIndex = 9;
            btnIniciar.Text = "INICIAR 30 S";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(135, 221);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 40);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "CANCELAR/PAUSAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCustomizado
            // 
            btnCustomizado.Location = new Point(135, 275);
            btnCustomizado.Name = "btnCustomizado";
            btnCustomizado.Size = new Size(143, 28);
            btnCustomizado.TabIndex = 11;
            btnCustomizado.Text = "CUSTOMIZADO";
            btnCustomizado.UseVisualStyleBackColor = true;
        
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(529, 360);
            Controls.Add(btnCustomizado);
            Controls.Add(btnCancelar);
            Controls.Add(btnIniciar);
            Controls.Add(btnFeijao);
            Controls.Add(btnFrango);
            Controls.Add(btnCarnes);
            Controls.Add(btnLeite);
            Controls.Add(btnPipoca);
            Controls.Add(textBoxPotencia);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxTempo);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "MicroondasElton";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTempo;
        private Label label1;
        private Label label2;
        private TextBox textBoxPotencia;
        private Button btnPipoca;
        private Button btnLeite;
        private Button btnCarnes;
        private Button btnFrango;
        private Button btnFeijao;
        private Button btnIniciar;
        private Button btnCancelar;
        private Button btnCustomizado;
    }
}