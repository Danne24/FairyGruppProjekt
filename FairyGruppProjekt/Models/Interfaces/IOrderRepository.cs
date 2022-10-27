namespace FairyGruppProjekt.Models.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);


        IEnumerable<Order> GetAllOrdersForDashboard { get; }
        IEnumerable<Order> GetStatistic { get; }
       // public int GetStatistic(); 

        IEnumerable<Order> GetAllOrders();
        OrderDetail GetById(int id);


    }
}
