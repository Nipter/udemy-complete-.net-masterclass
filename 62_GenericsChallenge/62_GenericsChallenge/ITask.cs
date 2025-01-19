using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62_GenericsChallenge
{
    internal interface ITask<TResult>
    {
        TResult Perform();
    }
}
