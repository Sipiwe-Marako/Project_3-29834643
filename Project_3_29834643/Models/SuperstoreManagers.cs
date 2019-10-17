using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Project_3_29834643.Models
{
    public class SuperstoreManagers
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [Required]
        
        public string Person { get; set; }
        [Required]

        public string Region { get; set; }
    }
}
