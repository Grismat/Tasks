using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_OOP
{
    abstract class Room
    {
        protected List<Product> Storage = new List<Product>();

        public int CountOfProducts
        {
            get { return Storage.Count; }
        }

        public bool AddProduct(Product product)
        {
            if (Storage.Contains(product))
                return false;
            Storage.Add(product);
            return true;
        }

        public bool RemoveProduct(string productName)
        {
            var element = Storage.Find(x => x.Name == productName);
            if (element == null)
                return false;
            return Storage.Remove(element);
        }

        public Product GetProduct(string productName)
        {
            var element = Storage.Find(x => x.Name == productName);
            if (element != null)
                Storage.Remove(element);
            return element;
        }

        public void SetDiscountOnType(TypeOfFood type, int discount)
        {
            foreach (Product product in Storage)
            {
                if (product is Food)
                {
                    Food food = (Food)product;
                    if(food.Type == type)
                        product.Discount = discount;
                }
            }
        }

        public void SetDiscountOnType(TypeOfItem type, int discount)
        {
            foreach (Product product in Storage)
            {
                if (product is Item)
                {
                    Item item = (Item)product;
                    if (item.Type == type)
                        product.Discount = discount;
                }
            }
        }

        public bool SetDiscountOnProduct(string productName, int discount)
        {
            Product element = Storage.Find(x => x.Name == productName);
            if (element == null)
                return false;
            element.Discount = discount;
            return true;
        }
    }
}
