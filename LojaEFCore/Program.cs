using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace LojaEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using var db = new Data.ApplicationContext();

            var existe = db.Database.GetPendingMigrations().Any();

            if (existe)
            {
                //MessageBox.Show("Migrations pendentes...");
            }

            Console.WriteLine("Hello World!");
        }
    }
}
