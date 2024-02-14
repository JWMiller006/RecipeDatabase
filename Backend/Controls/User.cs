using MillerInc.Convert.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeDatabase.Backend.Controls
{
    internal class User : Loadable
    {
        #region Properties

        public string Username { get; set; }

        public string Password { get; set; }

        public Role Role { get; set; }

        public bool IsLoggedIn { get; set; } = false;

        #endregion

        #region Methods

        internal void SaveUser(string filePath)
        {
            Console.WriteLine("Saving the user...");
            string? json = System.Text.Json.JsonSerializer.Serialize(this);
            System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(filePath) ?? "");
            System.IO.File.WriteAllText(filePath, json);
        }

        #endregion

        #region Constructors

        internal User()
        {
            Username = "guest";
            Password = "guest";
            Role = Role.Guest;
            IsLoggedIn = false;
        }

        internal User(string username, string password)
        {
            Username = username;
            Password = password;
        }


        #endregion
    }
}
