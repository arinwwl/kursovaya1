using KursSolodkaya.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursSolodkaya.ModelView
{
    class AddEditCustomersViewModel:BaseClass
    {
        public IList<Dealer> Universities { get; } = new ObservableCollection<Dealer>();

        public AddEditCustomersViewModel()
        {
            using (BazaContext db = new BazaContext())
            {
                Universities = db.Dealers.ToList();
            }
        }

    }
}
