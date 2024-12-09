namespace Trabalho_Leo
{
    partial class Vendedor
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
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txt_id = new TextBox();
            txt_Senha = new TextBox();
            txt_nomevendedor = new TextBox();
            txt_enderecovendedor = new TextBox();
            txt_bairrovendedor = new TextBox();
            txt_cepvendedor = new TextBox();
            txt_cidadevendedor = new TextBox();
            txt_estadovendedor = new TextBox();
            txt_telefonevendedor = new TextBox();
            txt_admissaovendedor = new TextBox();
            lbl_numeroendereco = new Label();
            txt_numeroendereco = new TextBox();
            txt_afastamentovendedor = new TextBox();
            label11 = new Label();
            txt_cargovendedor = new TextBox();
            label12 = new Label();
            txt_emailvendedor = new TextBox();
            label13 = new Label();
            btn_inserirvendedor = new Button();
            btn_procurarvendedor = new Button();
            btn_atualizarvendedor = new Button();
            btn_deletarvendedor = new Button();
            btn_SairTelaInicio = new Button();
            label14 = new Label();
            cbb_nivelvendedor = new ComboBox();
            txt_cpfvendedor = new TextBox();
            label15 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 14);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 37);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 14);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 88);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Endereço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 114);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 4;
            label5.Text = "Bairro:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 140);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 5;
            label6.Text = "Cidade:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 162);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 6;
            label7.Text = "Telefone:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(321, 114);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 7;
            label8.Text = "CEP:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(304, 140);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 8;
            label9.Text = "Estado:";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(286, 162);
            label10.Name = "label10";
            label10.Size = new Size(105, 15);
            label10.TabIndex = 9;
            label10.Text = "Data de Admissão:";
            label10.Click += label10_Click;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(75, 12);
            txt_id.Margin = new Padding(3, 2, 3, 2);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(81, 23);
            txt_id.TabIndex = 0;
            txt_id.TextChanged += txt_id_TextChanged;
            // 
            // txt_Senha
            // 
            txt_Senha.Location = new Point(212, 12);
            txt_Senha.Margin = new Padding(3, 2, 3, 2);
            txt_Senha.MaxLength = 100;
            txt_Senha.Name = "txt_Senha";
            txt_Senha.PasswordChar = '*';
            txt_Senha.Size = new Size(335, 23);
            txt_Senha.TabIndex = 1;
            txt_Senha.TextChanged += txt_Senha_TextChanged;
            // 
            // txt_nomevendedor
            // 
            txt_nomevendedor.Location = new Point(75, 37);
            txt_nomevendedor.Margin = new Padding(3, 2, 3, 2);
            txt_nomevendedor.Name = "txt_nomevendedor";
            txt_nomevendedor.Size = new Size(586, 23);
            txt_nomevendedor.TabIndex = 2;
            txt_nomevendedor.TextChanged += txt_nomevendedor_TextChanged;
            // 
            // txt_enderecovendedor
            // 
            txt_enderecovendedor.Location = new Point(75, 88);
            txt_enderecovendedor.Margin = new Padding(3, 2, 3, 2);
            txt_enderecovendedor.Name = "txt_enderecovendedor";
            txt_enderecovendedor.Size = new Size(471, 23);
            txt_enderecovendedor.TabIndex = 3;
            txt_enderecovendedor.TextChanged += txt_enderecovendedor_TextChanged;
            // 
            // txt_bairrovendedor
            // 
            txt_bairrovendedor.Location = new Point(75, 112);
            txt_bairrovendedor.Margin = new Padding(3, 2, 3, 2);
            txt_bairrovendedor.Name = "txt_bairrovendedor";
            txt_bairrovendedor.Size = new Size(241, 23);
            txt_bairrovendedor.TabIndex = 5;
            txt_bairrovendedor.TextChanged += txt_bairrovendedor_TextChanged;
            // 
            // txt_cepvendedor
            // 
            txt_cepvendedor.Location = new Point(359, 112);
            txt_cepvendedor.Margin = new Padding(3, 2, 3, 2);
            txt_cepvendedor.Name = "txt_cepvendedor";
            txt_cepvendedor.Size = new Size(302, 23);
            txt_cepvendedor.TabIndex = 6;
            txt_cepvendedor.TextChanged += txt_cepvendedor_TextChanged;
            // 
            // txt_cidadevendedor
            // 
            txt_cidadevendedor.Location = new Point(75, 135);
            txt_cidadevendedor.Margin = new Padding(3, 2, 3, 2);
            txt_cidadevendedor.Name = "txt_cidadevendedor";
            txt_cidadevendedor.Size = new Size(224, 23);
            txt_cidadevendedor.TabIndex = 7;
            txt_cidadevendedor.TextChanged += txt_cidadevendedor_TextChanged;
            // 
            // txt_estadovendedor
            // 
            txt_estadovendedor.Location = new Point(359, 136);
            txt_estadovendedor.Margin = new Padding(3, 2, 3, 2);
            txt_estadovendedor.Name = "txt_estadovendedor";
            txt_estadovendedor.Size = new Size(302, 23);
            txt_estadovendedor.TabIndex = 8;
            txt_estadovendedor.TextChanged += txt_estadovendedor_TextChanged;
            // 
            // txt_telefonevendedor
            // 
            txt_telefonevendedor.Location = new Point(75, 160);
            txt_telefonevendedor.Margin = new Padding(3, 2, 3, 2);
            txt_telefonevendedor.Name = "txt_telefonevendedor";
            txt_telefonevendedor.Size = new Size(206, 23);
            txt_telefonevendedor.TabIndex = 9;
            txt_telefonevendedor.TextChanged += txt_telefonevendedor_TextChanged;
            // 
            // txt_admissaovendedor
            // 
            txt_admissaovendedor.Location = new Point(409, 160);
            txt_admissaovendedor.Margin = new Padding(3, 2, 3, 2);
            txt_admissaovendedor.Name = "txt_admissaovendedor";
            txt_admissaovendedor.Size = new Size(252, 23);
            txt_admissaovendedor.TabIndex = 10;
            txt_admissaovendedor.TextChanged += txt_admissaovendedor_TextChanged;
            // 
            // lbl_numeroendereco
            // 
            lbl_numeroendereco.AutoSize = true;
            lbl_numeroendereco.Location = new Point(551, 90);
            lbl_numeroendereco.Name = "lbl_numeroendereco";
            lbl_numeroendereco.Size = new Size(24, 15);
            lbl_numeroendereco.TabIndex = 20;
            lbl_numeroendereco.Text = "N°:";
            // 
            // txt_numeroendereco
            // 
            txt_numeroendereco.Location = new Point(580, 87);
            txt_numeroendereco.Margin = new Padding(3, 2, 3, 2);
            txt_numeroendereco.Name = "txt_numeroendereco";
            txt_numeroendereco.Size = new Size(81, 23);
            txt_numeroendereco.TabIndex = 4;
            txt_numeroendereco.TextChanged += txt_numeroendereco_TextChanged;
            // 
            // txt_afastamentovendedor
            // 
            txt_afastamentovendedor.Location = new Point(409, 185);
            txt_afastamentovendedor.Margin = new Padding(3, 2, 3, 2);
            txt_afastamentovendedor.Name = "txt_afastamentovendedor";
            txt_afastamentovendedor.Size = new Size(252, 23);
            txt_afastamentovendedor.TabIndex = 12;
            txt_afastamentovendedor.TextChanged += txt_afastamentovendedor_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(269, 187);
            label11.Name = "label11";
            label11.Size = new Size(121, 15);
            label11.TabIndex = 22;
            label11.Text = "Data de Afastamento:";
            // 
            // txt_cargovendedor
            // 
            txt_cargovendedor.Location = new Point(75, 184);
            txt_cargovendedor.Margin = new Padding(3, 2, 3, 2);
            txt_cargovendedor.Name = "txt_cargovendedor";
            txt_cargovendedor.Size = new Size(189, 23);
            txt_cargovendedor.TabIndex = 11;
            txt_cargovendedor.TextChanged += txt_cargovendedor_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(24, 185);
            label12.Name = "label12";
            label12.Size = new Size(42, 15);
            label12.TabIndex = 24;
            label12.Text = "Cargo:";
            // 
            // txt_emailvendedor
            // 
            txt_emailvendedor.Location = new Point(74, 209);
            txt_emailvendedor.Margin = new Padding(3, 2, 3, 2);
            txt_emailvendedor.Name = "txt_emailvendedor";
            txt_emailvendedor.Size = new Size(587, 23);
            txt_emailvendedor.TabIndex = 13;
            txt_emailvendedor.TextChanged += txt_emailvendedor_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(22, 209);
            label13.Name = "label13";
            label13.Size = new Size(44, 15);
            label13.TabIndex = 26;
            label13.Text = "E-mail:";
            // 
            // btn_inserirvendedor
            // 
            btn_inserirvendedor.Location = new Point(5, 253);
            btn_inserirvendedor.Margin = new Padding(3, 2, 3, 2);
            btn_inserirvendedor.Name = "btn_inserirvendedor";
            btn_inserirvendedor.Size = new Size(82, 22);
            btn_inserirvendedor.TabIndex = 27;
            btn_inserirvendedor.Text = "INSERIR";
            btn_inserirvendedor.UseVisualStyleBackColor = true;
            btn_inserirvendedor.Click += btn_inserirvendedor_Click;
            // 
            // btn_procurarvendedor
            // 
            btn_procurarvendedor.Location = new Point(101, 253);
            btn_procurarvendedor.Margin = new Padding(3, 2, 3, 2);
            btn_procurarvendedor.Name = "btn_procurarvendedor";
            btn_procurarvendedor.Size = new Size(82, 22);
            btn_procurarvendedor.TabIndex = 28;
            btn_procurarvendedor.Text = "PROCURAR";
            btn_procurarvendedor.UseVisualStyleBackColor = true;
            btn_procurarvendedor.Click += btn_procurarvendedor_Click;
            // 
            // btn_atualizarvendedor
            // 
            btn_atualizarvendedor.Location = new Point(199, 253);
            btn_atualizarvendedor.Margin = new Padding(3, 2, 3, 2);
            btn_atualizarvendedor.Name = "btn_atualizarvendedor";
            btn_atualizarvendedor.Size = new Size(82, 22);
            btn_atualizarvendedor.TabIndex = 29;
            btn_atualizarvendedor.Text = "ATUALIZAR";
            btn_atualizarvendedor.UseVisualStyleBackColor = true;
            btn_atualizarvendedor.Click += btn_atualizarvendedor_Click;
            // 
            // btn_deletarvendedor
            // 
            btn_deletarvendedor.Location = new Point(286, 253);
            btn_deletarvendedor.Margin = new Padding(3, 2, 3, 2);
            btn_deletarvendedor.Name = "btn_deletarvendedor";
            btn_deletarvendedor.Size = new Size(82, 22);
            btn_deletarvendedor.TabIndex = 30;
            btn_deletarvendedor.Text = "DELETAR";
            btn_deletarvendedor.UseVisualStyleBackColor = true;
            btn_deletarvendedor.Click += btn_deletarvendedor_Click;
            // 
            // btn_SairTelaInicio
            // 
            btn_SairTelaInicio.Location = new Point(578, 253);
            btn_SairTelaInicio.Margin = new Padding(3, 2, 3, 2);
            btn_SairTelaInicio.Name = "btn_SairTelaInicio";
            btn_SairTelaInicio.Size = new Size(82, 22);
            btn_SairTelaInicio.TabIndex = 31;
            btn_SairTelaInicio.Text = "SAIR";
            btn_SairTelaInicio.UseVisualStyleBackColor = true;
            btn_SairTelaInicio.Click += btn_SairTelaInicio_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(551, 14);
            label14.Name = "label14";
            label14.Size = new Size(37, 15);
            label14.TabIndex = 32;
            label14.Text = "Nível:";
            // 
            // cbb_nivelvendedor
            // 
            cbb_nivelvendedor.FormattingEnabled = true;
            cbb_nivelvendedor.Location = new Point(597, 11);
            cbb_nivelvendedor.Margin = new Padding(3, 2, 3, 2);
            cbb_nivelvendedor.Name = "cbb_nivelvendedor";
            cbb_nivelvendedor.Size = new Size(64, 23);
            cbb_nivelvendedor.TabIndex = 33;
            cbb_nivelvendedor.SelectedIndexChanged += cbb_nivelvendedor_SelectedIndexChanged;
            // 
            // txt_cpfvendedor
            // 
            txt_cpfvendedor.Location = new Point(74, 61);
            txt_cpfvendedor.Margin = new Padding(3, 2, 3, 2);
            txt_cpfvendedor.Name = "txt_cpfvendedor";
            txt_cpfvendedor.Size = new Size(587, 23);
            txt_cpfvendedor.TabIndex = 34;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(24, 61);
            label15.Name = "label15";
            label15.Size = new Size(31, 15);
            label15.TabIndex = 35;
            label15.Text = "CPF:";
            // 
            // Vendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label15);
            Controls.Add(txt_cpfvendedor);
            Controls.Add(cbb_nivelvendedor);
            Controls.Add(label14);
            Controls.Add(btn_SairTelaInicio);
            Controls.Add(btn_deletarvendedor);
            Controls.Add(btn_atualizarvendedor);
            Controls.Add(btn_procurarvendedor);
            Controls.Add(btn_inserirvendedor);
            Controls.Add(txt_emailvendedor);
            Controls.Add(label13);
            Controls.Add(txt_cargovendedor);
            Controls.Add(label12);
            Controls.Add(txt_afastamentovendedor);
            Controls.Add(label11);
            Controls.Add(txt_numeroendereco);
            Controls.Add(lbl_numeroendereco);
            Controls.Add(txt_admissaovendedor);
            Controls.Add(txt_telefonevendedor);
            Controls.Add(txt_estadovendedor);
            Controls.Add(txt_cidadevendedor);
            Controls.Add(txt_cepvendedor);
            Controls.Add(txt_bairrovendedor);
            Controls.Add(txt_enderecovendedor);
            Controls.Add(txt_nomevendedor);
            Controls.Add(txt_Senha);
            Controls.Add(txt_id);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Vendedor";
            Text = "Vendedor";
            Load += Vendedor_Load;
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
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txt_id;
        private TextBox txt_Senha;
        private TextBox txt_nomevendedor;
        private TextBox txt_enderecovendedor;
        private TextBox txt_bairrovendedor;
        private TextBox txt_cepvendedor;
        private TextBox txt_cidadevendedor;
        private TextBox txt_estadovendedor;
        private TextBox txt_telefonevendedor;
        private TextBox txt_admissaovendedor;
        private Label lbl_numeroendereco;
        private TextBox txt_numeroendereco;
        private TextBox txt_afastamentovendedor;
        private Label label11;
        private TextBox txt_cargovendedor;
        private Label label12;
        private TextBox txt_emailvendedor;
        private Label label13;
        private Button btn_inserirvendedor;
        private Button btn_procurarvendedor;
        private Button btn_atualizarvendedor;
        private Button btn_deletarvendedor;
        private Button btn_SairTelaInicio;
        private Label label14;
        private ComboBox cbb_nivelvendedor;
        private TextBox txt_cpfvendedor;
        private Label label15;
    }
}