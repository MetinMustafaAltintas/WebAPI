using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.DesignPatterns.SingletonPattern
{
    public class DBTool
    {
        DBTool() { }

        static NorthwindEntities _dbInstance;

        public static NorthwindEntities DbInstance
        {
            get
            {
                if (_dbInstance == null) _dbInstance = new NorthwindEntities();
                return _dbInstance;
            }
        }
    }
}