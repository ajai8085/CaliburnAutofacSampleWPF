using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace DemoApp
{
    public class ShellViewModel : Screen
    {
        public ShellViewModel()
        {

            Customers = new ObservableCollection<Customer>( new DataServices().GetCustomers());
        }
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                NotifyOfPropertyChange();
            }
        }

        private ObservableCollection<Customer> customers;

        public ObservableCollection<Customer> Customers
        {
            get { return customers; }
            set { customers = value; }
        }


        public void Save()
        {

        }

        
    }
}
