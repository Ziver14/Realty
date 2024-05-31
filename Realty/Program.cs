namespace Realty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var flat = new Flat(80.5, 3, "Екатеринбург, ул. Луночарского, д. 95, кв. 5", true, true, 4);
            var privatehome = new PrivteHome(150.0, 5, "Свердловская область, пос. Чистые Росы, ул. Ленина, д. 20", 2, 600.0);

            BuyRealty buyRealty = new BuyRealty("Иванов Иван Иванович", "Петров Петр Петрович", flat , 8000000.0);
            BuyRealty buyRealty1 = new BuyRealty("Сидоров Сидор Сидорович", "Васильев Василий Васильевич", privatehome, 15000000.0);

            Console.WriteLine(buyRealty.Information());
            Console.WriteLine();
            Console.WriteLine($"Стоимость квадратного метра {buyRealty.CostSquareNetr()}");
            Console.WriteLine();
            Console.WriteLine(buyRealty1.Information());
            Console.WriteLine();
            Console.WriteLine($"Стоимость квадратного метра {buyRealty1.CostSquareNetr()}");
        }
    }
}
