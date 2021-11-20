namespace _3C1felipe10
{
    partial class EPA
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_cad = new System.Windows.Forms.Button();
            this.btn_alt = new System.Windows.Forms.Button();
            this.btn_exc = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtproduto = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_produto = new System.Windows.Forms.Label();
            this.lbl_preco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cad
            // 
            this.btn_cad.Location = new System.Drawing.Point(15, 147);
            this.btn_cad.Name = "btn_cad";
            this.btn_cad.Size = new System.Drawing.Size(75, 23);
            this.btn_cad.TabIndex = 0;
            this.btn_cad.Text = "Cadastra";
            this.btn_cad.UseVisualStyleBackColor = true;
            this.btn_cad.Click += new System.EventHandler(this.btn_cad_Click);
            // 
            // btn_alt
            // 
            this.btn_alt.Location = new System.Drawing.Point(111, 147);
            this.btn_alt.Name = "btn_alt";
            this.btn_alt.Size = new System.Drawing.Size(75, 23);
            this.btn_alt.TabIndex = 1;
            this.btn_alt.Text = "Alterar";
            this.btn_alt.UseVisualStyleBackColor = true;
            this.btn_alt.Click += new System.EventHandler(this.btn_alt_Click);
            // 
            // btn_exc
            // 
            this.btn_exc.Location = new System.Drawing.Point(219, 147);
            this.btn_exc.Name = "btn_exc";
            this.btn_exc.Size = new System.Drawing.Size(75, 23);
            this.btn_exc.TabIndex = 2;
            this.btn_exc.Text = "Excluir";
            this.btn_exc.UseVisualStyleBackColor = true;
            this.btn_exc.Click += new System.EventHandler(this.btn_exc_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(-7, 230);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(795, 150);
            this.dataGrid.TabIndex = 3;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(111, 29);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 4;
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(111, 96);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(100, 20);
            this.txtpreco.TabIndex = 5;
            // 
            // txtproduto
            // 
            this.txtproduto.Location = new System.Drawing.Point(111, 61);
            this.txtproduto.Name = "txtproduto";
            this.txtproduto.Size = new System.Drawing.Size(100, 20);
            this.txtproduto.TabIndex = 6;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(12, 29);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 7;
            this.lbl_id.Text = "ID";
            // 
            // lbl_produto
            // 
            this.lbl_produto.AutoSize = true;
            this.lbl_produto.Location = new System.Drawing.Point(12, 61);
            this.lbl_produto.Name = "lbl_produto";
            this.lbl_produto.Size = new System.Drawing.Size(43, 13);
            this.lbl_produto.TabIndex = 8;
            this.lbl_produto.Text = "produto";
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(12, 103);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(34, 13);
            this.lbl_preco.TabIndex = 9;
            this.lbl_preco.Text = "preco";
            // 
            // EPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.lbl_produto);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txtproduto);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btn_exc);
            this.Controls.Add(this.btn_alt);
            this.Controls.Add(this.btn_cad);
            this.Name = "EPA";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cad;
        private System.Windows.Forms.Button btn_alt;
        private System.Windows.Forms.Button btn_exc;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtproduto;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_produto;
        private System.Windows.Forms.Label lbl_preco;
    }
}

