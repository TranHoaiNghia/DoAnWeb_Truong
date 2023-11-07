using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demo_lop1.Models
{
    public class SanPham
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        [Required]
        public int TheLoaiId { get; set; }
        [ForeignKey("TheLoaiId")]
        public TheLoai1 TheLoai1 { get; set; }

    }
}
