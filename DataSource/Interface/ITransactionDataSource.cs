using SpeedyAir.Models;

namespace SpeedyAir.DataSource.Interface
{
    internal interface ITransactionDataSource
    {
        IEnumerable<OrderModel> GetOrders();
    }

} 