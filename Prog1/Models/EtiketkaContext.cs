using System;
using System.Data.Entity;
using System.Linq;

namespace Prog1.Models
{
    public class EtiketkaContext : DbContext
    {
        // Your context has been configured to use a 'EtiketkaModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Prog1.Models.EtiketkaModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EtiketkaModel' 
        // connection string in the application configuration file.
        public EtiketkaContext()
            : base("name=DBConnectionString")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<EtiketkaContext>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<EtiketkaModel> Etiketkas { get; set; }
    }
}