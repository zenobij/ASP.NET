namespace ExoPizza.Data.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ExoPizzaContext : DbContext
    {
        public ExoPizzaContext()
            : base("name=ExoPizzaConString")
        {
        }

        public virtual DbSet<Categorie> Categorie { get; set; }
        public virtual DbSet<Ingredient> Ingredient { get; set; }
        public virtual DbSet<Pizza> Pizza { get; set; }
        public virtual DbSet<PizzaIngredients> PizzaIngredients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorie>()
                .HasMany(e => e.Ingredient)
                .WithRequired(e => e.Categorie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ingredient>()
                .HasMany(e => e.PizzaIngredients)
                .WithRequired(e => e.Ingredient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pizza>()
                .HasMany(e => e.PizzaIngredients)
                .WithRequired(e => e.Pizza)
                .WillCascadeOnDelete(false);
        }
    }
}
