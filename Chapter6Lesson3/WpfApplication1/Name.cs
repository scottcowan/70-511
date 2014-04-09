using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using WpfApplication1.Annotations;

namespace WpfApplication1
{
    public class Name : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Name(string fName, string lName)
        {
            mFirstName = fName;
            mLastName = lName;
        }

        private string mFirstName;
        private string mLastName;

        public string FirstName
        {
            get { return mFirstName; }
            set
            {
                mFirstName = value;
                PropertyChanged(this, new PropertyChangedEventArgs("FirstName"));
            }
        }

        public string LastName
        {
            get { return mLastName; }
            set
            {
                mLastName = value;
                PropertyChanged(this, new PropertyChangedEventArgs("LastName"));
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
