using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Choose_a_Picture
{
    /// <summary>
    /// IS 3.14 Choose a Picture
    /// This form uses a picturebox and a combobox to provide the simple function
    /// of displaying a user chosen image
    /// Author: Shan Ahmed 21813031
    /// </summary>
    /// 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Choice.Text)
            {
                case "alien": Pictures.Image = Image.FromFile("alien.gif"); break;
                case "Dragon": Pictures.Image = Image.FromFile("dragon.gif"); break;
                case "Hydra": Pictures.Image = Image.FromFile("hydra.gif"); break;
                case "Medusa": Pictures.Image = Image.FromFile("medusa.jpg"); break;
                case "Scorpius": Pictures.Image = Image.FromFile("scorpius.jpg"); break;
                case "Shadow": Pictures.Image = Image.FromFile("shadow.jpg"); break;
            }
            
          
        }

        private void Pictures_Click(object sender, EventArgs e)
        {
            
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
