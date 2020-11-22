using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Sol_Demo.Data
{
    public interface IPersonData
    {
        Task<IReadOnlyList<PersonModel>> GetPersonData();
    }

    public class PersonData : IPersonData
    {
        Task<IReadOnlyList<PersonModel>> IPersonData.GetPersonData()
        {
            return Task.Run<IReadOnlyList<PersonModel>>(() =>
            {
                var listPersonData = new List<PersonModel>();
                listPersonData.Add(new PersonModel()
                {
                    Name = "Kishor Naik",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla elit dolor, convallis non interdum."
                });
                listPersonData.Add(new PersonModel()
                {
                    Name = "Eshaan Naik",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla elit dolor, convallis non interdum."
                });
                listPersonData.Add(new PersonModel()
                {
                    Name = "Yogesh Naik",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla elit dolor, convallis non interdum."
                });

                return listPersonData.AsReadOnly();
            });
        }
    }
}