using SellSix.View;

namespace SellSix
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            this.Text = "SellSix - Sistema de Vendas";
            this.Icon = Properties.Resources.Sellsix;
            this.WindowState = FormWindowState.Maximized;
        }

        private void LoadScreen(UserControl tela)
        {
            panelScreens.Controls.Clear(); 
            tela.Dock = DockStyle.Fill; 
            panelScreens.Controls.Add(tela); 
            

        }

        private void cadastroDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadScreen(new UserManagement());
        }
    }
}
