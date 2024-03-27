using ConsoleEnum.Entities;
using ConsoleEnum.Entities.Enums;

namespace ConsoleEnum {
    class Program { 
    
        static  void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.Delivered
            };
            Console.WriteLine("Order " + order);
        }
    }
}