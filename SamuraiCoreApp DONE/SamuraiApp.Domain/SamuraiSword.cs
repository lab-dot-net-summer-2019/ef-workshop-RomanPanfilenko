using System;
using System.Collections.Generic;
using System.Text;

namespace SamuraiApp.Domain
{
    public class SamuraiSword
    {
        public int SamuraiId { get; set; }
        public virtual Samurai Samurai { get; set; }
        public int SwordId { get; set; }
        public virtual Sword Sword { get; set; }
    }
}
