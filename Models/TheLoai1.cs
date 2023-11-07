using System.ComponentModel.DataAnnotations;

namespace demo_lop1.Models
{
    public class TheLoai1
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Không được để trống Tên thể loại!")]
        [Display(Name = "Tên thể loại")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Không đúng định dạng ngày!")]
        [Display(Name = "Ngày tạo")]
        public DateTime TimeCreated { get; set; }
    }
}
