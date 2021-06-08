using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServer.Data.Context;
using WcfServer.Dto.Dto;

namespace WcfServer.Businees.Mapper
{
    public static class MapperFactory
    {
        private static MapperConfiguration mapperConfiguration;
        private static bool _isInitialized;
        private static object lck = new object();

        public static K Map<T, K>(T input)
        {
            Init();

            IMapper mapper = mapperConfiguration.CreateMapper();

            return input != null ? mapper.Map<T, K>(input) : default(K);
        }

        private static void Init()
        {
            lock (lck)
            {
                if (_isInitialized) return;

                mapperConfiguration = new MapperConfiguration(p =>
                {
                   
                    p.CreateMap<Products, ProductsDto>().MaxDepth(1).ReverseMap();
                   
                });
            }
            _isInitialized = true;
        }
    }
}