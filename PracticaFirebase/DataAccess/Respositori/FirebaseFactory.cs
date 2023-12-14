using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFirebase.DataAccess.Respositori
{
    public class FirebaseFactory
    {
        public static FirebaseRepository GetFirebaseRepository()
        {
            return new FirebaseRepository();
        }
    }
}
