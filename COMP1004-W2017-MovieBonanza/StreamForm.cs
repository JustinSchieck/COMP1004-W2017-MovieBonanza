using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MovieBonanza
{
    public partial class StreamForm : Form
    {
        public StreamForm()
        {
            InitializeComponent();
        }

        private void _OkButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _StreamForm_Load(object sender, EventArgs e)
        {
            CostLabel.Text = "Your credit card will be charged " + Program.movie.cost;
            MovieLabel.Text = Program.movie.title + " will begin playing shortly.";
        }
    }
}
