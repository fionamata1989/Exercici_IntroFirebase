using Firebase.Database;
using PracticaFirebase.Models;

namespace PracticaFirebase.DataAccess.Respositori
{
    public interface IFirebaseRepository
    {
        public Task<bool> ExistsStudent(string name);
        public Task<bool> RemoveStudent(string name);
        public Task<bool> AddStudent(Student  student);
        public Task<bool> UpdateStudent(Student student);
        public Task<Student> GetStudent(string name);
        public Task<IReadOnlyCollection<FirebaseObject<Student>>> GetStudents();
    }
}