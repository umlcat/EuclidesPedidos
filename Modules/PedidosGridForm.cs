using Dapper;
using EuclidesPedidos.Models;
using EuclidesPedidos.shared;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuclidesPedidos.Modules
{
    public partial class PedidosGridForm : Form
    {
        public bool IsActivated;

        #region "constructor"
        public PedidosGridForm()
        {
            InitializeComponent();
        }
        #endregion

        // this may change due connection !!!
        private string connection = @"Server=127.0.0.1;Database=pedidosdapper;Uid=hurricane;Pwd=tornado;";

        public void /* func */ ClearData()
        {
            this.MainDataGridView.DataSource = null;
        }

        public void /* func */ LoadData()
        {
            string SQL = "SELECT pedidosID, pedidosTotal, clientesID FROM pedidos;";

            IEnumerable<Pedido> List = null;

            using (var DB = new MySqlConnection(connection))
            {
                List = DB.Query<Pedido>(SQL);

                BindingSource BS = new BindingSource();
                BS.DataSource = List;
                MainDataGridView.DataSource = BS;
            } // using
        } // func

        private void PedidosForm_Activated(object sender, EventArgs e)
        {
            // causes code to be executed once
            IsActivated = true;
        }

        private void PedidosForm_Shown(object sender, EventArgs e)
        {
            // called just once
            LoadData();
        }

        private void PedidosForm_Load(object sender, EventArgs e)
        {
            // causes code to be executed once
            IsActivated = false;
        }

        private void PedidosForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainDataGridView.DataSource = null;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

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

            //ClearData();

            AParams.DBState = DBStatesEnum.View;

            PedidosEditForm.ShowModal(ref AParams);

            LoadData();

            AParams = null;
        } // func

        private void AddToolStripButton_Click(object sender, EventArgs e)
        {
            IntFormParameters AParams =
                new IntFormParameters();

            ClearData();

            AParams.DBState = DBStatesEnum.Append;

            PedidosEditForm.ShowModal(ref AParams);

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
            PedidosEditForm.ShowModal(ref AParams);

            LoadData();

            AParams = null;
        } // func

        private bool /* func */ CanDelete(int AKey)
        {
            bool Result = false;

            // ---

            // agregar revisar pedidos

            // ---

            string Txt =
                "¿Esta seguro de eliminar el registro ?";
            string Cap =
                "Borrar Registro";
            Result =
                (MessageBox.Show(Txt, Cap, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes);

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
                //    "DELETE FROM pedidos " +
                //    "WHERE " + "pedidosID = @pedidosID";

                string SQLTemplate =
                    "DELETE FROM pedidos " +
                    "WHERE " + "pedidosID = {0}";
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

        // ---

        public static void /* func */ ShowModal()
        {
            PedidosGridForm ThisForm = new PedidosGridForm();

            // display form
            ThisForm.ShowDialog();

            ThisForm.Dispose();
            ThisForm = null;
        } // func

        private void MainDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // ...

    } // class

    // ...

} // namespace
