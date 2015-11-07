using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;

namespace DemoApp
{
    public class ShellViewModel : Screen
    {
        public ShellViewModel()
        {
            this.DisplayName = "Entry";
          
        }
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (this.SetValue(ref _firstName, value))
                    NotifyOfPropertyChange(() => CanSave);
            }
        }
        
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set
            {
                this.SetValue(ref _lastName,value);
                    NotifyOfPropertyChange(() => CanSave);
            }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if(this.SetValue(ref _age, value))
                NotifyOfPropertyChange(() => CanSave);
            }
        }

        public bool CanSave
        {
            get
            {
                return (Age > 0 && !string.IsNullOrWhiteSpace(FirstName) && !string.IsNullOrWhiteSpace(LastName));
            }
        }

        public void Save()
        {
            MessageBox.Show("Saved");
        }

        
    }
}
