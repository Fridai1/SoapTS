﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ClassLibraryCI;

namespace SoapTS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private Class1 s;
        public Service1()
        {
            s = new Class1();
        }
        public string GetName()
        {
            
            return s.GetName();
        }

        public string GetAddress()
        {
            return s.GetAdress();
        }
    }
}
