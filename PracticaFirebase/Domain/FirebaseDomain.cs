using PracticaFirebase.DataAccess.Respositori;
using PracticaFirebase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFirebase.Domain
{
    public class FirebaseDomain : IFirebaseDomain
    { 

        public IFirebaseRepository fr {  get; set; }

        public FirebaseDomain() 
        {
            fr = new FirebaseRepository();
        }
    
        public Task<bool> AddStudent(Student student)
        {
            Task<bool> result;
            result = fr.AddStudent(student);
            return result;
        }

        public Task<bool> ExistsStudent(string name)
        {
            Task<bool> result;
            result = fr.ExistsStudent(name);
            return result;
        }

        public Task<List<Student>> GetListStudents()
        {

        }

        public Task<Student> GetStudent(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveStudent(string name)
        {
            Task<bool> result;
            result = fr.RemoveStudent(name);
            return result;
        }

        public Task<bool> RemoveStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
