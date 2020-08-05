using System;
using System.Collections.Generic;

namespace mercer_api.DAL.Models
{
    public partial class AbilityScoreType : IEntity
    {
        public int Id { get; set; }
        public string AbilityScoreName { get; set; }
    }
}
