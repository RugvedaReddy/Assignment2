using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PizzaOrder> po = new List<PizzaOrder>
            {
                //USING PROPERTY INITIALISATION OF CLASS PIZZA ORDER
                new PizzaOrder { OrderID =1001,OrderDate=DateTime.Now,PizzaType="Veg",PizzaSize='S',Toppings="SWEET CORN",Qty=1,Price=250},
                new PizzaOrder { OrderID =1002,OrderDate=DateTime.Now,PizzaType="Veg",PizzaSize='M',Toppings="ONION",Qty=1,Price=300},
                new PizzaOrder { OrderID =1003,OrderDate=DateTime.Now,PizzaType="Veg",PizzaSize='L',Toppings="CAPCICUM",Qty=1,Price=350},
                new PizzaOrder { OrderID =1004,OrderDate=DateTime.Now,PizzaType="Veg",PizzaSize='M',Toppings="TOMATO",Qty=2,Price=500},
                new PizzaOrder { OrderID =1005,OrderDate=DateTime.Now,PizzaType="NonVeg",PizzaSize='S',Toppings="CHICKEN",Qty=1,Price=550},
                new PizzaOrder { OrderID =1006,OrderDate=DateTime.Now,PizzaType="NonVeg",PizzaSize='M',Toppings="EGG",Qty=1,Price=450},
                new PizzaOrder { OrderID =1007,OrderDate=DateTime.Now,PizzaType="NonVeg",PizzaSize='L',Toppings="CHICKEN",Qty=1,Price=1000}
            };
            foreach (var i in po)
                Console.WriteLine(i.OrderID + " " + i.OrderDate + " " + i.PizzaType + " " + i.PizzaSize + " " + i.Toppings + " " + i.Qty + " " + i.Price);
            Console.WriteLine("*********************");
            foreach (var i in po.Where(x => x.PizzaType == "Veg" && x.PizzaSize == 'M')) 
                Console.WriteLine(i.OrderID + " " + i.OrderDate + " " + i.PizzaType + " " + i.PizzaSize + " " + i.Toppings + " " + i.Qty + " " + i.Price);
            Console.WriteLine("*********************");

            var grp1 = po.GroupBy(x => x.PizzaType).Select(x => new { PizzaSold = x.Sum(y=>y.Qty), AmountCollected = x.Sum(y => y.Price) });
            foreach (var d in grp1)
                Console.WriteLine(d.PizzaSold + " " + d.AmountCollected);
            Console.WriteLine("*************");
            var grp2 = po.GroupBy(x => x.PizzaSize).Select(x => new { PizzaSold = x.Sum(y => y.Qty), AmtCollected = x.Sum(y => y.Price) });
            foreach (var d in grp2)
                Console.WriteLine(d.PizzaSold + " " + d.AmtCollected);
            Console.WriteLine("*************");
            foreach (var i in po.Where(X => X.PizzaSize == 'M'))
                Console.WriteLine(i.PizzaType + " " + i.Toppings);
            Console.WriteLine("*************");
            var data1 = po.Where(x => new { maxprice = x.Max(y => y.Price) });





        }
    }
}
