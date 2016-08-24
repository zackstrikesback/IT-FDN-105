using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Item
    {
        private int num;
        private string desc;
        private decimal price;
        private int qty;
        private decimal cost;
        private decimal val;

        public int Num
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }
        public string Desc
        {
            get
            {
                return desc;
            }
            set
            {
                desc = value;
            }
        }
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public int Qty
        {
            get
            {
                return qty;
            }
            set
            {
                qty = value;
            }
        }
        public decimal Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }
        public decimal Val
        {
            get
            {
                return qty * price;
            }
        }
        
        public Item(int n, string d, decimal p, int q, decimal c)
        {
            num = n;
            desc = d;
            price = p;
            qty = q;
            cost = c;
            val = p * q;
        }

        public string Money(decimal x)
        {
            return x.ToString("C");
        }

        public string Info()
        {
            return "Item #: " + num + ", Description: " + desc + ", Price: " + Money(price) + ", Quantity: " + qty + ", Cost: " + Money(cost) + ", Value: " + Money(val);
        }
    }

    class Inventory
    {
        private List<Item> Inv;

        public void add(Item i)
        {
            if (Inv == null)
            {
                Inv = new List<Item> { i };
            }
            else
            {
                Inv.Add(i);
            }
        }
        public int find(int n)
        {
            int x = -1;
            for(int i = 0; i < Inv.Count; i++)
            {
                if(n == Inv[i].Num)
                {
                    x = i;
                }
            }
            return x;
        }
        public void change(int index, Item change)
        {
            Inv[index] = change;
        }
        public void delete(int index)
        {
            Inv.RemoveAt(index);
        }
        public void list()
        {
            if(Inv == null || Inv.Count == 0)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                foreach (Item i in Inv)
                {
                    Console.WriteLine(i.Info());
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Inventory i = new Inventory();
            bool quit = false;
            while(!quit)
            {
                Console.WriteLine("Inventory:");
                i.list();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add item");
                Console.WriteLine("2. Delete item");
                Console.WriteLine("3. Change item information");
                Console.WriteLine("4. Display inventory");
                Console.WriteLine("5. Quit");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        {
                            Console.WriteLine("Item #: ");
                            int n = int.Parse(Console.ReadLine());
                            Console.WriteLine("Description: ");
                            string d = Console.ReadLine();
                            Console.WriteLine("Price: $");
                            decimal p = decimal.Parse(Console.ReadLine());
                            Console.WriteLine("Quantity: ");
                            int q = int.Parse(Console.ReadLine());
                            Console.WriteLine("Cost: $");
                            decimal c = decimal.Parse(Console.ReadLine());
                            Item a = new Item(n, d, p, q, c);
                            i.add(a);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Item #: ");
                            int n = int.Parse(Console.ReadLine());
                            int f = i.find(n);
                            if (f == -1)
                            {
                                Console.WriteLine("Could not find item.");
                            }
                            else
                            {
                                i.delete(f);
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Item #: ");
                            int n = int.Parse(Console.ReadLine());
                            int f = i.find(n);
                            if (f == -1)
                            {
                                Console.WriteLine("Could not find item.");
                            }
                            else
                            {
                                Console.WriteLine("Description: ");
                                string d = Console.ReadLine();
                                Console.WriteLine("Price: $");
                                decimal p = decimal.Parse(Console.ReadLine());
                                Console.WriteLine("Quantity: ");
                                int q = int.Parse(Console.ReadLine());
                                Console.WriteLine("Cost: $");
                                decimal c = decimal.Parse(Console.ReadLine());
                                Item a = new Item(n, d, p, q, c);
                                i.change(f, a);
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Inventory:");
                            i.list();
                            break;
                        }
                    case 5:
                        {
                            quit = true;
                            break;
                        }
                }
            }
        }
    }
}
