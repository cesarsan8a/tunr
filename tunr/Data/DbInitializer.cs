using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tunr.Models;


namespace tunr.Data
{
    public class DbInitializer
    {
        public static void Initialize(tunrContext context)
        {
            context.Database.EnsureCreated();

            // Check if there's any mixtapes already.
            if (context.Mixtapes.Any())
            {
                return;
            }

            var users = new User[]
{
                new User{Name="Steven", Surname="Universe", Email="steven@tunr.com"},
                new User{Name="Bruno", Surname="Diaz", Email="notBatman@tunr.com"},
                new User{Name="Simon", Surname="Says", Email="badJoke@tunr.com"},
};
            foreach (User u in users)
            {
                context.Users.Add(u);
            }

            var mixtapes = new Mixtape[]
            {
                new Mixtape{Title="Sleepy time", User= users[0], Tags="sleep chill lo-fi"},
                new Mixtape{Title="Road trip", User= users[1], Tags="fun friends rock"},
                new Mixtape{Title="Cooking", User= users[2], Tags="friends love fun"}
            };
            foreach (Mixtape m in mixtapes)
            {
                context.Mixtapes.Add(m);
            }

            context.SaveChanges();
        }
    }
}
