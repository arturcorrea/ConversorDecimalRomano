namespace ConversorDeNumerosRomanos
{
    partial class frmPrincipal
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
            this.btnAbrirFrmConversao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridViewConversoes = new System.Windows.Forms.DataGridView();
            this.clnDecimais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRomanos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConversoes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrirFrmConversao
            // 
            this.btnAbrirFrmConversao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirFrmConversao.Location = new System.Drawing.Point(12, 369);
            this.btnAbrirFrmConversao.Name = "btnAbrirFrmConversao";
            this.btnAbrirFrmConversao.Size = new System.Drawing.Size(600, 36);
            this.btnAbrirFrmConversao.TabIndex = 1;
            this.btnAbrirFrmConversao.Text = "Faça uma conversão clicando aqui";
            this.btnAbrirFrmConversao.UseVisualStyleBackColor = true;
            this.btnAbrirFrmConversao.Click += new System.EventHandler(this.btnAbrirFrmConversao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Histórico de conversões";
            // 
            // gridViewConversoes
            // 
            this.gridViewConversoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewConversoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnDecimais,
            this.clnRomanos});
            this.gridViewConversoes.Location = new System.Drawing.Point(12, 32);
            this.gridViewConversoes.Name = "gridViewConversoes";
            this.gridViewConversoes.Size = new System.Drawing.Size(600, 331);
            this.gridViewConversoes.TabIndex = 4;
            // 
            // clnDecimais
            // 
            this.clnDecimais.HeaderText = "Decimais";
            this.clnDecimais.Name = "clnDecimais";
            // 
            // clnRomanos
            // 
            this.clnRomanos.HeaderText = "Romanos";
            this.clnRomanos.Name = "clnRomanos";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(624, 423);
            this.Controls.Add(this.gridViewConversoes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbrirFrmConversao);
            this.Name = "frmPrincipal";
            this.Text = "Conversor de Números Romanos/Decimais";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConversoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirFrmConversao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridViewConversoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDecimais;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRomanos;
    }
}

