using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFSSLRest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class SecureRESTSvcTest : ISecureRESTSvcTest
    {
        public Customer GetCustomerData(string CustID)
        {

            Customer customer = new Customer()
            {
                ID = CustID,
                FirstName = "John",
                LastName = "Smithers",
                PhoneNumber = "800-555-5555",
                DOB = "01/01/70",
                Email = "jsmithers@fancydomain.com",
                AccountNumber = "1234567890"
            };

            return customer;
        }
    }

    [DataContract]
    public class Customer
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public string DOB { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string ID { get; set; }
        [DataMember]
        public string AccountNumber { get; set; }
    }
}
