using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonConvert2Core.Entities;

namespace JsonConvert2Core.Contracts.Services
{
public interface IProductService
    {
     Task<Root> GetProducts();
    }
}
