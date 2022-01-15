# _Pierre's Sweet and Savory Treats_

#### By _**Matt Luker**_

#### _A webpage to keep track of flavors and treats at Pierre's Bakery_

## Technologies Used

* _C#_
* _.NET 5_
* _ASP.NET Core MVC_
* _dotnet script, REPL_
* _Razor View Engine_
* _MySQL and MySQL Workbench_
* _Git_
* _Pomelo Entity Framework for MySql_
* _Microsoft Entity Framework (Identity)_

## Description
_An application that lets users see all the flavors and treats at Pierre's Bakery and lets authorized users create, update, delete and read all treats and flavors_


## Setup/Installation Requirements

### Application Setup
* _Install .NET 5.0 [here](https://dotnet.microsoft.com/download/dotnet/5.0)_
* _In your web browser navigate to [https://github.com/jmlden36/Pierre.Solution.git](https://github.com/jmlden36/Pierre.Solution.git)
* _Click the green "Code" button and Download Zip _
* _Extract the contents of the zip file to a folder on your machine_
* _alternatively to [clone this repository](https://github.com/jmlden36/Pierre.Solution.git) from Git Hub please follow these next steps_
* Open the terminal on your desktop
* Once in the terminal, use it to navigate to your desktop folder
* Once inside your desktop folder, use the command `git clone https://github.com/jmlden36/Pierre.Solution.git`
* _Open Pierre.Solution in your code editor of choice(something like Visual Studio Code)_
* _Navigate to the Pierre Directory and type in your terminal `touch appsettings.json` and fill this new file with the following_
```
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=pierre;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
}
```
* _Replace `[YOUR-PASSWORD-HERE]` with your MySql Password.


### Database Setup

* _Download MySQL and MySQL Workbench to set up a local database_
* _Open MySQL Workbench and log into your server_
* _Once installed, create a database from the included migration files by navigating to the Pierre Directory and typing `dotnet ef database update` into the terminal_

### To Run Application

* _Navigate to Pierre production folder in terminal_

* _To download obj and bin files needed for the program to run, while still in Pierre folder type `dotnet restore` into the terminal_
* _To run the program, while still in the Pierre directory type `dotnet run` into the terminal_
#### Note: The server will not open automatically. The user will need to cmd+click on the live share link in terminal, or enter 'localhost:5000' URL into browser.


## Known Bugs

* _No known bugs_

* _If you have any issues or notice any bugs please email [jamesmattluker@gmail.com](mailto:jamesmattluker@gmail.com)._

## License

*[MIT](https://opensource.org/licenses/MIT) Licenced
*Copyright (c) _2021_ _Matt Luker_