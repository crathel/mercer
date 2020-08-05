using System;
using System.Collections.Generic;

namespace mercer_api.DAL.Models
{
    public partial class Alignment : IEntity
    {
        public Alignment()
        {
            Character = new HashSet<Character>();
        }

        public int Id { get; set; }
        public string AlignmentName { get; set; }

        public virtual ICollection<Character> Character { get; set; }
    }
}
