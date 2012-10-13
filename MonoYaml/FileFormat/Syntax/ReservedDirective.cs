using System;
using System.Collections.Generic;
using System.Text;

namespace MonoYaml
{
    public partial class ReservedDirective : Directive
    {
        public string Name;

        public List<string> Parameters = new List<string>();

    }
}
