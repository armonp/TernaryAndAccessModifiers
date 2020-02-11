using System;

namespace TernaryAndAccessModifier {

    public class Customer {

        private static int NextId = 1; //static = all instances share same value. use to automatically assign Id
        
        public int Id { get; set; }
        public string Name { get; set; }
        private bool IsNationalAccount { get; set; }

        public override string ToString() { //modify ToString method that is automatically called in C.W(cust1)
            return $"Id ={this.Id}, Name = {this.Name}, NAcct={this.IsNationalAccount}";

        }

        #region static constructor
        static Customer() {
            //read file to get the next id to be assigned
            NextId = 21;
        }
        #endregion
        public void NationalAccount(string yesOrNo) {
            this.IsNationalAccount = yesOrNo.Equals("yes")? true : false;
        }
        public static string PrintNextId() { //static method. Cannot use instance properties or methods. 
            return $"Next Id is: {NextId}";
        }
        public Customer(string Name) {
            this.Id = NextId;
            NextId++;
            this.Name = Name;
        }
        

    }
}
