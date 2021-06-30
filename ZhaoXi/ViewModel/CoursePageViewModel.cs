using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZhaoXi.View;

namespace ZhaoXi.ViewModel
{
    public class CoursePageViewModel
    {
        public ObservableCollection<CategoryItemModel> CategoryCourses { set; get; } = new ObservableCollection<CategoryItemModel>();

        public ObservableCollection<CategoryItemModel> CategoryTechnology { set; get; } = new ObservableCollection<CategoryItemModel>();

        public ObservableCollection<CategoryItemModel> CategoryTeacher { set; get; } = new ObservableCollection<CategoryItemModel>();

        public CoursePageViewModel()
        {
            CategoryCourses.Add(new CategoryItemModel("全部", true));
            CategoryCourses.Add(new CategoryItemModel("公开课"));
            CategoryCourses.Add(new CategoryItemModel("VIP课程"));

            CategoryTechnology.Add(new CategoryItemModel("全部", true));
            CategoryTechnology.Add(new CategoryItemModel("C#"));
            CategoryTechnology.Add(new CategoryItemModel("ASP.NET"));
            CategoryTechnology.Add(new CategoryItemModel("微服务"));
            CategoryTechnology.Add(new CategoryItemModel("Java"));
            CategoryTechnology.Add(new CategoryItemModel("Vue"));


            CategoryTeacher.Add(new CategoryItemModel("全部", true));
            CategoryTeacher.Add(new CategoryItemModel("Eleven"));
            CategoryTeacher.Add(new CategoryItemModel("Richard"));
            CategoryTeacher.Add(new CategoryItemModel("Clay"));
            CategoryTeacher.Add(new CategoryItemModel("Garry"));
            CategoryTeacher.Add(new CategoryItemModel("Aces"));

        }
    }
}
