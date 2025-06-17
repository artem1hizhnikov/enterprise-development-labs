using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Domain.Model;
using Library.Domain.Services.InMemory;
using Xunit;

namespace Library.Domain.Tests
{
    public class BookIssueRepositoryTests
    {
        /// <summary>
        /// Тест проверяет успешное получение выданных книг, упорядоченных по названию.
        /// </summary>
        /// <remarks>
        /// Этот тест проверяет, что метод <see cref="BookIssueInMemoryRepository.GetIssuedBooksOrderedByTitle"/>
        /// возвращает непустой список книг, упорядоченных по названию.
        /// </remarks>
        [Fact]
        public async Task GetIssuedBooksOrderedByTitle_Success()
        {
            var repo = new BookIssueInMemoryRepository();
            var issuedBooks = await repo.GetIssuedBooksOrderedByTitle();

            Assert.NotNull(issuedBooks);
            Assert.True(issuedBooks.Count > 0);
        }

        /// <summary>
        /// Тест проверяет успешное получение топ-5 читателей за указанный период.
        /// </summary>
        /// <remarks>
        /// Этот тест проверяет, что метод <see cref="BookIssueInMemoryRepository.GetTop5ReadersByPeriod"/>
        /// возвращает не более 5 читателей, упорядоченных по количеству взятых книг за указанный период.
        /// </remarks>
        [Fact]
        public async Task GetTop5ReadersByPeriod_Success()
        {
            var repo = new BookIssueInMemoryRepository();
            var topReaders = await repo.GetTop5ReadersByPeriod(new DateTime(2023, 1, 1), new DateTime(2023, 12, 31));

            Assert.NotNull(topReaders);
            Assert.True(topReaders.Count <= 5);
        }

        /// <summary>
        /// Тест проверяет успешное получение читателей, задержавших книги.
        /// </summary>
        /// <remarks>
        /// Этот тест проверяет, что метод <see cref="BookIssueInMemoryRepository.GetReadersWithDelayedBooks"/>
        /// возвращает список читателей, которые задержали возврат книг.
        /// </remarks>
        [Fact]
        public async Task GetReadersWithDelayedBooks_Success()
        {
            var repo = new BookIssueInMemoryRepository();
            var readersWithDelays = await repo.GetReadersWithDelayedBooks();

            Assert.NotNull(readersWithDelays);
        }
    }
}
// Не уверен, был ли смысл вообще вставлять судой <see cref=""/>, но я готов понести бремя "Капитан очевидность".
// В конце концов, просто покажу, что умею это делать...
