namespace DBmovie
{
    partial class Form1
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
            this.textid_movie = new System.Windows.Forms.TextBox();
            this.textnom_movie = new System.Windows.Forms.TextBox();
            this.buttinsert = new System.Windows.Forms.Button();
            this.buttupdate = new System.Windows.Forms.Button();
            this.buttdelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combobox = new System.Windows.Forms.ComboBox();
            this.buttvalidate = new System.Windows.Forms.Button();
            this.buttcancel = new System.Windows.Forms.Button();
            this.Movies = new System.Windows.Forms.Label();
            this.buttsearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textid_movie
            // 
            this.textid_movie.Location = new System.Drawing.Point(162, 356);
            this.textid_movie.Name = "textid_movie";
            this.textid_movie.Size = new System.Drawing.Size(266, 22);
            this.textid_movie.TabIndex = 0;
            // 
            // textnom_movie
            // 
            this.textnom_movie.Location = new System.Drawing.Point(162, 398);
            this.textnom_movie.Name = "textnom_movie";
            this.textnom_movie.Size = new System.Drawing.Size(266, 22);
            this.textnom_movie.TabIndex = 1;
            // 
            // buttinsert
            // 
            this.buttinsert.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttinsert.Location = new System.Drawing.Point(593, 123);
            this.buttinsert.Name = "buttinsert";
            this.buttinsert.Size = new System.Drawing.Size(102, 44);
            this.buttinsert.TabIndex = 3;
            this.buttinsert.Text = "insert";
            this.buttinsert.UseVisualStyleBackColor = false;
            this.buttinsert.Click += new System.EventHandler(this.buttinsert_Click);
            // 
            // buttupdate
            // 
            this.buttupdate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttupdate.Location = new System.Drawing.Point(593, 198);
            this.buttupdate.Name = "buttupdate";
            this.buttupdate.Size = new System.Drawing.Size(102, 43);
            this.buttupdate.TabIndex = 4;
            this.buttupdate.Text = "update";
            this.buttupdate.UseVisualStyleBackColor = false;
            this.buttupdate.Click += new System.EventHandler(this.buttupdate_Click);
            // 
            // buttdelete
            // 
            this.buttdelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttdelete.Location = new System.Drawing.Point(593, 267);
            this.buttdelete.Name = "buttdelete";
            this.buttdelete.Size = new System.Drawing.Size(102, 44);
            this.buttdelete.TabIndex = 5;
            this.buttdelete.Text = "delete";
            this.buttdelete.UseVisualStyleBackColor = false;
            this.buttdelete.Click += new System.EventHandler(this.buttdelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(111, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Oswald", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(99, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 42);
            this.label2.TabIndex = 8;
            this.label2.Text = "nom";
            // 
            // combobox
            // 
            this.combobox.FormattingEnabled = true;
            this.combobox.Location = new System.Drawing.Point(89, 109);
            this.combobox.Name = "combobox";
            this.combobox.Size = new System.Drawing.Size(387, 24);
            this.combobox.TabIndex = 9;
            this.combobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttvalidate
            // 
            this.buttvalidate.Location = new System.Drawing.Point(607, 358);
            this.buttvalidate.Name = "buttvalidate";
            this.buttvalidate.Size = new System.Drawing.Size(75, 23);
            this.buttvalidate.TabIndex = 10;
            this.buttvalidate.Text = "validate";
            this.buttvalidate.UseVisualStyleBackColor = true;
            this.buttvalidate.Click += new System.EventHandler(this.buttvalidate_Click);
            // 
            // buttcancel
            // 
            this.buttcancel.Location = new System.Drawing.Point(607, 400);
            this.buttcancel.Name = "buttcancel";
            this.buttcancel.Size = new System.Drawing.Size(75, 23);
            this.buttcancel.TabIndex = 11;
            this.buttcancel.Text = "cancel";
            this.buttcancel.UseVisualStyleBackColor = true;
            this.buttcancel.Click += new System.EventHandler(this.buttcancel_Click);
            // 
            // Movies
            // 
            this.Movies.AutoSize = true;
            this.Movies.Font = new System.Drawing.Font("Oswald", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movies.Location = new System.Drawing.Point(231, 48);
            this.Movies.Name = "Movies";
            this.Movies.Size = new System.Drawing.Size(124, 56);
            this.Movies.TabIndex = 12;
            this.Movies.Text = "Movies ";
            // 
            // buttsearch
            // 
            this.buttsearch.Location = new System.Drawing.Point(241, 155);
            this.buttsearch.Name = "buttsearch";
            this.buttsearch.Size = new System.Drawing.Size(75, 23);
            this.buttsearch.TabIndex = 13;
            this.buttsearch.Text = "search";
            this.buttsearch.UseVisualStyleBackColor = true;
            this.buttsearch.Click += new System.EventHandler(this.buttsearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttsearch);
            this.Controls.Add(this.Movies);
            this.Controls.Add(this.buttcancel);
            this.Controls.Add(this.buttvalidate);
            this.Controls.Add(this.combobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttdelete);
            this.Controls.Add(this.buttupdate);
            this.Controls.Add(this.buttinsert);
            this.Controls.Add(this.textnom_movie);
            this.Controls.Add(this.textid_movie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textid_movie;
        private System.Windows.Forms.TextBox textnom_movie;
        private System.Windows.Forms.Button buttinsert;
        private System.Windows.Forms.Button buttupdate;
        private System.Windows.Forms.Button buttdelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combobox;
        private System.Windows.Forms.Button buttvalidate;
        private System.Windows.Forms.Button buttcancel;
        private System.Windows.Forms.Label Movies;
        private System.Windows.Forms.Button buttsearch;
    }
}

