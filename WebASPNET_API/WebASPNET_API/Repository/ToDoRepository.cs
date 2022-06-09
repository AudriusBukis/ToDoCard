using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using WebASPNET_API.Context;
using WebASPNET_API.Models;
using WebASPNET_API.Services;

namespace WebASPNET_API.Repository
{

    public class ToDoRepository : IToDoRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<ToDoRepository> _logger;

        public ToDoRepository(ILogger<ToDoRepository> logger, IMapper mapper, ApplicationDbContext context)
        {
            _logger = logger;
            _mapper = mapper;
            _context = context;
        }

        public IEnumerable<ToDo> GetAllToDoCards()
        {
            return _context.ToDos;
        }
        public ToDo AddNewToDoCard(ToDoDto toDoDto)
        {
            try
            {
                _logger.LogInformation($"Adding\n {toDoDto} ");
                var newToDo = _mapper.MapToDoDtoWithToDo(toDoDto);
                _context.ToDos.Add(newToDo);
                _context.SaveChanges();
                return newToDo;
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return default;
            }
            
        }
        public ToDo UpdateToDoCard( ToDoDto toDoDto, int id)
        {
            try
            {
                _logger.LogInformation($"Updating\n {toDoDto}");
                var toDoCardToUpdate = _context.ToDos.Single(x => x.Id == id);
                toDoCardToUpdate.NameLastName = toDoDto.NameLastName;
                toDoCardToUpdate.ToDoType = toDoDto.ToDoType;
                toDoCardToUpdate.ToDoContext = toDoDto.ToDoContext;
                toDoCardToUpdate.EndDateToDo = toDoDto.EndDateToDo;
                toDoCardToUpdate.ToDoDone = toDoDto.ToDoDone;
                _context.SaveChanges();
                return toDoCardToUpdate;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return default;
            }
            
        }
        public ToDo DeleteToDoCard( int id)
        {
            try
            {
                var toDoCardToDelate = _context.ToDos.Single(x => x.Id == id);
                _logger.LogInformation($"Deleting\n {toDoCardToDelate}");
                _context.ToDos.Remove(toDoCardToDelate);
                _context.SaveChanges();
                return toDoCardToDelate;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return default;
            }
        }
    }
}
