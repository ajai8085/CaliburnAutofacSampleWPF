using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoApp
{
    public class ShellViewModel : Screen
    {
        private int displayName;

        public int MyProperty
        {
            get { return displayName; }
            set { displayName = value; }
        }


        public ShellViewModel()
        {
            displayName = "Shell View";
        }
    }
}
