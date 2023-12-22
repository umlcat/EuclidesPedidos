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
    public partial class ClientesEditForm : Form
    {
        public bool IsActivated;

        public CloseOptionsEnum CloseOptions { get; set; }
        public DBStatesEnum DBState { get; set; }

        public int Key = 0;

        // ---

        public Cliente MainEntity;

        #region "constructor"
        public ClientesEditForm()
        {
            InitializeComponent();

            // ---

            this.DBState = DBStatesEnum.None;
            this.IsActivated = false;

            // ---

            this.MainEntity = new Cliente();
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
            switch (this.DBState)
            {
                case DBStatesEnum.View:
                    this.Text = "Solo Ver Cliente";

                    this.ClientesIDTextBox.ReadOnly = true;
                    this.ClientesNameTextBox.ReadOnly = true;
                    this.ClientesRFCTextBox.ReadOnly = true;
                    break;

                case DBStatesEnum.Edit:
                    this.Text = "Cambiar Cliente existente";

                    // key is generated automatically
                    this.ClientesIDTextBox.ReadOnly = true;

                    this.ClientesNameTextBox.ReadOnly = false;
                    this.ClientesRFCTextBox.ReadOnly = false;
                    break;

                case DBStatesEnum.Append:
                    this.Text = "Agregar nuevo Cliente";

                    // key is generated automatically
                    this.ClientesIDTextBox.ReadOnly = true;

                    this.ClientesNameTextBox.ReadOnly = false;
                    this.ClientesRFCTextBox.ReadOnly = false;
                    break;
                default:
                    this.ClientesIDTextBox.ReadOnly = true;
                    this.ClientesNameTextBox.ReadOnly = true;
                    this.ClientesRFCTextBox.ReadOnly = true;
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

            ASequencer.TableName = "clientes";
            ASequencer.FieldName = "clientesID";

            this.MainEntity.clientesID =
                (ASequencer.AsInteger + 1);

            ASequencer.Dispose();
            ASequencer = null;

            // ---

            this.MainEntity.clientesName = "<replace me>";
            this.MainEntity.clientesRFC = "????";
        } // func

        // this may change due connection !!!
        private string connection = @"Server=127.0.0.1;Database=pedidosdapper;Uid=hurricane;Pwd=tornado;";

        public void /* func */ LoadData()
        {
            // causo error
            //string SQL =
            //    "SELECT clientesID, clientesName, clientesRFC " +
            //    "FROM clientes " +
            //    "WHERE (clientesID = @ID);" ;

            string SQLTemplate =
                "SELECT clientesID, clientesName, clientesRFC " +
                "FROM clientes " +
                "WHERE (clientesID = {0});";
            string SQL =
                String.Format(SQLTemplate, this.Key);

            IEnumerable <Cliente> List = null;

            using (var DB = new MySqlConnection(connection))
            {
                // causo error
                //List = DB.Query<Clientes>(SQL, this.Key);

                List = DB.Query<Cliente>(SQL);
            } // using

            // ---

            // assign values to entity,
            // note: is reference that is already part of "DBContext"
            this.MainEntity =
                List.FirstOrDefault<Cliente>();
        } // func

        public void /* func */ LoadControls()
        {
            this.ClientesIDTextBox.Text =
              Convert.ToString(this.MainEntity.clientesID);

            this.ClientesNameTextBox.Text =
                this.MainEntity.clientesName;
            this.ClientesRFCTextBox.Text =
                this.MainEntity.clientesRFC;
        } // func

        public void /* func */ SaveControls()
        {
            if ((this.DBState == DBStatesEnum.Append) || (this.DBState == DBStatesEnum.Edit))
            {
                //this.MainEntity.clientesID =
                //this.ClientesIDTextBox.Text;

                // ---

                this.MainEntity.clientesName =
                    this.ClientesNameTextBox.Text;
                this.MainEntity.clientesRFC =
                    this.ClientesRFCTextBox.Text;
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

                ASequencer.TableName = "clientes";
                ASequencer.FieldName = "clientesID";

                this.MainEntity.clientesID =
                    (ASequencer.AsInteger + 1);

                ASequencer.Dispose();
                ASequencer = null;

                // ---

                string SQL =
                    "INSERT INTO clientes (" +
                    "clientesID, clientesName, clientesRFC " +
                    ") values (" +
                    "@clientesID, @clientesName, @clientesRFC " +
                    ");";

                using (var DB = new MySqlConnection(connection))
                {
                    DB.Execute(SQL, this.MainEntity);
                } // using
            }
            else if (this.DBState == DBStatesEnum.Edit)
            {
                string SQL =
                    "UPDATE clientes SET " +
                    "clientesID = @clientesID, " +
                    "clientesName = @clientesName, " +
                    "clientesRFC = @clientesRFC " +
                    "WHERE (" +
                    "clientesID = @clientesID " +
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

            Result = (!String.IsNullOrEmpty(ClientesNameTextBox.Text));
            if (!Result)
            { 
                MessageBox.Show("Nombre no puede estar vacio.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Result;
            }

            Result = (!String.IsNullOrEmpty(ClientesRFCTextBox.Text));
            if (!Result)
            {
                MessageBox.Show("R.F.C. no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    ClientesIDTextBox.Focus();
                    break;

                case DBStatesEnum.Edit:
                    this.LoadData();
                    this.LoadControls();

                    ClientesIDTextBox.Focus();
                    break;
                case DBStatesEnum.Append:
                    this.ClearData();
                    this.LoadControls();

                    ClientesIDTextBox.Focus();
                    break;
                default:
                    // Nothing()
                    break;
            } // switch
        } // func

        private void ClientesEditForm_Load(object sender, EventArgs e)
        {
            IsActivated = false;
        }

        private void ClientesEditForm_Shown(object sender, EventArgs e)
        {
            RefreshForm();
            RefreshData();
            IsActivated = true;
        }

        private void ClientesEditForm_Activated(object sender, EventArgs e)
        {
            //
        }

        private void ClientesEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //
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
            }
        } // func

        private void FileDontSaveButton_Click(object sender, EventArgs e)
        {
            CloseOptions = CloseOptionsEnum.DontSave;
            DialogResult = DialogResult.Cancel;
            this.Close();
        } // func

        private void ExitButton_Click(object sender, EventArgs e)
        {
            CloseOptions = CloseOptionsEnum.Exit;
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // ---

        public static CloseOptionsEnum /* ## func */ ShowModal
            (ref IntFormParameters /* ## params */ AParams)
        {
            CloseOptionsEnum Result = CloseOptionsEnum.None;

            // --

            ClientesEditForm ThisForm = new ClientesEditForm();

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

        // ...

    } // class

    // ...

} // class
