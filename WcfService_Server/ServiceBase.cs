using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfService_Server
{
    [ServiceContract]
    public interface ServiceBase<T> where T : class
    {
        [OperationContract]
        List<T> GetAll();
        [OperationContract]
        T GetById(int id);
        [OperationContract]
        void Add(T dto);
        [OperationContract]
        void Update(T dto);
        [OperationContract]
        void Delete(int id);
    }
}
