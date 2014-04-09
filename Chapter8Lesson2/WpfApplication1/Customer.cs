using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WpfApplication1
{
    public class Customer : IDataErrorInfo
    {
        private string mFirstName = "";
        public string FirstName
        {
            get { return mFirstName; }
            set { mFirstName = value; }
        }

        private string mLastName = "";
        public string LastName
        {
            get { return mLastName; }
            set { mLastName = value; }
        }

        public string this[string columnName]
        {
            get { 
                string result = null;
                switch (columnName)
                {
                    case "FirstName":
                        if (!(FirstName.Length > 1))
                            result = "First Name must be at least 2 characters long";
                        else if (FirstName.Length > 10)
                            result = "First Name cannot be longer than 10 characters";
                        break;
                    case "LastName":
                        if (!(LastName.Length > 1))
                            result = "Last Name must be at least 2 characters long";
                        break;
                }
                return result;
            }
        }

        public string Error {
            get { throw new NotImplementedException(); }
        }
    }
}
