# API To get GWP (VS Code Version)

##Steps To Run
### 1) Download the <a href="https://dotnet.microsoft.com/download/dotnet/3.1">.NET Core SDK </a> .
### 2) Clone the project-

In the repository on Github click on <b>Clone or Download</b>, then <b>Download ZIP</b> and on downloading extract it in the directory of your choice.

<b>OR</b>

<i> Requires <a href="https://git-scm.com/downloads">Git</a> to be downloaded.</i>

In your machine go to the directory where you want to download the project.

Open <b>Git bash</b>  (option available on right-click in Windows 10) or any command line interface supporting <b>Git</b> in that directory.

Run the following code


`git clone https://github.com/ajinkyad8/GWPVSCode.git`


### 3) Build the application

Open a command line inetrface (Powershell, Command Prompt or a Terminal in your VS Code) and un the following command to build the application.
 
 <i>Make sure you are in the project folder while running them.</i>

 ```shell
 dotnet run
 ```
if the build is successfull you will see the following message on your terminal.
> Microsoft.Hosting.Lifetime[0]
> Now listening on: http://[::]:9091
> Application started. Press Ctrl+C to shut down.

The application can be accessed on  <i>localhost:9091</i>.

### 4) Test the API
You need an API testing tool to test the API. I will suggest you use <a href="https://www.postman.com/downloads/">Postman</a> for the same.
To test the application you need to hit the url

`http://localhost:9091/api/gwp/avg`

of type <b>POST</b>

and have a JSON body like this

```json
{
    "country": "country",
    "linesOfBusiness": ["lineOfBusiness1", "lineOfBusiness2","cont.."]
}
```

The response of the API shoule be of the format
```json
{
    "lineOfBusiness1": 10,
    "lineOfBusiness2": 20
}
```

where 10 and 20 are the respective averages for the lines of businesses for the country in input.

