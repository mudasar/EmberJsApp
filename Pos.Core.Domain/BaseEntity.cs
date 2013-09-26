using System;

namespace Pos.Core
{
    [Serializable]
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime LastModified { get; set; }
    }
}
