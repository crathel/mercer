using System;
using System.Collections.Generic;

namespace mercer_api.DAL.Models
{
    public partial class SubClass : IEntity
    {
        public SubClass()
        {
            Character = new HashSet<Character>();
        }

        public int Id { get; set; }
        public string SubClassName { get; set; }
        public int ClassId { get; set; }

        public virtual Class Class { get; set; }
        public virtual ICollection<Character> Character { get; set; }
    }
}
