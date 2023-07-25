using KL.CatAPI;

namespace CatAppUI
{
    internal class MainForm : Form
    {
        private readonly Label label;
        private readonly PictureBox pictureBox;
        private readonly CatAPIService api;

        public MainForm(CatAPIService api)
        {
            this.api = api;

            this.Size = new Size(500, 600);

            //panel stuff
            Panel mainPanel = new Panel();
            this.Controls.Add(mainPanel);
            mainPanel.Dock = DockStyle.Fill;

            //button stuff
            Button button = new Button();
            mainPanel.Controls.Add(button);
            button.Click += Button_Click;
            button.Text = "Load Picture";
            button.AutoSize = true;

            //label stuff
            this.label = new Label();
            mainPanel.Controls.Add(label);
            this.label.Location = new Point(0, 30);
            this.label.AutoSize = true;

            //picturebox stuff
            this.pictureBox = new PictureBox();
            mainPanel.Controls.Add(pictureBox);
            this.pictureBox.Location = new Point(0, 60);
            this.pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox.Size = new Size(500, 500);
        }

        //Button functionality
        private async void Button_Click(object? sender, EventArgs e)
        {
            CatPicture? picture = await api.GetRandomCatPicture();
            if (picture == null) return;

            this.pictureBox.Load(picture.Url);
        }
    }
}
