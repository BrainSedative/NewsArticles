using NewsArticles.Application.AppServices.Contexts.Article.Repositories;
using NewsArticles.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.InfrastructureDataAccess.Contexts.Post.Repositories
{
    public class PostRepository : IArticleRepository
    {
        public Task<ArticleDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return Task.Run(() => new ArticleDto
            {
                Id = Guid.NewGuid(),
                Title = "Статья о чем-то",
                Description = "Описание",
                CategoryName = "Полезное",
                TagNames = new[] { "природа", "праздники" },
            }, cancellationToken);
        }
    }
}