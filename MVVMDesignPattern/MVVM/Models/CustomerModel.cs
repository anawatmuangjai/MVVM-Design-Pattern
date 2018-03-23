using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.Notification;

namespace MVVM.Models
{
    public class CustomerModel : PropertyChangedNotification
    {
        int customerID;

        public int CustomerID
        {
            get
            {
                return customerID;
            }

            set
            {
                customerID = value;

                NotifyPropertyChanged("CustomerID");
            }
        }
        string email;

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;

                NotifyPropertyChanged("Email");
            }
        }
        string firstName;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;

                NotifyPropertyChanged("FirstName");
            }
        }
        string lastName;

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;

                NotifyPropertyChanged("LastName");
            }
        }
    }
}
