using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;


namespace Project_3_29834643.Models
{
    public class SuperstoreReturns
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [Required]
        

        public string Returned { get; set; }
        [Required]
        public string Order_ID { get; set; }
        [Required]

        public string Region { get; set; }
    }
}
