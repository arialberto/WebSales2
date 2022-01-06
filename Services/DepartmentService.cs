using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSales2.Data;
using WebSales2.Models;
using Microsoft.EntityFrameworkCore;

namespace WebSales2.Services
{
    public class DepartmentService
    {
        private readonly WebSales2Context _context;

        public DepartmentService(WebSales2Context context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
