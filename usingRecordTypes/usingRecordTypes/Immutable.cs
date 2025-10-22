using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingRecordTypes
{
   public class Employee
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public string Descriprtion { get; init; }

    }

    public record EmployeeRecord(int Id, string Name, string Description);
}
