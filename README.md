# Store written on ASP.NET core
![WSIiZ](https://moodle.wsiz.edu.pl/pluginfile.php/1/theme_alpha/customlogotopbar/1707397324/wsiz-favicon.png)  
## What should be installed first
1. Visual Studio 2022 or [VSCode](https://code.visualstudio.com/docs/languages/dotnet) 
2. [.NET 8.0](https://dotnet.microsoft.com/en-us/download) 
## Installation
   Docker support will be soon
### Manually
1. To run this project you need to install and configure [Admin panel](https://github.com/Zacky3181V/admin-panel) first. Please follow the link and instructions  
2. Clone this repository using git or manually downloading an archive
   ```
    git clone https://github.com/Zacky3181V/store
   ```
3. If Admin Panel set up was successful take the store token and paste it inside Index() method
   ```
    var endpoint2 = new Uri("http://localhost:3000/api/***paste the token here***/billboards");
   ```
5. Run admin panel and then build the store application
