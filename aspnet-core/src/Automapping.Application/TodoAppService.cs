using Automapping.DTO;
using Automapping.Todo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Automapping
{
    public class TodoAppService : ApplicationService
    {
        private readonly IRepository<Todos, Guid> _todoRepository;

        public TodoAppService(IRepository<Todos, Guid> todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<TodoDto> CreateTodo(TodoDto todoDto)
        {
            //Automatically creating a new User object using the CreateUserInput object
            var todo = ObjectMapper.Map<TodoDto, Todos>(todoDto);
            var createdTodo = await _todoRepository.InsertAsync(todo);
            return ObjectMapper.Map<Todos,TodoDto>(createdTodo);
        }

        public async Task<TodoDto> GetTodo(Guid id)
        {
            return ObjectMapper.Map<Todos, TodoDto>(await _todoRepository.GetAsync(id));
        }
    }

}
