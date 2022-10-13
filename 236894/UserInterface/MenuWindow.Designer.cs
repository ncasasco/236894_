
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
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(250, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 445);
            this.panel2.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(185, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 53);
            this.button3.TabIndex = 15;
            this.button3.Text = "Add Movie";
            this.button3.UseVisualStyleBackColor = true;
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
            this.listView1.Size = new System.Drawing.Size(494, 279);
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
            this.panel3.Location = new System.Drawing.Point(250, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 450);
            this.panel3.TabIndex = 16;
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(768, 476);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu | Social Network";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}