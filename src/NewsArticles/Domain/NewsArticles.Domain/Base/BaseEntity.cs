using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsArticles.Domain.Base
{
    /// <summary>
    /// Базовый контракт
    /// </summary>
    internal class BaseEntity
    {
        /// <summary>
        /// Идентификатор сущности
        /// </summary>
        public Guid Id { get; set; }
    }
}
