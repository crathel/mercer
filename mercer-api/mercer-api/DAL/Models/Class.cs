using System;
using System.Collections.Generic;

namespace mercer_api.DAL.Models
{
    public partial class Class : IEntity
    {
        public Class()
        {
            Character = new HashSet<Character>();
            SubClass = new HashSet<SubClass>();
        }

        public int Id { get; set; }
        public string ClassName { get; set; }
        public string HitDie { get; set; }

        public virtual ICollection<Character> Character { get; set; }
        public virtual ICollection<SubClass> SubClass { get; set; }
    }
}
