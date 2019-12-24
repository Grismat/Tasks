using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_OOP
{
    class Market
    {
        private Accounting accounting = new Accounting();
        private Hall hall = new Hall();
        private Warehouse warehouse = new Warehouse();
        
        public DateTime CurrentDate
        {
            get { return accounting.CurrentDate; }
        }

        public double TotalAmountOfMoney
        {
            get { return accounting.AmountOfMoney; }
        }

        public double MoneyFromThisDay
        {
            get { return accounting.MoneyFromThisDay; }
        }

        public double CountOfProducts
        {
            get { return warehouse.CountOfProducts + hall.CountOfProducts; }
        }

        //прибавить день
        public void AddDay()
        {
            accounting.AddDay();
        }

        //добавить продукт в зал со склада
        public bool MoveProductFromWarehouseToHall(string productName)
        {
            var element = warehouse.GetProduct(productName);
            if (element == null)
                return false;
            return hall.AddProduct(element);
        }

        //добавить продукт на склад
        public bool AddProductsToWarehouse(Product product)
        {
            return warehouse.AddProduct(product);
        }

        //список просроченных продуктов
        public List<Product> GetListOfExpiredProdicts()
        {
            return warehouse.GetListOfExpiredProducts(accounting.CurrentDate);
        }

        //переклеить срок годности
        public bool ChangeShelfLife(string productName, DateTime newDate)
        {
            return warehouse.ChangeShelfLife(productName, newDate);
        }

        //сделать скидку на тип еды
        public void SetDiscountOnType(TypeOfFood type, int discount)
        {
            warehouse.SetDiscountOnType(type, discount);
            hall.SetDiscountOnType(type, discount);
        }

        //сделать скидку на тип вещи
        public void SetDiscountOnType(TypeOfItem type, int discount)
        {
            warehouse.SetDiscountOnType(type, discount);
            hall.SetDiscountOnType(type, discount);
        }

        //сделать скидку на продукт
        public void SetDiscountOnProduct(string productName, int discount)
        {
            warehouse.SetDiscountOnProduct(productName, discount);
            hall.SetDiscountOnProduct(productName, discount);
        }

        //удалить продукты по списку
        public void RemoveProductsFromTheList(List<string> products)
        {
            foreach (string productName in products)
            {
                warehouse.RemoveProduct(productName);
                hall.RemoveProduct(productName);
            }
        }

        //убрать все продукты типа на склад
        public void MoveProductsFromHallToWarehouse(Type type)
        {
            List<Product> buffer = hall.MoveProductsToWarehouse(type);
            foreach (Product element in buffer)
            {
                warehouse.AddProduct(element);
            }
        }

        //продать вещь
        public bool SellProduct(string productName)
        {
            Product product = hall.GetProduct(productName); //сразу удаляет элемент из хранилища зала если он есть
            if (product == null)
                return false;
            accounting.AddProfit(product.Cost);
            return true;
        }

        //прибыль между двумя числами
        public double CountProfit(DateTime firstDate, DateTime lastDate)
        {
            return accounting.CountProfit(firstDate, lastDate);
        }

        //прибыль в определенный день
        public double CountProfit(DateTime date)
        {
            return accounting.CountProfit(date);
        }

        //прибыль за прошедшие несколько дней
        public double CountProfit(int countOfLastDays)
        {
            return accounting.CountProfit(countOfLastDays);
        }
    }
}
