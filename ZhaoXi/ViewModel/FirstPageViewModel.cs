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
    class FirstPageViewModel :Common.NotifyProperty
    {

        private int _instrument;

        public int Instrument
        {
            get { return _instrument; }
            set { _instrument = value; OnPropertyChanged(); }
        }

        public ObservableCollection<CourseServiceModel> CourseSeriesList { get; set; } = new ObservableCollection<CourseServiceModel>();

        public FirstPageViewModel()
        {
            InitCourseSeries();
            Task.Run(() => 
            {
                while (true)
                {
                    Random random = new Random(Guid.NewGuid().GetHashCode());
                    _instrument = random.Next(-2, 81);
                    Console.WriteLine(_instrument);
                    Thread.Sleep(1000);
                }
            });
        }

        void InitCourseSeries()
        {
            CourseSeriesList.Add(new CourseServiceModel
            {
                //字符串
                CourseName = "Java 高级实战VIP班级",

                //集合
                SeriesCollection = new LiveCharts.SeriesCollection 
                {
                    new PieSeries {
                    Title = "云课堂", 
                    Values = new ChartValues<ObservableValue>{new ObservableValue(272) },
                    DataLabels = false },

                  new PieSeries {
                    Title = "B站",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(682) },
                    DataLabels = false },

                    new PieSeries {
                    Title = "知乎",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(1026) },
                    DataLabels = false },

                      new PieSeries {
                    Title = "抖音",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(3389) },
                    DataLabels = false },

                  new PieSeries {
                    Title = "博客",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(288) },
                    DataLabels = false }
                },

                //集合
                SeriesList=new ObservableCollection<SeriesModel>
                {
                    new SeriesModel{SeriesName="云课堂",CurrentValue=272, IsGrowing=false, ChangeRate=-75},
                    new SeriesModel{SeriesName="B站",CurrentValue=682,IsGrowing=true, ChangeRate=75},
                     new SeriesModel{SeriesName="知乎",CurrentValue=1026, IsGrowing=false, ChangeRate=-75},
                    new SeriesModel{SeriesName="抖音",CurrentValue=3389,IsGrowing=true, ChangeRate=75},
                     new SeriesModel{SeriesName="博客",CurrentValue=288, IsGrowing=false, ChangeRate=-75}
                }

            });
            CourseSeriesList.Add(new CourseServiceModel
            {
                //字符串
                CourseName = "Java 高级实战VIP班级",

                //集合
                SeriesCollection = new LiveCharts.SeriesCollection
                {
                    new PieSeries {
                    Title = "云课堂",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(272) },
                    DataLabels = false },

                  new PieSeries {
                    Title = "B站",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(682) },
                    DataLabels = false },

                    new PieSeries {
                    Title = "知乎",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(1026) },
                    DataLabels = false },

                      new PieSeries {
                    Title = "抖音",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(3389) },
                    DataLabels = false },

                  new PieSeries {
                    Title = "博客",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(288) },
                    DataLabels = false }
                },

                //集合
                SeriesList = new ObservableCollection<SeriesModel>
                {
                    new SeriesModel{SeriesName="云课堂",CurrentValue=272, IsGrowing=false, ChangeRate=-75},
                    new SeriesModel{SeriesName="B站",CurrentValue=682,IsGrowing=true, ChangeRate=75},
                     new SeriesModel{SeriesName="知乎",CurrentValue=1026, IsGrowing=false, ChangeRate=-75},
                    new SeriesModel{SeriesName="抖音",CurrentValue=3389,IsGrowing=true, ChangeRate=75},
                     new SeriesModel{SeriesName="博客",CurrentValue=288, IsGrowing=false, ChangeRate=-75}
                }

            });
            CourseSeriesList.Add(new CourseServiceModel
            {
                //字符串
                CourseName = "Java 高级实战VIP班级",

                //集合
                SeriesCollection = new LiveCharts.SeriesCollection
                {
                    new PieSeries {
                    Title = "云课堂",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(272) },
                    DataLabels = false },

                  new PieSeries {
                    Title = "B站",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(682) },
                    DataLabels = false },

                    new PieSeries {
                    Title = "知乎",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(1026) },
                    DataLabels = false },

                      new PieSeries {
                    Title = "抖音",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(3389) },
                    DataLabels = false },

                  new PieSeries {
                    Title = "博客",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(288) },
                    DataLabels = false }
                },

                //集合
                SeriesList = new ObservableCollection<SeriesModel>
                {
                    new SeriesModel{SeriesName="云课堂",CurrentValue=272, IsGrowing=false, ChangeRate=-75},
                    new SeriesModel{SeriesName="B站",CurrentValue=682,IsGrowing=true, ChangeRate=75},
                     new SeriesModel{SeriesName="知乎",CurrentValue=1026, IsGrowing=false, ChangeRate=-75},
                    new SeriesModel{SeriesName="抖音",CurrentValue=3389,IsGrowing=true, ChangeRate=75},
                     new SeriesModel{SeriesName="博客",CurrentValue=288, IsGrowing=false, ChangeRate=-75}
                }

            });
            CourseSeriesList.Add(new CourseServiceModel
            {
                //字符串
                CourseName = "Java 高级实战VIP班级",

                //集合
                SeriesCollection = new LiveCharts.SeriesCollection
                {
                    new PieSeries {
                    Title = "云课堂",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(272) },
                    DataLabels = false },

                  new PieSeries {
                    Title = "B站",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(682) },
                    DataLabels = false },

                    new PieSeries {
                    Title = "知乎",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(1026) },
                    DataLabels = false },

                      new PieSeries {
                    Title = "抖音",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(3389) },
                    DataLabels = false },

                  new PieSeries {
                    Title = "博客",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(288) },
                    DataLabels = false }
                },

                //集合
                SeriesList = new ObservableCollection<SeriesModel>
                {
                    new SeriesModel{SeriesName="云课堂",CurrentValue=272, IsGrowing=false, ChangeRate=-75},
                    new SeriesModel{SeriesName="B站",CurrentValue=682,IsGrowing=true, ChangeRate=75},
                     new SeriesModel{SeriesName="知乎",CurrentValue=1026, IsGrowing=false, ChangeRate=-75},
                    new SeriesModel{SeriesName="抖音",CurrentValue=3389,IsGrowing=true, ChangeRate=75},
                     new SeriesModel{SeriesName="博客",CurrentValue=288, IsGrowing=false, ChangeRate=-75}
                }

            });
            CourseSeriesList.Add(new CourseServiceModel
            {
                //字符串
                CourseName = "Java 高级实战VIP班级",

                //集合
                SeriesCollection = new LiveCharts.SeriesCollection
                {
                    new PieSeries {
                    Title = "云课堂",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(272) },
                    DataLabels = false },

                  new PieSeries {
                    Title = "B站",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(682) },
                    DataLabels = false },

                    new PieSeries {
                    Title = "知乎",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(1026) },
                    DataLabels = false },

                      new PieSeries {
                    Title = "抖音",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(3389) },
                    DataLabels = false },

                  new PieSeries {
                    Title = "博客",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(288) },
                    DataLabels = false }
                },

                //集合
                SeriesList = new ObservableCollection<SeriesModel>
                {
                    new SeriesModel{SeriesName="云课堂",CurrentValue=272, IsGrowing=false, ChangeRate=-75},
                    new SeriesModel{SeriesName="B站",CurrentValue=682,IsGrowing=true, ChangeRate=75},
                     new SeriesModel{SeriesName="知乎",CurrentValue=1026, IsGrowing=false, ChangeRate=-75},
                    new SeriesModel{SeriesName="抖音",CurrentValue=3389,IsGrowing=true, ChangeRate=75},
                     new SeriesModel{SeriesName="博客",CurrentValue=288, IsGrowing=false, ChangeRate=-75}
                }

            });
            CourseSeriesList.Add(new CourseServiceModel
            {
                //字符串
                CourseName = "Java 高级实战VIP班级",

                //集合
                SeriesCollection = new LiveCharts.SeriesCollection
                {
                    new PieSeries {
                    Title = "云课堂",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(272) },
                    DataLabels = false },

                  new PieSeries {
                    Title = "B站",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(682) },
                    DataLabels = false },

                    new PieSeries {
                    Title = "知乎",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(1026) },
                    DataLabels = false },

                      new PieSeries {
                    Title = "抖音",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(3389) },
                    DataLabels = false },

                  new PieSeries {
                    Title = "博客",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(288) },
                    DataLabels = false }
                },

                //集合
                SeriesList = new ObservableCollection<SeriesModel>
                {
                    new SeriesModel{SeriesName="云课堂",CurrentValue=272, IsGrowing=false, ChangeRate=-75},
                    new SeriesModel{SeriesName="B站",CurrentValue=682,IsGrowing=true, ChangeRate=75},
                     new SeriesModel{SeriesName="知乎",CurrentValue=1026, IsGrowing=false, ChangeRate=-75},
                    new SeriesModel{SeriesName="抖音",CurrentValue=3389,IsGrowing=true, ChangeRate=75},
                     new SeriesModel{SeriesName="博客",CurrentValue=288, IsGrowing=false, ChangeRate=-75}
                }

            });
        }
    }
}
