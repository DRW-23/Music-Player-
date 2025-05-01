Music Application in C# with Microsoft SQL Server

This repository contains a music application developed using C# and Microsoft SQL Server. The application provides a user-friendly interface for playing and managing music, leveraging a robust backend for data storage and retrieval.

Features

Play, pause, stop, and skip music tracks
play any songs in your local desktop


Technologies Used

C# (.NET Framework or .NET Core)

Microsoft SQL Server for backend database

Visual Studio for development

---How to Run---

To run this application you have to open the login.sln C# file. You can find this file inside the login file.
In case you want to open Model, View, Controller files , those are also inside the login file.

After open the login.sln file through Visual Studio , you can run the program.

First should have Microsoft SQL server management studio.
Then you should open loginapp.sql file in SSMS. 
After that, Execute to run the script and recreate the database/tables on the new server.

Then Update the connection String,
Change the connection string in your app to point to the local SQL Server instance on the new desktop.
Your connection string should like this,
you should update connection string on Registration.cs and LoginController.cs file.

Data Source=DESKTOP-TJLBV3V\\SQLEXPRESS;Initial Catalog=loginapp;Integrated Security=True"

After all this work done then you can run the code and enjoy some music!
