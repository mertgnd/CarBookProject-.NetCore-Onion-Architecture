using System.ComponentModel.DataAnnotations;

namespace CarBookProject.Domain.Entities
{
    public class Testimonial
    {
        [Key]
        public int TestiomonialID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImageURL { get; set; }
    }
}
