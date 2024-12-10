namespace Trabalho_Leo
{
    partial class Procurar_Cliente
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
            txt_idProcurarCliente = new TextBox();
            btn_confirmarBuscaCliente = new Button();
            btn_cancelarBuscaCliente = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 27);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 8;
            label1.Text = "ID do Cliente:";
            // 
            // txt_idProcurarCliente
            // 
            txt_idProcurarCliente.Location = new Point(149, 25);
            txt_idProcurarCliente.Name = "txt_idProcurarCliente";
            txt_idProcurarCliente.Size = new Size(200, 23);
            txt_idProcurarCliente.TabIndex = 9;
            // 
            // btn_confirmarBuscaCliente
            // 
            btn_confirmarBuscaCliente.Location = new Point(69, 77);
            btn_confirmarBuscaCliente.Name = "btn_confirmarBuscaCliente";
            btn_confirmarBuscaCliente.Size = new Size(100, 30);
            btn_confirmarBuscaCliente.TabIndex = 10;
            btn_confirmarBuscaCliente.Text = "Confirmar";
            btn_confirmarBuscaCliente.Click += btn_confirmarBuscaCliente_Click;
            // 
            // btn_cancelarBuscaCliente
            // 
            btn_cancelarBuscaCliente.Location = new Point(249, 77);
            btn_cancelarBuscaCliente.Name = "btn_cancelarBuscaCliente";
            btn_cancelarBuscaCliente.Size = new Size(100, 30);
            btn_cancelarBuscaCliente.TabIndex = 11;
            btn_cancelarBuscaCliente.Text = "Cancelar";
            btn_cancelarBuscaCliente.Click += btn_cancelarBuscaCliente_Click;
            // 
            // Procurar_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 135);
            Controls.Add(label1);
            Controls.Add(txt_idProcurarCliente);
            Controls.Add(btn_confirmarBuscaCliente);
            Controls.Add(btn_cancelarBuscaCliente);
            Name = "Procurar_Cliente";
            Text = "Procurar_Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_idProcurarCliente;
        private Button btn_confirmarBuscaCliente;
        private Button btn_cancelarBuscaCliente;
    }
}