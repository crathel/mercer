using System;
using System.Collections.Generic;

namespace mercer_api.DAL.Models
{
    public partial class Character : IEntity
    {
        public int Id { get; set; }
        public string CharacterName { get; set; }
        public int ClassId { get; set; }
        public int? SubClassId { get; set; }
        public int CharacterLevel { get; set; }
        public string PlayerName { get; set; }
        public int RaceId { get; set; }
        public int AlignmentId { get; set; }
        public string CharacterHeight { get; set; }
        public string CharacterWeight { get; set; }
        public int Speed { get; set; }
        public int ArmorClass { get; set; }
        public int MaxHitPoint { get; set; }
        public int CurrentHitPoint { get; set; }

        public virtual Alignment Alignment { get; set; }
        public virtual Class Class { get; set; }
        public virtual CharacterRace Race { get; set; }
        public virtual SubClass SubClass { get; set; }
    }
}
