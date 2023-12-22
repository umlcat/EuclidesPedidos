namespace EuclidesPedidos.Modules
{
    partial class ClientesEditForm
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
            ClientesRFCTextBox = new TextBox();
            ClientesRFCLabel = new Label();
            ClientesNameTextBox = new TextBox();
            ClientesNameLabel = new Label();
            ClientesIDTextBox = new TextBox();
            ClientesIDLabel = new Label();
            ButtonBar = new Panel();
            ExitDontSaveButton = new Button();
            ExitSaveButton = new Button();
            ExitButton = new Button();
            MainPanel.SuspendLayout();
            ButtonBar.SuspendLayout();
            SuspendLayout();
            // 
            // MainStatusStrip
            // 
            MainStatusStrip.ImageScalingSize = new Size(20, 20);
            MainStatusStrip.Location = new Point(0, 428);
            MainStatusStrip.Name = "MainStatusStrip";
            MainStatusStrip.Size = new Size(800, 22);
            MainStatusStrip.TabIndex = 0;
            MainStatusStrip.Text = "MainStatusStrip";
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.AppWorkspace;
            MainPanel.Controls.Add(ClientesRFCTextBox);
            MainPanel.Controls.Add(ClientesRFCLabel);
            MainPanel.Controls.Add(ClientesNameTextBox);
            MainPanel.Controls.Add(ClientesNameLabel);
            MainPanel.Controls.Add(ClientesIDTextBox);
            MainPanel.Controls.Add(ClientesIDLabel);
            MainPanel.Controls.Add(ButtonBar);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(800, 428);
            MainPanel.TabIndex = 1;
            // 
            // ClientesRFCTextBox
            // 
            ClientesRFCTextBox.Location = new Point(12, 145);
            ClientesRFCTextBox.Name = "ClientesRFCTextBox";
            ClientesRFCTextBox.Size = new Size(215, 27);
            ClientesRFCTextBox.TabIndex = 6;
            // 
            // ClientesRFCLabel
            // 
            ClientesRFCLabel.AutoSize = true;
            ClientesRFCLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ClientesRFCLabel.Location = new Point(12, 122);
            ClientesRFCLabel.Name = "ClientesRFCLabel";
            ClientesRFCLabel.Size = new Size(47, 20);
            ClientesRFCLabel.TabIndex = 5;
            ClientesRFCLabel.Text = "R.F.C.";
            // 
            // ClientesNameTextBox
            // 
            ClientesNameTextBox.Location = new Point(12, 87);
            ClientesNameTextBox.Name = "ClientesNameTextBox";
            ClientesNameTextBox.Size = new Size(411, 27);
            ClientesNameTextBox.TabIndex = 4;
            // 
            // ClientesNameLabel
            // 
            ClientesNameLabel.AutoSize = true;
            ClientesNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ClientesNameLabel.Location = new Point(12, 64);
            ClientesNameLabel.Name = "ClientesNameLabel";
            ClientesNameLabel.Size = new Size(71, 20);
            ClientesNameLabel.TabIndex = 3;
            ClientesNameLabel.Text = "Nombre:";
            // 
            // ClientesIDTextBox
            // 
            ClientesIDTextBox.Location = new Point(12, 32);
            ClientesIDTextBox.Name = "ClientesIDTextBox";
            ClientesIDTextBox.Size = new Size(125, 27);
            ClientesIDTextBox.TabIndex = 2;
            // 
            // ClientesIDLabel
            // 
            ClientesIDLabel.AutoSize = true;
            ClientesIDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ClientesIDLabel.Location = new Point(12, 9);
            ClientesIDLabel.Name = "ClientesIDLabel";
            ClientesIDLabel.Size = new Size(29, 20);
            ClientesIDLabel.TabIndex = 1;
            ClientesIDLabel.Text = "ID:";
            // 
            // ButtonBar
            // 
            ButtonBar.BackColor = SystemColors.ButtonFace;
            ButtonBar.Controls.Add(ExitDontSaveButton);
            ButtonBar.Controls.Add(ExitSaveButton);
            ButtonBar.Controls.Add(ExitButton);
            ButtonBar.Dock = DockStyle.Bottom;
            ButtonBar.Location = new Point(0, 347);
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
            ExitDontSaveButton.Click += FileDontSaveButton_Click;
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
            // ClientesEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainPanel);
            Controls.Add(MainStatusStrip);
            Name = "ClientesEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Cliente";
            Activated += ClientesEditForm_Activated;
            FormClosed += ClientesEditForm_FormClosed;
            Load += ClientesEditForm_Load;
            Shown += ClientesEditForm_Shown;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ButtonBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip MainStatusStrip;
        private Panel MainPanel;
        private Panel ButtonBar;
        private Button ExitButton;
        private TextBox ClientesIDTextBox;
        private Label ClientesIDLabel;
        private TextBox ClientesNameTextBox;
        private Label ClientesNameLabel;
        private TextBox ClientesRFCTextBox;
        private Label ClientesRFCLabel;
        private Button ExitSaveButton;
        private Button ExitDontSaveButton;
    }
}