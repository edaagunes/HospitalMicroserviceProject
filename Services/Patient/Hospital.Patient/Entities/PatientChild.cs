using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Hospital.Patient.Entities
{
	public class PatientChild
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string PatientChildId { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public int Age { get; set; }
		public string Gender { get; set; }
		public string ParentNameSurname { get; set; }
	}
}
