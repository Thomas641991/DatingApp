using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    // [Table("Photos")] is used to give it the table name Photos in the database instead of Photo
    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}