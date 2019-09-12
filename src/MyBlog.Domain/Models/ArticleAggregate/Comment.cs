using MyBlog.Domain.Core.Models;
using System;

namespace MyBlog.Domain.Models.ArticleAggregate
{
    public class Comment : Entity
    {
        public string Content { get; private set; }
        public DateTimeOffset CreateOn { get; private set; } = DateTimeOffset.Now;
    }
}
