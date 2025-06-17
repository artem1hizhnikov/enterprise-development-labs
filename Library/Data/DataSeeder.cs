using Library.Domain.Model;

namespace Library.Domain.Data;

public static class DataSeeder
{
    public static readonly List<Book> Books =
    [
        new() { InventoryNumber = 1, CatalogCode = "A001", Authors = "А.И Дозморов", Title = "История России", PublicationType = "Учебное пособие", PublicationPlace = "Екатеринбург", PublicationYear = 2018 },
        new() { InventoryNumber = 2, CatalogCode = "B002", Authors = "С.А. Лем", Title = "Сумма технологии", PublicationType = "Монография", PublicationPlace = "Москва", PublicationYear = 2020 },
        new() { InventoryNumber = 3, CatalogCode = "C003", Authors = "А.В. Ткаченко", Title = "Алгоритмы и структуры данных", PublicationType = "Учебное пособие", PublicationPlace = "Новосибирск", PublicationYear = 2021 },
        new() { InventoryNumber = 4, CatalogCode = "D004", Authors = "А.А. Андреев", Title = "Математический анализ", PublicationType = "Монография", PublicationPlace = "Екатеринбург", PublicationYear = 2018 },
        new() { InventoryNumber = 5, CatalogCode = "E005", Authors = "В.В. Васильев", Title = "Физика", PublicationType = "Учебное пособие", PublicationPlace = "Казань", PublicationYear = 2022 },
        new() { InventoryNumber = 6, CatalogCode = "F006", Authors = "Д.Д. Дмитриев", Title = "Химия", PublicationType = "Методические указания", PublicationPlace = "Ростов-на-Дону", PublicationYear = 2020 },
        new() { InventoryNumber = 7, CatalogCode = "G007", Authors = "Е.Е. Егоров", Title = "Биология", PublicationType = "Учебное пособие", PublicationPlace = "Владивосток", PublicationYear = 2021 }
    ];

    public static readonly List<Department> Departments =
    [
        new() { Id = 1, Name = "Отдел учебной литературы" },
        new() { Id = 2, Name = "Отдел научной литературы" },
        new() { Id = 3, Name = "Отдел художественной литературы" },
        new() { Id = 4, Name = "Отдел периодики" },
        new() { Id = 5, Name = "Отдел редких книг" },
        new() { Id = 6, Name = "Отдел электронных ресурсов" },
        new() { Id = 7, Name = "Отдел международной литературы" }
    ];

    public static readonly List<BookInDepartment> BooksInDepartments =
    [
        new() { Id = 1, InventoryNumber = 1, DepartmentId = 1, Quantity = 5 },
        new() { Id = 2, InventoryNumber = 2, DepartmentId = 2, Quantity = 3 },
        new() { Id = 3, InventoryNumber = 3, DepartmentId = 1, Quantity = 7 },
        new() { Id = 4, InventoryNumber = 4, DepartmentId = 3, Quantity = 2 },
        new() { Id = 5, InventoryNumber = 5, DepartmentId = 4, Quantity = 6 },
        new() { Id = 6, InventoryNumber = 6, DepartmentId = 5, Quantity = 4 },
        new() { Id = 7, InventoryNumber = 7, DepartmentId = 6, Quantity = 8 }
    ];

    public static readonly List<Reader> Readers =
    [
        new() { Id = 1, FullName = "Сидоров А.А.", Address = "ул. Ленина, 10", Phone = "123-456-789", RegistrationDate = new DateTime(2023, 1, 1) },
        new() { Id = 2, FullName = "Кузнецов Б.Б.", Address = "ул. Пушкина, 20", Phone = "987-654-321", RegistrationDate = new DateTime(2023, 2, 1) },
        new() { Id = 3, FullName = "Иванов В.В.", Address = "ул. Гагарина, 30", Phone = "111-222-333", RegistrationDate = new DateTime(2023, 3, 1) },
        new() { Id = 4, FullName = "Петров Г.Г.", Address = "ул. Чехова, 40", Phone = "444-555-666", RegistrationDate = new DateTime(2023, 4, 1) },
        new() { Id = 5, FullName = "Смирнов Д.Д.", Address = "ул. Толстого, 50", Phone = "777-888-999", RegistrationDate = new DateTime(2023, 5, 1) },
        new() { Id = 6, FullName = "Васильев Е.Е.", Address = "ул. Достоевского, 60", Phone = "000-111-222", RegistrationDate = new DateTime(2023, 6, 1) },
        new() { Id = 7, FullName = "Николаев Ж.Ж.", Address = "ул. Тургенева, 70", Phone = "333-444-555", RegistrationDate = new DateTime(2023, 7, 1) }
    ];

    public static readonly List<BookIssue> BookIssues =
    [
        new() { Id = 1, InventoryNumber = 1, ReaderId = 1, IssueDate = new DateTime(2023, 10, 1), DaysIssued = 14, ReturnDate = new DateTime(2023, 10, 15), Book = Books[0] },
        new() { Id = 2, InventoryNumber = 2, ReaderId = 2, IssueDate = new DateTime(2023, 10, 2), DaysIssued = 7, ReturnDate = new DateTime(2023, 10, 9), Book = Books[1] },
        new() { Id = 3, InventoryNumber = 3, ReaderId = 3, IssueDate = new DateTime(2023, 10, 3), DaysIssued = 10, ReturnDate = new DateTime(2023, 10, 13), Book = Books[2] },
        new() { Id = 4, InventoryNumber = 4, ReaderId = 4, IssueDate = new DateTime(2023, 10, 4), DaysIssued = 5, ReturnDate = new DateTime(2023, 10, 9), Book = Books[3] },
        new() { Id = 5, InventoryNumber = 5, ReaderId = 5, IssueDate = new DateTime(2023, 10, 5), DaysIssued = 21, ReturnDate = new DateTime(2023, 10, 26), Book = Books[4] },
        new() { Id = 6, InventoryNumber = 6, ReaderId = 6, IssueDate = new DateTime(2023, 10, 6), DaysIssued = 14, ReturnDate = new DateTime(2023, 10, 20), Book = Books[5] },
        new() { Id = 7, InventoryNumber = 7, ReaderId = 7, IssueDate = new DateTime(2023, 10, 7), DaysIssued = 30, ReturnDate = new DateTime(2023, 11, 6), Book = Books[6] }
    ];
}