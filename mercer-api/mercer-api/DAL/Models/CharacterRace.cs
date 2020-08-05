using System;
using System.Collections.Generic;

namespace mercer_api.DAL.Models
{
    public partial class CharacterRace : IEntity
    {
        public CharacterRace()
        {
            Character = new HashSet<Character>();
        }

        public int Id { get; set; }
        public string RaceName { get; set; }

        public virtual ICollection<Character> Character { get; set; }
    }
}
