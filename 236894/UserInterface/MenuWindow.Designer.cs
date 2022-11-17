
namespace UserInterface
{
    partial class MenuWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenres = new System.Windows.Forms.Button();
            this.btnMovies = new System.Windows.Forms.Button();
            this.bnSalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textMovieOtherGenre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textMovieGenre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxSponsor = new System.Windows.Forms.CheckBox();
            this.checkBoxExplicit = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textMovieDesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPoster = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textMovieName = new System.Windows.Forms.TextBox();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.textGenreDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textGenreName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.btnGenres);
            this.panel1.Controls.Add(this.btnMovies);
            this.panel1.Controls.Add(this.bnSalir);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 447);
            this.panel1.TabIndex = 0;
            // 
            // btnGenres
            // 
            this.btnGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenres.Location = new System.Drawing.Point(0, 110);
            this.btnGenres.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenres.Name = "btnGenres";
            this.btnGenres.Size = new System.Drawing.Size(227, 55);
            this.btnGenres.TabIndex = 5;
            this.btnGenres.Text = "Manage Genres";
            this.btnGenres.UseVisualStyleBackColor = true;
            this.btnGenres.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMovies
            // 
            this.btnMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovies.Location = new System.Drawing.Point(0, 47);
            this.btnMovies.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(227, 55);
            this.btnMovies.TabIndex = 4;
            this.btnMovies.Text = "Manage Movies";
            this.btnMovies.UseVisualStyleBackColor = true;
            this.btnMovies.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // bnSalir
            // 
            this.bnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnSalir.Location = new System.Drawing.Point(0, 372);
            this.bnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.bnSalir.Name = "bnSalir";
            this.bnSalir.Size = new System.Drawing.Size(227, 55);
            this.bnSalir.TabIndex = 3;
            this.bnSalir.Text = "Exit";
            this.bnSalir.UseVisualStyleBackColor = true;
            this.bnSalir.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textMovieOtherGenre);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textMovieGenre);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.checkBoxSponsor);
            this.panel2.Controls.Add(this.checkBoxExplicit);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textMovieDesc);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnPoster);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textMovieName);
            this.panel2.Controls.Add(this.textBoxURL);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(250, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 450);
            this.panel2.TabIndex = 4;
            // 
            // textMovieOtherGenre
            // 
            this.textMovieOtherGenre.Location = new System.Drawing.Point(97, 295);
            this.textMovieOtherGenre.Name = "textMovieOtherGenre";
            this.textMovieOtherGenre.Size = new System.Drawing.Size(168, 22);
            this.textMovieOtherGenre.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(12, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "2nd Genre";
            // 
            // textMovieGenre
            // 
            this.textMovieGenre.Location = new System.Drawing.Point(97, 266);
            this.textMovieGenre.Name = "textMovieGenre";
            this.textMovieGenre.Size = new System.Drawing.Size(168, 22);
            this.textMovieGenre.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(286, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 53);
            this.button2.TabIndex = 32;
            this.button2.Text = "Delete Movie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // checkBoxSponsor
            // 
            this.checkBoxSponsor.AutoSize = true;
            this.checkBoxSponsor.Location = new System.Drawing.Point(107, 413);
            this.checkBoxSponsor.Name = "checkBoxSponsor";
            this.checkBoxSponsor.Size = new System.Drawing.Size(98, 21);
            this.checkBoxSponsor.TabIndex = 31;
            this.checkBoxSponsor.Text = "checkBox2";
            this.checkBoxSponsor.UseVisualStyleBackColor = true;
            // 
            // checkBoxExplicit
            // 
            this.checkBoxExplicit.AutoSize = true;
            this.checkBoxExplicit.Location = new System.Drawing.Point(107, 385);
            this.checkBoxExplicit.Name = "checkBoxExplicit";
            this.checkBoxExplicit.Size = new System.Drawing.Size(98, 21);
            this.checkBoxExplicit.TabIndex = 30;
            this.checkBoxExplicit.Text = "checkBox1";
            this.checkBoxExplicit.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(12, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Sponsored";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(12, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Explicit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Genre";
            // 
            // textMovieDesc
            // 
            this.textMovieDesc.Location = new System.Drawing.Point(97, 357);
            this.textMovieDesc.Name = "textMovieDesc";
            this.textMovieDesc.Size = new System.Drawing.Size(168, 22);
            this.textMovieDesc.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(16, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Description";
            // 
            // btnPoster
            // 
            this.btnPoster.Location = new System.Drawing.Point(97, 322);
            this.btnPoster.Margin = new System.Windows.Forms.Padding(4);
            this.btnPoster.Name = "btnPoster";
            this.btnPoster.Size = new System.Drawing.Size(95, 28);
            this.btnPoster.TabIndex = 16;
            this.btnPoster.Text = "Browse...";
            this.btnPoster.UseVisualStyleBackColor = true;
            this.btnPoster.Click += new System.EventHandler(this.btnPoster_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 327);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Poster";
            // 
            // textMovieName
            // 
            this.textMovieName.Location = new System.Drawing.Point(97, 238);
            this.textMovieName.Name = "textMovieName";
            this.textMovieName.Size = new System.Drawing.Size(168, 22);
            this.textMovieName.TabIndex = 23;
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(199, 324);
            this.textBoxURL.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(168, 22);
            this.textBoxURL.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Name";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(286, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 53);
            this.button3.TabIndex = 15;
            this.button3.Text = "Add Movie";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(197, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Movies";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombre,
            this.genre});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(5, 53);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(494, 171);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // nombre
            // 
            this.nombre.Text = "Movie";
            this.nombre.Width = 255;
            // 
            // genre
            // 
            this.genre.Text = "Genre";
            this.genre.Width = 78;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textGenreDesc);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textGenreName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.listView2);
            this.panel3.Location = new System.Drawing.Point(250, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 450);
            this.panel3.TabIndex = 16;
            // 
            // textGenreDesc
            // 
            this.textGenreDesc.Location = new System.Drawing.Point(115, 376);
            this.textGenreDesc.Name = "textGenreDesc";
            this.textGenreDesc.Size = new System.Drawing.Size(150, 22);
            this.textGenreDesc.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(15, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Description";
            // 
            // textGenreName
            // 
            this.textGenreName.Location = new System.Drawing.Point(115, 322);
            this.textGenreName.Name = "textGenreName";
            this.textGenreName.Size = new System.Drawing.Size(150, 22);
            this.textGenreName.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(299, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 53);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add Genre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(195, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Genres";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(3, 45);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(494, 192);
            this.listView2.TabIndex = 16;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Genre";
            this.columnHeader1.Width = 255;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 216;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "fotoPoster";
            this.openFileDialog2.Filter = "Archivos de imagen |*.jpg;*.jpeg;*.png";
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(768, 476);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu | Threat Level Midnight Entertainment";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bnSalir;
        private System.Windows.Forms.Button btnGenres;
        private System.Windows.Forms.Button btnMovies;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.ColumnHeader genre;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textGenreDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textGenreName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Button btnPoster;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textMovieDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textMovieName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxSponsor;
        private System.Windows.Forms.CheckBox checkBoxExplicit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textMovieGenre;
        private System.Windows.Forms.TextBox textMovieOtherGenre;
        private System.Windows.Forms.Label label11;
    }
}