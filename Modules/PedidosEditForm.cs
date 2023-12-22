using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using Dapper;
using EuclidesPedidos.Models;
using EuclidesPedidos.shared;

namespace EuclidesPedidos.Modules
{
    public partial class PedidosEditForm : Form
    {
        public bool IsActivated;

        public CloseOptionsEnum CloseOptions { get; set; }
        public DBStatesEnum DBState { get; set; }

        public int Key = 0;

        // ---

        public Pedido MainEntity;
        public Cliente ClienteEntity;

        #region "constructor"
        public PedidosEditForm()
        {
            InitializeComponent();

            // ---

            this.DBState = DBStatesEnum.None;
            this.IsActivated = false;

            // ---

            this.MainEntity = new Pedido();
            this.ClienteEntity = new Cliente();
        }
        #endregion

        public void /* func */ RefreshButtonNavigator()
        {
            switch (this.DBState)
            {
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

                    //        ExitSaveButton.Visible = false;
                    //        ExitDontSaveButton.Visible = false;

                    ExitButton.Visible = false;
                    break;

                default:
                    // Nothing()
                    break;
            } // switch
        } // func

        public void /* func */ RefreshControls()
        {
            // siempre solo lectura
            this.ClientesIDTextBox.ReadOnly = true;
            this.ClientesNameTextBox.ReadOnly = true;
            this.ClientesRFCTextBox.ReadOnly = true;

            switch (this.DBState)
            {
                case DBStatesEnum.View:
                    this.Text = "Solo Ver Pedido";

                    this.PedidosIDTextBox.ReadOnly = true;
                    this.PedidosTotalTextBox.ReadOnly = true;

                    this.BuscarClienteButton.Enabled = false;
                    break;

                case DBStatesEnum.Edit:
                    this.Text = "Cambiar Pedido existente";

                    // key is generated automatically
                    this.PedidosIDTextBox.ReadOnly = true;
                    this.PedidosTotalTextBox.ReadOnly = false;

                    this.BuscarClienteButton.Enabled = true;
                    break;

                case DBStatesEnum.Append:
                    this.Text = "Agregar nuevo Pedido";

                    // key is generated automatically
                    this.PedidosIDTextBox.ReadOnly = true;
                    this.PedidosTotalTextBox.ReadOnly = false;

                    this.BuscarClienteButton.Enabled = true;
                    break;

                default:
                    this.PedidosIDTextBox.ReadOnly = true;
                    this.PedidosTotalTextBox.ReadOnly = true;

                    this.BuscarClienteButton.Enabled = false;
                    break;
            } // switch
        } // func

        public void /* func */ RefreshForm()
        {
            RefreshButtonNavigator();
            RefreshControls();
        } // func

        public void /* func */ ClearData()
        {
            // replace this:
            const string AServerName = "127.0.0.1";
            const string ADatabaseName = "pedidosdapper";
            const string AUserNameName = "hurricane";
            const string APassword = "tornado";

            // obtain last key plus one
            MySQLIntKeySequencer ASequencer = new MySQLIntKeySequencer();

            ASequencer.ServerName = AServerName;
            ASequencer.DatabaseName = ADatabaseName;
            ASequencer.UserName = AUserNameName;
            ASequencer.Password = APassword;

            ASequencer.TableName = "pedidos";
            ASequencer.FieldName = "pedidosID";

            this.MainEntity.pedidosID =
                (ASequencer.AsInteger + 1);

            ASequencer.Dispose();
            ASequencer = null;

            // ---

            this.MainEntity.pedidosTotal = 0;
            this.MainEntity.clientesID = 0;
        } // func

        // this may change due connection !!!
        private string connection = @"Server=127.0.0.1;Database=pedidosdapper;Uid=hurricane;Pwd=tornado;";

        public void /* func */ LoadDataPedido()
        {
            string SQLTemplate =
                "SELECT pedidosID, pedidosTotal, clientesID " +
                "FROM pedidos " +
                "WHERE (pedidosID = {0});";
            string SQL =
                String.Format(SQLTemplate, this.Key);

            IEnumerable<Pedido> List = null;

            using (var DB = new MySqlConnection(connection))
            {
                List = DB.Query<Pedido>(SQL);
            } // using

            // ---

            // assign values to entity
            this.MainEntity =
                List.FirstOrDefault<Pedido>();
        } // func

        public void /* func */ LoadDataCliente()
        {
            // nota: marca error al intentar usar parametros
            string SQLTemplate =
                "SELECT clientesID, clientesName, clientesRFC " +
                "FROM clientes " +
                "WHERE (clientesID = {0});";
            string SQL =
                String.Format(SQLTemplate, this.MainEntity.clientesID);

            IEnumerable<Cliente> List = null;

            using (var DB = new MySqlConnection(connection))
            {
                List = DB.Query<Cliente>(SQL);
            } // using

            // ---

            // assign values to entity
            this.ClienteEntity =
                List.FirstOrDefault<Cliente>();
        } // func

        public void /* func */ LoadData()
        {
            LoadDataPedido();
            LoadDataCliente();
        } // func

        public void /* func */ LoadControlsPedido()
        {
            this.PedidosIDTextBox.Text =
              Convert.ToString(this.MainEntity.pedidosID);

            this.PedidosTotalTextBox.Text =
                Convert.ToString(this.MainEntity.pedidosTotal);
            this.ClientesIDTextBox.Text =
                Convert.ToString(this.MainEntity.clientesID);
        } // func
        public void /* func */ LoadControlsCliente()
        {
            this.ClientesIDTextBox.Text =
              Convert.ToString(this.MainEntity.clientesID);

            this.ClientesNameTextBox.Text =
                this.ClienteEntity.clientesName;
            this.ClientesRFCTextBox.Text =
                this.ClienteEntity.clientesRFC;
        } // func

        public void /* func */ LoadControls()
        {
            LoadControlsPedido();
            LoadControlsCliente();
        } // func

        public void /* func */ SaveControls()
        {
            if ((this.DBState == DBStatesEnum.Append) || (this.DBState == DBStatesEnum.Edit))
            {
                //this.MainEntity.clientesID =
                //this.ClientesIDTextBox.Text;

                // ---

                this.MainEntity.pedidosTotal =
                    Convert.ToDecimal(this.PedidosTotalTextBox.Text);
                this.MainEntity.clientesID =
                    Convert.ToInt32(this.ClientesIDTextBox.Text);
            } // if
        } // func

        public void /* func */ SaveData()
        {
            // replace this:
            const string AServerName = "127.0.0.1";
            const string ADatabaseName = "pedidosdapper";
            const string AUserNameName = "hurricane";
            const string APassword = "tornado";

            if (this.DBState == DBStatesEnum.Append)
            {
                // obtain last key plus one
                MySQLIntKeySequencer ASequencer = new MySQLIntKeySequencer();

                ASequencer.ServerName = AServerName;
                ASequencer.DatabaseName = ADatabaseName;
                ASequencer.UserName = AUserNameName;
                ASequencer.Password = APassword;

                ASequencer.TableName = "pedidos";
                ASequencer.FieldName = "pedidosID";

                this.MainEntity.pedidosID =
                    (ASequencer.AsInteger + 1);

                ASequencer.Dispose();
                ASequencer = null;

                // ---

                string SQL =
                    "INSERT INTO pedidos (" +
                    "pedidosID, pedidosTotal, clientesID " +
                    ") values (" +
                    "@pedidosID, @pedidosTotal, @clientesID " +
                    ");";

                using (var DB = new MySqlConnection(connection))
                {
                    DB.Execute(SQL, this.MainEntity);
                } // using
            }
            else if (this.DBState == DBStatesEnum.Edit)
            {
                string SQL =
                    "UPDATE pedidos SET " +
                    "pedidosID = @pedidosID, " +
                    "pedidosTotal = @pedidosTotal, " +
                    "clientesID = @clientesID " +
                    "WHERE (" +
                    "pedidosID = @pedidosID " +
                    ");";

                using (var DB = new MySqlConnection(connection))
                {
                    DB.Execute(SQL, this.MainEntity);
                } // using

            } // if
        } // func

        public bool /* func */ CanSaveData()
        {
            bool Result = false;

            // ---

            // note: key control is always read-only and generated automatically

            Result = (!String.IsNullOrEmpty(PedidosTotalTextBox.Text));
            if (!Result)
            {
                MessageBox.Show("Total no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Result;
            }

            Result = (!String.IsNullOrEmpty(ClientesIDTextBox.Text));
            if (!Result)
            {
                MessageBox.Show("Cliente I.D. no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Result;
            }

            decimal ATotal = 0;
            Result =
                Decimal.TryParse(PedidosTotalTextBox.Text, out ATotal);
            if (!Result)
            {
                MessageBox.Show("Total debe ser un numero flotante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Result;
            }

            Result =
                (ATotal > 0);
            if (!Result)
            {
                MessageBox.Show("Total no puede ser igual o menor que cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Result;
            }

            Int32 AKey = 0;
            Result =
                (Int32.TryParse(ClientesIDTextBox.Text, out AKey) && (AKey > 0));
            if (!Result)
            {
                MessageBox.Show("Debe seleccionar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Result;
            }

            // ---

            return Result;
        } // func

        public void /* func */ RefreshData()
        {
            switch (this.DBState)
            {
                case DBStatesEnum.View:
                    this.LoadData();
                    this.LoadControls();

                    PedidosIDTextBox.Focus();
                    break;

                case DBStatesEnum.Edit:
                    this.LoadData();
                    this.LoadControls();

                    PedidosIDTextBox.Focus();
                    break;
                case DBStatesEnum.Append:
                    this.ClearData();
                    this.LoadControls();

                    PedidosIDTextBox.Focus();
                    break;
                default:
                    // Nothing()
                    break;
            } // switch
        } // func

        private void PedidosEditForm_Activated(object sender, EventArgs e)
        {
            //
        }

        private void PedidosEditForm_Shown(object sender, EventArgs e)
        {
            RefreshForm();
            RefreshData();
            IsActivated = true;
        }

        private void PedidosEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //
        }

        private void PedidosEditForm_Load(object sender, EventArgs e)
        {
            IsActivated = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            CloseOptions = CloseOptionsEnum.Exit;
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ExitSaveButton_Click(object sender, EventArgs e)
        {
            if (this.CanSaveData())
            {
                SaveControls();
                SaveData();

                // ---

                CloseOptions = CloseOptionsEnum.Save;
                DialogResult = DialogResult.OK;
                this.Close();
            } // if
        } // func

        private void ExitDontSaveButton_Click(object sender, EventArgs e)
        {
            CloseOptions = CloseOptionsEnum.DontSave;
            DialogResult = DialogResult.Cancel;
            this.Close();
        } // func

        private void ClientesRFCLabel_Click(object sender, EventArgs e)
        {

        }

        // ---

        public static CloseOptionsEnum /* ## func */ ShowModal
            (ref IntFormParameters /* ## params */ AParams)
        {
            CloseOptionsEnum Result = CloseOptionsEnum.None;

            // --

            PedidosEditForm ThisForm = new PedidosEditForm();

            // prepare input parameters
            ThisForm.DBState = AParams.DBState;

            ThisForm.Key = AParams.Key;

            // display form
            ThisForm.ShowDialog();

            // return output parameters
            Result = ThisForm.CloseOptions;

            if ((Result == CloseOptionsEnum.OK) || (Result == CloseOptionsEnum.Yes))
            {
                AParams.Key = ThisForm.Key;
            }

            ThisForm.Dispose();
            ThisForm = null;

            // ---

            return Result;
        } // func

        private void BuscarClienteButton_Click(object sender, EventArgs e)
        {
            IntFormParameters /* ## var */ AParams =
                new IntFormParameters();

            AParams.Key =
                this.MainEntity.clientesID;

            AParams.DBState = DBStatesEnum.Edit;

            bool CanContinue =
                (ClientesGridForm.ShowModal(ref AParams) == CloseOptionsEnum.Save);
            if (CanContinue)
            {
                this.MainEntity.clientesID =
                    AParams.Key;

                LoadDataCliente();
                LoadControlsCliente();
            } // if

            //MessageBox.Show
            //("Aun no implementado", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } // func

        private void PedidosTotalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PedidosTotalLabel_Click(object sender, EventArgs e)
        {

        }

        // ...

    } // class

    // ...

} // namespace
