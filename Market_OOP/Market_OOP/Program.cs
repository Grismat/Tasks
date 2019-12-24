using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Market Lenta = new Market();

            Product product1 = new Item("Ultra30", TypeOfItem.Pen, 30.0, DateTime.Parse("27.02.2019"), 0.2, 5);
            Product product2 = new Food("Golden", TypeOfFood.Fruit, 99.0, DateTime.Parse("16.12.2019"), 1.0, 0);
            Product product3 = new Item("Bumaga", TypeOfItem.Paper, 299.0, DateTime.Parse("1.2.2021"), 0.5, 15);
            Product product4 = new Food("asdas", TypeOfFood.Cookie, 69.0, DateTime.Parse("15.01.2021"), 0.4, 0);

            Lenta.AddProductsToWarehouse(product1);
            Lenta.AddProductsToWarehouse(product2);
            Lenta.AddProductsToWarehouse(product3);

            Lenta.MoveProductFromWarehouseToHall("Ultra30");
            
            List<Product> listOfExpiredProducts = Lenta.GetListOfExpiredProdicts();

            bool shelfLife = Lenta.ChangeShelfLife("Golden", DateTime.Parse("31.12.2019"));

            listOfExpiredProducts = Lenta.GetListOfExpiredProdicts();

            Lenta.RemoveProductsFromTheList(new List<string> { "Bumaga" });

            Lenta.SetDiscountOnType(TypeOfFood.Fruit, 50);

            Lenta.SetDiscountOnProduct("Ultra30", 80);

            Lenta.MoveProductsFromHallToWarehouse(typeof(Item));

            Lenta.MoveProductFromWarehouseToHall("Ultra30");

            bool sell = Lenta.SellProduct("Ultra30");

            double profit = Lenta.CountProfit(DateTime.Now);

            Lenta.AddDay();

            Lenta.SellProduct("Golden");

            Lenta.AddDay();

            Lenta.CountProfit(2);

            Lenta.AddDay();

            Lenta.CountProfit(DateTime.Parse("18.12.2019"), DateTime.Parse("20.12.2019"));

            Console.ReadKey();
        }
    }
}
