using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace Performance.Helpers
{
    public class Global
    {
        // db strings
        public static string DBConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public const string DBSelectWebUser = @"SELECT [Username] FROM [dbo].[WebUser] WHERE [Username] = @username AND [Password] = @password";

    }
}