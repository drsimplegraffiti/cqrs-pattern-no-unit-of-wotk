##### install packages
SqlServer
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools

MediatR.Extensions.Microsoft.DependencyInjection
- dotnet add package MediatR.Extensions.Microsoft.DependencyInjection

Microsoft.EntityFrameworkCore
- dotnet add package Microsoft.EntityFrameworkCore

uninstall packages
dotnet remove package MediatR

---

###### Creation steps
- install packages
- Create Models Class
- Create DbContext Class
- Create IRepository Interface
- Create Repository Class and Implement IRepository Interface
- Create Query Class and Implement IRequest Interface
- Create QueryHandler Class and Implement IRequestHandler Interface
- Create Command Class and Implement IRequest Interface
- Create CommandHandler Class and Implement IRequestHandler Interface
- Add DbContext in Program.cs
- Add Repository in Program.cs
- Add MediatR in Program.cs
- Create Controller and Inject MediatR
