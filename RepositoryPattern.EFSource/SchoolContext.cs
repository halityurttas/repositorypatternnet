namespace RepositoryPattern.EFSource
{
    using System.Data.Entity;
    using Core.DomainObjecs;

    public partial class SchoolContext : DbContext
    {
        public SchoolContext()
            : base("name=SchoolContext")
        {
        }

        public virtual DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
