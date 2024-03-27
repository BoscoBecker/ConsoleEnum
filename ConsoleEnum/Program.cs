using ConsoleEnum.Entities;
using ConsoleEnum.Entities.Enums;

namespace ConsoleEnum {
    class Program { 
    
        static  void Main(string[] args)
        {
            Order order = new Order();
            order.Id = 1;
            order.Moment = DateTime.Now;
            order.Status = OrderStatus.Delivered;
            Console.WriteLine("Order " + order);

        }
    }
}