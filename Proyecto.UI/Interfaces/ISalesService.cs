using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.UI.Interfaces
{
    public interface ISalesService
    {
        Task<List<Sales>> GetSales();
        Task<bool> InsertSale(List<Sales> sales);
    }
}
