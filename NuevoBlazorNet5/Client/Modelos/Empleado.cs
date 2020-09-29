using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NuevoBlazorNet5.Client.Modelos
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
