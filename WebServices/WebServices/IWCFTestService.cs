﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITestService" in both code and config file together.
    [ServiceContract]
    public interface IWCFTestService
    {
        [OperationContract]
        Student GetStudent();

        [OperationContract]
        string GetStudentJSON();

        [OperationContract]
        string GetFullName(Student s);
    }
}
