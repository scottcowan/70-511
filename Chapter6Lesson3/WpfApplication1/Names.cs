using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace WpfApplication1
{
    public class Names : ObservableCollection<Name>
    {
        public Names()
        {
            var aName = new Name("FirstName " + (this.Count + 1).ToString(), "LastName " + (this.Count + 1).ToString());
            this.Add(aName);
        }
    }
}
