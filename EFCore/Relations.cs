using System;
using System.Collections.Generic;

namespace SQL_Multi_Flow
{
    public partial class Relations
    {
        public int Id { get; set; }
        public int ServerListId { get; set; }
        public int MarkerId { get; set; }

        public virtual Markers Marker { get; set; }
        public virtual ServerList ServerList { get; set; }
    }
}
