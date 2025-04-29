using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers;
using Models;
using Views;
using Repository;

namespace Controllers
{
    class OrderController
    {
        private ClientController cController;
        private ProductController pController;
        private List<Order> orderList = new List<Order>();

        public OrderController()
        {
            this.cController = new ClientController();
            this.pController = new ProductController();
            this.orderList = Repository<Order

        }

        public void CreateOrder()
        {
            Order temp = new Order();
            temp.client = ClientView.LoadClient();
            temp.setProductList(OrderView.LoadProductList());
        }
    }
}
