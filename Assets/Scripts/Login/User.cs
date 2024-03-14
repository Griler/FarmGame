using UnityEngine;

namespace Login
{
    public class User
    {
        public string username;
        public string password;
        public string token;

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string SaveToString()
        {
            return JsonUtility.ToJson(this);
        }

        public User fromToJson(string json)
        {
            return JsonUtility.FromJson<User>(json);
        }
        
    }
}