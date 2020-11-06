# Proyecto Basico Asp.Net Core de tipo ToDo
Proyecto Basado en [The Little ASP.NET Core Book](https://recaffeinate.co/book/).

Consideraciones:
* No fue implementado ApplicationUser, solo IdentityUser
* Desplegado en DotnetCore 2.2
* AspNetCore 2.1 genera errores en la autorizacion con respecto al proyecto original de [Nate Barbettini](https://github.com/nbarbettini/little-aspnetcore-todo)
* Modificada la ruta original de TodoRoutShould en AspNetCore.IntegrationTest por http://localhost:5000/Identity/Account/Login?ReturnUrl=%2Ftodo