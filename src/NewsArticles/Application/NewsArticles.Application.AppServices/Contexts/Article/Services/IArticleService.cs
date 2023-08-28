using NewsArticles.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsArticles.Application.AppServices.Contexts.Article.Services
{
    /// <summary>
    /// Сервис работы со статьями
    /// </summary>
    public interface IArticleService
    {           /// <summary>
        /// Возвращает статью по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор статьи</param>
        /// <param name="cancellationToken">Отмена операции</param>
        /// <returns>Модель статьи <see cref="ArticleDto"/></returns>
        Task<ArticleDto> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
