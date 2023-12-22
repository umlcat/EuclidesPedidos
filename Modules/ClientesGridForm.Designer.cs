namespace EuclidesPedidos.Modules
{
    partial class ClientesGridForm
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
            MainDataGridView = new DataGridView();
            ClientesIDColumn = new DataGridViewTextBoxColumn();
            ClientesNameColumn = new DataGridViewTextBoxColumn();
            ClientesRFCColumn = new DataGridViewTextBoxColumn();
            MainToolStrip = new ToolStrip();
            ReadToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            AddToolStripButton = new ToolStripButton();
            EditToolStripButton = new ToolStripButton();
            DeleteToolStripButton = new ToolStripButton();
            ButtonBar = new Panel();
            ExitDontSaveButton = new Button();
            ExitSaveButton = new Button();
            ExitButton = new Button();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainDataGridView).BeginInit();
            MainToolStrip.SuspendLayout();
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
            MainStatusStrip.Text = "statusStrip1";
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.AppWorkspace;
            MainPanel.Controls.Add(MainDataGridView);
            MainPanel.Controls.Add(MainToolStrip);
            MainPanel.Controls.Add(ButtonBar);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(800, 428);
            MainPanel.TabIndex = 1;
            // 
            // MainDataGridView
            // 
            MainDataGridView.AllowUserToAddRows = false;
            MainDataGridView.AllowUserToDeleteRows = false;
            MainDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MainDataGridView.Columns.AddRange(new DataGridViewColumn[] { ClientesIDColumn, ClientesNameColumn, ClientesRFCColumn });
            MainDataGridView.Dock = DockStyle.Fill;
            MainDataGridView.Location = new Point(0, 27);
            MainDataGridView.MultiSelect = false;
            MainDataGridView.Name = "MainDataGridView";
            MainDataGridView.ReadOnly = true;
            MainDataGridView.RowHeadersWidth = 51;
            MainDataGridView.RowTemplate.Height = 29;
            MainDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MainDataGridView.Size = new Size(800, 328);
            MainDataGridView.TabIndex = 2;
            MainDataGridView.CellContentClick += MainDataGridView_CellContentClick;
            // 
            // ClientesIDColumn
            // 
            ClientesIDColumn.DataPropertyName = "clientesID";
            ClientesIDColumn.HeaderText = "ID";
            ClientesIDColumn.MinimumWidth = 6;
            ClientesIDColumn.Name = "ClientesIDColumn";
            ClientesIDColumn.ReadOnly = true;
            ClientesIDColumn.Width = 125;
            // 
            // ClientesNameColumn
            // 
            ClientesNameColumn.DataPropertyName = "clientesName";
            ClientesNameColumn.HeaderText = "Nombre";
            ClientesNameColumn.MinimumWidth = 6;
            ClientesNameColumn.Name = "ClientesNameColumn";
            ClientesNameColumn.ReadOnly = true;
            ClientesNameColumn.Width = 325;
            // 
            // ClientesRFCColumn
            // 
            ClientesRFCColumn.DataPropertyName = "clientesRFC";
            ClientesRFCColumn.HeaderText = "R.F.C.";
            ClientesRFCColumn.MinimumWidth = 6;
            ClientesRFCColumn.Name = "ClientesRFCColumn";
            ClientesRFCColumn.ReadOnly = true;
            ClientesRFCColumn.Width = 125;
            // 
            // MainToolStrip
            // 
            MainToolStrip.ImageScalingSize = new Size(20, 20);
            MainToolStrip.Items.AddRange(new ToolStripItem[] { ReadToolStripButton, toolStripSeparator1, AddToolStripButton, EditToolStripButton, DeleteToolStripButton });
            MainToolStrip.Location = new Point(0, 0);
            MainToolStrip.Name = "MainToolStrip";
            MainToolStrip.Size = new Size(800, 27);
            MainToolStrip.TabIndex = 1;
            MainToolStrip.Text = "toolStrip1";
            // 
            // ReadToolStripButton
            // 
            ReadToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ReadToolStripButton.Image = Properties.Resources.bmpRecordRead_2424;
            ReadToolStripButton.ImageTransparentColor = Color.Magenta;
            ReadToolStripButton.Name = "ReadToolStripButton";
            ReadToolStripButton.Size = new Size(29, 24);
            ReadToolStripButton.Text = "ReadToolStripButton";
            ReadToolStripButton.ToolTipText = "Solo leer registro actual ...";
            ReadToolStripButton.Click += ReadToolStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // AddToolStripButton
            // 
            AddToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            AddToolStripButton.Image = Properties.Resources.bmpRecordAdd_24x24;
            AddToolStripButton.ImageTransparentColor = Color.Magenta;
            AddToolStripButton.Name = "AddToolStripButton";
            AddToolStripButton.Size = new Size(29, 24);
            AddToolStripButton.Text = "AddToolStripButton";
            AddToolStripButton.ToolTipText = "Agregar un nuevo registro...";
            AddToolStripButton.Click += AddToolStripButton_Click;
            // 
            // EditToolStripButton
            // 
            EditToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            EditToolStripButton.Image = Properties.Resources.bmpRecordEdit_24x24;
            EditToolStripButton.ImageTransparentColor = Color.Magenta;
            EditToolStripButton.Name = "EditToolStripButton";
            EditToolStripButton.Size = new Size(29, 24);
            EditToolStripButton.Text = "EditlStripButton";
            EditToolStripButton.ToolTipText = "Cambiar el registro actual ...";
            EditToolStripButton.Click += EditlStripButton_Click;
            // 
            // DeleteToolStripButton
            // 
            DeleteToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            DeleteToolStripButton.Image = Properties.Resources.bmpRecordDelete_24x24;
            DeleteToolStripButton.ImageTransparentColor = Color.Magenta;
            DeleteToolStripButton.Name = "DeleteToolStripButton";
            DeleteToolStripButton.Size = new Size(29, 24);
            DeleteToolStripButton.Text = "DeleteToolStripButton";
            DeleteToolStripButton.ToolTipText = "Borrar el registro actual ...";
            DeleteToolStripButton.Click += DeleteToolStripButton_Click;
            // 
            // ButtonBar
            // 
            ButtonBar.BackColor = SystemColors.ButtonFace;
            ButtonBar.Controls.Add(ExitDontSaveButton);
            ButtonBar.Controls.Add(ExitSaveButton);
            ButtonBar.Controls.Add(ExitButton);
            ButtonBar.Dock = DockStyle.Bottom;
            ButtonBar.Location = new Point(0, 355);
            ButtonBar.Name = "ButtonBar";
            ButtonBar.Size = new Size(800, 73);
            ButtonBar.TabIndex = 0;
            // 
            // ExitDontSaveButton
            // 
            ExitDontSaveButton.Image = Properties.Resources.bmpFileExit_24x24;
            ExitDontSaveButton.ImageAlign = ContentAlignment.MiddleRight;
            ExitDontSaveButton.Location = new Point(568, 12);
            ExitDontSaveButton.Name = "ExitDontSaveButton";
            ExitDontSaveButton.Size = new Size(120, 45);
            ExitDontSaveButton.TabIndex = 4;
            ExitDontSaveButton.Text = "No Guardar";
            ExitDontSaveButton.TextAlign = ContentAlignment.MiddleLeft;
            ExitDontSaveButton.UseVisualStyleBackColor = true;
            ExitDontSaveButton.Click += ExitDontSaveButton_Click;
            // 
            // ExitSaveButton
            // 
            ExitSaveButton.Image = Properties.Resources.bmpFileSave_24x24;
            ExitSaveButton.ImageAlign = ContentAlignment.MiddleRight;
            ExitSaveButton.Location = new Point(12, 12);
            ExitSaveButton.Name = "ExitSaveButton";
            ExitSaveButton.Size = new Size(109, 45);
            ExitSaveButton.TabIndex = 3;
            ExitSaveButton.Text = "Guardar";
            ExitSaveButton.TextAlign = ContentAlignment.MiddleLeft;
            ExitSaveButton.UseVisualStyleBackColor = true;
            ExitSaveButton.Click += ExitSaveButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Image = Properties.Resources.bmpFileExit_24x24;
            ExitButton.ImageAlign = ContentAlignment.MiddleRight;
            ExitButton.Location = new Point(694, 12);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 45);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "Salir";
            ExitButton.TextAlign = ContentAlignment.MiddleLeft;
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ClientesGridForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainPanel);
            Controls.Add(MainStatusStrip);
            Name = "ClientesGridForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de Clientes";
            Activated += ClientesGridForm_Activated;
            FormClosed += ClientesGridForm_FormClosed;
            Load += ClientesGridForm_Load;
            Shown += ClientesGridForm_Shown;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MainDataGridView).EndInit();
            MainToolStrip.ResumeLayout(false);
            MainToolStrip.PerformLayout();
            ButtonBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip MainStatusStrip;
        private Panel MainPanel;
        private Panel ButtonBar;
        private Button ExitButton;
        private ToolStrip MainToolStrip;
        private ToolStripButton AddToolStripButton;
        private ToolStripButton EditToolStripButton;
        private ToolStripButton DeleteToolStripButton;
        private DataGridView MainDataGridView;
        private DataGridViewTextBoxColumn ClientesIDColumn;
        private DataGridViewTextBoxColumn ClientesNameColumn;
        private DataGridViewTextBoxColumn ClientesRFCColumn;
        private ToolStripButton ReadToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private Button ExitSaveButton;
        private Button ExitDontSaveButton;
    }
}