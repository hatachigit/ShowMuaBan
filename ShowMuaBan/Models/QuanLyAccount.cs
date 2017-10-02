using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;

using System.Data.Entity;
namespace ShowMuaBan.Models
{
    public class QuanLyAccount : DbContext
    {
        public QuanLyAccount(): base("QuanLyAccountConnectionString")
        {

        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<DanhMuc> DanhMucs { get; set; }
    }
}