﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1 
    {
          
        

        public string InsertLogin(LoginDetails L)
        {
        try
        {

                HotelContext H = new HotelContext();
                H.LoginDetailsTable.Add(L);
                H.SaveChanges();
                return "1 row inserted";
        }
        catch (DbUpdateException Ex)
        {
            SqlException sql = (SqlException)Ex.GetBaseException();
            return sql.Message;
        }
    }
    }
}
