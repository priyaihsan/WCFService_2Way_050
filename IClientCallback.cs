using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFService_2Way_050
{
    [ServiceContract]
    interface IClientCallback
    {
        [OperationContract(IsOneWay = true)]
        void pesenKirim(string user, string pesan);
    }
}
