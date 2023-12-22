namespace EuclidesPedidos.Modules
{
    partial class PedidosGridForm
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
            statusStrip1 = new StatusStrip();
            toolStrip1 = new ToolStrip();
            ReadToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            AddToolStripButton = new ToolStripButton();
            EditToolStripButton = new ToolStripButton();
            DeleteToolStripButton = new ToolStripButton();
            MainPanel = new Panel();
            MainDataGridView = new DataGridView();
            PedidosIDColumn = new DataGridViewTextBoxColumn();
            PedidosTotalColumn = new DataGridViewTextBoxColumn();
            ClientesIDColumn = new DataGridViewTextBoxColumn();
            ButtonBar = new Panel();
            ExitButton = new Button();
            toolStrip1.SuspendLayout();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainDataGridView).BeginInit();
            ButtonBar.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { ReadToolStripButton, toolStripSeparator1, AddToolStripButton, EditToolStripButton, DeleteToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // ReadToolStripButton
            // 
            ReadToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ReadToolStripButton.Image = Properties.Resources.bmpRecordRead_2424;
            ReadToolStripButton.ImageTransparentColor = Color.Magenta;
            ReadToolStripButton.Name = "ReadToolStripButton";
            ReadToolStripButton.Size = new Size(29, 24);
            ReadToolStripButton.Text = "toolStripButton1";
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
            AddToolStripButton.Text = "toolStripButton1";
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
            EditToolStripButton.Text = "toolStripButton1";
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
            DeleteToolStripButton.Text = "toolStripButton1";
            DeleteToolStripButton.ToolTipText = "Borrar el registro actual ...";
            DeleteToolStripButton.Click += DeleteToolStripButton_Click;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.AppWorkspace;
            MainPanel.Controls.Add(MainDataGridView);
            MainPanel.Controls.Add(ButtonBar);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 27);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(800, 401);
            MainPanel.TabIndex = 2;
            // 
            // MainDataGridView
            // 
            MainDataGridView.AllowUserToAddRows = false;
            MainDataGridView.AllowUserToDeleteRows = false;
            MainDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MainDataGridView.Columns.AddRange(new DataGridViewColumn[] { PedidosIDColumn, PedidosTotalColumn, ClientesIDColumn });
            MainDataGridView.Dock = DockStyle.Fill;
            MainDataGridView.Location = new Point(0, 0);
            MainDataGridView.MultiSelect = false;
            MainDataGridView.Name = "MainDataGridView";
            MainDataGridView.ReadOnly = true;
            MainDataGridView.RowHeadersWidth = 51;
            MainDataGridView.RowTemplate.Height = 29;
            MainDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MainDataGridView.Size = new Size(800, 328);
            MainDataGridView.TabIndex = 3;
            MainDataGridView.CellContentClick += MainDataGridView_CellContentClick;
            // 
            // PedidosIDColumn
            // 
            PedidosIDColumn.DataPropertyName = "pedidosID";
            PedidosIDColumn.HeaderText = "ID";
            PedidosIDColumn.MinimumWidth = 6;
            PedidosIDColumn.Name = "PedidosIDColumn";
            PedidosIDColumn.ReadOnly = true;
            PedidosIDColumn.Width = 125;
            // 
            // PedidosTotalColumn
            // 
            PedidosTotalColumn.DataPropertyName = "pedidosTotal";
            PedidosTotalColumn.HeaderText = "Pedidos Total";
            PedidosTotalColumn.MinimumWidth = 6;
            PedidosTotalColumn.Name = "PedidosTotalColumn";
            PedidosTotalColumn.ReadOnly = true;
            PedidosTotalColumn.Width = 125;
            // 
            // ClientesIDColumn
            // 
            ClientesIDColumn.DataPropertyName = "clientesID";
            ClientesIDColumn.HeaderText = "Clientes I.D.";
            ClientesIDColumn.MinimumWidth = 6;
            ClientesIDColumn.Name = "ClientesIDColumn";
            ClientesIDColumn.ReadOnly = true;
            ClientesIDColumn.Width = 125;
            // 
            // ButtonBar
            // 
            ButtonBar.BackColor = SystemColors.ButtonFace;
            ButtonBar.Controls.Add(ExitButton);
            ButtonBar.Dock = DockStyle.Bottom;
            ButtonBar.Location = new Point(0, 328);
            ButtonBar.Name = "ButtonBar";
            ButtonBar.Size = new Size(800, 73);
            ButtonBar.TabIndex = 1;
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
            // PedidosGridForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainPanel);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Name = "PedidosGridForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de Pedidos";
            Activated += PedidosForm_Activated;
            FormClosed += PedidosForm_FormClosed;
            Load += PedidosForm_Load;
            Shown += PedidosForm_Shown;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainDataGridView).EndInit();
            ButtonBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private Panel MainPanel;
        private Panel ButtonBar;
        private Button ExitButton;
        private ToolStripButton ReadToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton AddToolStripButton;
        private ToolStripButton EditToolStripButton;
        private ToolStripButton DeleteToolStripButton;
        private DataGridView MainDataGridView;
        private DataGridViewTextBoxColumn PedidosIDColumn;
        private DataGridViewTextBoxColumn PedidosTotalColumn;
        private DataGridViewTextBoxColumn ClientesIDColumn;
    }
}