using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DzialAudytuBazaDanych;
using Microsoft.EntityFrameworkCore;

namespace DzialAudytu
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            using (var context = new DADbContext())
            {
                context.Database.Migrate();
                var db = new SupplyDatabaseWithData(new DADbContext());
                db.SeedDatabase();
            }
        }
 
    }
}
