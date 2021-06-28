using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
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
    class FirstPageViewModel 
    {
        //public string CourseName { get; set; }

        public ObservableCollection<CourseServiceModel> CourseSeriesList { get; set; } = new ObservableCollection<CourseServiceModel>();

        public FirstPageViewModel()
        {
            InitCourseSeries();
        }

        void InitCourseSeries()
        {
            CourseSeriesList.Add(new CourseServiceModel
            {
                CourseName = "Java 高级实战VIP班级",
                SeriesCollection = new LiveCharts.SeriesCollection 
                {
                    new PieSeries {
                    Title = "zhaoxi", 
                    Values = new ChartValues<ObservableValue>{new ObservableValue(123)},
                    DataLabels = false },

                  new PieSeries {
                    Title = "zhaoxi",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(123)},
                    DataLabels = false },

                    new PieSeries {
                    Title = "zhaoxi",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(123)},
                    DataLabels = false },

                }
            }); 
        }
    }
}
