using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCompany.Domain.Repositories.Abstract;

namespace MyCompany.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemRepository ServiceItems { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository,IServiceItemRepository serviceItemRepository)
        {
            TextFields = textFieldsRepository;
            ServiceItems = serviceItemRepository;
        }
    }
}
