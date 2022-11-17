using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingPractice.Entities
{
    internal class TraineeInfo:INotifyPropertyChanged
    {
        private string name;
        private string clientcompanyname;
        private string address;
        private string mobilenumber;
        private string photo;
             
        private void changedproperty(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
        public string Name 
        {
            get {return name;}
            set 
            {
                name = value;
                changedproperty("name");
            } 
        }

        public string ClientCompanyName 
        { 
            get { return clientcompanyname; } 
            set 
            {
                clientcompanyname = value;
                changedproperty("clientcompanyname");
            } 
        }

        public string MobileNumber 
        { 
            get { return mobilenumber; } 
            set 
            {
                mobilenumber = value;
                changedproperty("mobilenumber");
            } 
        }

        public string Address 
        { 
            get {return address; } 
            set 
            {
                address = value;
                changedproperty("address");
            } 
        }

       // public string Photo { get; set; }
        public string Photo
        {
            get { return photo; }
            set
            {
                photo = value;
                changedproperty("photo");

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
