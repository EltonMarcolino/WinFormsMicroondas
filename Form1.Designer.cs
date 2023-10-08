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
            SuspendLayout();
            // 
            // textBoxTempo
            // 
            textBoxTempo.Location = new Point(105, 53);
            textBoxTempo.Name = "textBoxTempo";
            textBoxTempo.Size = new Size(104, 23);
            textBoxTempo.TabIndex = 0;
            textBoxTempo.KeyPress += tempo_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 53);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Tempo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 92);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Potência:";
            // 
            // textBoxPotencia
            // 
            textBoxPotencia.Location = new Point(105, 92);
            textBoxPotencia.Name = "textBoxPotencia";
            textBoxPotencia.Size = new Size(104, 23);
            textBoxPotencia.TabIndex = 3;
            textBoxPotencia.KeyPress += potencia_KeyPress;
            textBoxPotencia.Leave += textBoxPotencia_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxPotencia);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxTempo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTempo;
        private Label label1;
        private Label label2;
        private TextBox textBoxPotencia;
    }
}