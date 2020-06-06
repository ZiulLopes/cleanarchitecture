using Quotes.Project.Domain.Interfaces;
using Quotes.Project.Domain.Model;
using Quotes.Project.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Quotes.Project.Infrastructure.Data.Repositories
{
    public class QuoteRepository : IQuoteRepository
    {
        private QuotesDbContext _dbContext;

        public QuoteRepository(QuotesDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IQueryable<Quote> GetQuoteById(int id)
        {
            var quote = from q in _dbContext.Quote where q.Id == id select q;
            return quote;
        }

        public IEnumerable<Quote> GetQuotes()
        {
            return _dbContext.Quote;
        }

        public Quote PostQuote(Quote quote)
        {
            _dbContext.Quote.Add(quote);
            _dbContext.SaveChanges();
            return quote;
        }

        public HttpStatusCode UpdateQuote(Quote quote)
        {
            var quoteInDb = _dbContext.Quote.Find(quote.Id);

            if (quoteInDb == null)
                return HttpStatusCode.NotFound;

            quoteInDb.Title = quote.Title;
            quoteInDb.Author = quote.Author;
            quoteInDb.Description = quote.Description;
            quoteInDb.CreatedAt = quote.CreatedAt;
            _dbContext.SaveChanges();

            return HttpStatusCode.OK;
        }
        public HttpStatusCode DeleteQuote(int id)
        {
            var quoteInDb = _dbContext.Quote.Find(id);

            if (quoteInDb == null)
                return HttpStatusCode.NotFound;

            _dbContext.Quote.Remove(quoteInDb);
            _dbContext.SaveChanges();

            return HttpStatusCode.OK;
        }

    }
}
