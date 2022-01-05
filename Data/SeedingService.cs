using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSales2.Models;
using WebSales2.Models.Enums;

namespace WebSales2.Data
{
    public class SeedingService
    {
        private WebSales2Context _context;

        public SeedingService(WebSales2Context context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return;
            }
            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria M", "Maria@gmail.com", new DateTime(1990, 5, 27), 3100.0, d2);
            Seller s3 = new Seller(3, "Alex E", "Alex@gmail.com", new DateTime(1998, 1, 15), 2500.0, d3);
            Seller s4 = new Seller(4, "Martha H", "marthah@gmail.com", new DateTime(1993, 4, 21), 3000.0, d4);
            Seller s5 = new Seller(5, "Debora D", "debora@gmail.com", new DateTime(2000, 1, 9), 2500.0, d1);
            Seller s6 = new Seller(6, "Alevino", "alevino@gmail.com", new DateTime(1998, 4, 21), 3000.0, d4);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2021, 10, 10), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2021, 10, 10), 12000.0, SaleStatus.Canceled, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2021, 10, 10), 10000.0, SaleStatus.Pending, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2021, 10, 10), 8000.0, SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2021, 10, 10), 3300.0, SaleStatus.Pending, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2021, 10, 10), 8800.0, SaleStatus.Billed, s6);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2021, 10, 10), 1000.0, SaleStatus.Billed, s1);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2021, 10, 10), 500.0, SaleStatus.Billed, s2);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2021, 10, 10), 100.0, SaleStatus.Billed, s3);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2021, 10, 10), 1800.0, SaleStatus.Billed, s4);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2021, 10, 10), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2021, 10, 10), 12000.0, SaleStatus.Canceled, s2);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2021, 10, 10), 10000.0, SaleStatus.Pending, s3);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2021, 10, 10), 8000.0, SaleStatus.Billed, s4);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2021, 10, 10), 3300.0, SaleStatus.Pending, s5);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2021, 10, 10), 8800.0, SaleStatus.Billed, s6);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2021, 10, 10), 1000.0, SaleStatus.Billed, s1);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2021, 10, 10), 500.0, SaleStatus.Billed, s2);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2021, 10, 10), 100.0, SaleStatus.Billed, s3);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2021, 10, 10), 1800.0, SaleStatus.Billed, s4);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2021, 10, 10), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2021, 10, 10), 12000.0, SaleStatus.Canceled, s2);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2021, 10, 10), 10000.0, SaleStatus.Pending, s3);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2021, 10, 10), 8000.0, SaleStatus.Billed, s4);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2021, 10, 10), 3300.0, SaleStatus.Pending, s5);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2021, 10, 10), 8800.0, SaleStatus.Billed, s6);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2021, 10, 10), 1000.0, SaleStatus.Billed, s1);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2021, 10, 10), 500.0, SaleStatus.Billed, s2);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2021, 10, 10), 100.0, SaleStatus.Billed, s3);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2021, 10, 10), 1800.0, SaleStatus.Billed, s4);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Database.OpenConnection();
            _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Department ON");
            _context.SaveChanges( );
            _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Department OFF");

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Seller ON");
            _context.SaveChanges();
            _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Seller OFF");

            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10
                                         , r11, r12, r13, r14, r15, r16, r17, r18, r19, r20
                                         , r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);
            _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.SalesRecord ON");
            _context.SaveChanges();
            _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.SalesRecord OFF");


        }
    }
}
