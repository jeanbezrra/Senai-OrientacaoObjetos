namespace AplicacaoPoo.Estrutural.Windows
{
    partial class CotacaoDolar
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
            this.txtVdolarHoje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVconversao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConverter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVdolarHoje
            // 
            this.txtVdolarHoje.Location = new System.Drawing.Point(43, 85);
            this.txtVdolarHoje.Name = "txtVdolarHoje";
            this.txtVdolarHoje.Size = new System.Drawing.Size(100, 23);
            this.txtVdolarHoje.TabIndex = 0;
            this.txtVdolarHoje.TextChanged += new System.EventHandler(this.vDolarHoje_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("GothicG", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor do Dolar hoje:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtVconversao
            // 
            this.txtVconversao.Location = new System.Drawing.Point(43, 169);
            this.txtVconversao.Name = "txtVconversao";
            this.txtVconversao.Size = new System.Drawing.Size(100, 23);
            this.txtVconversao.TabIndex = 2;
            this.txtVconversao.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("GothicG", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor para Conversão:";
            // 
            // btnConverter
            // 
            this.btnConverter.BackColor = System.Drawing.Color.Black;
            this.btnConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverter.Font = new System.Drawing.Font("GothicG", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConverter.ForeColor = System.Drawing.Color.White;
            this.btnConverter.Location = new System.Drawing.Point(43, 239);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(308, 43);
            this.btnConverter.TabIndex = 4;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = false;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // CotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(393, 321);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVconversao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVdolarHoje);
            this.Name = "CotacaoDolar";
            this.Text = "CotacaoDolar";
            this.Load += new System.EventHandler(this.CotacaoDolar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtVdolarHoje;
        private Label label1;
        private TextBox txtVconversao;
        private Label label2;
        private Button btnConverter;
    }
}