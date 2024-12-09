namespace Trabalho_Leo
{
    partial class Procurar_Vendedor
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private TextBox txt_idProcurar;
        private Button btn_confirmar;
        private Button btn_cancelar;

        private void InitializeComponent()
        {
            label1 = new Label();
            txt_idProcurar = new TextBox();
            btn_confirmar = new Button();
            btn_cancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "ID do Vendedor:";
            // 
            // txt_idProcurar
            // 
            txt_idProcurar.Location = new Point(130, 18);
            txt_idProcurar.Name = "txt_idProcurar";
            txt_idProcurar.Size = new Size(200, 27);
            txt_idProcurar.TabIndex = 1;
            // 
            // btn_confirmar
            // 
            btn_confirmar.Location = new Point(50, 70);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(100, 30);
            btn_confirmar.TabIndex = 2;
            btn_confirmar.Text = "Confirmar";
            btn_confirmar.Click += btn_confirmar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(200, 70);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(100, 30);
            btn_cancelar.TabIndex = 3;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // Procurar_Vendedor
            // 
            ClientSize = new Size(400, 120);
            Controls.Add(label1);
            Controls.Add(txt_idProcurar);
            Controls.Add(btn_confirmar);
            Controls.Add(btn_cancelar);
            Name = "Procurar_Vendedor";
            Text = "Procurar Vendedor";
            Load += Procurar_Vendedor_Load_2;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
