using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum_BookStore_Fawry_Challenge2.Interfaces
{
    internal interface IshipService
    {
        bool ShipService(string Address,decimal pay);
    }
}
