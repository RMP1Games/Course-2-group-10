using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using proekt.Models;
using proekt.Services.Repositories;
using proekt.Interfaces;
using System.Linq;
namespace proekt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultantsController : ControllerBase
    {
        private readonly IRRequest _requestRepository;

        public ConsultantsController(IRRequest requestRepository)
        {
            _requestRepository = requestRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Request>>> GetRequests()
        {
            return await _requestRepository.GetAllRequests();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Request>> GetRequest(int id)
        {
            var task = await _requestRepository.GetRequestById(id);
            if (task == null) return NotFound();
            return task;
        }

        [HttpPost]
        public async Task<ActionResult> CreateRequest(Request task)
        {
            await _requestRepository.CreateRequest(task);
            return CreatedAtAction(nameof(GetRequest), new { id = task.id }, task);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateRequest(int id, Request task)
        {
            if (id != task.id) return BadRequest();
            await _requestRepository.UpdateRequest(task);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteRequest(int id)
        {
            await _requestRepository.DeleteRequest(id);
            return NoContent();
        }




        //Всё, связанное с реакциями
        //В целом по своему заданию с реакциями и комментариями я решил не изобретать колесо и сделано всё "на легке".
        //Вообще, если бы были реализованы пользователи, то при запросах, связанных с реакциями, в заранее созданной подтаблице запишется id пользователя 
        //которые уже (например) лайкнули статью, чтобы нельзя было легко накрутить. Но у нас такого нет и смысла пытаться мне сделать это тоже нет :)
        [HttpPut("{id}")]
        public async Task<ActionResult> AddLike(int id, Request task)
        {
            if (id != task.id) return BadRequest();
            else
            {
                task.likes = task.likes + 1;
                await _requestRepository.UpdateRequest(task);
                return NoContent();
            }
        }

        //в данном случае проверялось бы, поставил ли n-ый пользователь лайк, чтобы он смог его удалить. Но, опять же, пользователей нет. С дизлайками та же история
        [HttpPut("{id}")]
        public async Task<ActionResult> DeleteLike(int id, Request task)
        {
            if (id != task.id) return BadRequest();
            else
            {
                task.likes = task.likes - 1;
                await _requestRepository.UpdateRequest(task);
                return NoContent();
            }
        }

        
        [HttpPut("{id}")]
        public async Task<ActionResult> AddDislike(int id, Request task)
        {
            if (id != task.id) return BadRequest();
            else
            {
                task.dislikes = task.dislikes + 1;
                await _requestRepository.UpdateRequest(task);
                return NoContent();
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> DeleteDislike(int id, Request task)
        {
            if (id != task.id) return BadRequest();
            else
            {
                task.dislikes = task.dislikes - 1;
                await _requestRepository.UpdateRequest(task);
                return NoContent();
            }
        }

        //комментарии, тут огранчений нет, пользователь может писать сколько угодно комментариев
        //т.к. опять же пользователей нет, я не пытался реализовать комментарии как-то по умному и просто всунул List.
        //Если бы были пользователи, я бы запарился и комментарий стал бы отдельной моделью.
        [HttpPut("{id}")]
        public async Task<ActionResult> AddComment(int id, string comment, Request task)
        {
            if (id != task.id) return BadRequest();
            else
            {
                task.comments.Add(comment);
                await _requestRepository.UpdateRequest(task);
                return NoContent();
            }
        }

        //Я пытался, но реализовать удаление без поиска комментария/ев по id пользователя не представляю возможным
        //удалить все комментарии можно через Clear(), так что над удаление всех решил не делать  т.к. легко сделать
    }
}
