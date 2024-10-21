# GameZone Web Application

**GameZone** is a simple CRUD (Create, Read, Update, Delete) operations web application built using ASP.NET Core MVC. This application allows users to manage a game collection, categorize games into different categories, and associate games with multiple devices.

## Features

- **Manage Games**: Add, Edit, Delete, and View games.
- **Categorize Games**: Games can be categorized into different categories such as **Sports**, **Action**, **Adventure**, etc.
- **Associate Devices**: Games can be related to different devices such as **PlayStation**, **Xbox**, **Nintendo Switch**, and **PC**.
- **Many-to-Many Relationship**: Supports a many-to-many relationship between games and devices (Game-Device).

## Technologies Used

- **ASP.NET Core MVC** - The web framework used for building the application.
- **Entity Framework Core** - ORM (Object-Relational Mapping) tool to interact with SQL Server.
- **SQL Server** - The database used to store game, category, and device data.
- **Bootstrap** - A front-end framework used for styling and layout.
- **SweetAlert2** - A library used for custom alert popups to improve UX.
- **Font Awesome** - A font and icon toolkit used for adding icons in the application.

## How to Run the Project

1. Clone the repository:
   ```bash
   git clone https://github.com/AbdallahElshenawy/GameZone.git
2. Set up the database
    Update-Database
3. Run the application
    dotnet run

