using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Организация
    /// </summary>
    public class Organization : OrganizationBase
    {
        List<OrganizationChild> OrganizationChildren { get; set; }
    }
}
