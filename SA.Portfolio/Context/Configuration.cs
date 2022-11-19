using Microsoft.Ajax.Utilities;
using SA.Portfolio.Models;
using System.Collections.Generic;
using System.Data.Entity.Migrations; 

namespace SA.Portfolio.Context
{
    public sealed class Configuration : DbMigrationsConfiguration<BaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BaseContext context)
        {
            var member = new List<Members>
            {
                new Members{ Name="Safak", Surname="Akca", Mail="safakca@gmail.com", Password="0"}
            };
            member.ForEach(m => context.Members.AddOrUpdate(x => x.Password, m));
            context.SaveChanges();
        }
    }
}