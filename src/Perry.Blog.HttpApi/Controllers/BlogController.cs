﻿//BlogController.cs
using Microsoft.AspNetCore.Mvc;
using Perry.Blog.Application.Blog;
using Perry.Blog.Application.Contracts.Blog;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace Perry.Blog.HttpApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : AbpController
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        /// <summary>
        /// 添加博客
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<bool> InsertPostAsync([FromBody] PostDto dto)
        {
            return await _blogService.InsertPostAsync(dto);
        }
    }
}
