using Microsoft.EntityFrameworkCore;
using GuestBook.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuestBook.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<GuestNote> GuestNotes { get; set; }


      

    }
}
