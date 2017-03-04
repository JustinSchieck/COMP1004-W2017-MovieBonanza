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

        /// <summary>
        /// Program: Movie Bonanza Assignment 3
        /// Name: Justin Schieck
        /// StudentID: 200328630
        /// App Creation Date: March 4th, 2017
        /// App Desc: Mimics a streaming service for customers
        /// </summary>
        

        public StreamForm()
        {
            InitializeComponent();
        }

        //Finalizes the Stream and Starts it for the user, Application ends.
        private void _OkButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Loads the variables into the proper places in the labels.
        private void _StreamForm_Load(object sender, EventArgs e)
        {
            CostLabel.Text = "Your credit card will be charged " + Program.movie.cost + "\n" 
                + Program.movie.title + " will begin playing shortly.";
          
        }
    }
}
