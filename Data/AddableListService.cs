using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Data
{
    public class AddableListService
    {
        private readonly IList<AddableListElement> _addableElementsList = new List<AddableListElement>();

        public Task<IList<AddableListElement>> GetElementListAsync()
        {
            return Task.FromResult(_addableElementsList);
        }
    }
}
