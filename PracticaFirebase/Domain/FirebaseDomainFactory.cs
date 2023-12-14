using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFirebase.Domain
{
    public class FirebaseDomainFactory
    {
        public static FirebaseDomain GetFirebaseDomain()
        {
            return new FirebaseDomain();
        }
    }
}
