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

    public class ProductService : IProductService
    {

        IProductsService productsService = new ProductsService();
        public void Add(ProductsDto dto)
        {
             productsService.Add(dto);
        }

        public void Delete(int id)
        {
            productsService.Delete(id);
        }

        public List<ProductsDto> GetAll()
        {
           return productsService.GetAll();
        }

        public ProductsDto GetById(int id)
        {
            return productsService.GetById(id);
        }

        public void Update(ProductsDto dto)
        {
            productsService.Update(dto);
        }
    }
}
