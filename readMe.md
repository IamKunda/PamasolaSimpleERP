Pamasola ERP Solution
Overview
The Pamasola ERP Solution is a comprehensive Enterprise Resource Planning (ERP) system developed for Pamasola Resources, a Solar and Power Storage Consultancy company. The system aims to streamline operations, manage inventory, customer relations, projects, and finances, while supporting the company's growth and sustainability objectives.

Features
Customer Relationship Management (CRM): Manage clients, track interactions, and handle leads.
Inventory Management: Efficient tracking of solar panels, power storage products, and related equipment.
Project Management: Organize and monitor consultancy projects and solar installations.
Financial Management: Manage invoices, payments, and generate financial reports.
Employee Management: Monitor employee data, attendance, and project assignments.
Reporting & Analytics: Generate insights and reports for improved decision-making.
Technologies Used
ASP.NET MVC: Used for both backend and frontend web application development, offering a robust framework for building scalable and maintainable applications.
SQL Server: Acts as the database for storing all ERP data, including customer records, inventory, projects, and transactions.
Azure: The solution is deployed and hosted on Microsoft Azure, leveraging Azure App Services for scalability, reliability, and high availability.
Setup Instructions
Follow these steps to set up the ERP solution on your local machine:

Prerequisites
.NET SDK (version 6.0 or later)
SQL Server
An Azure account for hosting (optional if hosting locally)
Installation
Clone the Repository:

bash
Copy code
git clone https://github.com/IamKunda/PamasolaSimpleERP
cd PamasolaSimpleERP
App Setup (ASP.NET MVC):
bash
Copy code
dotnet restore
Update the database connection string in appsettings.json to point to your local SQL Server instance.
Apply database migrations:
bash
Copy code
dotnet ef database update
Run the application:
bash
Copy code
dotnet run
Database Setup (SQL Server):

Ensure SQL Server is running.
Update your appsettings.json file to reflect your local SQL Server connection string.
Create the required tables by running the migrations.
Deployment (Azure):

Set up an Azure App Service.
Publish the project to Azure from Visual Studio or using the Azure CLI:
bash
Copy code
dotnet publish --configuration Release
az webapp up --name PamasolaSimpleERP --resource-group MyResourceGroup --plan MyPlan
Security
Authentication: Secure authentication using OAuth2 or JWT (depending on the client’s requirements).
Data Encryption: SSL/TLS is enforced on the hosted platform to secure communication.
Access Control: Role-based access to ensure only authorized personnel can access sensitive information.
Sustainability Practices
The application is hosted on Azure, a platform with a commitment to 100% renewable energy.
Efficient coding practices are used to minimize resource consumption.
Database queries and transactions are optimized to reduce processing overhead.
Future Enhancements
Mobile Application Support: Add a mobile interface for managing operations on the go.
API Integrations: Integrate with third-party services for solar monitoring and remote system control.
Machine Learning Integration: Analyze data for predictive maintenance and efficiency optimizations.
License
This project is licensed under the MIT License.

By following the instructions above, you can set up the Pamasola ERP Solution locally or on Azure, ensuring a scalable and secure solution for your consultancy needs.
