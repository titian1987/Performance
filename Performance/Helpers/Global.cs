using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Performance.Helpers
{
    public class Global
    {

        // Database strings
        public const string DBConnectionString = @"Data Source=(LocalDB)\v11.0;" +
                                                  @"AttachDbFilename ='C:\Users\yli\Documents\Visual Studio 2013\Projects\Performance\Performance\App_Data\Performance.mdf';" +
                                                  @"Integrated Security=True";

        public const string DBSelectWebUser = @"SELECT [Username] FROM [dbo].[WebUser] WHERE [Username] = @username AND [Password] = @password";
    }
}