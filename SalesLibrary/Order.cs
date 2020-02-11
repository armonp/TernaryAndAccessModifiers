using System;
using System.Collections.Generic;
using System.Text;

namespace TernaryAndAccessModifier {

    public class Order {

        private static int NextId = 7; //Order Ids with 7

        public int Id { get; private set; }
        public double Amount { get; set; }
        public Customer Customer { get; set; }

        public void SetCustomer(Customer customer) {

        }

        public Order() {
        this.Id = NextId;
        NextId += 7; //increment by 7
        }

    }//class
} //namespace
