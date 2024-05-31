using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realty
{
    public struct PrivteHome:IRealty
    {
        public string TypeOfRealEstate { get; } = "Частный дом";
        public double AreaOfTheApart { get; }
        public int NumberOfRooms { get; }
        public string Adres { get; }
        public int NumberOfFloor {  get; }
        public double PlotArea {  get; }
        public PrivteHome(double areaoftheapart, int numberofrooms,string adres,int numberofflor,double plotarea)
        {
            AreaOfTheApart = areaoftheapart;
            NumberOfRooms = numberofrooms;
            Adres = adres;
            NumberOfFloor = numberofflor;
            PlotArea = plotarea;
        }


    }
}
