using Firebase.Database;
using Firebase.Database.Query;
using PracticaFirebase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFirebase.DataAccess.Respositori
{
    public class FirebaseRepository : IFirebaseRepository
    {
        private readonly FirebaseClient fireBaseClient;
        public static string path = "/Students/";
        public static string auth = "MRVEXiyTOdifZM1jHW3IAewGIDViweKTNWhdUTgY";
        public static string url = "https://primerprojectefirebase-default-rtdb.europe-west1.firebasedatabase.app/";
        
        public FirebaseRepository()
        {
            fireBaseClient = FirebaseConnection.GetFirebaseClient(url, auth);
        }

        public async Task<bool> ExistsStudent(string name)
        {
            return await fireBaseClient
                .Child("Students")
                .Child($"{name}")
                .OnceSingleAsync<Student>() != null;
        }

        public async Task<bool> RemoveStudent(string name)
        {
            try
            {
                await fireBaseClient
                    .Child(path)
                    .Child($"{name}")
                    .DeleteAsync();

                    return true;
            }
            catch (Exception ex)
            {
                string missatge = $"No s'ha pogut borrar el registre. {ex.Message}";
                return false;
            }
        }

        public async Task<bool> AddStudent(Student student)
        {
            try
            {
                return await fireBaseClient
                .Child(path)
                .PostAsync(student) != null;
            }

            catch (Exception ex)
            {
                string missatge = $"No s'ha pogut afegir l'estudiant: {ex.Message}";
                return false;
            }
            
        }

        public async Task<bool> UpdateStudent(Student student)
        {
            try
            {
                await fireBaseClient
                    .Child(path)
                    .Child(student.FullName)
                    .Child(student.Age)
                    .PutAsync(student);

                return true; // Assuming success if no exception is thrown
            }
            catch (Exception ex)
            {
                // Handle the exception or log it
                string missatge = $"No s'ha pogut actualitzar: {ex.Message}";
                return false;
            }
        }

        public async Task<Student> GetStudent(string name)
        {
            try
            {
                return await fireBaseClient
                    .Child(path)
                    .Child(name)
                    .OnceSingleAsync<Student>();
                
            }

            catch(Exception ex)
            {
                string misstatge = $"No s'ha pogut aconseguir l'informació de {ex.Message}";
                return null;
            }
        }

        public async Task<IReadOnlyCollection<FirebaseObject<Student>>> GetStudents()
        {
            var students = await fireBaseClient
                .Child(path)
                .OnceAsync<Student>();
            return students;
        }
    }
}
