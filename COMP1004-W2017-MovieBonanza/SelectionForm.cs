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

        private void _NextButton_Click(object sender, EventArgs e)
        {
            try
            {

                Program.movie.title = TitleTextBox.Text;
                Program.movie.category = CategoryTextBox.Text;
                Program.movie.cost = CostTextBox.Text;
                

                //Selection[0] = TitleTextBox.Text;
                //Selection[1] = CategoryTextBox.Text;
                //Selection[2] = CostTextBox.Text;

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
            orderForm.Show();

        }

        private void _MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitleTextBox.Text = Convert.ToString(MovieListBox.Text);
            _SetPoster();
            _CategorySelector();
            NextButton.Enabled = true;

        }


        private void _SetPoster()
        {

            if (TitleTextBox.Text == "Season of the Witch")
            {
                MoviePictureBox.Image = Properties.Resources.Season_of_the_Witch;
                Program.movie.image = Properties.Resources.Season_of_the_Witch;
            }
            else if (TitleTextBox.Text == "The Green Hornet")
            { 
                MoviePictureBox.Image = Properties.Resources.The_Green_Hornet_Poster;
                Program.movie.image = Properties.Resources.The_Green_Hornet_Poster;
            }

            else if (TitleTextBox.Text == "The Dilemma")
            {
                MoviePictureBox.Image = Properties.Resources.TheDilemma;
                Program.movie.image = Properties.Resources.TheDilemma;
            }

            else if (TitleTextBox.Text == "Death Race 2")
            {
                MoviePictureBox.Image = Properties.Resources.Death_Race_2;
                Program.movie.image = Properties.Resources.Death_Race_2;
            }

            else if (TitleTextBox.Text == "Company Men")
            {
                MoviePictureBox.Image = Properties.Resources.Company_Men;
                Program.movie.image = Properties.Resources.Company_Men;
            }

            else if (TitleTextBox.Text == "No Strings Attached")
            {
                MoviePictureBox.Image = Properties.Resources.No_Strings_Attached_Poster;
                Program.movie.image = Properties.Resources.No_Strings_Attached_Poster;
            }

            else if (TitleTextBox.Text == "The Way Back")
            {
                MoviePictureBox.Image = Properties.Resources.The_Way_Back;
                Program.movie.image = Properties.Resources.The_Way_Back;
            }

            else if (TitleTextBox.Text == "The Mechanic")
            {
                MoviePictureBox.Image = Properties.Resources.Mechanic_poster;
                Program.movie.image = Properties.Resources.Mechanic_poster;
            }
            else if (TitleTextBox.Text == "The Rite")
            {
                MoviePictureBox.Image = Properties.Resources.The_rite;
                Program.movie.image = Properties.Resources.The_rite;
            }

            else if (TitleTextBox.Text == "Sanctum")
            {
                MoviePictureBox.Image = Properties.Resources.sanctum;
                Program.movie.image = Properties.Resources.sanctum;
            }

            else if (TitleTextBox.Text == "The Other Woman")
            {
                MoviePictureBox.Image = Properties.Resources.The_Other_Woman;
                Program.movie.image = Properties.Resources.The_Other_Woman;
            }

            else if (TitleTextBox.Text == "The Roommate")
            {
                MoviePictureBox.Image = Properties.Resources.Roommate;
                Program.movie.image = Properties.Resources.Roommate;
            }

            else if (TitleTextBox.Text == "Waiting for Forever")
            {
                MoviePictureBox.Image = Properties.Resources.Waiting_for_Forever;
                Program.movie.image = Properties.Resources.Waiting_for_Forever;
            }

            else if (TitleTextBox.Text == "Cedar Rapids")
            {
                MoviePictureBox.Image = Properties.Resources.CedarRapids;
                Program.movie.image = Properties.Resources.CedarRapids;
            }

            else if (TitleTextBox.Text == "Gnomeo and Juliet")
            {
                MoviePictureBox.Image = Properties.Resources.Gnomeo___Juliet;
                Program.movie.image = Properties.Resources.Gnomeo___Juliet;
            }

            else if (TitleTextBox.Text == "Just Go With It")
            {
                MoviePictureBox.Image = Properties.Resources.Just_Go_with_It;
                Program.movie.image = Properties.Resources.Just_Go_with_It;
            }

            else if (TitleTextBox.Text == "The Eagle")
            {
                MoviePictureBox.Image = Properties.Resources.The_Eagle;
                Program.movie.image = Properties.Resources.The_Eagle;
            }

            else if (TitleTextBox.Text == "I am Number Four")
            {
                MoviePictureBox.Image = Properties.Resources.I_Am_Number_Four;
                Program.movie.image = Properties.Resources.I_Am_Number_Four;
            }

            else if (TitleTextBox.Text == "Footloose")
            {
                MoviePictureBox.Image = Properties.Resources.Footloose;
                Program.movie.image = Properties.Resources.Footloose;
            }

            else if (TitleTextBox.Text == "Real Steel")
            {
                MoviePictureBox.Image = Properties.Resources.Real_Steel;
                Program.movie.image = Properties.Resources.Real_Steel;
            }
        }

        private void _CategorySelector()
        {
          
                if (TitleTextBox.Text == "Season of the Witch" || TitleTextBox.Text == "I am Number Four")
                {
                    CategoryTextBox.Text = "Sci-Fi";
                }
                else if (TitleTextBox.Text == "The Green Hornet" || TitleTextBox.Text == "Death Race 2" || TitleTextBox.Text == "The Mechanic" ||
                    TitleTextBox.Text == "Sanctum" || TitleTextBox.Text == "The Eagle")
                {
                    CategoryTextBox.Text = "Action";
                }
                else if (TitleTextBox.Text == "The Dilemma" || TitleTextBox.Text == "No Strings Attached" || TitleTextBox.Text == "Cedar Rapids"
                    || TitleTextBox.Text == "Just Go With It" || TitleTextBox.Text == "The Other Woman")
                {
                    CategoryTextBox.Text = "Comedy";
                }
                else if (TitleTextBox.Text == "Company Men" || TitleTextBox.Text == "The Way Back" || TitleTextBox.Text == "Waiting for Forever")
                {
                    CategoryTextBox.Text = "Drama";
                }
                else if (TitleTextBox.Text == "The Roomate")
                {
                    CategoryTextBox.Text = "Thriller";
                }
                else if (TitleTextBox.Text == "The Rite")
                {
                    CategoryTextBox.Text = "Horror";
                }
                else if (TitleTextBox.Text == "Gnomeo and Juliet")
                {
                    CategoryTextBox.Text = "Family";
                }
                else
                {
                    CategoryTextBox.Text = "New Releases";
                }



            if (CategoryTextBox.Text == "Sci-Fi" || CategoryTextBox.Text == "Action" || CategoryTextBox.Text == "Horror")
            {
                CostTextBox.Text = "2.99";
            }

            else if (CategoryTextBox.Text == "Comedy" || CategoryTextBox.Text == "Drama" || CategoryTextBox.Text == "Thriller")
            {
                CostTextBox.Text = "1.99";
            }

            else if (CategoryTextBox.Text == "Family")
            {
                CostTextBox.Text = "0.99";
            }

            else if (CategoryTextBox.Text == "New Releases")
            {
                CostTextBox.Text = "4.99";
            }
        }

    

    }
}
