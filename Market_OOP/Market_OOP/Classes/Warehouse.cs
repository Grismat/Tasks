using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_OOP
{
    sealed class Warehouse:Room
    {
        /*private List<Product> StoredProducts = new List<Product>();

        public int CountOfProducts
        {
            get { return StoredProducts.Count; }
        }
        
        public bool AddProduct(Product product)
        {
            if (StoredProducts.Contains(product))
                return false;
            StoredProducts.Add(product);
            return true;
        }

        public Product GetProduct(string productName)
        {
            var element = StoredProducts.Find(x => x.Name == productName);
            if (element != null)
                StoredProducts.Remove(element);
            return element;
        }*/

        public bool ChangeShelfLife(string productName, DateTime newDate)
        {
            var element = Storage.Find(x => x.Name == productName);
            if (element == null)
                return false;
            element.ShelfLife = newDate;
            return true;
        }

        public List<Product> GetListOfExpiredProducts(DateTime currentDate)
        {
            List<Product> list = Storage.FindAll(x => x.ShelfLife < currentDate);
            return list;
        }

        /*public void SetDiscountOnType(TypeOfFood type, int discount)
        {
            foreach (Food product in Storage)
            {
                if(product.Type == type)
                {
                    product.Discount = discount;
                }
            }
        }

        public void SetDiscountOnType(TypeOfItem type, int discount)
        {
            foreach (Item product in StoredProducts)
            {
                if (product.Type == type)
                {
                    product.Discount = discount;
                }
            }
        }*/
    }
}
