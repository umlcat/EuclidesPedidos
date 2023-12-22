using EuclidesPedidos.Modules;
using EuclidesPedidos.shared;

namespace EuclidesPedidos
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientesButton_Click(object sender, EventArgs e)
        {
            IntFormParameters /* ## var */ AParams = new IntFormParameters();

            AParams.DBState = DBStatesEnum.View;
            AParams.Key = 0;

            ClientesGridForm.ShowModal(ref AParams);
        } // func

        private void PedidosButton_Click(object sender, EventArgs e)
        {
            PedidosGridForm.ShowModal();
        }

        // ...

    } // class

    // ...

} // namespace
