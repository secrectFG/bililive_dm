using AutoCompleteTextBox.Editors;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bililive_dm.AutoComplete
{
    public class RoomIdHistroyProvider : IComboSuggestionProvider
    {
        public IEnumerable GetFullCollection()
        {
            return roomIdList;
        }

        public IEnumerable GetSuggestions(string filter)
        {
            return
                roomIdList
                    .Where(x => x.ToString().IndexOf(filter, StringComparison.CurrentCultureIgnoreCase) > -1)
                    .ToList();
        }

        List<int> roomIdList = new List<int>();
    }
}
