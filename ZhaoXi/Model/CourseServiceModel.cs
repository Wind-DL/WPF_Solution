using LiveCharts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZhaoXi.Model
{
    class CourseServiceModel
    {
        public string CourseName { get; set; }

        public SeriesCollection SeriesCollection { get; set; }

        public ObservableCollection<SeriesModel> SeriesList { get; set; }
    }
}
