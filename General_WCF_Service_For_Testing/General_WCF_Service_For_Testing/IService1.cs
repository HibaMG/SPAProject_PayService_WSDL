﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace General_WCF_Service_For_Testing
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        bool GetStatus(int value);


    }
}

    