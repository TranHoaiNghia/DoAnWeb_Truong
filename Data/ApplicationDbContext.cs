using demo_lop1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace demo_lop1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TheLoai> TheLoai { get; set;}
        public DbSet<TheLoai1> TheLoai1 { get; set; }
        public DbSet<SanPham> Sanpham { get; set; }
    }
}