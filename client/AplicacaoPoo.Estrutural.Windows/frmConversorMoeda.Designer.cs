namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmConversorMoeda
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
            this.txtValorEmDolar = new System.Windows.Forms.TextBox();
            this.lblPrimeiroValor = new System.Windows.Forms.Label();
            this.lblSegundoValor = new System.Windows.Forms.Label();
            this.cmbMoedas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtValorEmDolar
            // 
            this.txtValorEmDolar.BackColor = System.Drawing.Color.White;
            this.txtValorEmDolar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorEmDolar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorEmDolar.ForeColor = System.Drawing.Color.Black;
            this.txtValorEmDolar.Location = new System.Drawing.Point(18, 96);
            this.txtValorEmDolar.Name = "txtValorEmDolar";
            this.txtValorEmDolar.PlaceholderText = "informe o valor em dolar";
            this.txtValorEmDolar.Size = new System.Drawing.Size(173, 29);
            this.txtValorEmDolar.TabIndex = 1;
            this.txtValorEmDolar.Text = "8";
            this.txtValorEmDolar.TextChanged += new System.EventHandler(this.txtValorEmDolar_TextChanged);
            // 
            // lblPrimeiroValor
            // 
            this.lblPrimeiroValor.AutoSize = true;
            this.lblPrimeiroValor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrimeiroValor.Location = new System.Drawing.Point(18, 12);
            this.lblPrimeiroValor.Name = "lblPrimeiroValor";
            this.lblPrimeiroValor.Size = new System.Drawing.Size(0, 17);
            this.lblPrimeiroValor.TabIndex = 3;
            // 
            // lblSegundoValor
            // 
            this.lblSegundoValor.AutoSize = true;
            this.lblSegundoValor.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSegundoValor.Location = new System.Drawing.Point(18, 29);
            this.lblSegundoValor.Name = "lblSegundoValor";
            this.lblSegundoValor.Size = new System.Drawing.Size(0, 30);
            this.lblSegundoValor.TabIndex = 4;
            // 
            // cmbMoedas
            // 
            this.cmbMoedas.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbMoedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoedas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbMoedas.ForeColor = System.Drawing.Color.Black;
            this.cmbMoedas.FormattingEnabled = true;
            this.cmbMoedas.Items.AddRange(new object[] {
            "Dolar",
            "Libra",
            "Euro"});
            this.cmbMoedas.Location = new System.Drawing.Point(229, 96);
            this.cmbMoedas.Name = "cmbMoedas";
            this.cmbMoedas.Size = new System.Drawing.Size(162, 29);
            this.cmbMoedas.TabIndex = 5;
            this.cmbMoedas.SelectedIndexChanged += new System.EventHandler(this.cmbMoedas_SelectedIndexChanged);
            // 
            // frmConversorMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(434, 243);
            this.Controls.Add(this.cmbMoedas);
            this.Controls.Add(this.lblSegundoValor);
            this.Controls.Add(this.lblPrimeiroValor);
            this.Controls.Add(this.txtValorEmDolar);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmConversorMoeda";
            this.Text = "frmConversorMoeda";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtValorEmDolar;
        private Label lblPrimeiroValor;
        private Label lblSegundoValor;
        private ComboBox cmbMoedas;
    }
}