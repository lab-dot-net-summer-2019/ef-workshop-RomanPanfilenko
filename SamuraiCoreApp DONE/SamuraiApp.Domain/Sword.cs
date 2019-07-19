using System;
using System.Collections.Generic;
using System.Text;

namespace SamuraiApp.Domain
{
    public class Sword
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<SamuraiSword> SamuraiSwords { get; set; }
        public string BlacksmithName { get; set; }
        public int KilledEnemy { get; set; }
    }
}
