using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibraryChannelFactory
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CustomersService : ICustomersService
    {
        private Cliente customer = null;
        private List<Cliente> customers = null;
        private CustomerDetail customerDetail = null;
        private string updateQuery = string.Empty;
        private int NumRecordAffected = 0;

        public List<Cliente> GetListOfCustomers()
        {
            customers = new List<Cliente>();

            string SQLCustomers = "Select CustomerID, CompanyName, ContactName, ContactTitle from Customers Order By CustomerID";

            using (SqlConnection nwindConnect = new SqlConnection(Properties.Settings.Default.NWindConnection))
            {
                nwindConnect.Open();

                var nwindCmd = nwindConnect.CreateCommand();

                nwindCmd.CommandText = SQLCustomers;

                SqlDataReader dr = nwindCmd.ExecuteReader(CommandBehavior.SequentialAccess);

                while (dr.Read())
                {
                    customer = new Cliente();

                    customer.CustomerID = (dr.IsDBNull(0) != true ? dr.GetString(0) : "");
                    customer.CompanyName = (dr.IsDBNull(1) != true ? dr.GetString(1) : "");
                    customer.ContactName = (dr.IsDBNull(2) != true ? dr.GetString(2) : "");
                    customer.ContactTitle = (dr.IsDBNull(3) != true ? dr.GetString(3) : "");

                    customers.Add(customer);
                }
                dr.Close();
            }
            return customers;


        }

        public CustomerDetail GetCustomerDetail(string CustID)
        {
            customerDetail = new CustomerDetail();

            string SQLCustomers = "Select CustomerID, Address, City, Region, PostalCode, Phone from Customers Where CustomerID = @CustID Order By CustomerID";

            using (var nwindConnect = new SqlConnection(Properties.Settings.Default.NWindConnection))
            {
                nwindConnect.Open();

                var nwindCmd = nwindConnect.CreateCommand();

                nwindCmd.CommandText = SQLCustomers;

                nwindCmd.Parameters.Add(new SqlParameter("@CustID", DbType.String)).Value = CustID;


                SqlDataReader dr = nwindCmd.ExecuteReader(CommandBehavior.SequentialAccess);

                while (dr.Read())
                {

                    customerDetail.CustomerID = (dr.IsDBNull(0) != true ? dr.GetString(0) : "");
                    customerDetail.Address = (dr.IsDBNull(1) != true ? dr.GetString(1) : "");
                    customerDetail.City = (dr.IsDBNull(2) != true ? dr.GetString(2) : "");
                    customerDetail.Region = (dr.IsDBNull(3) != true ? dr.GetString(3) : "");
                    customerDetail.PostalCode = (dr.IsDBNull(4) != true ? dr.GetString(4) : "");
                    customerDetail.Phone = (dr.IsDBNull(5) != true ? dr.GetString(5) : "");

                }
                dr.Close();
            }
            return customerDetail;

        }

        public bool SaveChanges(string CustomerID, string Direccion, string Cuidad, string ThisRegion, string ZipCode, string Telefono)
        {
            string updateQuery =
                      @"UPDATE SET Address = @Direccion, "
                     + @"City = @Cuidad, "
                     + @"Region = @ThisRegion, "
                     + @"PostalCode = @ZonaPostal, "
                     + @"Phone = @Telefono "
                     + @"from Customers Order By CustomerID Where CustomerID = @ClienteID";

            using (var nwindConnect = new SqlConnection("name= NorthwindEntities"))
            {
                nwindConnect.Open();

                var nwindCmd = nwindConnect.CreateCommand();

                nwindCmd.CommandText = updateQuery;
                nwindCmd.Parameters.AddWithValue("@Direccion", Direccion).Direction = ParameterDirection.Input;
                nwindCmd.Parameters.AddWithValue("@Cuidad", Cuidad).Direction = ParameterDirection.Input;
                nwindCmd.Parameters.AddWithValue("@ThisRegion", ThisRegion).Direction = ParameterDirection.Input;
                nwindCmd.Parameters.AddWithValue("@ZonaPostal", ZipCode).Direction = ParameterDirection.Input;
                nwindCmd.Parameters.AddWithValue("@Telefono", Telefono).Direction = ParameterDirection.Input;
                nwindCmd.Parameters.AddWithValue("@ClienteID", CustomerID).Direction = ParameterDirection.Input;

                NumRecordAffected = nwindCmd.ExecuteNonQuery();

            }


            return (NumRecordAffected != 0);
        }
    }
}
