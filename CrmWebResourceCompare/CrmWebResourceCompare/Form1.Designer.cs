namespace CrmWebResourceCompare
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPublishedWebResourcesFolder = new System.Windows.Forms.Label();
            this.lblGitFolder = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBoxEquals = new System.Windows.Forms.ListBox();
            this.listBoxDifferents = new System.Windows.Forms.ListBox();
            this.listBoxNotFoundsOrMultipleFounds = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCountEquals = new System.Windows.Forms.Label();
            this.labelCountDifferents = new System.Windows.Forms.Label();
            this.labelCountNotFoundOrMultipleFounds = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Published Web Resources Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Git Folder";
            // 
            // lblPublishedWebResourcesFolder
            // 
            this.lblPublishedWebResourcesFolder.AutoSize = true;
            this.lblPublishedWebResourcesFolder.Location = new System.Drawing.Point(288, 9);
            this.lblPublishedWebResourcesFolder.Name = "lblPublishedWebResourcesFolder";
            this.lblPublishedWebResourcesFolder.Size = new System.Drawing.Size(0, 13);
            this.lblPublishedWebResourcesFolder.TabIndex = 2;
            // 
            // lblGitFolder
            // 
            this.lblGitFolder.AutoSize = true;
            this.lblGitFolder.Location = new System.Drawing.Point(288, 43);
            this.lblGitFolder.Name = "lblGitFolder";
            this.lblGitFolder.Size = new System.Drawing.Size(0, 13);
            this.lblGitFolder.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Select Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Select Folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(182, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Compare";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBoxEquals
            // 
            this.listBoxEquals.FormattingEnabled = true;
            this.listBoxEquals.HorizontalScrollbar = true;
            this.listBoxEquals.Location = new System.Drawing.Point(29, 141);
            this.listBoxEquals.Name = "listBoxEquals";
            this.listBoxEquals.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxEquals.Size = new System.Drawing.Size(276, 355);
            this.listBoxEquals.TabIndex = 7;
            // 
            // listBoxDifferents
            // 
            this.listBoxDifferents.FormattingEnabled = true;
            this.listBoxDifferents.HorizontalScrollbar = true;
            this.listBoxDifferents.Location = new System.Drawing.Point(326, 141);
            this.listBoxDifferents.Name = "listBoxDifferents";
            this.listBoxDifferents.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxDifferents.Size = new System.Drawing.Size(276, 355);
            this.listBoxDifferents.TabIndex = 8;
            // 
            // listBoxNotFoundsOrMultipleFounds
            // 
            this.listBoxNotFoundsOrMultipleFounds.FormattingEnabled = true;
            this.listBoxNotFoundsOrMultipleFounds.HorizontalScrollbar = true;
            this.listBoxNotFoundsOrMultipleFounds.Location = new System.Drawing.Point(627, 141);
            this.listBoxNotFoundsOrMultipleFounds.Name = "listBoxNotFoundsOrMultipleFounds";
            this.listBoxNotFoundsOrMultipleFounds.Size = new System.Drawing.Size(276, 355);
            this.listBoxNotFoundsOrMultipleFounds.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Equal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Different";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(624, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Not Found or Multiple Found";
            // 
            // labelCountEquals
            // 
            this.labelCountEquals.AutoSize = true;
            this.labelCountEquals.Location = new System.Drawing.Point(288, 109);
            this.labelCountEquals.Name = "labelCountEquals";
            this.labelCountEquals.Size = new System.Drawing.Size(0, 13);
            this.labelCountEquals.TabIndex = 13;
            // 
            // labelCountDifferents
            // 
            this.labelCountDifferents.AutoSize = true;
            this.labelCountDifferents.Location = new System.Drawing.Point(591, 109);
            this.labelCountDifferents.Name = "labelCountDifferents";
            this.labelCountDifferents.Size = new System.Drawing.Size(0, 13);
            this.labelCountDifferents.TabIndex = 14;
            // 
            // labelCountNotFoundOrMultipleFounds
            // 
            this.labelCountNotFoundOrMultipleFounds.AutoSize = true;
            this.labelCountNotFoundOrMultipleFounds.Location = new System.Drawing.Point(882, 109);
            this.labelCountNotFoundOrMultipleFounds.Name = "labelCountNotFoundOrMultipleFounds";
            this.labelCountNotFoundOrMultipleFounds.Size = new System.Drawing.Size(0, 13);
            this.labelCountNotFoundOrMultipleFounds.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(385, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Copy";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(88, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Copy";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(771, 99);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "Copy";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(439, 99);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = "Select All";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 508);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.labelCountNotFoundOrMultipleFounds);
            this.Controls.Add(this.labelCountDifferents);
            this.Controls.Add(this.labelCountEquals);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxNotFoundsOrMultipleFounds);
            this.Controls.Add(this.listBoxDifferents);
            this.Controls.Add(this.listBoxEquals);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblGitFolder);
            this.Controls.Add(this.lblPublishedWebResourcesFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ERMS.Net - WebResources Comparer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPublishedWebResourcesFolder;
        private System.Windows.Forms.Label lblGitFolder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBoxEquals;
        private System.Windows.Forms.ListBox listBoxDifferents;
        private System.Windows.Forms.ListBox listBoxNotFoundsOrMultipleFounds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCountEquals;
        private System.Windows.Forms.Label labelCountDifferents;
        private System.Windows.Forms.Label labelCountNotFoundOrMultipleFounds;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

