using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.Entitiy.Abstract
{
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public DateTime _createDate = DateTime.UtcNow;  
        public virtual DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; }
        }
    }
}
