# _Travel API_

#### _C# ASP.NET MCV Project for Epicodus, October 27th, 2020_

#### By _**Natalie Murphy Joseph Nilles Michael Watts**_

## Description

Build an API that allows users to GET and POST reviews about various travel destinations around the world. Here are some user stories to get started. Note that you will have to create custom endpoints for some of these user stories.

User Should:

- GET and POST reviews about travel destinations.

- GET reviews by country or city.
- see the most popular travel destinations by number of reviews or by overall rating.
- PUT and DELETE reviews, but only if USER wrote them.
  (Start by requiring a user_name param to match the user_name of the author on the message. You can always try authentication later.)
- look up random destinations just for fun.

## API DOCUMENTATION

For Docmuentation, run and visit:

- http://localhost:5003/swagger/index.html

See all places

- http://localhost:5003/api/Places

- See the places that rate above number entered: (this case is for above 5)
- http://localhost:5003/api/Places/best?rating=5

- Random
- http://localhost:5003/api/places/random

- Best Cities (ranking order)
- http://localhost:5003/api/places/bestcity

## Setup/Installation Requirements

- Download option

  - Download files from GitHub repository by click Code and Download Zip
  - Extract files into a single directory
  - Run GitBASH in directory
  - Type "dotnet restore" to get bin and obj files
  - Type "dotnet run" in GitBash to run the program
  - Have fun with Places Been! <!-- TITLE HERE -->

- Cloning options
  - For cloning please use the following GitHub [tutorial](https://docs.github.com/en/enterprise/2.16/user/github/creating-cloning-and-archiving-repositories/cloning-a-repository)
  - Place files into a single directory
  - Run GitBASH in directory
  - Type "dotnet restore" to get bin and obj files
  - Type "dotnet run" in GitBash to run the program
  - Have fun with Places Been! <!-- TITLE HERE -->

## API ACCESS

open Postman

- post: http://localhost:5003/users/authenticate
- select Body
- slelect 'raw'
  enter:

```
{
"Username" : "test",
"Password" : "test"
}
```

- send get token

go to:

- get: http://localhost:5003/api/places
- select authorization
- change type to Bearer Token
- place token into box without ""
- send.

Information on endpoints:

- http://localhost:5003/swagger/index.html

for more guidence on JWT Authentication:

- https://jasonwatmore.com/post/2018/08/14/aspnet-core-21-jwt-authentication-tutorial-with-example-api
- https://jasonwatmore.com/post/2018/06/26/aspnet-core-21-simple-api-for-authentication-registration-and-user-management

### License

Copyright (c) 2020 **_Natalie Murphy / Joseph Nilles / Michael Watts _**
Licensed under MIT
