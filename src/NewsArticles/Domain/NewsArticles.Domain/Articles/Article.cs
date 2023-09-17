using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsArticles.Domain.Base;

namespace NewsArticles.Domain.Articles
{
    /// <summary>
    /// Сущность статей.
    /// </summary>
    public class Article : BaseEntity
    {
        /// <summary>
        /// Заголовк
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Имя категории
        /// </summary>
        public Guid CategoryId { get; set; }

        /// <summary>
        /// Имя пользователя, который создал статью
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Наименование тегов
        /// </summary>
        public string[] TagNames { get; set; }
    }
}
