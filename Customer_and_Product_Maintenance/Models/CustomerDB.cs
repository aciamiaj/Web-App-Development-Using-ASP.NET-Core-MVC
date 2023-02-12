namespace Lab3.Models
{
    public class CustomerDB
    {
        private static List<Customer> _customers = new List<Customer>()
        {
            new Customer(){CustomerID = "C101", CustomerName = "Jaimaica", CustomerEmail = "jaimaica@gmail.com", Phone = "6477789987"},
            new Customer(){CustomerID = "C102", CustomerName = "Sarath", CustomerEmail = "sarath@gmail.com", Phone = "4169087756"},
            new Customer(){CustomerID = "C103", CustomerName = "Nahom", CustomerEmail = "nahom@gmail.com", Phone = "6479983456"},
            new Customer(){CustomerID = "C104", CustomerName = "Efe", CustomerEmail = "efe@gmail.com", Phone = "4169805632"},
            new Customer(){CustomerID = "C105", CustomerName = "Altamash", CustomerEmail = "altamash@gmail.com", Phone = "6471127856"},
            new Customer(){CustomerID = "C106", CustomerName = "Harsha", CustomerEmail = "harsha@gmail.com", Phone = "4163456987"}

        };

        public static List<Customer> GetCustomer()
        {
            return _customers;
        }
    }
}
