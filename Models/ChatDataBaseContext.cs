using System.Data.Entity;

namespace SignalRTest.Models
{
    public partial class ChatDataBaseContext : DbContext
    {
        public ChatDataBaseContext()
            : base("name=ChatDataBase")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>()
                .HasMany(e => e.Messages)
                .WithOptional(e => e.Group)
                .HasForeignKey(e => e.Group_Id);
        }
    }
}
