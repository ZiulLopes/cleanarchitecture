using Quotes.Project.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Quotes.Project.Domain.Interfaces
{
    public interface IQuoteRepository
    {
        IEnumerable<Quote> GetQuotes();
        IQueryable<Quote> GetQuoteById(int id);
        Quote PostQuote(Quote quote);
        HttpStatusCode UpdateQuote(Quote quote);
        HttpStatusCode DeleteQuote(int id);
    }
}
