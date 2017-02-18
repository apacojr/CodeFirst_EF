using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_EF.Model
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string  SubjectName { get; set; }

        public virtual Student Student { get; set; }
    }
}
