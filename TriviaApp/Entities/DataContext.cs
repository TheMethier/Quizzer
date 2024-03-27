using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaAppSerices.Entities
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
           
        }
        public DataContext()
        {
             Database.EnsureCreated() ;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source = Quiz.db"); 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Category>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Question>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Player>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Deck>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Category>()
                .HasMany(x=>x.Decks)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryId);

            modelBuilder.Entity<Deck>()
                .HasMany(x=>x.Players)
                .WithOne(x => x.Deck)
                .HasForeignKey(x => x.DeckId);
            modelBuilder.Entity<Deck>()
                .HasMany(x => x.Questions)
                .WithOne(x => x.Deck)
                .HasForeignKey(x => x.DeckId);
            modelBuilder.Entity<Question>()
                .HasMany(x => x.Answers)
                .WithOne(x => x.Question)
                .HasForeignKey(x => x.QuestionId);
        }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Question> Questions {  get; set; }
        public DbSet<Deck> Decks {  get; set; }

    }
}
