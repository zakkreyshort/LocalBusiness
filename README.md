# Local Business Search Interface+Api
### By **Zakkrey Short**  3 April 2020

Application that uses an API and interface to run a local business rating app. User can add types of business, then places to list within the type with a short description.

## Specifications 

### user stories:

* As a user, I want to be able to GET all category.
* As a user, I want to be able to GET all places related to category.
* As a user, I want to be able to POST category.
* As a user, I want to be able to POST places to category.
* As a user, I want to be able to see a list of all categories.
* As a user, I want to be able to POST a review.

### API Endpoints
#### To view API endpoints for personal use, visit http://localhost:5000/swagger/index.html#/Places when servers are running on the API side.

CATEGORY
```
GET /api/categories
POST /api/categories
GET /api/categories/{categoryId}
PUT /api/categories/{categoryId}
DELETE /api/categories/{categoryId}
```

PLACES
```
GET /api/categories/{categoryId}/places
POST /api/categories/{categoryId}/places
GET /api​/categories​/{categoryId}​/places​/{id}
PUT /api​/categories​/{categoryId}​/places​/{id}
DELETE /api/categories/{categoryId}/places/{id}
```

COMMENTS (Reviews)
```
GET /api/categories/{categoryId}/places/{placeId}/Comments
POST /api/categories/{categoryId}/places/{placeId}/Comments
GET /api/categories/{categoryId}/places/{placeId}/Comments/{id}
PUT /api/categories/{categoryId}/places/{placeId}/Comments/{id}
```


## Getting Started

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._


### Prerequisites

1. [.NET Framework](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) 
2. Text Editor (Visual Studio Code)

### Installing

1. Clone the repository:
    ```
    git clone https://github.com/zakkreyshort/LocalBusiness
    ```

2. Move to directory:
    ```
    cd LocalBusiness
    cd LocalBusinessApi
    ```

3. Restore all dependencies:
    ```
    dotnet restore
    ```

### Open program

4. Compile and Run code:
    ```
    dotnet build
    dotnet run
    ```

5. Repeat steps 2-4 to operate interface by:
    ```
    cd ..
    cd LocalBusinessInterface
    ```

6. View webpage in browser using
    ```
    http://localhost:5010
    ```

7. Enjoy!

_To view/edit the source code of this application, open the contents of this directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._


## Technologies Used

* _Git_
* _VSCode_
* _C#_
* _HTML_
* _Razor_
* _.NET Core 2.2_
* _ASP.NET Core MVC 2.2_
* _dotnet script_
* _MySQL_
* _MySQL Workbench_
* _Entity Framework Core 2.2_
* _RestSharp API_
* _Newtonsoft.Json_


## Known Bugs
Currently there's no known bugs. Working to add reviews as comments to each place.

## Contact Info 
If there are any issues running this website I would love feedback! Please email me at 
* zakkreyjshort@gmail.com


## License

Licensed under the MIT license.

## 2020  Zakkrey Short.