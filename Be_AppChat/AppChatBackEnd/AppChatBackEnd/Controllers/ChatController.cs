
using AppChat.Models.Entities;
using AppChatBackEnd.DTO.Request.ChatRequest;
using AppChatBackEnd.DTO.Response.ChatResponse;
using AppChatBackEnd.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AppChatBackEnd.Controllers
{
    
        [HttpGet("friend-chat-list")]
        public async Task<IActionResult> GetFriendListChat([FromQuery] string email, [FromQuery] string? username)
        {
            var response = await chatRepository.GetUsersFriendListChatByEmailAndUserName(email, username);  

            return Ok(response);
        }
}
