# UPI Payment System
## Overview
A simple UPI Payment System built with ASP.NET Core, Angular, and MongoDB.

## Features
- User registration and authentication
- Secure UPI transaction processing
- View transaction history
- Retrieve transaction details by ID
### Prerequisites
1) [.NET SDK](https://dotnet.microsoft.com/download) (6.0 or higher)
2) [Node.js](https://nodejs.org/en/download/) (for Angular)
3) [MongoDB](https://www.mongodb.com/try/download/community) (for database)
### Steps to Setup
1. Navigate to the backend project directory: UPIPaymentSystem
2. Restore the .NET dependencies: dotnet restore
3. Configure your MongoDB connection string in the `appsettings.json` file.
4. Run the backend server: dotnet run
5. Open a new terminal, navigate to the frontend project directory: cd UPIPaymentSystem/Frontend
 6. Install the Angular dependencies: npm install
 7. Start the Angular application: ng serve
 8. Open your browser and go to `http://localhost:4200` to access the application.
##Usage
1) Register a User: Use the registration form to create a new user.
2) Make a Payment: Navigate to the payment section to initiate a UPI transaction.
3) View Transactions: Check transaction history and details by user ID or transaction ID.
### Backend Setup
1. Clone the repository.
2. Navigate to the backend directory.
3. Run `dotnet restore` to restore dependencies.
4. Update the `appsettings.json` with your MongoDB connection string.
5. Run `dotnet run` to start the backend server.
### Backend Tests
1. Navigate to the test project directory: cd UPIPaymentSystem/test
2. Creation of Folders for Backend
Controllers: UPIController.cs () & UserController ()
 Models: Transaction.cs & User.cs
 Services (Business Logic): TransactionServices.cs & UserServices.cs
 Data (MongoDB Context): UPIDatabaseContext.cs
 Authentication (JWT Configuration: appsettings.Development json
 Tests (xUnit/NUnit): TransactionServicesTests.cs & UserServicesTests.cs
3. Add the MongoDB.Driver NuGet package to your project.
4. Configure the connection string in appsettings.json:
5. Run the tests using the .NET CLI: dotnet test

### Frontend Setup
1. Navigate to the frontend directory.
2. Run `npm install` to install dependencies.
3. Run `ng serve` to start the Angular application.

### Frontend Tests
•	Create & Navigate to the frontend directory: cd UPIPaymentSystem/Frontend
•	C:\Users\sunil>node –v : v20.18.0
o	C:\Users\sunil>npm –v: 10.8.2
o	Run the Angular unit tests: ng test & ng serve



### API Documentation
Visit `/swagger` for API documentation.

### Testing
- For backend: Run `dotnet test`.
- For frontend: Run `ng test`.
