namespace Crud
{
    partial class Form1
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
            this.tablefornecedor = new System.Windows.Forms.DataGridView();
            this.txtcnpj = new System.Windows.Forms.TextBox();
            this.txtrazao = new System.Windows.Forms.TextBox();
            this.txtend = new System.Windows.Forms.TextBox();
            this.txtfantasia = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtins = new System.Windows.Forms.TextBox();
            this.btnnovo = new System.Windows.Forms.Button();
            this.btnprodutos = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbusca = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablefornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // tablefornecedor
            // 
            this.tablefornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablefornecedor.Location = new System.Drawing.Point(32, 145);
            this.tablefornecedor.Name = "tablefornecedor";
            this.tablefornecedor.Size = new System.Drawing.Size(742, 282);
            this.tablefornecedor.TabIndex = 0;
            this.tablefornecedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablefornecedor_CellContentClick);
            // 
            // txtcnpj
            // 
            this.txtcnpj.Location = new System.Drawing.Point(32, 32);
            this.txtcnpj.Name = "txtcnpj";
            this.txtcnpj.Size = new System.Drawing.Size(100, 20);
            this.txtcnpj.TabIndex = 1;
            this.txtcnpj.TextChanged += new System.EventHandler(this.txtcnpj_TextChanged);
            // 
            // txtrazao
            // 
            this.txtrazao.Location = new System.Drawing.Point(171, 32);
            this.txtrazao.Name = "txtrazao";
            this.txtrazao.Size = new System.Drawing.Size(100, 20);
            this.txtrazao.TabIndex = 2;
            this.txtrazao.TextChanged += new System.EventHandler(this.txtrazao_TextChanged);
            // 
            // txtend
            // 
            this.txtend.Location = new System.Drawing.Point(306, 32);
            this.txtend.Name = "txtend";
            this.txtend.Size = new System.Drawing.Size(100, 20);
            this.txtend.TabIndex = 3;
            this.txtend.TextChanged += new System.EventHandler(this.txtend_TextChanged);
            // 
            // txtfantasia
            // 
            this.txtfantasia.Location = new System.Drawing.Point(434, 32);
            this.txtfantasia.Name = "txtfantasia";
            this.txtfantasia.Size = new System.Drawing.Size(100, 20);
            this.txtfantasia.TabIndex = 4;
            this.txtfantasia.TextChanged += new System.EventHandler(this.txtfantasia_TextChanged);
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(560, 32);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 20);
            this.txttel.TabIndex = 5;
            this.txttel.TextChanged += new System.EventHandler(this.txttel_TextChanged);
            // 
            // txtins
            // 
            this.txtins.Location = new System.Drawing.Point(32, 85);
            this.txtins.Name = "txtins";
            this.txtins.Size = new System.Drawing.Size(100, 20);
            this.txtins.TabIndex = 6;
            this.txtins.TextChanged += new System.EventHandler(this.txtins_TextChanged);
            // 
            // btnnovo
            // 
            this.btnnovo.Location = new System.Drawing.Point(171, 85);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(75, 23);
            this.btnnovo.TabIndex = 7;
            this.btnnovo.Text = "novo";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // btnprodutos
            // 
            this.btnprodutos.Location = new System.Drawing.Point(699, 29);
            this.btnprodutos.Name = "btnprodutos";
            this.btnprodutos.Size = new System.Drawing.Size(75, 23);
            this.btnprodutos.TabIndex = 8;
            this.btnprodutos.Text = "produtos";
            this.btnprodutos.UseVisualStyleBackColor = true;
            this.btnprodutos.Click += new System.EventHandler(this.btnprodutos_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(252, 85);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 9;
            this.btnsalvar.Text = "salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "cnpj";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "razao social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "endereco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "famtasia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "tel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "ins";
            // 
            // txtbusca
            // 
            this.txtbusca.Location = new System.Drawing.Point(437, 85);
            this.txtbusca.Name = "txtbusca";
            this.txtbusca.Size = new System.Drawing.Size(100, 20);
            this.txtbusca.TabIndex = 16;
            this.txtbusca.TextChanged += new System.EventHandler(this.txtbusca_TextChanged);
            // 
            // buscar
            // 
            this.buscar.AutoSize = true;
            this.buscar.Location = new System.Drawing.Point(434, 66);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(124, 13);
            this.buscar.TabIndex = 17;
            this.buscar.Text = "buscar (COLOCAR O ID)";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(333, 85);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 18;
            this.btndelete.Text = "deleta";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.txtbusca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnprodutos);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.txtins);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtfantasia);
            this.Controls.Add(this.txtend);
            this.Controls.Add(this.txtrazao);
            this.Controls.Add(this.txtcnpj);
            this.Controls.Add(this.tablefornecedor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tablefornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablefornecedor;
        private System.Windows.Forms.TextBox txtcnpj;
        private System.Windows.Forms.TextBox txtrazao;
        private System.Windows.Forms.TextBox txtend;
        private System.Windows.Forms.TextBox txtfantasia;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtins;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnprodutos;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbusca;
        private System.Windows.Forms.Label buscar;
        private System.Windows.Forms.Button btndelete;
    }
}

