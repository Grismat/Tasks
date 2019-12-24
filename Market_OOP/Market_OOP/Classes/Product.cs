using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_OOP
{

    class Product
    {
        protected string name;
        protected int discount;
        protected double weight;
        protected double cost;
        protected DateTime shelfLife = new DateTime();

        public Product(string name, double cost, DateTime shelfLife, double weight, int discount)
        {
            this.name = name;
            this.shelfLife = shelfLife;
            this.weight = weight;
            this.Discount = discount;
            this.cost = cost;
        }

        public string Name
        {
            get { return name; }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if(Weight > 0)
                {
                    weight = value;
                }
                //else?????
            }
        }

        public int Discount
        {
            get { return discount; }
            set
            {
                if(value < 100)
                {
                    discount = value;
                }
                else
                {
                    discount = 0;
                }
            }
        }

        public double Cost
        {
            get { return cost * (100 - discount) / 100; }
        }

        public DateTime ShelfLife
        {
            get { return shelfLife; }
            set { shelfLife = value; }
        }
    }

    class Food : Product
    {
        public Food(string name, TypeOfFood type, double cost, DateTime shelfLife, double weight, int discount)
            : base(name, cost, shelfLife, weight, discount)
        {
            this.Type = type;
        }

        public TypeOfFood Type { get; }
    }

    class Item : Product
    {
        public Item(string name, TypeOfItem type, double cost, DateTime shelfLife, double weight, int discount)
            : base(name, cost, shelfLife, weight, discount)
        {
            this.Type = type;
        }

        public TypeOfItem Type { get; }
    }
}
