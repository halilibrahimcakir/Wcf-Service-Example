using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService_Client.ServiceReference1;

namespace WcfService_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductServiceClient client = new ProductServiceClient();
            client.Open();
            bool loopBreaker = true;
            
            while (loopBreaker)
            {
                Console.WriteLine("Wcf service client'a hoş geldiniz\n\r1-Ürün Ekle\n\r2-Ürün Sil\n\r3-Ürün Listele\n\r4-Ürün Id'sine göre ürün bul\n\r5-Ürün Güncelle");
                int secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {

                    case 1 :
                        ProductsDto productsDto = new ProductsDto();
                        Console.WriteLine("Ürün adı giriniz");
                        productsDto.ProductName = Console.ReadLine();
                        Console.WriteLine("Ürün fiyatı giriniz");
                        productsDto.SalesPrice = Convert.ToDecimal(Console.ReadLine());
                        client.Add(productsDto);

                        break;

                    case 2 :
                        Console.WriteLine("Silinicek ürün ID'sini giriniz");
                        client.Delete(Convert.ToInt32(Console.ReadLine()));
                        break;

                    case 3:
                        List<ProductsDto> list = client.GetAll().ToList();
                        foreach (var p in list)
                        {
                            Console.WriteLine($"Ürün ID : {p.ProductId} Ürün Adı : {p.ProductName} Ürün Fiyatı : {p.SalesPrice} TL");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Ürün ID'si giriniz");
                       var getID = client.GetById(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine($"Ürün ID : {getID.ProductId} Ürün Adı : {getID.ProductName} Ürün Fiyatı : {getID.SalesPrice} TL");
                        break;
                    case 5:
                        loopBreaker = false;
                        ProductsDto productsDtoUpdate = new ProductsDto();
                        Console.WriteLine("Güncellenen ürün adı");
                        productsDtoUpdate.ProductName = Console.ReadLine();
                        Console.WriteLine("Güncellenecek satış fiyatı");
                        productsDtoUpdate.SalesPrice = Convert.ToDecimal(Console.ReadLine());
                        break;
                }
            }
            client.Close();
            Console.ReadKey();
        }
    }
}
