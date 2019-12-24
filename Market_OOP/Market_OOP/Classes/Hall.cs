using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_OOP
{
    sealed class Hall:Room
    {

        public List<Product> MoveProductsToWarehouse(Type type)
        {
            List<Product> buffer = Storage.FindAll(x => x.GetType() == type);
            Storage.RemoveAll(x => x.GetType() == type);
            return buffer;
        }

        /*public bool AddProduct(Product product)
        {
            if (exhibitedProducts.Contains(product))
                return false;
            exhibitedProducts.Add(product);
            return true;
        }

        public Product GetProduct(string productName)
        {
            var element = exhibitedProducts.Find(x => x.Name == productName);
            if(element != null)
                exhibitedProducts.Remove(element);
            return element;
        }

        public void SetDiscountOnType(TypeOfFood type, int discount)
        {
            foreach (Food product in exhibitedProducts)
            {
                if (product.Type == type)
                {
                    product.Discount = discount;
                }
            }
        }

        //скидка на тип вещи
        public void SetDiscountOnType(TypeOfItem type, int discount)
        {
            foreach (Item product in exhibitedProducts)
            {
                if (product.Type == type)
                {
                    product.Discount = discount;
                }
            }
        }*/
        /*public bool MoveProductToWarehouse(Product product)
        {
            int element = exhibitedProducts.IndexOf(product);
            if(element == -1)
            {
                return false
            }
            
        }*/
    }
}
