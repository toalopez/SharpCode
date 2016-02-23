using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibraryChannelFactory
{
    [ServiceContract]
    public interface ICustomersService
    {

        [OperationContract]
        List<Cliente> GetListOfCustomers();

        [OperationContract]
        CustomerDetail GetCustomerDetail(string CustID);

        [OperationContract]
        bool SaveChanges(string CustomerID, string Direccion, string Cuidad, string ThisRegion, string ZipCode, string Telefono);
    }

    [DataContract]
    public class Cliente
    {
        [DataMember]
        public string CustomerID { get; set; }

        [DataMember]
        public string CompanyName { get; set; }

        [DataMember]
        public string ContactName { get; set; }

        [DataMember]
        public string ContactTitle { get; set; }

    }

    [DataContract]
    public class CustomerDetail
    {
        [DataMember]
        public string CustomerID { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Region { get; set; }

        [DataMember]
        public string PostalCode { get; set; }

        [DataMember]
        public string Phone { get; set; }
    }
}
