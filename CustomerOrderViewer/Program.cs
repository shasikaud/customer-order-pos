using CustomerOrderViewer.Repository;
using System;
using System.Collections.Generic;

namespace CustomerOrderViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerOrderDetailCommand customerOrderDetailCommand = new CustomerOrderDetailCommand(@"Data Source=localhost;Initial Catalog=CustomerOrderViewer;Integrated Security=True");
            IList<CustomerOrderDetailModerl> customerOrderDetailModels = customerOrderDetailCommand.GetList();
        }
    }
}
