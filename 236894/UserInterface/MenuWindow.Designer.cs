
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
            this.btnExit = new System.Windows.Forms.Button();
            this.moviesView1 = new UserInterface.MoviesView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.btnGenres);
            this.panel1.Controls.Add(this.btnMovies);
            this.panel1.Controls.Add(this.btnExit);
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
            this.btnGenres.Visible = false;
            this.btnGenres.Click += new System.EventHandler(this.btnGenres_Click);
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
            this.btnMovies.Visible = false;
            this.btnMovies.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(0, 372);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(227, 55);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // moviesView1
            // 
            this.moviesView1.BackColor = System.Drawing.SystemColors.Desktop;
            this.moviesView1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.moviesView1.Location = new System.Drawing.Point(252, 15);
            this.moviesView1.Margin = new System.Windows.Forms.Padding(5);
            this.moviesView1.Name = "moviesView1";
            this.moviesView1.Size = new System.Drawing.Size(500, 450);
            this.moviesView1.TabIndex = 3;
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(768, 476);
            this.Controls.Add(this.moviesView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu | Social Network";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private MoviesView moviesView1;
        private System.Windows.Forms.Button btnGenres;
        private System.Windows.Forms.Button btnMovies;
    }
}