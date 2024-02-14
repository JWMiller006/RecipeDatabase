using RecipeDatabase.Backend.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeDatabase.Backend
{
    internal static class AppData
    {
        internal static string ConnectionString { get; set; } = "";

        internal static User CurrentUser { get; set; } = new(); 

        #region Methods

        internal static void SetConnectionString(string server, string database, string username, string password)
        {
            ConnectionString = $"Server={server};Database={database};User Id={username};Password={password};";
        }
        


        #endregion
    }
}
