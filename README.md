# Author & Book Management System
A simple C# Console Application that manages book and author information using LINQ Method Syntax.
This code how to filter, join, sort, and project data from multiple collections using LINQ. It connects books with their authors through AuthorId and displays the book title, author name, and published year in an organized format.

# Features
- Store multiple book records
- Store multiple author records
- Join Books and Authors using AuthorId
- Filter books based on publication year
- Display only the published year
- Sort books by published year
- Sort books alphabetically by title
- Select only required information for output
- Use console text colors for better presentation
- Display book and author information in the console

Code Structure
│
├── Books
│   ├── BookId
│   ├── Title
│   ├── AuthorId
│   ├── Genre
│   ├── PublishedYear
│   └── Books()
│
├── Author
│   ├── AuthorId
│   ├── Name
│   ├── Country
│   └── Author()
│
└── AuthorBook
    └── Main()
        │
        └── LINQ Method Syntax
            ├── Where()
            ├── Join()
            ├── OrderBy()
            ├── ThenBy()
            ├── Select()
            └── ToList()  
