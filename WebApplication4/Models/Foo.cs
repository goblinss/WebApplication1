using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public enum Abc { A, B, C }
    public class Foo
    {
        [UIHint("Abc")]
        public Abc MyProperty { get; set; }
    }
}
