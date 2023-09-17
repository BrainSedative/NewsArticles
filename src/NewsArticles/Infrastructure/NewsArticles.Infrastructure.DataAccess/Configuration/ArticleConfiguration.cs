using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewsArticles.Domain.Articles;

namespace NewsArticles.Infrastructure.DataAccess.Configuration
{
    /// <summary>
    /// Конфигурация таблицы Articles
    /// </summary>
    internal class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            throw new NotImplementedException();
        }
    }
}
