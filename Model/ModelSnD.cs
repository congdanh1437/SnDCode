using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp1.Model
{
    public partial class ModelSnd : DbContext
    {
        public ModelSnd()
            : base("name=ModelSnd2")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Borrow> Borrows { get; set; }
        public virtual DbSet<Borrow_List> Borrow_List { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Import> Imports { get; set; }
        public virtual DbSet<Import_List> Import_List { get; set; }
        public virtual DbSet<Suplier> Supliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasMany(e => e.Borrows)
                .WithRequired(e => e.Book)
                .HasForeignKey(e => e.B_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.Imports)
                .WithRequired(e => e.Book)
                .HasForeignKey(e => e.B_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Borrow_List>()
                .HasMany(e => e.Borrows)
                .WithRequired(e => e.Borrow_List)
                .HasForeignKey(e => e.BL_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone_numb)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Borrow_List)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Import_List>()
                .HasMany(e => e.Imports)
                .WithRequired(e => e.Import_List)
                .HasForeignKey(e => e.IL_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Suplier>()
                .HasMany(e => e.Import_List)
                .WithRequired(e => e.Suplier)
                .HasForeignKey(e => e.Supplier_ID)
                .WillCascadeOnDelete(false);
        }
    }
}
