using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZhaoXi.Model;

namespace ZhaoXi.ViewModel
{
    class FirstPageViewModel : Common.NotifyProperty
    {
        public ObservableCollection<CourseServiceModel> CourseSeriesList { get; set; }

        public FirstPageViewModel()
        {
           
        }
    }
}
