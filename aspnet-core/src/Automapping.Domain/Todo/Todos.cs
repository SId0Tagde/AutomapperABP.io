using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Automapping.Todo
{
    public class Todos : Entity<Guid>
    {
        public string Content { get; set; }
        public bool isDone { get; set; }    
    }
}
