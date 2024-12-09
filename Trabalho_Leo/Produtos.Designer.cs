namespace Trabalho_Leo
{
    partial class Produtos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_nomeProduto = new TextBox();
            txt_marcaProduto = new TextBox();
            txt_modeloProduto = new TextBox();
            txt_anoProduto = new TextBox();
            txt_precoCompraProduto = new TextBox();
            txt_precoRevendaProduto = new TextBox();
            txt_fornecedorProduto = new TextBox();
            btn_sairproduto = new Button();
            btn_deletarproduto = new Button();
            btn_atualizarproduto = new Button();
            btn_procurarproduto = new Button();
            btn_inserirproduto = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 9);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(498, 9);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "Modelo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 55);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 3;
            label4.Text = "Ano";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(181, 55);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 4;
            label5.Text = "Preço de Compra";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(473, 55);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 5;
            label6.Text = "Preço de Revenda";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 98);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 6;
            label7.Text = "Fornecedor";
            // 
            // txt_nomeProduto
            // 
            txt_nomeProduto.Location = new Point(67, 6);
            txt_nomeProduto.Name = "txt_nomeProduto";
            txt_nomeProduto.Size = new Size(167, 23);
            txt_nomeProduto.TabIndex = 7;
            // 
            // txt_marcaProduto
            // 
            txt_marcaProduto.Location = new Point(286, 6);
            txt_marcaProduto.Name = "txt_marcaProduto";
            txt_marcaProduto.Size = new Size(206, 23);
            txt_marcaProduto.TabIndex = 8;
            // 
            // txt_modeloProduto
            // 
            txt_modeloProduto.Location = new Point(552, 6);
            txt_modeloProduto.Name = "txt_modeloProduto";
            txt_modeloProduto.Size = new Size(217, 23);
            txt_modeloProduto.TabIndex = 9;
            // 
            // txt_anoProduto
            // 
            txt_anoProduto.Location = new Point(67, 52);
            txt_anoProduto.Name = "txt_anoProduto";
            txt_anoProduto.Size = new Size(94, 23);
            txt_anoProduto.TabIndex = 10;
            // 
            // txt_precoCompraProduto
            // 
            txt_precoCompraProduto.Location = new Point(286, 52);
            txt_precoCompraProduto.Name = "txt_precoCompraProduto";
            txt_precoCompraProduto.Size = new Size(181, 23);
            txt_precoCompraProduto.TabIndex = 11;
            // 
            // txt_precoRevendaProduto
            // 
            txt_precoRevendaProduto.Location = new Point(580, 52);
            txt_precoRevendaProduto.Name = "txt_precoRevendaProduto";
            txt_precoRevendaProduto.Size = new Size(189, 23);
            txt_precoRevendaProduto.TabIndex = 12;
            // 
            // txt_fornecedorProduto
            // 
            txt_fornecedorProduto.Location = new Point(85, 95);
            txt_fornecedorProduto.Name = "txt_fornecedorProduto";
            txt_fornecedorProduto.Size = new Size(382, 23);
            txt_fornecedorProduto.TabIndex = 13;
            // 
            // btn_sairproduto
            // 
            btn_sairproduto.Location = new Point(606, 417);
            btn_sairproduto.Margin = new Padding(3, 2, 3, 2);
            btn_sairproduto.Name = "btn_sairproduto";
            btn_sairproduto.Size = new Size(82, 22);
            btn_sairproduto.TabIndex = 36;
            btn_sairproduto.Text = "SAIR";
            btn_sairproduto.UseVisualStyleBackColor = true;
            btn_sairproduto.Click += btn_sairproduto_Click;
            // 
            // btn_deletarproduto
            // 
            btn_deletarproduto.Location = new Point(314, 417);
            btn_deletarproduto.Margin = new Padding(3, 2, 3, 2);
            btn_deletarproduto.Name = "btn_deletarproduto";
            btn_deletarproduto.Size = new Size(82, 22);
            btn_deletarproduto.TabIndex = 35;
            btn_deletarproduto.Text = "DELETAR";
            btn_deletarproduto.UseVisualStyleBackColor = true;
            // 
            // btn_atualizarproduto
            // 
            btn_atualizarproduto.Location = new Point(227, 417);
            btn_atualizarproduto.Margin = new Padding(3, 2, 3, 2);
            btn_atualizarproduto.Name = "btn_atualizarproduto";
            btn_atualizarproduto.Size = new Size(82, 22);
            btn_atualizarproduto.TabIndex = 34;
            btn_atualizarproduto.Text = "ATUALIZAR";
            btn_atualizarproduto.UseVisualStyleBackColor = true;
            // 
            // btn_procurarproduto
            // 
            btn_procurarproduto.Location = new Point(129, 417);
            btn_procurarproduto.Margin = new Padding(3, 2, 3, 2);
            btn_procurarproduto.Name = "btn_procurarproduto";
            btn_procurarproduto.Size = new Size(82, 22);
            btn_procurarproduto.TabIndex = 33;
            btn_procurarproduto.Text = "PROCURAR";
            btn_procurarproduto.UseVisualStyleBackColor = true;
            // 
            // btn_inserirproduto
            // 
            btn_inserirproduto.Location = new Point(33, 417);
            btn_inserirproduto.Margin = new Padding(3, 2, 3, 2);
            btn_inserirproduto.Name = "btn_inserirproduto";
            btn_inserirproduto.Size = new Size(82, 22);
            btn_inserirproduto.TabIndex = 32;
            btn_inserirproduto.Text = "INSERIR";
            btn_inserirproduto.UseVisualStyleBackColor = true;
            btn_inserirproduto.Click += btn_inserirproduto_Click;
            // 
            // Produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_sairproduto);
            Controls.Add(btn_deletarproduto);
            Controls.Add(btn_atualizarproduto);
            Controls.Add(btn_procurarproduto);
            Controls.Add(btn_inserirproduto);
            Controls.Add(txt_fornecedorProduto);
            Controls.Add(txt_precoRevendaProduto);
            Controls.Add(txt_precoCompraProduto);
            Controls.Add(txt_anoProduto);
            Controls.Add(txt_modeloProduto);
            Controls.Add(txt_marcaProduto);
            Controls.Add(txt_nomeProduto);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Produtos";
            Text = "Produto";
            Load += Produtos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_nomeProduto;
        private TextBox txt_marcaProduto;
        private TextBox txt_modeloProduto;
        private TextBox txt_anoProduto;
        private TextBox txt_precoCompraProduto;
        private TextBox txt_precoRevendaProduto;
        private TextBox txt_fornecedorProduto;
        private Button btn_sairproduto;
        private Button btn_deletarproduto;
        private Button btn_atualizarproduto;
        private Button btn_procurarproduto;
        private Button btn_inserirproduto;
    }
}