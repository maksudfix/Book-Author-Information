# Book & Author Information System

A simple C# Console Application that manages books and authors using LINQ Method Syntax. The program joins books with their authors, filters books by publication year, sorts the results, and displays selected book information.

## Features

* Store multiple book records
* Store multiple author records
* Join books and authors using `AuthorId`
* Filter books published after the year 700
* Display book title, author name, and publication year
* Sort books by publication year
* Sort books alphabetically by title when years are the same
* Select only required information using `Select`
* Use console colors for presentation


## LINQ Concepts Used

* Where — Filters books published after year 700.
* Join — Connects books and authors using `AuthorId`.
* OrderBy — Sorts books by publication year.
* ThenBy — Sorts books alphabetically by title.
* Select — Projects only the required book information.
* ToList — Converts the query result into a list.

## Query Flow

Books
  ↓
Where(PublishedYear > 700)
  ↓
Join with Authors
  ↓
OrderBy(PublishedYear)
  ↓
ThenBy(BookTitle)
  ↓
Select(BookTitle, AuthorName, PublishedYear)
  ↓
ToList()
  ↓
Display Results

## Technologies

**C# • .NET Console Application • LINQ Method Syntax • Classes • Objects • List<T> • Join • Where • OrderBy • ThenBy • Select • DateTime • Console I/O**
