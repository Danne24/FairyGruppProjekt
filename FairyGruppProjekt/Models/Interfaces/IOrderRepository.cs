namespace FairyGruppProjekt.Models.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);

        IEnumerable<Order> GetAllOrders();
        OrderDetail GetById(int id);

    }
}
