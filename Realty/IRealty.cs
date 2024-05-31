using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realty
{
    public interface IRealty
    {
        public string TypeOfRealEstate {  get; }
        public double AreaOfTheApart {  get; }
        public int NumberOfRooms {  get; }
        public string Adres {  get; }

    }
    
    


}
