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
    public partial class OrderForm : Form
    {

        Movie movie = new Movie();

        public OrderForm()
        {
            InitializeComponent();
        }

        private void _OrderForm_Load(object sender, EventArgs e)
        {
            TitleTextBox.Text = Program.movie.title;
            CategoryTextBox.Text = Program.movie.category;
            CostTextBox.Text = Program.movie.cost;
            MovieSelectedPictureBox.Image = Program.movie.image;
            _GetTotalCost();
        }

        private void _GetTotalCost()
        {

            if(DvdCheckBox.Checked == true)
            {
                double Subtotal = Convert.ToDouble(Program.movie.cost) + 10;
                double Tax = Subtotal * 0.13;
                double Total = Subtotal * 1.13;
                DvdLabel.Show();
                DvdTextBox.Text = "10.00";
                DvdTextBox.Show();
                SubtotalTextBox.Text = Subtotal.ToString("C2");
                SalesTaxTextBox.Text = Tax.ToString("C2");
                GrandTotalTextBox.Text = Total.ToString("C2");

            }
            else
            {
                double Subtotal = Convert.ToDouble(Program.movie.cost);
                double Tax = Subtotal * 0.13;
                double Total = Subtotal * 1.13;
                DvdTextBox.Hide();
                DvdLabel.Hide();
                SubtotalTextBox.Text = Subtotal.ToString("C2");
                SalesTaxTextBox.Text = Tax.ToString("C2");
                GrandTotalTextBox.Text = Total.ToString("C2");
            }


        }

        private void _DvdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _GetTotalCost();
            
        }

        private void _aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutbox = new AboutBox();

            aboutbox.ShowDialog();
        }

        private void _CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _StreamButton_Click(object sender, EventArgs e)
        {

            Program.movie.cost = GrandTotalTextBox.Text;

            this.Hide();

            StreamForm streamForm = new StreamForm();
            streamForm.Show();
        }

        private void _printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have ordered: " + "\n" + TitleTextBox.Text + "\n" + "Genre: " + CategoryTextBox.Text +
                "\n" + "Cost: " + GrandTotalTextBox.Text);
        }

        private void _BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            SelectionForm selectionForm = new SelectionForm();
            selectionForm.Show();
        }
    }
}
