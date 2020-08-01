using System;
using System.Collections.Generic;

namespace mercer_api.DAL.Models
{
    public partial class Player : IEntity
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public DateTime Created { get; set; }
        public bool Active { get; set; }
    }
}
