namespace ControleVendas
{
    partial class IncluirProdutoNota
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
            this.bSalvar = new System.Windows.Forms.Button();
            this.bFechar = new System.Windows.Forms.Button();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.labelUnitario = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.textBoxUnitario = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bSalvar
            // 
            this.bSalvar.AutoSize = true;
            this.bSalvar.Location = new System.Drawing.Point(89, 219);
            this.bSalvar.Name = "bSalvar";
            this.bSalvar.Size = new System.Drawing.Size(75, 23);
            this.bSalvar.TabIndex = 6;
            this.bSalvar.Text = "&Salvar";
            this.bSalvar.UseVisualStyleBackColor = true;
            this.bSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bFechar
            // 
            this.bFechar.Location = new System.Drawing.Point(200, 219);
            this.bFechar.Name = "bFechar";
            this.bFechar.Size = new System.Drawing.Size(75, 23);
            this.bFechar.TabIndex = 7;
            this.bFechar.Text = "&Fechar";
            this.bFechar.UseVisualStyleBackColor = true;
            this.bFechar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(30, 40);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 2;
            this.labelCodigo.Text = "Código";
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Location = new System.Drawing.Point(30, 96);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(62, 13);
            this.labelQuantidade.TabIndex = 3;
            this.labelQuantidade.Text = "Quantidade";
            // 
            // labelUnitario
            // 
            this.labelUnitario.AutoSize = true;
            this.labelUnitario.Location = new System.Drawing.Point(30, 121);
            this.labelUnitario.Name = "labelUnitario";
            this.labelUnitario.Size = new System.Drawing.Size(70, 13);
            this.labelUnitario.TabIndex = 4;
            this.labelUnitario.Text = "Valor Unitário";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(30, 149);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(58, 13);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Valor Total";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(102, 33);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 1;
            this.textBoxCodigo.TextChanged += new System.EventHandler(this.textBoxCodigo_TextChanged);
            this.textBoxCodigo.Leave += new System.EventHandler(this.textBoxCodigo_Leave);
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(102, 89);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantidade.TabIndex = 3;
            this.textBoxQuantidade.Leave += new System.EventHandler(this.textBoxQuantidade_Leave);
            // 
            // textBoxUnitario
            // 
            this.textBoxUnitario.Location = new System.Drawing.Point(102, 118);
            this.textBoxUnitario.Name = "textBoxUnitario";
            this.textBoxUnitario.Size = new System.Drawing.Size(100, 20);
            this.textBoxUnitario.TabIndex = 4;
            this.textBoxUnitario.Leave += new System.EventHandler(this.textBoxUnitario_Leave);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(102, 149);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 5;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(102, 63);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(221, 20);
            this.textBoxDescricao.TabIndex = 2;
            this.textBoxDescricao.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(30, 66);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(55, 13);
            this.labelDescricao.TabIndex = 11;
            this.labelDescricao.Text = "Descrição";
            // 
            // IncluirProdutoNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 266);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxUnitario);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelUnitario);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.bFechar);
            this.Controls.Add(this.bSalvar);
            this.Name = "IncluirProdutoNota";
            this.Text = "IncluirProdutoNota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSalvar;
        private System.Windows.Forms.Button bFechar;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.Label labelUnitario;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.TextBox textBoxUnitario;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label labelDescricao;
    }
}