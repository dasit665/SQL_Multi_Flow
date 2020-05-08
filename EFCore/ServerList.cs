using System;
using System.Collections.Generic;

namespace SQL_Multi_Flow
{
    public partial class ServerList
    {
        public ServerList()
        {
            Relations = new HashSet<Relations>();
        }

        public int Id { get; set; }
        public string ServerDomainName { get; set; }
        public string DataBaseName { get; set; }
        public string ServerLogin { get; set; }
        public string ServerPassword { get; set; }

        public virtual ICollection<Relations> Relations { get; set; }
    }
}
