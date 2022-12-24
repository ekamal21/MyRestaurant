using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//interface that works with dbinitializer 
namespace MyRestaurant.Data
{
    public interface IDbInitializer
    {
        void Initialize();
    }
}
