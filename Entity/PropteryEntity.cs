using System.Net;

namespace AssignmentJsonPatch.Entity
{
    public class PropteryEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public AddressEntity Address { get; set; }

        public OwnerDetails Owner { get; set; }

        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }
    }
}
