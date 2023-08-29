using NewsArticles.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsArticles.Application.AppServices.Contexts.Article.Services
{

    public class ArticleService : IArticleService
    {
        public Task<ArticleDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

    }
}
