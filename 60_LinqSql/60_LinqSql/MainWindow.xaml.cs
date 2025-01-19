using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Configuration;
using System.Data.Linq;

namespace _60_LinqSql
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSqlDataClassesDataContext _DataContext;
        public MainWindow()
        {
            InitializeComponent();

            string connectionSctring = ConfigurationManager.ConnectionStrings["_60_LinqSql.Properties.Settings.DatabaseConnectionString"].ConnectionString;
            _DataContext = new LinqToSqlDataClassesDataContext(connectionSctring);

            InsertUniversities();
            InsertStudents();
            InsertLectures();
            InsertStudentLectureAssociations();
            GetUniversityOfTom();
            GetLecturesFromTom();
            GetAllStudentsFromYale();
            GetAllUniversitiesWithMale();
            GetAllLecturesFromBeijingTech();
            UpdateTom();
            DeleteHans();
        }

        public void InsertUniversities()
        {
            _DataContext.ExecuteCommand("delete from University");

            University yale = new University();
            yale.Name = "Yale";

            University beijingTech = new University();
            beijingTech.Name = "BeijingTech";

            _DataContext.Universities.InsertOnSubmit(yale);
            _DataContext.Universities.InsertOnSubmit(beijingTech);

            _DataContext.SubmitChanges();

            MainDataGrid.ItemsSource = _DataContext.Universities;
        }

        public void InsertStudents()
        {
            University yale = _DataContext.Universities.First(un => un.Name.Equals("Yale"));
            University beijingTech = _DataContext.Universities.First(un => un.Name.Equals("BeijingTech"));

            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Carla", Gender = "Female", UniversityId = yale.Id });
            students.Add(new Student { Name = "Tom", Gender = "Male", University = beijingTech });
            students.Add(new Student { Name = "Leyle", Gender = "Female", UniversityId = yale.Id });
            students.Add(new Student { Name = "Hans", Gender = "Male", University = beijingTech });

            _DataContext.Students.InsertAllOnSubmit(students);

            _DataContext.SubmitChanges();

            MainDataGrid.ItemsSource = _DataContext.Students;
        }

        public void InsertLectures()
        {
            Lecture math = new Lecture();
            math.Name = "Math";

            Lecture music = new Lecture();
            music.Name = "Music";

            _DataContext.Lectures.InsertOnSubmit(math);
            _DataContext.Lectures.InsertOnSubmit(music);

            _DataContext.SubmitChanges();

            MainDataGrid.ItemsSource = _DataContext.Lectures;
        }

        public void InsertStudentLectureAssociations()
        {
            Student Carla = _DataContext.Students.First(st => st.Name.Equals("Carla"));
            Student Tom = _DataContext.Students.First(st => st.Name.Equals("Tom"));
            Student Leyle = _DataContext.Students.First(st => st.Name.Equals("Leyle"));
            Student Hans = _DataContext.Students.First(st => st.Name.Equals("Hans"));

            Lecture Math = _DataContext.Lectures.First(lc => lc.Name.Equals("Math"));
            Lecture Music = _DataContext.Lectures.First(lc => lc.Name.Equals("Music"));

            _DataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Carla, Lecture = Math });
            _DataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Tom, Lecture = Math });

            StudentLecture slTom = new StudentLecture();
            slTom.StudentId = Tom.Id;
            slTom.LectureId = Math.Id;
            _DataContext.StudentLectures.InsertOnSubmit(slTom);

            _DataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Leyle, Lecture = Math });

            _DataContext.SubmitChanges();

            MainDataGrid.ItemsSource = _DataContext.StudentLectures;
        }

        public void GetUniversityOfTom()
        {
            Student Tom = _DataContext.Students.First(st => st.Name.Equals("Tom"));

            University TomsUniversity = Tom.University;

            List<University> universities = new List<University>();
            universities.Add(TomsUniversity);

            MainDataGrid.ItemsSource = universities;

        }

        public void GetLecturesFromTom()
        {
            Student Tom = _DataContext.Students.First(st => st.Name.Equals("Tom"));

            var tomsLectures = from sl in Tom.StudentLectures select sl.Lecture;

            MainDataGrid.ItemsSource = tomsLectures;
        }

        public void GetAllStudentsFromYale()
        {
            var studentsFromYale = from student in _DataContext.Students
                                   where student.University.Name == "Yale"
                                   select student;

            MainDataGrid.ItemsSource = studentsFromYale;
        }

        public void GetAllUniversitiesWithMale()
        {
            var transgernderUniversities = from student in _DataContext.Students
                                           join university in _DataContext.Universities
                                           on student.University equals university
                                           where student.Gender == "male"
                                           select university;

            MainDataGrid.ItemsSource = transgernderUniversities;
        }

        public void GetAllLecturesFromBeijingTech()
        {
            var lecturesFromBeijingTech = from sl in _DataContext.StudentLectures
                                          join student in _DataContext.Students on sl.StudentId equals student.Id
                                          where student.University.Name == "Beijing Tech"
                                          select sl.Lecture;

            MainDataGrid.ItemsSource = lecturesFromBeijingTech;
        }

        public void UpdateTom()
        {
            Student Tom = _DataContext.Students.FirstOrDefault(st => st.Name == "Tom");

            Tom.Name = "Mark";

            _DataContext.SubmitChanges();

            MainDataGrid.ItemsSource = _DataContext.Students;
        }

        public void DeleteHans()
        {
            Student Hans = _DataContext.Students.FirstOrDefault(st => st.Name == "Hans");
            _DataContext.Students.DeleteOnSubmit(Hans);
            _DataContext.SubmitChanges();

            MainDataGrid.ItemsSource = _DataContext.Students;
        }
    }
}
