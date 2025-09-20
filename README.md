# User Info MVC Project

## Table of Contents
- [Project Overview](#project-overview)
- [Technology Stack](#technology-stack)
- [Project Structure](#project-structure)
- [Installation and Setup](#installation-and-setup)
- [Features](#features)
- [Model Implementation](#model-implementation)
- [Controller Implementation](#controller-implementation)
- [View Implementation](#view-implementation)
- [Styling and Design](#styling-and-design)
- [Running the Application](#running-the-application)
- [Disclaimer](#disclaimer)

## Project Overview

User Info MVC is a simple ASP.NET Core web application that 
demonstrates the Model-View-Controller (MVC) architectural 
pattern. The application displays user information including 
name and surname through a clean, minimalist interface. The 
project serves as an educational example of MVC implementation 
in .NET Core with proper separation of concerns.

## Technology Stack

- ASP.NET Core 6.0
- MVC (Model-View-Controller) Architecture
- Bootstrap 5.0
- JavaScript (for dynamic year updating)
- CSS3 with modern design principles
- C# 10.0

## Project Structure

```
user-info-mvc/
├── Controllers/
│   └── HomeController.cs
├── Models/
│   ├── ErrorViewModel.cs
│   └── Details.cs
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml
│   │   └── Privacy.cshtml
│   ├── Shared/
│   │   ├── _Layout.cshtml
│   │   ├── _Layout.cshtml.css
│   │   ├── _ValidationScriptsPartial.cshtml
│   │   └── Error.cshtml
│   ├── _ViewImports.cshtml
│   └── _ViewStart.cshtml
├── wwwroot/
│   ├── css/
│   │   └── site.css
│   ├── js/
│   │   └── site.js
│   ├── lib/
│   └── favicon.ico
├── appsettings.json
└── Program.cs
```

## Installation and Setup

1. Clone the repository:
   ```
   git clone https://github.com/HChristopherNaoyuki/user-info-mvc.git
   cd user-info-mvc
   ```

2. Ensure you have .NET 6.0 SDK or later installed

3. Restore NuGet packages:
   ```
   dotnet restore
   ```

4. Build the project:
   ```
   dotnet build
   ```

## Features

- Display of user information (name and surname)
- Minimalist and responsive user interface
- Automatic copyright year updating
- Privacy policy page
- Error handling with custom error page
- Clean separation of concerns following MVC pattern

## Model Implementation

The `Details` model class located in `Models/Details.cs` contains:

- Two properties: `Name` and `Surname` with getters and setters
- A default constructor that initializes with placeholder values
- A parameterized constructor for custom initialization

The model follows proper encapsulation principles and serves as 
the data structure for user information.

## Controller Implementation

The `HomeController` in `Controllers/HomeController.cs` handles:

- Index action that creates an instance of the `Details` model
- Privacy action for the privacy policy page
- Error action for handling application errors
- Proper dependency injection through constructor injection

The controller acts as the intermediary between the model and 
view, ensuring clean separation of concerns.

## View Implementation

The main view `Views/Home/Index.cshtml` features:

- Strongly typed model declaration
- Display of user information using model properties
- Clean HTML structure integrated with the layout
- Responsive design elements

The layout system uses `_Layout.cshtml` as the master template, 
providing consistent styling across all pages.

## Styling and Design

The application features a minimalist design with:

- Clean typography using Inter font family
- Subtle gradient background
- Semi-transparent header and footer with backdrop blur effects
- Responsive design that works on mobile and desktop devices
- Smooth transitions and hover effects
- Accessibility considerations with proper focus states

The styling is implemented through a combination of `_Layout.cshtml.css` and `wwwroot/css/site.css`.

## Running the Application

1. Navigate to the project directory

2. Run the application:
   ```
   dotnet run
   ```

3. Open your web browser and navigate to:
   ```
   https://localhost:7000
   ```

4. The application will display the home page with user information

## Disclaimer

This project is intended for educational purposes and 
demonstrates basic MVC implementation in ASP.NET Core. 
The user data displayed is placeholder information and 
should be replaced with actual data in production 
environments. The design and code structure follow best 
practices for small-scale MVC applications but may require 
additional considerations for enterprise-level applications.
