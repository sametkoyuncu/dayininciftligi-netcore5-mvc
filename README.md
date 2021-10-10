# Dayının Çiftliği

dayininciftligi.com website

# Installation

- [Install .Net 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- [Install Visual Studio Express or Higher](https://visualstudio.microsoft.com/tr/downloads/)
- Clone this repository

```shell
git clone https://github.com/sametkoyuncu/dayininciftligi-netcore5-mvc.git
```

- Open project with Visual Studio
- Install this packages\
  ![Packages](https://github.com/sametkoyuncu/dayininciftligi-netcore5-mvc/blob/master/screenshots/Packages.png?raw=true)
- Change Connection String in 'Data/DayiDbContext.cs' and 'Startup.cs' files

```shell
  @"Server=YOUR_SERVER_NAME;Database=dayininciftligi; Integrated Security=true;"
```

- Add migrations using terminal

```shell
dotnet ef migrations add InitialCreate --context DayiDbContext
dotnet ef migrations add InitialCreate  --context ApplicationContext
```

- Update database using terminal

```shell
dotnet ef database update --context DayiDbContext
dotnet ef database update --context ApplicationContext
```

- Edit email settings (if you want)

```c#
 services.AddScoped<IEmailSender, SmtpEmailSender>(i =>
                new SmtpEmailSender(
                        Configuration["EmailSender:Host"],
                        Configuration.GetValue<int>("EmailSender:Port"),
                        Configuration.GetValue<bool>("EmailSender:EnableSSL"),
                        Configuration["EmailSender:UserName"],
                        Configuration["EmailSender:Password"]
                    )
            );
```

- Run project
- Visit url and create new user for dasboard
  [Register](https://localhost:44385/register)
- If edit email settings, system sent confirm url to your email. Click url and confirm your email or open 'AspNetUsers' table in your database. Change 'EmailConfirmed' cell 'true' for registered user. After then login to dashboard using [Login Page](https://localhost:44385/Login)
- Now everything is okay, i hope 🙃

# Lisence

[MIT](https://choosealicense.com/licenses/mit/)

# Thanks for templates

[Colorlib](https://colorlib.com/)
