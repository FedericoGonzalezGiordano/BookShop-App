# <span style="font-size:36pt; color:#008080;">Alphabet Bookshop Management System</span>

## <span style="font-size:24pt; color:#800080;">Overview</span>

The **Alphabet Bookshop Management System** is a C# application developed using .NET Core and WinForms. This system facilitates the efficient management of a bookshop by allowing users to create and manage invoices for clients. It includes features for customer management, invoice creation, and persistence using ADO.NET with SQL Server. Additionally, it provides a RESTful API for external integration. The application follows design patterns such as Singleton, Factory, and DAO (Data Access Object) for improved code organization and maintainability.

## <span style="font-size:20pt; color:#800080;">Features</span>

- **Customer Management:** Easily add, edit, and delete customer information.
- **Invoice Generation:** Create invoices with details such as items, quantities, prices, and due dates.
- **Persistence:** Store customer and invoice data in a SQL Server database for long-term retrieval.
- **RESTful API:** Expose endpoints for external applications to interact with the system programmatically.
- **Design Patterns:** Utilize design patterns such as Singleton, Factory, and DAO for improved code organization and maintainability.

## <span style="font-size:20pt; color:#800080;">Technologies Used</span>

- **C#:** The primary programming language for the application.
- **.NET Core:** The framework providing cross-platform support.
- **WinForms:** The UI framework for creating the graphical user interface.
- **ADO.NET:** Used for data access to connect and interact with the SQL Server database.
- **SQL Server:** The relational database management system for storing customer and invoice data.
- **REST API:** Implement API functionality using .NET Core's Web API.
- **Design Patterns:**
  - **Singleton:** Ensure a class has only one instance and provides a global point to this instance.
  - **Factory:** Define an interface for creating an object, but leave the choice of its type to the subclasses.
  - **DAO (Data Access Object):** Provide an abstract interface to some type of database or other persistence mechanism.

## <span style="font-size:20pt; color:#800080;">Getting Started</span>

1. **Clone the repository:**
   git clone https://github.com/FedericoGonzalezGiordano/BookShop-App.git


# Configure the Database:
1. Create a new database in SQL Server.
2. Update the connection string in `HelperDao` with your database details.
3. Build and Run the Application.

# Usage:
- Launch the application and navigate through the user-friendly interface.
- Manage customers, create invoices, and persist data to the connected SQL Server database.
- Utilize the REST API for programmatic access to the system.

# Contributing:
Contributions are welcome! If you find any issues or have suggestions for improvement, please open an issue or create a pull request.

# License:
This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

---

# MIT License

Copyright (c) [Year] [Author]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
