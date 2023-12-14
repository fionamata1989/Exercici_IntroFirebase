using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFirebase.DataAccess
{
    public static class FirebaseConnection
    {
        public static FirebaseClient Firebase { get; set; }
        public static string path = "/Students/";
        public static string auth = "MRVEXiyTOdifZM1jHW3IAewGIDViweKTNWhdUTgY";
        public static string url = "https://primerprojectefirebase-default-rtdb.europe-west1.firebasedatabase.app/";

        public static FirebaseClient GetFirebaseClient(string url, string secret = null)
        {
            FirebaseClient client = null;
            try
            {
                client = new FirebaseClient(url,
                    new FirebaseOptions()
                    {
                        AuthTokenAsyncFactory = () => Task.FromResult(secret)
                    });
            }
            catch (Exception e)
            {
                Console.WriteLine("Error In Creating FireBase Client\n" + e);
            }
            return client;
        }
    }

}
