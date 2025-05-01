Music Player App

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
