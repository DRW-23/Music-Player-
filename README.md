Music Player App – README
Welcome to the Music Player App! This is a C# desktop application built with Visual Studio and Microsoft SQL Server for user authentication and music playback. Follow the instructions below to set up and run the project on your local machine.

Features
User Registration and Login (with SQL Server authentication)

Music playback functionality

Simple and intuitive interface

Prerequisites
Visual Studio (any stable version)

Microsoft SQL Server Management Studio (SSMS)

.NET Framework (as required by the project)

Setup Instructions
1. Download the Project
Download the ZIP file from the GitHub repository.

Extract the ZIP file to your preferred location.

2. Set Up the Database
Locate the loginapp.sql file in the extracted folder.

Open loginapp.sql using Microsoft SQL Server Management Studio.

Execute the entire script. This will create the necessary database and tables for storing usernames and passwords.

3. Open the Project in Visual Studio
Open the login.sln file in Visual Studio.

4. Configure the Database Connection
In Visual Studio, go to Server Explorer.

Under the Data Connections tab, right-click and select Add Connection.

In the Add Connection dialog:

Set the Server Name to your SQL Server instance (e.g., DESKTOP-TJLBV3V\SQLEXPRESS).

Tip: Your server name may differ; check your SQL Server Management Studio for the correct name.

Tick Trust Server Certificate.

Click OK.

Once added, expand the Data Connections tab, right-click your new connection, and select Properties.

Copy the Connection String from the properties window.

5. Update the Connection String in Code
Open LoginController.cs and Registration.cs files in the project.

Replace the existing connection string in both files with your copied connection string.

In the connection string, ensure "Trust Server Certificate" is formatted as "TrustServerCertificate" (no spaces).

6. Run the Application
Build and run the project from Visual Studio.

First, sign up for a new account.

Then, log in with your new credentials.

Enjoy using the Music Player!

Notes
You must sign up before you can log in and use the music features.

Ensure SQL Server and Visual Studio are properly installed and configured on your system.

Troubleshooting
If you encounter connection issues, double-check your SQL Server instance name and ensure the server is running.

Make sure your connection string is correctly formatted and pasted in both files.

License
This project is open-source and free to use.

Enjoy your music! If you have any issues, feel free to open an issue on the GitHub repository.
