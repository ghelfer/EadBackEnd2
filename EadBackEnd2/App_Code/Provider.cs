﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Provider
/// </summary>
public class Provider
{
    public static string StrConnection()  
    {
        string server = "192.168.0.19";
        string database = "ead_db";
        string uid = "root";
        string password = "root";
        return "server=" + server + ";uid=" + uid + ";database=" + database + ";port=3306;pwd=" + password + ";";
      
    }


}