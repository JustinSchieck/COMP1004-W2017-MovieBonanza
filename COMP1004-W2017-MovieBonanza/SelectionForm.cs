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
    public partial class SelectionForm : Form
    {

        string[] Selection = new string[3]; 

        public SelectionForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            try
            {

                Selection[0] = TitleTextBox.Text;
                Selection[1] = CategoryTextBox.Text;
                Selection[2] = CostTextBox.Text;

                if (TitleTextBox.Text == "")
                {
                    throw new Exception();
                }
                if (CategoryTextBox.Text == "")
                {
                    throw new Exception();
                }
                if (CostTextBox.Text == "")
                {
                    throw new Exception();
                }

            }
            catch
            {
                MessageBox.Show("Please fill in a valid choice");
                return;    
            }


            this.Hide();

            OrderForm orderForm = new OrderForm();

            orderForm.previousForm = this;

            orderForm.Show();

        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NextButton.Enabled = true;
            _SetPoster();

        }


        private void _SetPoster()
        {

            if (TitleTextBox.Text == "Season of the Witch")
            {
                
            }

        }
    }
}
