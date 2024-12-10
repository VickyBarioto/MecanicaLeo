namespace Trabalho_Leo
{
    partial class Procurar_Produto
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
            txt_idProcurarProduto = new TextBox();
            btn_confirmarBuscaProduto = new Button();
            btn_cancelarBuscaProduto = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 4;
            label1.Text = "ID do Produto:";
            // 
            // txt_idProcurarProduto
            // 
            txt_idProcurarProduto.Location = new Point(122, 7);
            txt_idProcurarProduto.Name = "txt_idProcurarProduto";
            txt_idProcurarProduto.Size = new Size(200, 23);
            txt_idProcurarProduto.TabIndex = 5;
            // 
            // btn_confirmarBuscaProduto
            // 
            btn_confirmarBuscaProduto.Location = new Point(42, 59);
            btn_confirmarBuscaProduto.Name = "btn_confirmarBuscaProduto";
            btn_confirmarBuscaProduto.Size = new Size(100, 30);
            btn_confirmarBuscaProduto.TabIndex = 6;
            btn_confirmarBuscaProduto.Text = "Confirmar";
            btn_confirmarBuscaProduto.Click += btn_confirmarBuscaProduto_Click;
            // 
            // btn_cancelarBuscaProduto
            // 
            btn_cancelarBuscaProduto.Location = new Point(192, 59);
            btn_cancelarBuscaProduto.Name = "btn_cancelarBuscaProduto";
            btn_cancelarBuscaProduto.Size = new Size(100, 30);
            btn_cancelarBuscaProduto.TabIndex = 7;
            btn_cancelarBuscaProduto.Text = "Cancelar";
            btn_cancelarBuscaProduto.Click += btn_cancelarBuscaProduto_Click;
            // 
            // Procurar_Produto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txt_idProcurarProduto);
            Controls.Add(btn_confirmarBuscaProduto);
            Controls.Add(btn_cancelarBuscaProduto);
            Name = "Procurar_Produto";
            Text = "Procurar_Produto";
            Load += Procurar_Produto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_idProcurarProduto;
        private Button btn_confirmarBuscaProduto;
        private Button btn_cancelarBuscaProduto;
    }
}