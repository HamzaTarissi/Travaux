namespace ConecDB
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
            this.buttinsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttupdate = new System.Windows.Forms.Button();
            this.buttdelete = new System.Windows.Forms.Button();
            this.buttselect = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttinsert
            // 
            this.buttinsert.Location = new System.Drawing.Point(606, 277);
            this.buttinsert.Name = "buttinsert";
            this.buttinsert.Size = new System.Drawing.Size(117, 35);
            this.buttinsert.TabIndex = 0;
            this.buttinsert.Text = "insert";
            this.buttinsert.UseVisualStyleBackColor = true;
            this.buttinsert.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 304);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(228, 360);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // buttupdate
            // 
            this.buttupdate.Location = new System.Drawing.Point(606, 328);
            this.buttupdate.Name = "buttupdate";
            this.buttupdate.Size = new System.Drawing.Size(117, 35);
            this.buttupdate.TabIndex = 5;
            this.buttupdate.Text = "Update";
            this.buttupdate.UseVisualStyleBackColor = true;
            this.buttupdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttdelete
            // 
            this.buttdelete.Location = new System.Drawing.Point(606, 382);
            this.buttdelete.Name = "buttdelete";
            this.buttdelete.Size = new System.Drawing.Size(117, 38);
            this.buttdelete.TabIndex = 6;
            this.buttdelete.Text = "Delete";
            this.buttdelete.UseVisualStyleBackColor = true;
            this.buttdelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttselect
            // 
            this.buttselect.Location = new System.Drawing.Point(606, 57);
            this.buttselect.Name = "buttselect";
            this.buttselect.Size = new System.Drawing.Size(117, 204);
            this.buttselect.TabIndex = 7;
            this.buttselect.Text = "Select";
            this.buttselect.UseVisualStyleBackColor = true;
            this.buttselect.Click += new System.EventHandler(this.buttselect_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(471, 204);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttselect);
            this.Controls.Add(this.buttdelete);
            this.Controls.Add(this.buttupdate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttinsert);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttinsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttupdate;
        private System.Windows.Forms.Button buttdelete;
        private System.Windows.Forms.Button buttselect;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

