using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServer.Dto.Dto
{
    [DataContract]
    public class ProductsDto
    {
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public Nullable<int> SupplierId { get; set; }
        [DataMember]
        public Nullable<int> CategoryId { get; set; }
        [DataMember]
        public Nullable<int> QuantityPerUnit { get; set; }
        [DataMember]
        public Nullable<decimal> UnitPrice { get; set; }
        [DataMember]
        public Nullable<int> StockCount { get; set; }
        [DataMember]
        public Nullable<bool> Discount { get; set; }
        [DataMember]
        public Nullable<System.DateTime> ExpirationDate { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public Nullable<decimal> InPrice { get; set; }
        [DataMember]
        public Nullable<decimal> SalesPrice { get; set; }
        [DataMember]
        public Nullable<bool> IsActive { get; set; }
        [DataMember]
        public Nullable<System.DateTime> CreatedDate { get; set; }
        [DataMember]
        public Nullable<int> CreatedBy { get; set; }
        [DataMember]
        public Nullable<System.DateTime> UpdateDate { get; set; }
        [DataMember]
        public Nullable<int> UpdateBy { get; set; }
        [DataMember]
        public Nullable<int> Count { get; set; }
    }
}
