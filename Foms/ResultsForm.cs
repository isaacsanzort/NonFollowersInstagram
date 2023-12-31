using InstagramFollowersApp.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstagramFollowersApp.Foms
{
    public partial class ResultsForm : Form
    {
        private FileClass fileClass;
        public ResultsForm(FileClass fileClass)
        {
            InitializeComponent();
            this.fileClass = fileClass;
            setNonFollowers();
        }

        private void setNonFollowers()
        {
            fileClass.FollowersJSON = FileOperation.readFileContent(fileClass.FollowersFilePath);
            fileClass.FollowingJSON = FileOperation.readFileContent(fileClass.FollowingFilePath);

            var nonFollowers = FollowerOperation.getNonFollowers(fileClass.FollowersJSON, fileClass.FollowingJSON);

            /*Ajustes visuales*/
            listBoxNonFollowers.MultiColumn = false;

            foreach(var nonFollower in nonFollowers)
            {
                listBoxNonFollowers.Items.Add(nonFollower);
            }
        }
    }
}
