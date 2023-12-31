namespace InstagramFollowersApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxFollowersPath = new System.Windows.Forms.TextBox();
            this.textBoxFollowingPath = new System.Windows.Forms.TextBox();
            this.buttonBrowseFollowersPath = new System.Windows.Forms.Button();
            this.buttonBrowseFollowingPath = new System.Windows.Forms.Button();
            this.labelFollowingPath = new System.Windows.Forms.Label();
            this.labelFollowersPath = new System.Windows.Forms.Label();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSubmit.Enabled = false;
            this.buttonSubmit.Location = new System.Drawing.Point(575, 362);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(179, 58);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxFollowersPath
            // 
            this.textBoxFollowersPath.Location = new System.Drawing.Point(52, 184);
            this.textBoxFollowersPath.Name = "textBoxFollowersPath";
            this.textBoxFollowersPath.Size = new System.Drawing.Size(507, 31);
            this.textBoxFollowersPath.TabIndex = 1;
            this.textBoxFollowersPath.TextChanged += new System.EventHandler(this.textBoxFollowersPath_TextChanged);
            // 
            // textBoxFollowingPath
            // 
            this.textBoxFollowingPath.Location = new System.Drawing.Point(51, 286);
            this.textBoxFollowingPath.Name = "textBoxFollowingPath";
            this.textBoxFollowingPath.Size = new System.Drawing.Size(508, 31);
            this.textBoxFollowingPath.TabIndex = 2;
            this.textBoxFollowingPath.TextChanged += new System.EventHandler(this.textBoxFollowingPath_TextChanged);
            // 
            // buttonBrowseFollowersPath
            // 
            this.buttonBrowseFollowersPath.Location = new System.Drawing.Point(575, 184);
            this.buttonBrowseFollowersPath.Name = "buttonBrowseFollowersPath";
            this.buttonBrowseFollowersPath.Size = new System.Drawing.Size(179, 31);
            this.buttonBrowseFollowersPath.TabIndex = 3;
            this.buttonBrowseFollowersPath.Text = "Browse File";
            this.buttonBrowseFollowersPath.UseVisualStyleBackColor = true;
            this.buttonBrowseFollowersPath.Click += new System.EventHandler(this.buttonBrowseFollowersPath_Click);
            // 
            // buttonBrowseFollowingPath
            // 
            this.buttonBrowseFollowingPath.Location = new System.Drawing.Point(575, 286);
            this.buttonBrowseFollowingPath.Name = "buttonBrowseFollowingPath";
            this.buttonBrowseFollowingPath.Size = new System.Drawing.Size(179, 31);
            this.buttonBrowseFollowingPath.TabIndex = 4;
            this.buttonBrowseFollowingPath.Text = "Browse File";
            this.buttonBrowseFollowingPath.UseVisualStyleBackColor = true;
            this.buttonBrowseFollowingPath.Click += new System.EventHandler(this.buttonBrowseFollowingPath_Click);
            // 
            // labelFollowingPath
            // 
            this.labelFollowingPath.AutoSize = true;
            this.labelFollowingPath.Location = new System.Drawing.Point(52, 258);
            this.labelFollowingPath.Name = "labelFollowingPath";
            this.labelFollowingPath.Size = new System.Drawing.Size(316, 25);
            this.labelFollowingPath.TabIndex = 5;
            this.labelFollowingPath.Text = "Inserta la ruta del archivo de seguidos:";
            this.labelFollowingPath.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelFollowersPath
            // 
            this.labelFollowersPath.AutoSize = true;
            this.labelFollowersPath.Location = new System.Drawing.Point(51, 156);
            this.labelFollowersPath.Name = "labelFollowersPath";
            this.labelFollowersPath.Size = new System.Drawing.Size(364, 25);
            this.labelFollowersPath.TabIndex = 6;
            this.labelFollowersPath.Text = "Inserta la ruta del archivo con los seguidores";
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelErrorMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.labelErrorMessage.Location = new System.Drawing.Point(149, 60);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(503, 32);
            this.labelErrorMessage.TabIndex = 7;
            this.labelErrorMessage.Text = "¡ Introduce unas rutas de ficheros válidos !";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelErrorMessage);
            this.Controls.Add(this.labelFollowersPath);
            this.Controls.Add(this.labelFollowingPath);
            this.Controls.Add(this.buttonBrowseFollowingPath);
            this.Controls.Add(this.buttonBrowseFollowersPath);
            this.Controls.Add(this.textBoxFollowingPath);
            this.Controls.Add(this.textBoxFollowersPath);
            this.Controls.Add(this.buttonSubmit);
            this.Name = "MainForm";
            this.Text = "MainInsta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSubmit;
        private TextBox textBoxFollowersPath;
        private TextBox textBoxFollowingPath;
        private Button buttonBrowseFollowersPath;
        private Button buttonBrowseFollowingPath;
        private Label labelFollowingPath;
        private Label labelFollowersPath;
        private Label labelErrorMessage;
    }
}