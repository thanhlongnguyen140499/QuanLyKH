namespace _102170286_NguyenThanhLong_17TCLC2
{
    using _102170286_NguyenThanhLong_17TCLC2.DAL;
    using _102170286_NguyenThanhLong_17TCLC2.DTO;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class QuanLyKH_DV : DbContext
    {
        // Your context has been configured to use a 'QuanLyKH_DV' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // '_102170286_NguyenThanhLong_17TCLC2.QuanLyKH_DV' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QuanLyKH_DV' 
        // connection string in the application configuration file.
        public QuanLyKH_DV()
            : base("name=QuanLyKH_DV")
        {
            Database.SetInitializer<QuanLyKH_DV>
                (new creatDB());
        }
        public virtual DbSet<KhachHang> KHs { get; set; }
        public virtual DbSet<DichVu> DVs { get; set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}