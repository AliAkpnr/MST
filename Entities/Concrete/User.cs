using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String FullName { get; set; }
    }
}