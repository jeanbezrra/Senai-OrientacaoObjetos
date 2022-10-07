namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmSendMail
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
            this.lblSuporteContato = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSuporteContato
            // 
            this.lblSuporteContato.AutoSize = true;
            this.lblSuporteContato.Location = new System.Drawing.Point(74, 12);
            this.lblSuporteContato.Name = "lblSuporteContato";
            this.lblSuporteContato.Size = new System.Drawing.Size(101, 15);
            this.lblSuporteContato.TabIndex = 0;
            this.lblSuporteContato.Text = "Suporte e contato";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(16, 52);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(94, 15);
            this.lblNomeCompleto.TabIndex = 1;
            this.lblNomeCompleto.Text = "Nome completo";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(16, 71);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(281, 23);
            this.txtNomeCompleto.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(16, 125);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(281, 23);
            this.txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 106);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 15);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(16, 190);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(281, 23);
            this.txtAssunto.TabIndex = 6;
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Location = new System.Drawing.Point(16, 171);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(50, 15);
            this.lblAssunto.TabIndex = 5;
            this.lblAssunto.Text = "Assunto";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(16, 263);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(281, 23);
            this.txtMensagem.TabIndex = 8;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(16, 245);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(66, 15);
            this.lblMensagem.TabIndex = 7;
            this.lblMensagem.Text = "Mensagem";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "btnEnviarMensagem";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmSendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.lblAssunto);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.lblSuporteContato);
            this.Name = "frmSendMail";
            this.Text = "frmSendMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSuporteContato;
        private Label lblNomeCompleto;
        private TextBox txtNomeCompleto;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtAssunto;
        private Label lblAssunto;
        private TextBox txtMensagem;
        private Label lblMensagem;
        private Button button1;
    }
}