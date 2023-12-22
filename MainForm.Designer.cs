namespace EuclidesPedidos
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ExitButton = new Button();
            ClientesButton = new Button();
            PedidosButton = new Button();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ExitButton.Image = Properties.Resources.btnExit_192x192;
            ExitButton.Location = new Point(596, 12);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(192, 192);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "Salir";
            ExitButton.TextAlign = ContentAlignment.BottomCenter;
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ClientesButton
            // 
            ClientesButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ClientesButton.Image = Properties.Resources.btnCustomers;
            ClientesButton.Location = new Point(12, 12);
            ClientesButton.Name = "ClientesButton";
            ClientesButton.Size = new Size(192, 192);
            ClientesButton.TabIndex = 1;
            ClientesButton.Text = "Clientes";
            ClientesButton.TextAlign = ContentAlignment.BottomCenter;
            ClientesButton.UseVisualStyleBackColor = true;
            ClientesButton.Click += ClientesButton_Click;
            // 
            // PedidosButton
            // 
            PedidosButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PedidosButton.Image = Properties.Resources.btnSaleProjects_192x192;
            PedidosButton.Location = new Point(210, 12);
            PedidosButton.Name = "PedidosButton";
            PedidosButton.Size = new Size(192, 192);
            PedidosButton.TabIndex = 2;
            PedidosButton.Text = "Pedidos";
            PedidosButton.TextAlign = ContentAlignment.BottomCenter;
            PedidosButton.UseVisualStyleBackColor = true;
            PedidosButton.Click += PedidosButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(PedidosButton);
            Controls.Add(ClientesButton);
            Controls.Add(ExitButton);
            Name = "MainForm";
            Text = "Euclides Pedidos";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button ExitButton;
        private Button ClientesButton;
        private Button PedidosButton;
    }
}
