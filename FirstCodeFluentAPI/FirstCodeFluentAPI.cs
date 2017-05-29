namespace FirstCodeFluentAPI
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class FirstCodeFluentAPI : DbContext
    {
        
        public FirstCodeFluentAPI()
            : base("name=FirstCodeFluentAPI")
        {
        }

        public DbSet<Lop> Lops { get; set; }
        public DbSet<Sinhvien> Sinhviens { get; set; }
        public DbSet<Sinhviendiachi> Sinhviendiachis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sinhviendiachi>().HasKey(sc => sc.id);

            modelBuilder.Entity<Sinhvien>().HasOptional(s => s.sinhviendiachi).WithRequired(p => p.sinhvien);


            //set moi quan he
            modelBuilder.Entity<Sinhvien>().HasRequired<Lop>(s => s.lop)
                .WithMany(l => l.sinhviens).HasForeignKey(s => s.lopid);
            base.OnModelCreating(modelBuilder);
        }
    }



    public class Lop
    {
        public Lop()
        {
            this.sinhviens = new HashSet<Sinhvien>();
        }
        public int id { get; set; }
        public string ten { get; set; }

        public virtual ICollection<Sinhvien> sinhviens { get; set; }
    }

    public class Sinhvien
    {
        public Sinhvien() {           
        }
        public int id { get; set; }
        public string hoten { get; set; }
        public string sodienthoai { get; set; }
        public string email { get; set; }
        public string lopid { get; set; }
                
        public virtual Lop lop { get; set; }
        public virtual Sinhviendiachi sinhviendiachi { get; set; }
    }

    public class Sinhviendiachi
    {
        public Sinhviendiachi() { }
        public int id { get; set; }
        public string diachi1 { get; set; }
        public string diachi2 { get; set; }
        public string thanhpho { get; set; }

        public virtual Sinhvien sinhvien { get; set; }
    }
}