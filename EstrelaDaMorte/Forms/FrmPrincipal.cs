using System;
using System.Windows.Forms;
using EstrelaDaMorte.Servicos;


namespace EstrelaDaMorte.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private async void btnSincronizar_Click(object sender, EventArgs e)
        {
            var sincronizador = new SincronizadorService();

            Cursor = Cursors.WaitCursor;
            await sincronizador.Sincronizar();
            Cursor = Cursors.Default;

            MessageBox.Show("Sincronização finalizada com sucesso", "Sincronização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnControle_Click(object sender, EventArgs e)
        {
            var frm = new frmControleNaves();
            frm.ShowDialog();
        }
    }
}
