using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMandBindingfLesson.Models;
public class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public int Age { get; set; }

    public override string ToString()
    {
        return $"{Name} \t {Surname}\t {Age}";
    }
}
