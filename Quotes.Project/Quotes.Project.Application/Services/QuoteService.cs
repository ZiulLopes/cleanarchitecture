using Quotes.Project.Application.Interfaces;
using Quotes.Project.Domain.Interfaces;
using Quotes.Project.Domain.Model;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Quotes.Project.Application.Services
{
    public class QuoteService : IQuoteService
    {
        private IQuoteRepository _quoteRepository;

        public QuoteService(IQuoteRepository quoteRepository)
        {
            _quoteRepository = quoteRepository;
        }

        public List<Quote> GetQuotes()
        {
            return _quoteRepository.GetQuotes().ToList();
        }

        public Quote GetQuoteById(int id)
        {
            return _quoteRepository.GetQuoteById(id).SingleOrDefault();
        }

        public Quote PostQuote(Quote quote)
        {
            return _quoteRepository.PostQuote(quote);
        }

        public HttpStatusCode UpdateQuote(Quote quote)
        {
            return _quoteRepository.UpdateQuote(quote);
        }

        public HttpStatusCode DeleteQuote(int id)
        {
            return _quoteRepository.DeleteQuote(id);
        }
    }
}
