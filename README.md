# API To get GWP 

### 1) Clone the project-

In the repository on Github click on <b>Clone or Download</b>, then <b>Download ZIP</b> and on downloading extract it in the directory of your choice.

<b>OR</b>

<i> Requires <a href="https://git-scm.com/downloads">Git</a> to be downloaded.</i>

In your machine go to the directory where you want to download the project.

Open <b>Git bash</b>  (option available on right-click in Windows 10) or any command line interface supporting <b>Git</b> in that directory.

Run the following code


`git clone https://github.com/ajinkyad8/GWPVSCode.git`


## Steps To Run (VS Code Version)
### 2) Download the <a href="https://dotnet.microsoft.com/download/dotnet/3.1">.NET Core SDK </a> .

### 3) Build the application

Open a command line inetrface (Powershell, Command Prompt or a Terminal in your VS Code) and un the following command to build the application.
 
 <i>Make sure you are in the project folder while running them.</i>

 ```shell
 dotnet run
 ```
if the build is successfull you will see the following message on your terminal.
> info: Microsoft.Hosting.Lifetime[0]

>     Now listening on: http://[::]:9091

>info: Microsoft.Hosting.Lifetime[0]

>     Application started. Press Ctrl+C to shut down.

The application can be accessed on  <i>localhost:9091</i>.


## Steps To Run (Visual Studio Version)

### 2) Open solution in visual studio
In visual studio go to <i>File-->Open-->Project/Solution</i>.
 
 Select the solution file and open the project.
 
 ### 3) Ensure the CSV file is set to copy.
 
 In the Solution Explorer follow the following steps
 
 <i>Data-->gwpByCountry.csv(Right-Click)--->Properties<i>
 
 for <b>Copy to Directory</b> select <b>Copy if newer</b>. This will make sure this file gets copied in the buil.

### 3) Run the project

Right Click on the project file and click on <i>Set as Startup Project </i>.
Click on run from the top toolbar (green triangular button)
A terminal should open with the following text
> info: Microsoft.Hosting.Lifetime[0]

>     Now listening on: http://[::]:9091

>info: Microsoft.Hosting.Lifetime[0]

>     Application started. Press Ctrl+C to shut down.

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

To test any other file you can replace the file in the <i>Data</i> folder and its path in the <i>CSVData.cs</i> file. 

<b>Make sure the headers are the same.</b>
