using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using WcfServiceLibraryChannelFactory;

namespace WindowsClient1
{
    public partial class WinServiceClient : Form
    {
        public WinServiceClient()
        {
            InitializeComponent();
        }

        private Cliente customer = null;
        private List<Cliente> customers = null;
        private CustomerDetail customerDetail = null;
        private ICustomersService channel = null;

        private void WinServiceClient_Load(object sender, EventArgs e)
        {
            var endPoint = new EndpointAddress("net.tcp://localhost:9000/WcfServiceLibraryChannelFactory/CustomersService");

            channel = ChannelFactory<ICustomersService>.CreateChannel(new NetTcpBinding(), endPoint);

            
        }

        private void btnListCustomers_Click(object sender, EventArgs e)
        {
            customers = channel.GetListOfCustomers();

            clienteBindingSource.DataSource = customers;

        }

        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            customer = (Cliente)clienteBindingSource.Current;

            customerDetail = channel.GetCustomerDetail(customer.CustomerID);

            customerDetailBindingSource.DataSource = customerDetail;

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (channel.SaveChanges(customerDetail.CustomerID, customerDetail.Address, customerDetail.City, customerDetail.Region, customerDetail.PostalCode, customerDetail.Phone))
            {
                MessageBox.Show("This Information waas Saved!");
            }
            else
            {
                MessageBox.Show("This information was not saved.");
            }
        }
    }
}
