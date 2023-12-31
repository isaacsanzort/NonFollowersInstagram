namespace InstagramFollowersApp.Foms
{
    partial class ResultsForm
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
            this.labelTitleResults = new System.Windows.Forms.Label();
            this.listBoxNonFollowers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelTitleResults
            // 
            this.labelTitleResults.AutoSize = true;
            this.labelTitleResults.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitleResults.Location = new System.Drawing.Point(29, 25);
            this.labelTitleResults.Name = "labelTitleResults";
            this.labelTitleResults.Size = new System.Drawing.Size(301, 38);
            this.labelTitleResults.TabIndex = 0;
            this.labelTitleResults.Text = "Tus no seguidores son:";
            // 
            // listBoxNonFollowers
            // 
            this.listBoxNonFollowers.FormattingEnabled = true;
            this.listBoxNonFollowers.ItemHeight = 25;
            this.listBoxNonFollowers.Location = new System.Drawing.Point(41, 93);
            this.listBoxNonFollowers.Name = "listBoxNonFollowers";
            this.listBoxNonFollowers.Size = new System.Drawing.Size(272, 304);
            this.listBoxNonFollowers.TabIndex = 2;
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxNonFollowers);
            this.Controls.Add(this.labelTitleResults);
            this.Name = "ResultsForm";
            this.Text = "ResultsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitleResults;
        private ListBox listBoxNonFollowers;
    }
}