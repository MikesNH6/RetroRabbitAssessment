namespace CodingChallenge
{
    partial class CodingCallengeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodingCallengeForm));
            this.FileUploaded = new System.Windows.Forms.Label();
            this.TextFileDisplayBox = new System.Windows.Forms.TextBox();
            this.SearchString = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.ResultsDisplayBox = new System.Windows.Forms.TextBox();
            this.MatchingResults = new System.Windows.Forms.Label();
            this.MatchCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FileUploaded
            // 
            this.FileUploaded.AutoSize = true;
            this.FileUploaded.ForeColor = System.Drawing.Color.Chartreuse;
            this.FileUploaded.Location = new System.Drawing.Point(20, 12);
            this.FileUploaded.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileUploaded.Name = "FileUploaded";
            this.FileUploaded.Size = new System.Drawing.Size(95, 17);
            this.FileUploaded.TabIndex = 0;
            this.FileUploaded.Text = "File Uploaded";
            // 
            // TextFileDisplayBox
            // 
            this.TextFileDisplayBox.BackColor = System.Drawing.Color.DimGray;
            this.TextFileDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextFileDisplayBox.ForeColor = System.Drawing.Color.White;
            this.TextFileDisplayBox.Location = new System.Drawing.Point(23, 32);
            this.TextFileDisplayBox.Multiline = true;
            this.TextFileDisplayBox.Name = "TextFileDisplayBox";
            this.TextFileDisplayBox.ReadOnly = true;
            this.TextFileDisplayBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextFileDisplayBox.Size = new System.Drawing.Size(257, 242);
            this.TextFileDisplayBox.TabIndex = 2;
            // 
            // SearchString
            // 
            this.SearchString.AutoSize = true;
            this.SearchString.ForeColor = System.Drawing.Color.Chartreuse;
            this.SearchString.Location = new System.Drawing.Point(295, 12);
            this.SearchString.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchString.Name = "SearchString";
            this.SearchString.Size = new System.Drawing.Size(94, 17);
            this.SearchString.TabIndex = 3;
            this.SearchString.Text = "Search String";
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.DimGray;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SearchBox.ForeColor = System.Drawing.Color.White;
            this.SearchBox.Location = new System.Drawing.Point(298, 32);
            this.SearchBox.MaxLength = 5;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(251, 23);
            this.SearchBox.TabIndex = 1;
            this.SearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Search_KeyUp);
            // 
            // ResultsDisplayBox
            // 
            this.ResultsDisplayBox.BackColor = System.Drawing.Color.DimGray;
            this.ResultsDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultsDisplayBox.ForeColor = System.Drawing.Color.White;
            this.ResultsDisplayBox.Location = new System.Drawing.Point(298, 93);
            this.ResultsDisplayBox.Multiline = true;
            this.ResultsDisplayBox.Name = "ResultsDisplayBox";
            this.ResultsDisplayBox.ReadOnly = true;
            this.ResultsDisplayBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultsDisplayBox.Size = new System.Drawing.Size(251, 181);
            this.ResultsDisplayBox.TabIndex = 3;
            // 
            // MatchingResults
            // 
            this.MatchingResults.AutoSize = true;
            this.MatchingResults.ForeColor = System.Drawing.Color.Chartreuse;
            this.MatchingResults.Location = new System.Drawing.Point(299, 73);
            this.MatchingResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MatchingResults.Name = "MatchingResults";
            this.MatchingResults.Size = new System.Drawing.Size(116, 17);
            this.MatchingResults.TabIndex = 6;
            this.MatchingResults.Text = "Matching Results";
            // 
            // MatchCount
            // 
            this.MatchCount.AutoSize = true;
            this.MatchCount.ForeColor = System.Drawing.Color.Chartreuse;
            this.MatchCount.Location = new System.Drawing.Point(423, 73);
            this.MatchCount.Name = "MatchCount";
            this.MatchCount.Size = new System.Drawing.Size(0, 17);
            this.MatchCount.TabIndex = 7;
            // 
            // CodingCallengeForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(573, 291);
            this.Controls.Add(this.MatchCount);
            this.Controls.Add(this.MatchingResults);
            this.Controls.Add(this.ResultsDisplayBox);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SearchString);
            this.Controls.Add(this.TextFileDisplayBox);
            this.Controls.Add(this.FileUploaded);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Chartreuse;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CodingCallengeForm";
            this.Text = "Coding Challenge (Michael Harris)";
            this.Load += new System.EventHandler(this.CodingCallengeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FileUploaded;
        public System.Windows.Forms.TextBox TextFileDisplayBox;
        private System.Windows.Forms.Label SearchString;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.TextBox ResultsDisplayBox;
        private System.Windows.Forms.Label MatchingResults;
        private System.Windows.Forms.Label MatchCount;
    }
}

