using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSpawn.Domain.Interfaces
{
    public interface IEntity
    {
        int id { get; set; }
        bool Status { get; set; }
        DateTime CreatAt { get; set; }
        int? CreatedBy { get; set; }
        DateTime? UpdateAt { get; set; }
        int? UpdatedBy { get; set; }
    }
}
