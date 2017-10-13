namespace ConversorDeNumerosRomanos.Forms
{
    partial class frmConversao
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
            this.txtEntradaParaConversao = new System.Windows.Forms.TextBox();
            this.btnConverterValoresDeEntrada = new System.Windows.Forms.Button();
            this.txtSaidaConvertida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEntradaParaConversao
            // 
            this.txtEntradaParaConversao.Location = new System.Drawing.Point(61, 105);
            this.txtEntradaParaConversao.Name = "txtEntradaParaConversao";
            this.txtEntradaParaConversao.Size = new System.Drawing.Size(206, 20);
            this.txtEntradaParaConversao.TabIndex = 0;
            this.txtEntradaParaConversao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEntradaParaConversao.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnConverterValoresDeEntrada
            // 
            this.btnConverterValoresDeEntrada.Location = new System.Drawing.Point(64, 208);
            this.btnConverterValoresDeEntrada.Name = "btnConverterValoresDeEntrada";
            this.btnConverterValoresDeEntrada.Size = new System.Drawing.Size(203, 31);
            this.btnConverterValoresDeEntrada.TabIndex = 1;
            this.btnConverterValoresDeEntrada.Text = "Converter!";
            this.btnConverterValoresDeEntrada.UseVisualStyleBackColor = true;
            this.btnConverterValoresDeEntrada.Click += new System.EventHandler(this.btnConverterValoresDeEntrada_Click);
            // 
            // txtSaidaConvertida
            // 
            this.txtSaidaConvertida.Location = new System.Drawing.Point(61, 160);
            this.txtSaidaConvertida.Name = "txtSaidaConvertida";
            this.txtSaidaConvertida.Size = new System.Drawing.Size(206, 20);
            this.txtSaidaConvertida.TabIndex = 2;
            this.txtSaidaConvertida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insira um valor a ser convertido, ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "pode ser um número Romano ou decimal !";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Insira nesse campo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor convertido";
            // 
            // frmConversao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 321);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaidaConvertida);
            this.Controls.Add(this.btnConverterValoresDeEntrada);
            this.Controls.Add(this.txtEntradaParaConversao);
            this.Name = "frmConversao";
            this.Text = "Romano <> Decimal";
            this.Load += new System.EventHandler(this.frmConversao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntradaParaConversao;
        private System.Windows.Forms.Button btnConverterValoresDeEntrada;
        private System.Windows.Forms.TextBox txtSaidaConvertida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}