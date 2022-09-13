using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MS.Mensageria.API.Models
{
    public class Mensagem
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        public string MicroServicoId { get; set; }
        public string RequestId { get; set; }
        public string Texto { get; set; }

        public DateTime Timestamp { get; set; }

    }
}
