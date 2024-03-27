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
            OrderStatus status = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine("Order " + OrderStatus.PendingPayment.ToString());
            Console.WriteLine(status);
        }
    }
}