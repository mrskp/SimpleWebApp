# Introduction

**SimpleWebApp** is a simple .NET 8 web application designed to demonstrate a basic user authentication system. It allows users to:

Log in to their account.
Register a new account with an auto-generated account number.
View account status, including Dynamics Credits.
Add Dynamics Credits to their account.
Log out.

## Features
- Login Page: Secure login using username and password.
- Registration: Create a new account with a unique account number.
- Account Status Page: View username, account number, and current Dynamics Credits.
- Credit Management: Add Dynamics Credits for the logged-in account.
- Session Management: Logged-in users remain authenticated during their session.
- Logout Functionality: Clear user session and log out securely.

## Technologies Used
- Frontend: Razor Pages (MVC), HTML, CSS
- Backend: ASP.NET Core 8 MVC
- Database: In-Memory Database (using Microsoft.EntityFrameworkCore.InMemory)
- Session Management: ASP.NET Core Session Middleware

## Steps to Run the Application
1. Clone the repository:
  git clone <repository-url>
  cd SimpleWebApp
2. Open the solution file (SimpleWebApp.sln) in Visual Studio.
3. Build the solution to restore NuGet dependencies.
4. Run the application:
  In Visual Studio, press F5 or Ctrl + F5.
5. Open a browser and navigate to:
  https://localhost:5001

## Usage
1. **Register an Account**:
 - Navigate to the "Register" page.
 - Enter a username and password.
 - Click "Register". An account number will be automatically generated.
2. **Log In**:
 - Navigate to the "Login" page.
 - Enter your registered username and password.
 - Click "Login".
3. **Account Status**:
 - After logging in, view your account details on the "Account Status" page.
 - Add Dynamics Credits by clicking the "Add Dynamics Credit" button.
4. **Log Out**:
 - Click "Logout" to end the session.
