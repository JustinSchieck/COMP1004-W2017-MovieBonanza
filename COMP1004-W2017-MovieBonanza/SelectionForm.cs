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
            TitleTextBox.Text = Convert.ToString(MovieListBox.Text);
            SetPoster();
            CategorySelector();
            NextButton.Enabled = true;

        }


        private void SetPoster()
        {

            if (TitleTextBox.Text == "Season of the Witch")
            {
                MoviePictureBox.Image = Properties.Resources.Season_of_the_Witch;
            }
            if (TitleTextBox.Text == "The Green Hornet")
            { 
                MoviePictureBox.Image = Properties.Resources.The_Green_Hornet_Poster;
            }

            if (TitleTextBox.Text == "The Dilemma")
            {
                MoviePictureBox.Image = Properties.Resources.TheDilemma;
            }

            if (TitleTextBox.Text == "Death Race 2")
            {
                MoviePictureBox.Image = Properties.Resources.Death_Race_2;
            }

            if (TitleTextBox.Text == "Company Men")
            {
                MoviePictureBox.Image = Properties.Resources.Company_Men;
            }

            if (TitleTextBox.Text == "No Strings Attached")
            {
                MoviePictureBox.Image = Properties.Resources.No_Strings_Attached_Poster;
            }

            if (TitleTextBox.Text == "The Way Back")
            {
                MoviePictureBox.Image = Properties.Resources.The_Way_Back;
            }

            if (TitleTextBox.Text == "The Mechanic")
            {
                MoviePictureBox.Image = Properties.Resources.Mechanic_poster;
            }
            if (TitleTextBox.Text == "The Rite")
            {
                MoviePictureBox.Image = Properties.Resources.The_rite;
            }

            if (TitleTextBox.Text == "Sanctum")
            {
                MoviePictureBox.Image = Properties.Resources.sanctum;
            }

            if (TitleTextBox.Text == "The Other Woman")
            {
                MoviePictureBox.Image = Properties.Resources.The_Other_Woman;
            }

            if (TitleTextBox.Text == "The Roommate")
            {
                MoviePictureBox.Image = Properties.Resources.Roommate;
            }

            if (TitleTextBox.Text == "Waiting for Forever")
            {
                MoviePictureBox.Image = Properties.Resources.Waiting_for_Forever;
            }

            if (TitleTextBox.Text == "Cedar Rapids")
            {
                MoviePictureBox.Image = Properties.Resources.CedarRapids;
            }

            if (TitleTextBox.Text == "Gnomeo and Juliet")
            {
                MoviePictureBox.Image = Properties.Resources.Gnomeo___Juliet;
            }

            if (TitleTextBox.Text == "Just Go With It")
            {
                MoviePictureBox.Image = Properties.Resources.Just_Go_with_It;
            }

            if (TitleTextBox.Text == "The Eagle")
            {
                MoviePictureBox.Image = Properties.Resources.The_Eagle;
            }

            if (TitleTextBox.Text == "I am Number Four")
            {
                MoviePictureBox.Image = Properties.Resources.I_Am_Number_Four;
            }

            if (TitleTextBox.Text == "Footloose")
            {
                MoviePictureBox.Image = Properties.Resources.Footloose;
            }

            if (TitleTextBox.Text == "Real Steel")
            {
                MoviePictureBox.Image = Properties.Resources.Real_Steel;
            }
        }

        private void CategorySelector()
        {
            try {
                if (TitleTextBox.Text == "Season of the Witch" || TitleTextBox.Text == "I am Number Four")
                {
                    CategoryTextBox.Text = "Sci-Fi";
                }
                if (TitleTextBox.Text == "The Green Hornet" || TitleTextBox.Text == "Death Race 2" || TitleTextBox.Text == "The Mechanic" ||
                    TitleTextBox.Text == "Sanctum" || TitleTextBox.Text == "The Eagle")
                {
                    CategoryTextBox.Text = "Action";
                }
                if (TitleTextBox.Text == "The Dilemma" || TitleTextBox.Text == "No Strings Attached" || TitleTextBox.Text == "Cedar Rapids"
                    || TitleTextBox.Text == "Just Go With It")
                {
                    CategoryTextBox.Text = "Comedy";
                }
                if (TitleTextBox.Text == "Company Men" || TitleTextBox.Text == "The Way Back" || TitleTextBox.Text == "Waiting for Forever")
                {
                    CategoryTextBox.Text = "Drama";
                }
                if (TitleTextBox.Text == "The Roomate")
                {
                    CategoryTextBox.Text = "Thriller";
                }
                if (TitleTextBox.Text == "The Rite")
                {
                    CategoryTextBox.Text = "Horror";
                }
                if (TitleTextBox.Text == "Gnomeo and Juliet")
                {
                    CategoryTextBox.Text = "Family";
                }
                else
                {
                    CategoryTextBox.Text = "New Release";
                }
            }
            catch
            {
                MessageBox.Show("Please fill choose a valid movie");
                return;
            }
        }



    }
}
