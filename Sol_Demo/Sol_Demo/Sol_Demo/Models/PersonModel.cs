using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sol_Demo.Models
{
    public class PersonModel : ObservableObject
    {
        private String name;

        public String Name
        {
            get => name;
            set => base.SetProperty(ref name, value);
        }

        private String description;

        public String Description
        {
            get => description;
            set => base.SetProperty(ref description, value);
        }
    }
}