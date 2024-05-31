using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realty
{
    public class BuyRealty
    {
        public string NameBayer {  get; set; }
        public string NameSeller {  get; set; }
        public IRealty Realty { get; set; }
        public double Price {  get; set; }
        public BuyRealty(string nameBayer, string nameSeller, IRealty realty, double price)
        {
            NameBayer = nameBayer;
            NameSeller = nameSeller;
            Realty = realty;
            Price = price;
        }

        public string Information() {
            return $"Покупатель: {NameBayer} \nПродавец: {NameSeller} \nВид недвижимости:" +
                $"{Realty.TypeOfRealEstate}, Площадь:{Realty.AreaOfTheApart}, Количество комнат {Realty.NumberOfRooms}," +
                $"Адрес:{Realty.Adres}, Стоимость покупки {Price} руб"; }
        public double CostSquareNetr() { return Math.Round(Price / Realty.AreaOfTheApart, 2); }
    }
}

