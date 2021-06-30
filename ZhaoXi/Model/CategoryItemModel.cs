using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZhaoXi.View
{
    public class CategoryItemModel
    {
        public bool IsSelected { get; set; }
        public string CategoryName { get; set; }

        public CategoryItemModel(string Name, bool State = false)
        {
            CategoryName = Name;
            IsSelected = State;
        }
    }
}
