using MvvmHelpers;
using Sol_Demo.Data;
using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sol_Demo.ViewModels
{
    public class PersonViewModel : BaseViewModel
    {
        private readonly IPersonData personData = null;

        public PersonViewModel()
        {
            personData = DependencyService.Get<IPersonData>();

            OnPersonDataBind = async () =>
            {
                PersonList = new ObservableCollection<PersonModel>((await personData.GetPersonData()).ToList());
            };
            OnPersonDataBind();

            //PersonList = new ObservableCollection<PersonModel>(personData.GetPersonData().Result.ToList());

            DeleteCommand = new Command((name) => OnDeleteCommand(name.ToString()));
        }

        private ObservableCollection<PersonModel> personList;

        public ObservableCollection<PersonModel> PersonList
        {
            get => personList;
            set => base.SetProperty(ref personList, value);
        }

        public ICommand DeleteCommand { get; }

        private Action OnPersonDataBind { get; set; }

        private void OnDeleteCommand(String name)
        {
            PersonList.Remove(PersonList.FirstOrDefault((personModel) => personModel.Name == name));
        }
    }
}