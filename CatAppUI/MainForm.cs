using KL.CatAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace CatAppUI
{
    internal class MainForm : Form
    {
        Label label;
        PictureBox pictureBox;
        public MainForm()
        {

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
            label = new Label();
            mainPanel.Controls.Add(label);
            label.Location = new Point(0, 30);
            label.AutoSize = true;




            //picturebox stuff
            pictureBox = new PictureBox();
            mainPanel.Controls.Add(pictureBox);
            pictureBox.Location = new Point(0, 60);

        }

        //Button functionality
        private async void Button_Click(object? sender, EventArgs e)
        {
            CatPicture? picture = await CatAPI.GetRandomCatPicture();
            if (picture == null)
            {
                return;
            }

            pictureBox.Size = new Size(picture.Width, picture.Height);
            pictureBox.Load(picture.Url);

        }
    }
}
