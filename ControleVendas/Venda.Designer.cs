namespace ControleVendas
{
    partial class Venda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxFornecedor = new System.Windows.Forms.TextBox();
            this.labelFornecedor = new System.Windows.Forms.Label();
            this.textBoxEmissao = new System.Windows.Forms.TextBox();
            this.labelDataEmissao = new System.Windows.Forms.Label();
            this.textBoxValorTotal = new System.Windows.Forms.TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.labelNumero = new System.Windows.Forms.Label();
            this.bSalvar = new System.Windows.Forms.Button();
            this.bFechar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(2, 125);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1125, 320);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Itens Vendidos";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Produto,
            this.Descricao,
            this.Quantidade,
            this.Unitario,
            this.Total});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(8, 42);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1104, 264);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;

            // 
            // Produto
            // 
            this.Produto.Text = "Produto";
            // 
            // Descricao
            // 
            this.Descricao.Text = "Descrição";
            this.Descricao.Width = 229;
            // 
            // Quantidade
            // 
            this.Quantidade.Text = "Quantidade";
            this.Quantidade.Width = 80;
            // 
            // Unitario
            // 
            this.Unitario.Text = "Valor Unitário";
            this.Unitario.Width = 93;
            // 
            // Total
            // 
            this.Total.Text = "Valor Total";
            this.Total.Width = 110;
            // 
            // textBoxFornecedor
            // 
            this.textBoxFornecedor.Location = new System.Drawing.Point(586, 34);
            this.textBoxFornecedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFornecedor.Name = "textBoxFornecedor";
            this.textBoxFornecedor.Size = new System.Drawing.Size(494, 26);
            this.textBoxFornecedor.TabIndex = 13;
            // 
            // labelFornecedor
            // 
            this.labelFornecedor.AutoSize = true;
            this.labelFornecedor.Location = new System.Drawing.Point(520, 37);
            this.labelFornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFornecedor.Name = "labelFornecedor";
            this.labelFornecedor.Size = new System.Drawing.Size(58, 20);
            this.labelFornecedor.TabIndex = 8;
            this.labelFornecedor.Text = "Cliente";
            // 
            // textBoxEmissao
            // 
            this.textBoxEmissao.Location = new System.Drawing.Point(332, 34);
            this.textBoxEmissao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmissao.Name = "textBoxEmissao";
            this.textBoxEmissao.Size = new System.Drawing.Size(148, 26);
            this.textBoxEmissao.TabIndex = 9;
            this.textBoxEmissao.TextChanged += new System.EventHandler(this.textBoxEmissao_TextChanged);
            // 
            // labelDataEmissao
            // 
            this.labelDataEmissao.AutoSize = true;
            this.labelDataEmissao.Location = new System.Drawing.Point(219, 42);
            this.labelDataEmissao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataEmissao.Name = "labelDataEmissao";
            this.labelDataEmissao.Size = new System.Drawing.Size(109, 20);
            this.labelDataEmissao.TabIndex = 10;
            this.labelDataEmissao.Text = "Data Emissão";
            // 
            // textBoxValorTotal
            // 
            this.textBoxValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorTotal.Location = new System.Drawing.Point(350, 455);
            this.textBoxValorTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxValorTotal.Name = "textBoxValorTotal";
            this.textBoxValorTotal.ReadOnly = true;
            this.textBoxValorTotal.Size = new System.Drawing.Size(148, 35);
            this.textBoxValorTotal.TabIndex = 14;
            this.textBoxValorTotal.TabStop = false;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.Location = new System.Drawing.Point(198, 458);
            this.labelValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(144, 29);
            this.labelValor.TabIndex = 11;
            this.labelValor.Text = "Valor Venda";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(62, 34);
            this.textBoxNumero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(148, 26);
            this.textBoxNumero.TabIndex = 7;
            this.textBoxNumero.TextChanged += new System.EventHandler(this.textBoxNumero_TextChanged);
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(0, 39);
            this.labelNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(65, 20);
            this.labelNumero.TabIndex = 12;
            this.labelNumero.Text = "Numero";
            this.labelNumero.Click += new System.EventHandler(this.labelNumero_Click);
            // 
            // bSalvar
            // 
            this.bSalvar.Location = new System.Drawing.Point(341, 527);
            this.bSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSalvar.Name = "bSalvar";
            this.bSalvar.Size = new System.Drawing.Size(112, 35);
            this.bSalvar.TabIndex = 16;
            this.bSalvar.Text = "&Salva";
            this.bSalvar.UseVisualStyleBackColor = true;
            // 
            // bFechar
            // 
            this.bFechar.Location = new System.Drawing.Point(492, 527);
            this.bFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bFechar.Name = "bFechar";
            this.bFechar.Size = new System.Drawing.Size(112, 35);
            this.bFechar.TabIndex = 17;
            this.bFechar.Text = "&Fechar";
            this.bFechar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Adicionar Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 576);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxFornecedor);
            this.Controls.Add(this.labelFornecedor);
            this.Controls.Add(this.textBoxEmissao);
            this.Controls.Add(this.labelDataEmissao);
            this.Controls.Add(this.textBoxValorTotal);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.bSalvar);
            this.Controls.Add(this.bFechar);
            this.Name = "Venda";
            this.Text = "Venda";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ColumnHeader Produto;
        public System.Windows.Forms.ColumnHeader Descricao;
        public System.Windows.Forms.ColumnHeader Quantidade;
        public System.Windows.Forms.ColumnHeader Unitario;
        public System.Windows.Forms.ColumnHeader Total;
        public System.Windows.Forms.TextBox textBoxFornecedor;
        public System.Windows.Forms.Label labelFornecedor;
        public System.Windows.Forms.TextBox textBoxEmissao;
        public System.Windows.Forms.Label labelDataEmissao;
        public System.Windows.Forms.TextBox textBoxValorTotal;
        public System.Windows.Forms.Label labelValor;
        public System.Windows.Forms.TextBox textBoxNumero;
        public System.Windows.Forms.Label labelNumero;
        public System.Windows.Forms.Button bSalvar;
        public System.Windows.Forms.Button bFechar;
        public System.Windows.Forms.Button button1;
    }
}