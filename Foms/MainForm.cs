using InstagramFollowersApp.Foms;
using InstagramFollowersApp.Utilities;

namespace InstagramFollowersApp
{
    public partial class MainForm : Form
    {
        private readonly FileClass fileClass = new();
        public MainForm()
        {
            InitializeComponent();
            labelErrorMessage.Hide();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            labelErrorMessage.Hide();

            try
            {
                var resultForm = new ResultsForm(fileClass);
                this.Hide();
                resultForm.Show();
            }catch (Exception ex)
            {
                labelErrorMessage.Show();
            }
            
        }

        private void buttonBrowseFollowersPath_Click(object sender, EventArgs e)
        {
            fileClass.FollowersFilePath = FileOperation.getFilePath();
            textBoxFollowersPath.Text = fileClass.FollowersFilePath;

        }

        private void buttonBrowseFollowingPath_Click(object sender, EventArgs e)
        {
            fileClass.FollowingFilePath = FileOperation.getFilePath();
            textBoxFollowingPath.Text = fileClass.FollowingFilePath;
        }

        /*Habilitamos botón cuando se completen los archivos*/
        private void textBoxFollowersPath_TextChanged(object sender, EventArgs e)
        {
            buttonSubmit.Enabled = checkPathExists();
        }

        private void textBoxFollowingPath_TextChanged(object sender, EventArgs e)
        {
            buttonSubmit.Enabled = checkPathExists();
        }

        private bool checkPathExists()
        {
            bool pathExists = false;
            
            if (textBoxFollowersPath.Text != "" && textBoxFollowingPath.Text != "")
                pathExists = true;
            
            return pathExists;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}