using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Domain.Core.Models;
using MyBlog.Domain.Core.Interfaces;

namespace MyBlog.Domain.Models.ArticleAggregate
{
    public class Article : Entity, IAggregateRoot
    {
        public string Title { get; private set; }
        public string Submitter { get; private set; }
        public string Category { get; private set; }
        public string Content { get; private set; }
        public int CommentNum { get; private set; }
        public int Traffic { get; private set; }
        public DateTimeOffset CreateOn { get; private set; } = DateTimeOffset.Now;
        /// <summary>
        /// 
        /// </summary>
        public DateTimeOffset? UpdateOn { get; private set; }
        public string Remark { get; private set; }
        public bool IsDelete { get; private set; }

        public Article()
        {

        }
        public Article(string title, string submitter, string category, string content, string remark) : this()
        {
            Title = title;
            Submitter = submitter;
            Category = category;
            Content = content;
            CommentNum = 0;
            Traffic = 0;
            Remark = remark;
            IsDelete = false;
        }
    }
}
