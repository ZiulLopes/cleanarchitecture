using Quotes.Project.Domain.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Quotes.Project.Application.Interfaces
{
    public interface IQuoteService
    {
        List<Quote> GetQuotes();
        Quote GetQuoteById(int id);
        Quote PostQuote(Quote quote);
        HttpStatusCode UpdateQuote(Quote quote);
        HttpStatusCode DeleteQuote(int id);
    }
}
