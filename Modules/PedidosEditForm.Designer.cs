namespace EuclidesPedidos.Modules
{
    partial class PedidosEditForm
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
            MainStatusStrip = new StatusStrip();
            MainPanel = new Panel();
            ClienteGroupBox = new GroupBox();
            ClientesRFCTextBox = new TextBox();
            ClientesRFCLabel = new Label();
            ClientesNameTextBox = new TextBox();
            ClientesNameLabel = new Label();
            BuscarClienteButton = new Button();
            ClientesIDTextBox = new TextBox();
            ClientesIDLabel = new Label();
            PedidoGroupBox = new GroupBox();
            PedidosTotalTextBox = new TextBox();
            PedidosTotalLabel = new Label();
            PedidosIDTextBox = new TextBox();
            PedidosIDLabel = new Label();
            ButtonBar = new Panel();
            ExitDontSaveButton = new Button();
            ExitSaveButton = new Button();
            ExitButton = new Button();
            MainPanel.SuspendLayout();
            ClienteGroupBox.SuspendLayout();
            PedidoGroupBox.SuspendLayout();
            ButtonBar.SuspendLayout();
            SuspendLayout();
            // 
            // MainStatusStrip
            // 
            MainStatusStrip.ImageScalingSize = new Size(20, 20);
            MainStatusStrip.Location = new Point(0, 548);
            MainStatusStrip.Name = "MainStatusStrip";
            MainStatusStrip.Size = new Size(800, 22);
            MainStatusStrip.TabIndex = 1;
            MainStatusStrip.Text = "MainStatusStrip";
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.AppWorkspace;
            MainPanel.Controls.Add(ClienteGroupBox);
            MainPanel.Controls.Add(PedidoGroupBox);
            MainPanel.Controls.Add(ButtonBar);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(800, 548);
            MainPanel.TabIndex = 2;
            // 
            // ClienteGroupBox
            // 
            ClienteGroupBox.Controls.Add(ClientesRFCTextBox);
            ClienteGroupBox.Controls.Add(ClientesRFCLabel);
            ClienteGroupBox.Controls.Add(ClientesNameTextBox);
            ClienteGroupBox.Controls.Add(ClientesNameLabel);
            ClienteGroupBox.Controls.Add(BuscarClienteButton);
            ClienteGroupBox.Controls.Add(ClientesIDTextBox);
            ClienteGroupBox.Controls.Add(ClientesIDLabel);
            ClienteGroupBox.Location = new Point(12, 172);
            ClienteGroupBox.Name = "ClienteGroupBox";
            ClienteGroupBox.Size = new Size(740, 257);
            ClienteGroupBox.TabIndex = 9;
            ClienteGroupBox.TabStop = false;
            ClienteGroupBox.Text = "Cliente:";
            // 
            // ClientesRFCTextBox
            // 
            ClientesRFCTextBox.Location = new Point(12, 177);
            ClientesRFCTextBox.Name = "ClientesRFCTextBox";
            ClientesRFCTextBox.Size = new Size(215, 27);
            ClientesRFCTextBox.TabIndex = 14;
            // 
            // ClientesRFCLabel
            // 
            ClientesRFCLabel.AutoSize = true;
            ClientesRFCLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ClientesRFCLabel.Location = new Point(12, 154);
            ClientesRFCLabel.Name = "ClientesRFCLabel";
            ClientesRFCLabel.Size = new Size(47, 20);
            ClientesRFCLabel.TabIndex = 13;
            ClientesRFCLabel.Text = "R.F.C.";
            // 
            // ClientesNameTextBox
            // 
            ClientesNameTextBox.Location = new Point(12, 119);
            ClientesNameTextBox.Name = "ClientesNameTextBox";
            ClientesNameTextBox.Size = new Size(411, 27);
            ClientesNameTextBox.TabIndex = 12;
            // 
            // ClientesNameLabel
            // 
            ClientesNameLabel.AutoSize = true;
            ClientesNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ClientesNameLabel.Location = new Point(12, 96);
            ClientesNameLabel.Name = "ClientesNameLabel";
            ClientesNameLabel.Size = new Size(71, 20);
            ClientesNameLabel.TabIndex = 11;
            ClientesNameLabel.Text = "Nombre:";
            // 
            // BuscarClienteButton
            // 
            BuscarClienteButton.Image = Properties.Resources.btnSearchRecord_24x24;
            BuscarClienteButton.ImageAlign = ContentAlignment.MiddleRight;
            BuscarClienteButton.Location = new Point(233, 47);
            BuscarClienteButton.Name = "BuscarClienteButton";
            BuscarClienteButton.Size = new Size(144, 45);
            BuscarClienteButton.TabIndex = 10;
            BuscarClienteButton.Text = "Buscar Cliente...";
            BuscarClienteButton.TextAlign = ContentAlignment.MiddleLeft;
            BuscarClienteButton.UseVisualStyleBackColor = true;
            BuscarClienteButton.Click += BuscarClienteButton_Click;
            // 
            // ClientesIDTextBox
            // 
            ClientesIDTextBox.Location = new Point(12, 47);
            ClientesIDTextBox.Name = "ClientesIDTextBox";
            ClientesIDTextBox.Size = new Size(215, 27);
            ClientesIDTextBox.TabIndex = 9;
            // 
            // ClientesIDLabel
            // 
            ClientesIDLabel.AutoSize = true;
            ClientesIDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ClientesIDLabel.Location = new Point(12, 24);
            ClientesIDLabel.Name = "ClientesIDLabel";
            ClientesIDLabel.Size = new Size(91, 20);
            ClientesIDLabel.TabIndex = 8;
            ClientesIDLabel.Text = "Clientes I.D.";
            // 
            // PedidoGroupBox
            // 
            PedidoGroupBox.Controls.Add(PedidosTotalTextBox);
            PedidoGroupBox.Controls.Add(PedidosTotalLabel);
            PedidoGroupBox.Controls.Add(PedidosIDTextBox);
            PedidoGroupBox.Controls.Add(PedidosIDLabel);
            PedidoGroupBox.Location = new Point(12, 12);
            PedidoGroupBox.Name = "PedidoGroupBox";
            PedidoGroupBox.Size = new Size(250, 154);
            PedidoGroupBox.TabIndex = 8;
            PedidoGroupBox.TabStop = false;
            PedidoGroupBox.Text = "Pedido:";
            // 
            // PedidosTotalTextBox
            // 
            PedidosTotalTextBox.Location = new Point(12, 105);
            PedidosTotalTextBox.Name = "PedidosTotalTextBox";
            PedidosTotalTextBox.Size = new Size(215, 27);
            PedidosTotalTextBox.TabIndex = 10;
            PedidosTotalTextBox.TextChanged += textBox1_TextChanged;
            // 
            // PedidosTotalLabel
            // 
            PedidosTotalLabel.AutoSize = true;
            PedidosTotalLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PedidosTotalLabel.Location = new Point(11, 82);
            PedidosTotalLabel.Name = "PedidosTotalLabel";
            PedidosTotalLabel.Size = new Size(48, 20);
            PedidosTotalLabel.TabIndex = 7;
            PedidosTotalLabel.Text = "Total:";
            PedidosTotalLabel.Click += PedidosTotalLabel_Click;
            // 
            // PedidosIDTextBox
            // 
            PedidosIDTextBox.Location = new Point(12, 52);
            PedidosIDTextBox.Name = "PedidosIDTextBox";
            PedidosIDTextBox.Size = new Size(125, 27);
            PedidosIDTextBox.TabIndex = 6;
            // 
            // PedidosIDLabel
            // 
            PedidosIDLabel.AutoSize = true;
            PedidosIDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PedidosIDLabel.Location = new Point(12, 29);
            PedidosIDLabel.Name = "PedidosIDLabel";
            PedidosIDLabel.Size = new Size(29, 20);
            PedidosIDLabel.TabIndex = 5;
            PedidosIDLabel.Text = "ID:";
            // 
            // ButtonBar
            // 
            ButtonBar.BackColor = SystemColors.ButtonFace;
            ButtonBar.Controls.Add(ExitDontSaveButton);
            ButtonBar.Controls.Add(ExitSaveButton);
            ButtonBar.Controls.Add(ExitButton);
            ButtonBar.Dock = DockStyle.Bottom;
            ButtonBar.Location = new Point(0, 467);
            ButtonBar.Name = "ButtonBar";
            ButtonBar.Size = new Size(800, 81);
            ButtonBar.TabIndex = 0;
            // 
            // ExitDontSaveButton
            // 
            ExitDontSaveButton.Image = Properties.Resources.bmpFileExit_24x24;
            ExitDontSaveButton.ImageAlign = ContentAlignment.MiddleRight;
            ExitDontSaveButton.Location = new Point(568, 21);
            ExitDontSaveButton.Name = "ExitDontSaveButton";
            ExitDontSaveButton.Size = new Size(120, 45);
            ExitDontSaveButton.TabIndex = 3;
            ExitDontSaveButton.Text = "No Guardar";
            ExitDontSaveButton.TextAlign = ContentAlignment.MiddleLeft;
            ExitDontSaveButton.UseVisualStyleBackColor = true;
            ExitDontSaveButton.Click += ExitDontSaveButton_Click;
            // 
            // ExitSaveButton
            // 
            ExitSaveButton.Image = Properties.Resources.bmpFileSave_24x24;
            ExitSaveButton.ImageAlign = ContentAlignment.MiddleRight;
            ExitSaveButton.Location = new Point(12, 21);
            ExitSaveButton.Name = "ExitSaveButton";
            ExitSaveButton.Size = new Size(109, 45);
            ExitSaveButton.TabIndex = 2;
            ExitSaveButton.Text = "Guardar";
            ExitSaveButton.TextAlign = ContentAlignment.MiddleLeft;
            ExitSaveButton.UseVisualStyleBackColor = true;
            ExitSaveButton.Click += ExitSaveButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Image = Properties.Resources.bmpFileExit_24x24;
            ExitButton.ImageAlign = ContentAlignment.MiddleRight;
            ExitButton.Location = new Point(694, 21);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 45);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "Salir";
            ExitButton.TextAlign = ContentAlignment.MiddleLeft;
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // PedidosEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 570);
            Controls.Add(MainPanel);
            Controls.Add(MainStatusStrip);
            Name = "PedidosEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Pedido";
            Activated += PedidosEditForm_Activated;
            FormClosed += PedidosEditForm_FormClosed;
            Load += PedidosEditForm_Load;
            Shown += PedidosEditForm_Shown;
            MainPanel.ResumeLayout(false);
            ClienteGroupBox.ResumeLayout(false);
            ClienteGroupBox.PerformLayout();
            PedidoGroupBox.ResumeLayout(false);
            PedidoGroupBox.PerformLayout();
            ButtonBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip MainStatusStrip;
        private Panel MainPanel;
        private Panel ButtonBar;
        private Button ExitDontSaveButton;
        private Button ExitSaveButton;
        private Button ExitButton;
        private GroupBox ClienteGroupBox;
        private Button BuscarClienteButton;
        private TextBox ClientesIDTextBox;
        private Label ClientesIDLabel;
        private GroupBox PedidoGroupBox;
        private Label PedidosTotalLabel;
        private TextBox PedidosIDTextBox;
        private Label PedidosIDLabel;
        private TextBox ClientesRFCTextBox;
        private Label ClientesRFCLabel;
        private TextBox ClientesNameTextBox;
        private Label ClientesNameLabel;
        private TextBox PedidosTotalTextBox;
    }
}