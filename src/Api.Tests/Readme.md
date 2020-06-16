# install testing

## unit tests
Run in src folder
```
dotnet new xunit -o Api.Tests
dotnet add package FluentAssertions
```

More info here: https://fluentassertions.com/introduction

## integration tests
```
dotnet add package  Microsoft.AspNetCore.Mvc.Testing --version 3.1.5
```

More info here: https://docs.microsoft.com/en-us/aspnet/core/test/integration-tests?view=aspnetcore-3.1#test-app-prerequisites

