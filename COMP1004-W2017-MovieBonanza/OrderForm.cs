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

        /// <summary>
        /// Program: Movie Bonanza Assignment 3
        /// Name: Justin Schieck
        /// StudentID: 200328630
        /// App Creation Date: March 4th, 2017
        /// App Desc: Mimics a streaming service for customers
        /// </summary>

         
        Movie movie = new Movie();

        public OrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// on loading the form, takes saved information and populates the variables, also runs the total cost method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _OrderForm_Load(object sender, EventArgs e)
        {
            TitleTextBox.Text = Program.movie.title;
            CategoryTextBox.Text = Program.movie.category;
            CostTextBox.Text = Program.movie.cost;
            MovieSelectedPictureBox.Image = Program.movie.image;
            _GetTotalCost();
        }


        /// <summary>
        /// Checks if user wants physical copy of dvd, does the math and displays final cost, 
        /// filling textboxes with appropriate info.
        /// </summary>
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

        //shows about box with appropriate information
        private void _aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutbox = new AboutBox();

            aboutbox.ShowDialog();
        }

        //ends application
        private void _CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //brings up stream window and hides this form. Sends total cost to the cost variable
        private void _StreamButton_Click(object sender, EventArgs e)
        {

            Program.movie.cost = GrandTotalTextBox.Text;

            this.Hide();

            StreamForm streamForm = new StreamForm();
            streamForm.Show();
        }

        /// <summary>
        /// shows the print screen of summary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have ordered: " + "\n" + TitleTextBox.Text + "\n" + "Genre: " + CategoryTextBox.Text +
                "\n" + "Cost: " + GrandTotalTextBox.Text);
        }

        /// <summary>
        /// goes back to previous form that was cleared for re use
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            SelectionForm selectionForm = new SelectionForm();
            selectionForm.Show();
        }
    }
}
