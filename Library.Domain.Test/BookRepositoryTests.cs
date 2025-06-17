using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Domain.Model;
using Library.Domain.Services.InMemory;
using Xunit;

namespace Library.Domain.Tests
{
    public class BookRepositoryTests
    {
        /// <summary>
        /// Тест проверяет успешное получение книги по шифру в каталоге.
        /// </summary>
        /// <remarks>
        /// Этот тест проверяет, что метод <see cref="BookInMemoryRepository.GetByCatalogCode"/>
        /// возвращает книгу с указанным шифром в каталоге и что её название соответствует ожидаемому.
        /// </remarks>
        [Fact]
        public async Task GetBookByCatalogCode_Success()
        {
            var repo = new BookInMemoryRepository();
            var book = await repo.GetByCatalogCode("A123");

            Assert.NotNull(book);
            Assert.Equal("Основы SQL", book?.Title);
        }

        /// <summary>
        /// Тест проверяет успешное получение наличия книги в отделах.
        /// </summary>
        /// <remarks>
        /// Этот тест проверяет, что метод <see cref="BookInMemoryRepository.GetBookAvailability"/>
        /// возвращает непустой список отделов, в которых доступна книга с указанным инвентарным номером.
        /// </remarks>
        [Fact]
        public async Task GetBookAvailability_Success()
        {
            var repo = new BookInMemoryRepository();
            var availability = await repo.GetBookAvailability(1);

            Assert.NotNull(availability);
            Assert.True(availability.Count > 0);
        }

        /// <summary>
        /// Тест проверяет успешное получение количества книг по типу издания.
        /// </summary>
        /// <remarks>
        /// Этот тест проверяет, что метод <see cref="BookInMemoryRepository.GetBooksCountByPublicationType"/>
        /// возвращает непустой список с количеством книг для каждого типа издания.
        /// </remarks>
        [Fact]
        public async Task GetBooksCountByPublicationType_Success()
        {
            var repo = new BookInMemoryRepository();
            var counts = await repo.GetBooksCountByPublicationType();

            Assert.NotNull(counts);
            Assert.True(counts.Count > 0);
        }
    }
}
// Опять же, комменты стараюсь писать по одному шаблону, что бы глаза не сильно болели
// Могу добавить построчные пояснения, если необходимо
