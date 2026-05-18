using MyFirstBlazor.Components.ViewModel;
namespace MyFirstBlazor.Services
{
    public class StudentService
    {
        public List<Student> Students { get; set; } = new List<Student>();
        
        public void AddStudent(Student student) {
            Students.Add(student);
        }
    }
}
