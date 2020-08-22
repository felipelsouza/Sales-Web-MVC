using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Books");

            Seller s1 = new Seller(1, "Felipe Smith", "felsmith@email.com", new DateTime(1998, 4, 30), 1100.0, d2);
            Seller s2 = new Seller(2, "Maria Dom Bosco", "mariadb@email.com", new DateTime(1970, 5, 4), 1200.0, d2);
            Seller s3 = new Seller(3, "German Pipe", "cano@email.com", new DateTime(1990, 5, 4), 1300.0, d3);
            Seller s4 = new Seller(4, "Liliane Lima", "lilili@email.com", new DateTime(1997, 7, 7), 1700.0, d1);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2020, 08, 15), 400.0, SaleStatus.Pending, s3);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2020, 08, 18), 800.0, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2020, 08, 20), 999.9, SaleStatus.Cancelled, s4);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2020, 08, 20), 100.0, SaleStatus.Pending, s1);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2020, 08, 20), 9.19, SaleStatus.Pending, s1);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2020, 08, 21), 220.0, SaleStatus.Billed, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2020, 08, 21), 189.9, SaleStatus.Billed, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2020, 08, 21), 620.0, SaleStatus.Billed, s3);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2020, 08, 21), 666.0, SaleStatus.Billed, s2);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2020, 08, 21), 677.0, SaleStatus.Cancelled, s4);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2020, 08, 22), 22000.0, SaleStatus.Pending, s3);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2020, 08, 22), 150.0, SaleStatus.Pending, s2);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2020, 08, 22), 600.0, SaleStatus.Billed, s1);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2020, 08, 22), 67.8, SaleStatus.Billed, s1);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2020, 08, 22), 900.0, SaleStatus.Billed, s4);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2020, 08, 22), 66.6, SaleStatus.Billed, s4);

            _context.Department.AddRange(d1, d2, d3);
            _context.Seller.AddRange(s1, s2, s3, s4);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16);

            _context.SaveChanges();
        }
    }
}
