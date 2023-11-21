namespace Lesson28.Data
{
    internal class EduCenterDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost; Port=5432; User Id=postgres; Password=password; Database=EduCenterDB");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<GroupMember> GroupMembers { get; set; }
    }
}
