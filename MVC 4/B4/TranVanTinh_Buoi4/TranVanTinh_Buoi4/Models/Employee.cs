using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TranVanTinh_Buoi4.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public int Deptld { get; set; }
        public Employee()
        {

        }
    }
}