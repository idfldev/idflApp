# Food website

## Infrastructure

[ASPNET React Web](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started)

![](https://itzone.com.vn/wp-content/uploads/2020/03/db5d517f-b0a9-4c2f-870a-3d688ede10cc.png)

## Structure

- project
  - Controllers
  - ClientApp

## Code Convention

**branch name:** feature/{short-feature-description}

## Development Enviromment


- run application
  `dotnet run`
### create-generate new database schema
`./Commands/addNewSchema.sh`

### re-generate new database schema

`./Commands/reUpdateDatabase.sh`

### step for run app for FE
step 1: run ./Commands/reUpdateDatabase.sh (using bash)
step 2: dotnet run (using powershell)
### Document for jwt
https://jasonwatmore.com/net-7-csharp-jwt-authentication-tutorial-without-aspnet-core-identity
### Document for role
https://jasonwatmore.com/post/2022/02/18/net-6-role-based-authorization-tutorial-with-example-api