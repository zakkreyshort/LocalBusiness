# Local Business Search Interface+Api
### By **Zakkrey Short**  3 April 2020

Repo holding ASP.NET core MVC application to display views that interact with the LocalBusinessInterface application and the Api.

## Specifications 

### user stories:

* As a user, I want to be able to GET all category.
* As a user, I want to be able to GET all posts related to category.
* As a user, I want to be able to POST category.
* As a user, I want to be able to POST posts to category.
* As a user, I want to be able to see a list of all categories.
* As a user, I want to input date parameters and retrieve only reviews posted during that timeframe.
* As a user, I want to be able to PUT and DELETE reviews, but only if I wrote them. (Start by requiring a user_name param to match the user_name of the author on the message. You can always try authentication later.)

### API Endpoints

CATEGORY
```
GET /api/categories
POST /api/categories
GET /api/categories/{categoryId}
PUT /api/categories/{categoryId}
DELETE /api/categories/{categoryId}
```

POSTS
```
GET /api/categories/{categoryId}/places
POST /api/categories/{categoryId}/places
GET /api​/categories​/{categoryId}​/places​/{id}
PUT /api​/categories​/{categoryId}​/places​/{id}
DELETE /api/categories/{categoryId}/places/{id}
PATCH /api​/categories​/{categoryId}​/places​/{id}​/upvote
PATCH /api/categories/{categoryId}/places/{id}/downvote
```

COMMENTS 
```
GET /api/categories/{categoryId}/places/{placeId}/Comments
POST /api/categories/{categoryId}/places/{placeId}/Comments
GET /api/categories/{categoryId}/places/{placeId}/Comments/{id}
PUT /api/categories/{categoryId}/places/{placeId}/Comments/{id}
DELETE /api/categories/{categoryId}/places/{placeId}/Comments/{id}
```


## Getting Started

Download the .zip file and extract all files into directory of your choice OR clone the repository to a directory. Open project directory in preferred text editor.

### Prerequisites

1. [.NET Framework](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) 
2. Text Editor (Visual Studio Code)

### Installing

1. Clone the repository:
    ```
    git clone https://github.com/zakkreyshort/LocalBusiness
    ```

2. Restore all dependencies:
    ```
    dotnet restore
    ```

### Open program

3. Compile and Run code:
    ```
    dotnet build
    dotnet run
    ```



## Technologies Used

* C#
* ASP.NET core MVC 2.2
* RestSharp API
* Newtonsoft.Json
* Git


## Known Bugs
Currently there's no known bugs.

## Contact Info 
Currently there's no known bugs, however, if there are any issues running this website I would love feedback! Please email me at 
* zakkreyjshort@gmail.com


## License

Licensed under the MIT license.

## 2020  Zakkrey Short.