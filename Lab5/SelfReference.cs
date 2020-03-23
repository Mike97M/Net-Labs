namespace Lab5
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public class ModelSelfReferences : DbContext
    {
        // Your context has been configured to use a 'ModelSelfReferences' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Lab2.ModelSelfReferences' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelSelfReferences' 
        // connection string in the application configuration file.
        public ModelSelfReferences()
            : base("name=ModelSelfReferences")
        {
        }
        public virtual DbSet<SelfReference> SelfReferences { get; set; }

        public SelfReference AddSelfReference(string name)
        {
            var selfReference = new SelfReference()
            {
                Name = name,
            };
            SelfReferences.Add(selfReference);
            SaveChanges();
            return selfReference;
        }
        public SelfReference AddSelfReference(string name, SelfReference parentSelfReference)
        {
            var selfReference = new SelfReference()
            {
                Name = name,
                ParentSelfReference = parentSelfReference
            };
            SelfReferences.Add(selfReference);
            SaveChanges();
            return selfReference;
        }
        public List<SelfReference> GetAllSelfReferences()
        {
            return SelfReferences.ToList();
        }
        public SelfReference GetSelfReferenceById(int id)
        {
            return SelfReferences.Where(r => r.SelfReferenceId == id).FirstOrDefault();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SelfReference>()
            .HasMany(m => m.References)
            .WithOptional(m => m.ParentSelfReference);
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    public class SelfReference
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SelfReferenceId { get; private set; }
        public string Name { get; set; }
        public int? ParentSelfReferenceId { get; private set; }
        [ForeignKey("ParentSelfReferenceId")]
        public SelfReference ParentSelfReference { get; set; }
        public virtual ICollection<SelfReference> References { get; set; }
        public SelfReference()
        {
            References = new HashSet<SelfReference>();
        }
    }
}