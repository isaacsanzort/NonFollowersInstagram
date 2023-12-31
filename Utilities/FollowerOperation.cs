using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramFollowersApp.Utilities
{
    public static class FollowerOperation
    {
        public static List<string> getNonFollowers(string followers, string following)
        {
            var followersList = parseUsernames(followers,0);
            var followingList = parseUsernames(following,1);

            var result = compareFollowersFollowing(followersList, followingList);
            return result;
        }

        public static List<string> compareFollowersFollowing(List<string> followers, List<string> following) 
        {
            return following.Except(followers).ToList();       
        }

        public static List<string> parseUsernames(string usernames, int type)
        {
            var usernamesList = new List<string>();


            try
            {
                JArray jsonArray;
                
                if(type == 1)
                {
                    var jsonObjectFollowing = JObject.Parse(usernames);
                    jsonArray = (JArray)jsonObjectFollowing["relationships_following"];
                }
                else
                {
                    jsonArray = JArray.Parse(usernames);
                }

                
                foreach (JObject jsonObject in jsonArray)
                {
                    JArray stringListData = (JArray)jsonObject["string_list_data"];


                    if (stringListData != null)
                    {
                        foreach (JObject stringDataObject in stringListData)
                        {
                            string value = stringDataObject["value"]?.ToString();

                            if (value != null)
                            {
                                usernamesList.Add(value);
                            }
                        }
                    }
                }
            }
            catch (JsonException ex)
            {
                throw;
            }

            return usernamesList;


        }
    
    }
}
