using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BusinessLayer
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    public abstract class EntityBase
    {
        public EntityStateOption EntityState { get; set; }
        public bool IsNew { get; private set; }
        public bool HasChanges { get;  set; }
        public bool isValid => Validate();

        public abstract bool Validate();
        
    }
}
