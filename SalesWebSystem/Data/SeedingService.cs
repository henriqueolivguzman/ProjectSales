using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebSystem.Models;

namespace SalesWebSystem.Data
{
    public class SeedingService
    {
        private readonly SalesWebSystemContext _context;

        public SeedingService(SalesWebSystemContext context)
        {
            _context = context;
        }
        public void AddFirstMembers()
        {
            if(_context.SalesRecord.Any() || _context.Seller.Any() || _context.Department.Any())
            {
                return;
            }
            Department dep1 = new Department(1, "Electronics");
            Department dep2 = new Department(2, "Books");
            Department dep3 = new Department(3, "Furnitures");
            Department dep4 = new Department(4, "Accessories");

            Seller seller1 = new Seller(1, "Neyman Junior","njr@outlook.com", new DateTime(1990, 3, 4), 5995, dep3);
            Seller seller2 = new Seller(2, "Odvan Pereira","odvan@hotmail.com.com", new DateTime(1990, 6, 7), 5995, dep2);
            Seller seller3 = new Seller(3, "Laercio Quadrado","ldado@outlook.com", new DateTime(1990, 5, 8), 5995, dep4);
            Seller seller4 = new Seller(4, "Dado Dollabela","dado@gmail.com", new DateTime(1990, 12, 10), 5995, dep1);
            Seller seller5 = new Seller(5, "James Rodriguez","jrod@outlook.com", new DateTime(1990, 5, 17), 5995, dep1);
            Seller seller6 = new Seller(6, "Cristiano Ronaldo","cr7@outlook.com", new DateTime(1990, 2, 20), 5995, dep4);
            Seller seller7 = new Seller(7, "Roberto Moreira Salles","sallesvideogame@outlook.com", new DateTime(1987, 6, 24), 5995, dep3);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2021, 3, 20), 2000, Models.Enums.SalesStatus.Billed);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2021, 4, 22), 2000, Models.Enums.SalesStatus.Cancelled);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2021, 6, 17), 2000, Models.Enums.SalesStatus.Pending);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2021, 2, 27), 2000, Models.Enums.SalesStatus.Cancelled);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2021, 4, 15), 2000, Models.Enums.SalesStatus.Billed);
            SalesRecord sr6 = new SalesRecord(6, new DateTime(2021, 3, 3), 2000, Models.Enums.SalesStatus.Pending);
            SalesRecord sr7 = new SalesRecord(7, new DateTime(2021, 3, 9), 2000, Models.Enums.SalesStatus.Cancelled);
            SalesRecord sr8 = new SalesRecord(8, new DateTime(2021, 7, 25), 2000, Models.Enums.SalesStatus.Billed);
            SalesRecord sr9 = new SalesRecord(9, new DateTime(2021, 4, 3), 2000, Models.Enums.SalesStatus.Pending);
            SalesRecord sr10 = new SalesRecord(10, new DateTime(2021, 1, 1), 2000, Models.Enums.SalesStatus.Billed);
            SalesRecord sr11= new SalesRecord(11, new DateTime(2021, 7, 15), 2000, Models.Enums.SalesStatus.Cancelled);

            _context.Department.AddRange(dep1, dep2, dep3, dep4);
            _context.Seller.AddRange(seller1, seller2, seller3, seller4, seller5, seller6, seller7);
            _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4, sr5, sr6, sr7, sr8, sr9, sr10, sr11);

            _context.SaveChanges();


        }
    }
}
