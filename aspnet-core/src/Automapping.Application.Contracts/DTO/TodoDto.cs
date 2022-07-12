using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Automapping.DTO
{
    public class TodoDto : EntityDto<Guid>
    {
        [Required]
        public string Content { get; set; }
        public bool isDone { get; set; }
    }
}
