using Microsoft.AspNetCore.Mvc;
using Quotes.Project.Application.Interfaces;
using Quotes.Project.Domain.Model;
using System.Collections.Generic;
using System.Net;

namespace Quotes.Project.UI.WebApi.Controllers
{
    [ApiController]
    public class QuoteController : ControllerBase
    {
        private IQuoteService _quoteService;

        public QuoteController(IQuoteService quoteService)
        {
            _quoteService = quoteService;
        }

        /// <summary>
        /// Retorna a lista das frases no banco de dados
        /// </summary>
        /// <returns>json list de frases</returns>
        [Route("api/quote")]
        [HttpGet]
        public List<Quote> Get()
        {
            return _quoteService.GetQuotes();
        }

        [Route("api/quote/{id}")]
        [HttpGet]
        public Quote GetById(int id)
        {
            return _quoteService.GetQuoteById(id);
        }

        [Route("api/quote")]
        [HttpPost]
        public Quote PostQuote([FromBody] Quote quote)
        {
            _quoteService.PostQuote(quote);
            return quote;
        }

        [Route("api/quote")]
        [HttpPut]
        public HttpStatusCode UpdateQuote([FromBody] Quote quote)
        {
            return _quoteService.UpdateQuote(quote);
        }

        [Route("api/quote")]
        [HttpDelete]
        public HttpStatusCode DeleteQuote(int id)
        {
            return _quoteService.DeleteQuote(id);
        }
    }
}
