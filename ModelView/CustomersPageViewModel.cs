using KursSolodkaya.Customers;
using KursSolodkaya.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursSolodkaya.ModelView
{
    class CustomersPageViewModel : BaseClass
    {
        BazaContext db = new BazaContext();
        public ObservableCollection<Customer>? CustomerList { get; set; }

        private Customer? selectedCustomer;
        public Customer? SelectedCustomer
        {
            get { return selectedCustomer; }
            set
            {
                selectedCustomer = value;
                OnPropertyChanged("SelectedCustomer");
            }
        }

        public CustomersPageViewModel()
        {
            using (BazaContext db = new BazaContext()) 
            { 
               
            }
        }

        private RelayCommand? addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new RelayCommand(obj =>
                    {
                        AddEditCustomer window = new AddEditCustomer();
                        window.Show();
                    }));
            }
        }
    }
}
