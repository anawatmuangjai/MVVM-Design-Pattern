using MVVM.Command;
using MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM.ViewModels
{
    public class CustomerViewModel : ViewModel
    {
        private CustomerModel _selectedCustomer;

        public bool IsLoaded { get; private set; }

        public bool CanAdd
        {
            get
            {
                return IsLoaded;
            }
        }

        public bool CanDelete
        {
            get
            {
                return IsLoaded && SelectedCustomer != null;
            }
        }

        public bool CanSave
        {
            get
            {
                return IsLoaded && SelectedCustomer != null;
            }
        }

        public CustomerModel SelectedCustomer
        {
            get
            {
                return _selectedCustomer;
            }

            set
            {
                if (_selectedCustomer != value)
                {
                    _selectedCustomer = value;

                    NotifyPropertyChanged("SelectedCustomer");
                }
            }
        }

        public ObservableCollection<CustomerModel> CustomerList { get; set; }

        public ICommand AddCommand => new ActionCommand(c => Add());

        public ICommand SaveCommand => new ActionCommand(c => Save(), c => CanSave);

        public ICommand ClearCommand => new ActionCommand(c => Clear());

        public CustomerViewModel()
        {
            CustomerList = new ObservableCollection<CustomerModel>();
        }

        private void Add()
        {
            SelectedCustomer = new CustomerModel();
            IsLoaded = true;
        }

        private void Save()
        {
            throw new NotImplementedException();
        }

        private void Clear()
        {
            throw new NotImplementedException();
        }

    }
}
