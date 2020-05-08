using System;
using System.Collections.Generic;

namespace SQL_Multi_Flow
{
    public partial class Markers
    {
        public Markers()
        {
            Relations = new HashSet<Relations>();
        }

        public int Id { get; set; }
        public string MarkerName { get; set; }

        public virtual ICollection<Relations> Relations { get; set; }
    }
}
