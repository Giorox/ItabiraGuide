using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace NossoApp
{
    public static class Global
    {
        public static string connString { get; set; }
        public static int controllerButtonID { get; set; }
    }
}
