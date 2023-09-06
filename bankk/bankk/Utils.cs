using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankk
{
    internal class Utils
    {
        public static bool CheckBalance(User user, int minBalans) => minBalans >= user.Card.Balans;
    }
}
