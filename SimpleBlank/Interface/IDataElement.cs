using SimpleBlank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBlank.Interface
{
    interface IDataElement
    {
        string FullName { get; set; }
        string Name { get; set; }

        State State { get; set; }


    }
}
