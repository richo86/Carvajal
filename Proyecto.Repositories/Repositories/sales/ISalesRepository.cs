using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Repositories.Repositories.authentication
{
    public interface ISalesRepository
    {
        Task<bool> AddSale(Sales sale);
        Task<IEnumerable<Sales>> GetSales();
    }
}
