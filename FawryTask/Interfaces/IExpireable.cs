using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryTask.Interfaces
{
    internal interface IExpireable
    {
        public DateTime ExpireDate { get; }
    }
}
