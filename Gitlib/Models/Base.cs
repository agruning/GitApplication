using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitLib
{
    public class Base
    {
        public string label { get; set; }
        public string @ref { get; set; }
        public string sha { get; set; }
        public User2 user { get; set; }
        public Repo2 repo { get; set; }
    }
}
