using ApiConsulting.Context;
using ApiConsulting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiConsulting.API
{
    public class PostController : ApiController
    {
        private readonly ApiContext _apiContext;
        public PostController(ApiContext apiContext)
        {
            _apiContext = apiContext;
        }

        [HttpGet]
        // GET: api/Post
        public IEnumerable<Post> Get()
        {
            return _apiContext.Posts.ToList();
        }

        // GET: api/Post/5
        public Post GetById(int id)
        {
            var onePost = _apiContext.Posts.SingleOrDefault(p => p.Id == id);

            return onePost;
        }

        // POST: api/Post
        [HttpPost]
        public Post Post([FromBody]Post post)
        {
            _apiContext.Posts.Add(post);
            _apiContext.SaveChanges();

            return post;
        }

        // PUT: api/Post/5
        [HttpPut]
        public void Put(int id, [FromBody]Post post)
        {
            if (id != post.Id)
                throw new Exception();

            var onePost = _apiContext.Posts.SingleOrDefault(i => i.Id == id);

            _apiContext.SaveChanges();
        }

        // DELETE: api/Post/5
        [HttpDelete]
        public void Delete(int id)
        {
            var onePost = _apiContext.Posts.SingleOrDefault(i => i.Id == id);

            if (onePost == null)
                throw new Exception();

            _apiContext.Posts.Remove(onePost);
            _apiContext.SaveChanges();
        }
    }
}
