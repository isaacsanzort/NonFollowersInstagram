using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramFollowersApp.Utilities
{
    public class FileClass
    {
        public string FollowersFilePath { get; set; }
        public string FollowingFilePath { get; set; }
        public string FollowingJSON { get; set; }
        public string FollowersJSON { get; set; }

        public FileClass()
        {
            this.FollowersFilePath = string.Empty;
            this.FollowingFilePath = string.Empty;
        }
    }
}
