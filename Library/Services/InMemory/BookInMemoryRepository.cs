using Library.Domain.Model;
using Library.Domain.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Domain.Services.InMemory;

public class BookInMemoryRepository : IBookRepository
{
    private readonly List<Book> _books;

    public BookInMemoryRepository()
    {
        _books = DataSeeder.Books;
    }

    public Task<IList<Book>> GetAll()
    {
        return Task.FromResult<IList<Book>>(_books);
    }

    public Task<Book?> GetByInventoryNumber(int inventoryNumber)
    {
        var book = _books.FirstOrDefault(b => b.InventoryNumber == inventoryNumber);
        return Task.FromResult(book);
    }

    public Task<Book?> GetByCatalogCode(string catalogCode)
    {
        var book = _books.FirstOrDefault(b => b.CatalogCode == catalogCode);
        return Task.FromResult(book);
    }

    public Task<Book> Add(Book book)
    {
        _books.Add(book);
        return Task.FromResult(book);
    }

    public Task<Book> Update(Book book)
    {
        var existingBook = _books.FirstOrDefault(b => b.InventoryNumber == book.InventoryNumber);
        if (existingBook != null)
        {
            existingBook.CatalogCode = book.CatalogCode;
            existingBook.Authors = book.Authors;
            existingBook.Title = book.Title;
            existingBook.PublicationType = book.PublicationType;
            existingBook.PublicationPlace = book.PublicationPlace;
            existingBook.PublicationYear = book.PublicationYear;
        }
        return Task.FromResult(book);
    }

    public Task<bool> Delete(int inventoryNumber)
    {
        var book = _books.FirstOrDefault(b => b.InventoryNumber == inventoryNumber);
        if (book != null)
        {
            _books.Remove(book);
            return Task.FromResult(true);
        }
        return Task.FromResult(false);
    }

    public Task<IList<BookInDepartment>> GetBookAvailability(int inventoryNumber)
    {
        var availability = DataSeeder.BooksInDepartments
            .Where(bd => bd.InventoryNumber == inventoryNumber)
            .ToList();
        return Task.FromResult<IList<BookInDepartment>>(availability);
    }

    public Task<IList<(string PublicationType, int Quantity)>> GetBooksCountByPublicationType()
    {
        var counts = DataSeeder.BooksInDepartments
            .Join(DataSeeder.Books,
                bd => bd.InventoryNumber,
                b => b.InventoryNumber,
                (bd, b) => new { b.PublicationType, bd.Quantity })
            .GroupBy(x => x.PublicationType)
            .Select(g => (PublicationType: g.Key, Quantity: g.Sum(x => x.Quantity)))
            .ToList();
        return Task.FromResult<IList<(string, int)>>(counts);
    }
}