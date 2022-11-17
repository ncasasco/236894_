using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class MenuWindow : Form
    {
        private Context context;
        private UserContext userContext;
        private CredentialsManager credentials;
        private MovieContext movieContext;
        private GenreContext genreContext;

        public MenuWindow(Context newContext, UserContext newUserContext, CredentialsManager newCredentials)
        {
            InitializeComponent();
            panel2.Hide();
            panel3.Hide();
            btnMovies.Hide();
            btnGenres.Hide();
            context = newContext;
            userContext = newUserContext;
            credentials = newCredentials;
            genreContext = new GenreContext(context);
            movieContext = new MovieContext(context);
            if (credentials.UserLogged.IsAdmin)
            {
                btnMovies.Show();
                btnGenres.Show();
            }
            //foreach ()
        }
        private void button1_Click_3(object sender, EventArgs e)
        {
            panel2.Show();
            panel3.Hide();
            /*if (genreList != null)
            {
                foreach (Genre genre in genreList.GetAll())
                {
                    cmbMovieGenre.Items.Add(genre.GenreName);
                }
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel3.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            credentials.Logout();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Genre genre = new Genre();

            try
            {
                genre.GenreName = textGenreName.Text;
                genre.Description = textGenreDesc.Text;
                genreContext.AddGenre(genre);
                ListViewItem item = new ListViewItem(textGenreName.Text);
                item.SubItems.Add(textGenreDesc.Text);
                listView2.Items.Add(item);
                textGenreName.Clear();
                textGenreDesc.Clear();
                MessageBox.Show("Genre created", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArgumentNullException exc2)
            {
                MessageBox.Show(exc2.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (BusinessLogicException exc2)
            {
                MessageBox.Show(exc2.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPoster_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                textBoxURL.Text = openFileDialog2.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();

            try
            {
                movie.MovieName = textMovieName.Text;
                //movie.Genres.Add(cmbMovieGenre.Text);
                movie.Genre = textMovieGenre.Text;
                movie.OtherGenre = textMovieOtherGenre.Text;
                movie.PicturePath = textBoxURL.Text;
                movie.Description = textMovieDesc.Text;
                movie.IsExplicit = checkBoxExplicit.Checked;
                movie.IsSponsored = checkBoxSponsor.Checked;
                this.movieContext.AddMovie(movie);
                ListViewItem item = new ListViewItem(textMovieName.Text);
                //item.SubItems.Add(cmbMovieGenre.Text);
                item.SubItems.Add(textMovieGenre.Text);
                listView1.Items.Add(item);
                textMovieName.Clear();
                textMovieGenre.Clear();
                textMovieDesc.Clear();
                textBoxURL.Clear();
                checkBoxExplicit.Checked = false;
                checkBoxSponsor.Checked = false;
                MessageBox.Show("Movie created", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArgumentNullException exc2)
            {
                MessageBox.Show(exc2.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (BusinessLogicException exc2)
            {
                MessageBox.Show(exc2.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0 && listView1.SelectedItems != null)
            {
                string auxName = listView1.SelectedItems[0].Text;
                movieContext.Remove(auxName);
                listView1.Items.Remove(listView1.SelectedItems[0]);
                MessageBox.Show("Movie removed", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
