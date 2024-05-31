using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realty
{
    public struct Flat:IRealty
    {
        public string TypeOfRealEstate { get; } = "Квартира";
        public double AreaOfTheApart { get; }
        public int NumberOfRooms { get; }
        public string Adres { get; }
        public bool Balcony {  get; }
        public bool Gas {  get; }
        public int Floor {  get; }

        public Flat(double areaoftheapart, int numberofRooms,string adres,bool balcony,bool gas,int floor)
        {
            AreaOfTheApart = areaoftheapart;
            NumberOfRooms = numberofRooms;
            Adres = adres;
            Balcony = balcony;
            Gas = gas;
            Floor = floor;
        }


    }
}
