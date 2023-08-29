using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsArticles.Contracts.Base;
using NewsArticles;


namespace NewsArticles.Contracts
{
    /// <summary>
    /// Статья
    /// </summary>
    public class ArticleDto : BaseDto
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
        public string CategoryName { get; set; }

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
