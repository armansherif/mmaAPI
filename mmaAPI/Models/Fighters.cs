using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace mmaAPI.Models
{
    public class Fighters
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string FighterName { get; set; }

        [BsonElement("win")]
        public int Wins { get; set; }

        [BsonElement("lose")]
        public int Losses { get; set; }

        public string Height { get; set; }

        public string Weight { get; set; }

        public string Reach { get; set; }
    }

}
