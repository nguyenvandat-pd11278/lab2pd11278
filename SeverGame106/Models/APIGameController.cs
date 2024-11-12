using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServerGame106.Data;
using SeverGame106.Models;

namespace ServerGame106.Models
{
    [Route("api/[controller]")]
    [ApiController]


    public class APIGameController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        protected ResponseApi _response;
        public APIGameController(ApplicationDbContext db)
        {
            _db = db;
            _response = new();
        }
        [HttpGet("GetAllGameLevel")]
        public async Task<IActionResult> GetAllGameLevel()
        {
            try
            {
                var gameLevel = await _db.GameLevels.ToListAsync();
                _response.IsSuccess = true;
                _response.Notification = "Lay du lieu thanh cong";
                _response.data = gameLevel;
                _response.data = gameLevel;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Notification = "Loi";
                _response.data = ex.Message;
                return BadRequest(_response);
            }
        }
        [HttpGet("GetAllQuestionGame")]
        public async Task<IActionResult> GetAllQuestionGame()
        {
            try
            {
                var questionGame = await _db.Questions.ToListAsync();
                _response.IsSuccess = true;
                _response.Notification = "Lay du lieu thanh cong";
                _response.data = questionGame;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Notification = "Loi";
                _response.data = ex.Message;
                return BadRequest(_response);
            }
        }
        [HttpGet("GetAllRegion")]
        public async Task<IActionResult> GetAllRegion()
        {
            try
            {
                var region = await _db.Regions.ToListAsync();
                _response.IsSuccess = true;
                _response.Notification = "Lay du lieu thanh cong";
                _response.data = region;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Notification = "Loi";
                _response.data = ex.Message;
                return BadRequest(_response);
            }
        }
    }
}