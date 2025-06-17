using Library.Domain.Model;
using Library.Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Domain.Services.InMemory;

public class BookIssueInMemoryRepository : IBookIssueRepository
{
    private readonly List<BookIssue> _bookIssues;

    public BookIssueInMemoryRepository()
    {
        _bookIssues = DataSeeder.BookIssues;
    }

    public Task<IList<BookIssue>> GetAll()
    {
        return Task.FromResult<IList<BookIssue>>(_bookIssues);
    }

    public Task<BookIssue?> GetById(int id)
    {
        var bookIssue = _bookIssues.FirstOrDefault(bi => bi.Id == id);
        return Task.FromResult(bookIssue);
    }

    public Task<BookIssue> Add(BookIssue bookIssue)
    {
        _bookIssues.Add(bookIssue);
        return Task.FromResult(bookIssue);
    }

    public Task<BookIssue> Update(BookIssue bookIssue)
    {
        var existingBookIssue = _bookIssues.FirstOrDefault(bi => bi.Id == bookIssue.Id);
        if (existingBookIssue != null)
        {
            existingBookIssue.InventoryNumber = bookIssue.InventoryNumber;
            existingBookIssue.ReaderId = bookIssue.ReaderId;
            existingBookIssue.IssueDate = bookIssue.IssueDate;
            existingBookIssue.DaysIssued = bookIssue.DaysIssued;
            existingBookIssue.ReturnDate = bookIssue.ReturnDate;
        }
        return Task.FromResult(bookIssue);
    }

    public Task<bool> Delete(int id)
    {
        var bookIssue = _bookIssues.FirstOrDefault(bi => bi.Id == id);
        if (bookIssue != null)
        {
            _bookIssues.Remove(bookIssue);
            return Task.FromResult(true);
        }
        return Task.FromResult(false);
    }

    public Task<IList<BookIssue>> GetIssuedBooksOrderedByTitle()
    {
        var issuedBooks = _bookIssues
            .OrderBy(bi => bi.Book?.Title)
            .ToList();
        return Task.FromResult<IList<BookIssue>>(issuedBooks);
    }

    public Task<IList<Reader>> GetTop5ReadersByPeriod(DateTime startDate, DateTime endDate)
    {
        var topReaders = _bookIssues
            .Where(bi => bi.IssueDate >= startDate && bi.IssueDate <= endDate)
            .GroupBy(bi => bi.ReaderId)
            .OrderByDescending(g => g.Count())
            .Take(5)
            .Select(g => DataSeeder.Readers.FirstOrDefault(r => r.Id == g.Key))
            .Where(r => r != null)
            .Select(r => r!)
            .ToList();
        return Task.FromResult<IList<Reader>>(topReaders);
    }

    public Task<IList<Reader>> GetReadersWithDelayedBooks()
    {
        var readersWithDelays = _bookIssues
            .Where(bi => bi.ReturnDate == null || bi.ReturnDate > bi.IssueDate.AddDays(bi.DaysIssued))
            .Select(bi => DataSeeder.Readers.FirstOrDefault(r => r.Id == bi.ReaderId))
            .Where(r => r != null)
            .Select(r => r!)
            .OrderBy(r => r.FullName)
            .ToList();
        return Task.FromResult<IList<Reader>>(readersWithDelays);
    }
}