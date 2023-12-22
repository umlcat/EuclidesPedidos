using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Dapper;
using EuclidesPedidos.Models;
using EuclidesPedidos.shared;
using MySqlX.XDevAPI.Common;

namespace EuclidesPedidos.Modules
{
    public partial class ClientesGridForm : Form
    {
        public bool IsActivated;

        public DBStatesEnum DBState = DBStatesEnum.None;

        public int Key = 0;

        public CloseOptionsEnum CloseOptions { get; set; }

        #region "constructor"
        public ClientesGridForm()
        {
            InitializeComponent();

            // ---

            this.DBState = DBStatesEnum.None;
            this.IsActivated = false;
            this.CloseOptions = CloseOptionsEnum.None;
        }
        #endregion

        // this may change due connection !!!
        private string connection = @"Server=127.0.0.1;Database=pedidosdapper;Uid=hurricane;Pwd=tornado;";

        public void /* func */ ClearData()
        {
            this.MainDataGridView.DataSource = null;
        }
        public void /* func */ RefreshButtondNavigator()
        {
            switch (this.DBState)
            {
                //case DBStatesEnum.Closed:
                case DBStatesEnum.View:

                    ExitSaveButton.Visible = false;
                    ExitDontSaveButton.Visible = false;

                    ExitButton.Visible = true;
                    break;
                case DBStatesEnum.Edit:
                case DBStatesEnum.Append:

                    ExitSaveButton.Visible = true;
                    ExitDontSaveButton.Visible = true;

                    ExitButton.Visible = false;
                    break;
                case DBStatesEnum.Select:

                    ExitSaveButton.Visible = false;
                    ExitDontSaveButton.Visible = false;

                    ExitButton.Visible = false;
                    break;

                // dbstNone:
                default:
                    // Nothing()
                    break;
            } // switch
        } // func

        public void /* func */ RefreshForm()
        {
            RefreshButtondNavigator();
        } // func

        public void /* func */ LoadData()
        {
            string SQL = "SELECT clientesID, clientesName, clientesRFC FROM clientes;";

            IEnumerable<Cliente> List = null;

            using (var DB = new MySqlConnection(connection))
            {
                List = DB.Query<Cliente>(SQL);

                BindingSource BS = new BindingSource();
                BS.DataSource = List;
                MainDataGridView.DataSource = BS;
            } // using
        } // func

        private void ClientesGridForm_Load(object sender, EventArgs e)
        {
            // causes code to be executed once
            IsActivated = false;
        }

        private void ClientesGridForm_Activated(object sender, EventArgs e)
        {
            // causes code to be executed once
            IsActivated = true;
        }

        private void ClientesGridForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainDataGridView.DataSource = null;
        }

        private void ClientesGridForm_Shown(object sender, EventArgs e)
        {
            // called just once
            RefreshForm();
            LoadData();
        }

        // ---

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int /* ## func */ getSelectedRecordKey()
        {
            int Result = 0;
            // ---

            // get current cell object
            DataGridViewCell ACell = MainDataGridView.CurrentCell;

            int ARowIndex =
                ACell.RowIndex;

            // locate the first cell from the same row,
            // it stores the key
            DataGridViewRow ARow = MainDataGridView.Rows[ARowIndex];
            ACell = ARow.Cells[0];

            string AValue =
                Convert.ToString(ACell.Value);
            Result =
                Convert.ToInt16(AValue);

            // ---
            return Result;
        } // func

        private void ReadToolStripButton_Click(object sender, EventArgs e)
        {
            IntFormParameters AParams =
                new IntFormParameters();

            AParams.Key =
                this.getSelectedRecordKey();

            ClearData();

            AParams.DBState = DBStatesEnum.View;

            ClientesEditForm.ShowModal(ref AParams);

            LoadData();

            AParams = null;
        } // func

        private void AddToolStripButton_Click(object sender, EventArgs e)
        {
            IntFormParameters AParams =
                new IntFormParameters();

            ClearData();

            AParams.DBState = DBStatesEnum.Append;

            ClientesEditForm.ShowModal(ref AParams);

            LoadData();

            AParams = null;
        } // func

        private void EditlStripButton_Click(object sender, EventArgs e)
        {
            IntFormParameters AParams =
                new IntFormParameters();

            AParams.Key =
                this.getSelectedRecordKey();

            ClearData();

            AParams.DBState = DBStatesEnum.Edit;
            ClientesEditForm.ShowModal(ref AParams);

            LoadData();

            AParams = null;
        } // func

        private bool /* func */ CanDelete(int AKey)
        {
            bool Result = false;

            // ---

            string Txt =
                "¿Esta seguro de eliminar el registro ?";
            string Cap =
                "Borrar Registro";
            Result =
                (MessageBox.Show(Txt, Cap, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes);

            // revisar si tiene pedidos
            if (Result)
            {
                // marca error:
                //string SQL =
                //    "SELECT pedidosID, pedidosTotal, clientesID FROM pedidos WHERE (clientesID = @clientesID);";

                string SQLTemplate =
                    "SELECT pedidosID, pedidosTotal, clientesID FROM pedidos WHERE (clientesID = {0});";
                string SQL =
                    String.Format(SQLTemplate, AKey);

                IEnumerable<Pedido> List = null;

                using (var DB = new MySqlConnection(connection))
                {
                    // marca error
                    //List = DB.Query<Pedido>(SQL, AKey);

                    List = DB.Query<Pedido>(SQL);

                    bool HasInvoices =
                        (List.Count() > 0);

                    List = null;

                    // ---

                    Result = (!HasInvoices);
                    if (HasInvoices)
                    {
                        MessageBox.Show
                            ("No se puede borrar clientes mientras tiene pedidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return Result;
                    }
                } // using
            } // if

            // ---

            return Result;
        } // func

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            int AKey =
                this.getSelectedRecordKey();

            if (this.CanDelete(AKey))
            {
                // uso de parametros marca error:
                //string SQL =
                //    "DELETE FROM clientes " +
                //    "WHERE " + "clientesID = @clientesID";

                string SQLTemplate =
                    "DELETE FROM clientes " +
                    "WHERE " + "clientesID = {0}";
                string SQL =
                    String.Format(SQLTemplate, AKey);

                ClearData();

                using (var DB = new MySqlConnection(connection))
                {
                    // marca error:
                    //DB.Execute(SQL, AKey);

                    DB.Execute(SQL);
                } // using

                LoadData();
            } // if
        } // func

        private void ExitSaveButton_Click(object sender, EventArgs e)
        {
            this.Key =
                this.getSelectedRecordKey();

            // ---

            CloseOptions = CloseOptionsEnum.Save;
            DialogResult = DialogResult.OK;
            this.Close();
        } // func

        private void ExitDontSaveButton_Click(object sender, EventArgs e)
        {
            this.Key = 0;

            // ---

            CloseOptions = CloseOptionsEnum.DontSave;
            DialogResult = DialogResult.Cancel;
            this.Close();
        } // func


        // ---

        public static CloseOptionsEnum /* func */ ShowModal
            (ref IntFormParameters /* ## params */ AParams)
        {
            CloseOptionsEnum Result = CloseOptionsEnum.None;

            // --

            ClientesGridForm ThisForm = new ClientesGridForm();

            // prepare input parameters
            ThisForm.DBState = AParams.DBState;
            ThisForm.Key = AParams.Key;

            // display form
            ThisForm.ShowDialog();

            // return output parameters
            Result = ThisForm.CloseOptions;

            if ((Result == CloseOptionsEnum.OK) || (Result == CloseOptionsEnum.Yes) || (Result == CloseOptionsEnum.Save))
            {
                AParams.Key = ThisForm.Key;
            }

            ThisForm.Dispose();
            ThisForm = null;

            // ---

            return Result;
        } // func

        private void MainDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // ...

    } // class

    // ...

} // namespace
