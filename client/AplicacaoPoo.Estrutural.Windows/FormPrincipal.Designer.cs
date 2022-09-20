namespace AplicacaoPoo.Estrutural.Windows
{
    partial class btn
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
            this.btnCotacao = new System.Windows.Forms.Button();
            this.btnComissao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCotacao
            // 
            this.btnCotacao.BackColor = System.Drawing.Color.Indigo;
            this.btnCotacao.Font = new System.Drawing.Font("GothicG", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCotacao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCotacao.Location = new System.Drawing.Point(190, 231);
            this.btnCotacao.Name = "btnCotacao";
            this.btnCotacao.Size = new System.Drawing.Size(197, 70);
            this.btnCotacao.TabIndex = 0;
            this.btnCotacao.Text = "Cotação";
            this.btnCotacao.UseVisualStyleBackColor = false;
            this.btnCotacao.Click += new System.EventHandler(this.btnCotacao_Click);
            // 
            // btnComissao
            // 
            this.btnComissao.BackColor = System.Drawing.Color.Fuchsia;
            this.btnComissao.Font = new System.Drawing.Font("GothicG", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComissao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComissao.Location = new System.Drawing.Point(27, 35);
            this.btnComissao.Name = "btnComissao";
            this.btnComissao.Size = new System.Drawing.Size(197, 83);
            this.btnComissao.TabIndex = 1;
            this.btnComissao.Text = "Comissão";
            this.btnComissao.UseVisualStyleBackColor = false;
            // 
            // btn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(418, 334);
            this.Controls.Add(this.btnComissao);
            this.Controls.Add(this.btnCotacao);
            this.Name = "btn";
            this.Text = "AplicacaoPoo.Estrutural.Windows";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCotacao;
        private Button btnComissao;
    }
}