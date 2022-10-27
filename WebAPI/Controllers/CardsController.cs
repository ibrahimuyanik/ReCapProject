using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        ICardService _cardService;

        public CardsController(ICardService cardService)
        {
            _cardService = cardService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _cardService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbycardid")]
        public IActionResult GetByCardId(int cardId)
        {
            var result = _cardService.GetByCardId(cardId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getcardsbycustomerid")]
        public IActionResult GetCardsByCustomerId(int customerId)
        {
            var result = _cardService.GetCardsByCustomerId(customerId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Card card)
        {
            var result = _cardService.Add(card);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Card card)
        {
            var result = _cardService.Update(card);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Card card)
        {
            var result = _cardService.Delete(card);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
