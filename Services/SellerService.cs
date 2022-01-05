using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSales2.Models;
using WebSales2.Data;

namespace WebSales2.Services
{
    public class SellerService
    {
        private readonly WebSales2Context _context;

        public SellerService(WebSales2Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }


        public void Insert(Seller obj)
        {
           // obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
