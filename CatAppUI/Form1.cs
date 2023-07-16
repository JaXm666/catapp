using KL.CatAPI;

namespace CatAppUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.button1.Text = CatAPI.GetSomeString();
        }
    }
}