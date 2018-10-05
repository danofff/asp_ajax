using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp_ajax.Models
{
    public class TablesViewModel
    {
        public List<Independent> Independent { get; set; }
        public List<Responses> Responses { get; set; }
        public List<MathFunction> MathFunctions { get; set; }
    }
}