using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServer.Businees.Service;
using WcfServer.Dto.Dto;

namespace WcfService_Server
{
    [ServiceContract]
    public interface IProductService : ServiceBase<ProductsDto>
    {
       
    }
}
