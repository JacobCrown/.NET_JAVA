using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; //dla entityframework

namespace Api
{
    public class Chuck_DB: DbContext
    {
        public virtual DbSet<Chuck> Chucks { get; set; }
    }
}
