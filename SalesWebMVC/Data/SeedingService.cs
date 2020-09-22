using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Data {
    public class SeedingService {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context) {
            _context = context;
        }

        public void Seed() {
            if (_context.Departament.Any() || _context.Seller.Any() || _context.SalesRecord.Any()) {
                return; // banco de dados ja foi populado

            }

            Departament d1 = new Departament(1, "Computers");
            Departament d2 = new Departament(2, "Eletronics");
            Departament d3 = new Departament(3, "Fashion");
            Departament d4 = new Departament(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.00, d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 1500.00, d2);
            Seller s3 = new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(1998, 4, 21), 3500.00, d1);
            Seller s4 = new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 2500.00, d4);
            Seller s5 = new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 01, 09), 4000.00, d3);
            Seller s6 = new Seller(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 03, 04), 3000.00, d2);

            SalesRecord r1 = new SalesRecord(1,new DateTime(2018,09,25), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 04), 7000.00, SaleStatus.Billed, s5);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 09, 13), 4000.00, SaleStatus.Canceled, s4);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 09, 1), 8000.00, SaleStatus.Billed, s1);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 09, 21), 3000.00, SaleStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 09, 15), 2000.00, SaleStatus.Billed, s1);

            _context.Departament.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
               r1, r2, r3, r4, r5, r6 
               );

            _context.SaveChanges();





        }
    }
}

