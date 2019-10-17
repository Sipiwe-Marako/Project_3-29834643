using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;


namespace Project_3_29834643.Models
{
    public class SuperstoreOrders

    {
        [BsonId]
        public ObjectId Id { get; set; } 
        [Required]
       
        public string Row_ID { get; set; }
        [Required]
        public string Order_ID { get; set; }
        [Required]

        public string Order_Date { get; set; }

        public string Ship_Date { get; set; }
        [Required]
        public string Ship_Mode { get; set; }
        [Required]

        public string Customer_ID { get; set; }
        [Required]

        public string Segment { get; set; }
        [Required]

        public string Postal_Code { get; set; }
        [Required]

        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]

        public string Country { get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        public string Market { get; set; }
        [Required]
        public string Product_ID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Sub_Category { get; set; }
        [Required]
        public string Product_Name { get; set; }
        [Required]
        public string Sales { get; set; }
        [Required]

        public string Quantity { get; set; }
        [Required]
        public string Discount { get; set; }
        [Required]
        public string Profit { get; set; }
        [Required]
        public string Shipping_Cost { get; set; }
        [Required]
        public string Order_Priority { get; set; }
        




    }
}
