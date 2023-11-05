using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace TrainerSharshekeev
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetStartedWelcomeButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
