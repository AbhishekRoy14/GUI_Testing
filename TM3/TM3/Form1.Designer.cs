namespace TM3
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.refresh_invertedIndex = new System.Windows.Forms.Button();
            this.browse_button = new System.Windows.Forms.Button();
            this.build_inverted_index = new System.Windows.Forms.Button();
            this.select_folder = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.display_statistics = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SearchTerms = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.refresh_invertedIndex);
            this.groupBox5.Controls.Add(this.browse_button);
            this.groupBox5.Controls.Add(this.build_inverted_index);
            this.groupBox5.Controls.Add(this.select_folder);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(554, 121);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select Folder";
            // 
            // refresh_invertedIndex
            // 
            this.refresh_invertedIndex.Location = new System.Drawing.Point(13, 75);
            this.refresh_invertedIndex.Name = "refresh_invertedIndex";
            this.refresh_invertedIndex.Size = new System.Drawing.Size(524, 23);
            this.refresh_invertedIndex.TabIndex = 7;
            this.refresh_invertedIndex.Text = "Refresh Inverted Index";
            this.refresh_invertedIndex.UseVisualStyleBackColor = true;
            this.refresh_invertedIndex.Click += new System.EventHandler(this.refresh_invertedIndex_Click);
            // 
            // browse_button
            // 
            this.browse_button.Location = new System.Drawing.Point(452, 17);
            this.browse_button.Name = "browse_button";
            this.browse_button.Size = new System.Drawing.Size(85, 23);
            this.browse_button.TabIndex = 6;
            this.browse_button.Text = "Browse";
            this.browse_button.UseVisualStyleBackColor = true;
            this.browse_button.Click += new System.EventHandler(this.browse_button_Click);
            // 
            // build_inverted_index
            // 
            this.build_inverted_index.Location = new System.Drawing.Point(13, 46);
            this.build_inverted_index.Name = "build_inverted_index";
            this.build_inverted_index.Size = new System.Drawing.Size(524, 23);
            this.build_inverted_index.TabIndex = 5;
            this.build_inverted_index.Text = "Build Inverted Index";
            this.build_inverted_index.UseVisualStyleBackColor = true;
            this.build_inverted_index.Click += new System.EventHandler(this.button2_Click);
            // 
            // select_folder
            // 
            this.select_folder.Location = new System.Drawing.Point(14, 19);
            this.select_folder.Name = "select_folder";
            this.select_folder.Size = new System.Drawing.Size(432, 20);
            this.select_folder.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.display_statistics);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 95);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(293, 15);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(85, 20);
            this.textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(452, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(85, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Average Term Length:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total Files:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total Terms:";
            // 
            // display_statistics
            // 
            this.display_statistics.Location = new System.Drawing.Point(13, 46);
            this.display_statistics.Name = "display_statistics";
            this.display_statistics.Size = new System.Drawing.Size(524, 23);
            this.display_statistics.TabIndex = 5;
            this.display_statistics.Text = "Display Statistics";
            this.display_statistics.UseVisualStyleBackColor = true;
            this.display_statistics.Click += new System.EventHandler(this.display_statistics_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 20);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.listBox1);
            this.groupBox9.Controls.Add(this.button2);
            this.groupBox9.Controls.Add(this.textBox6);
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Controls.Add(this.SearchTerms);
            this.groupBox9.Location = new System.Drawing.Point(12, 240);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(557, 236);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Search";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(14, 82);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(523, 121);
            this.listBox1.TabIndex = 45;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(452, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(81, 51);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(76, 20);
            this.textBox6.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Files Found:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 2;
            // 
            // SearchTerms
            // 
            this.SearchTerms.Location = new System.Drawing.Point(14, 25);
            this.SearchTerms.Name = "SearchTerms";
            this.SearchTerms.Size = new System.Drawing.Size(432, 20);
            this.SearchTerms.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 535);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button refresh_invertedIndex;
        private System.Windows.Forms.Button browse_button;
        private System.Windows.Forms.Button build_inverted_index;
        private System.Windows.Forms.TextBox select_folder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button display_statistics;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SearchTerms;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

