using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsArticles.Contracts;
namespace NewsArticles.Hosts.Api.Controllers
{
    /// <summary>
    /// Контроллер для работы с объявлениями
    /// </summary>
    [ApiController]
    [Route("article")]
    public class ArticleController : ControllerBase
    {
        /// <summary>
        /// Возвращает статью по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор статьи</param>
        /// <param name="cancellationToken">Отмена операции</param>
        /// <returns>Модель статьи <see cref="ArticleDto"/></returns>
        [HttpGet(template:"get-by-id")]
        [ProducesResponseType(typeof(ArticleDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return Ok();
        }

        /// <summary>
        /// Возвращает постраничные статьи
        /// </summary>
        /// <param name="cancellationToken">Отмена операции</param>
        /// <param name="PageSize">Размер страницы</param>
        /// <param name="pageIndex">Номер страницы</param>
        /// <returns>Коллекция статей <see cref="ArticleDto"/></returns>
        
        [HttpGet(template:"get-all-paged")]
        public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken, int PageSize = 10, int pageIndex = 0)
        {
            return Ok();
        }

        /// <summary>
        /// Создание статьи
        /// </summary>
        /// <param name="dto"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateAsync(ArticleDto dto, CancellationToken cancellationToken)
        {
            return Created(string.Empty, null);
        }

        /// <summary>
        /// Редактирует статью
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Отмена операции.</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> UpdateAsync(ArticleDto dto, CancellationToken cancellationToken)
        {
            return Ok();
        }

        /// <summary>
        /// Удаление статьи по идентификатору.
        /// </summary>
        /// <param name="id">Идетификатор объявления.</param>
        /// <param name="cancellationToken">Отмена операции.</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            return Ok();
        }
    }

}
