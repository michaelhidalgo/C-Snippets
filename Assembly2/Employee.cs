using Assembly1;

namespace Assembly2
{
    public class Employee : Person
    {
    }

    public class Payment
    {
        public void ProcessPayment()
        {
            var employee = new Employee
                {
                    FirstName = "Michael",
                    LasName = "Hidalgo",
                    Address1 = "San Jose, Costa Rica",
                    Address2 = "Street 27,Cartago",
                    EmailAddress = "michaelfallas@gmail.com",
                    HomePhone = "+506 83423557",
                    WorkPhone = "+506 83423557"
                };
        }
    }
}