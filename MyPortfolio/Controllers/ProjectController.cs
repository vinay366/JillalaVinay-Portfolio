using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Build()
        {
            var projects = new List<Projects>
            {
                new Projects
                {
                    Title="HRM System Development",
                    Description="In our recent project, we developed RESTful APIs to efficiently manage employee data and streamline HR workflows using .NET Core Web API. By adopting a Code-First approach with Entity Framework, we ensured that our database operations were both effective and easy to manage. Additionally, we seamlessly integrated our modules with third-party applications, which allowed for smooth communication between the APIs and external systems. This holistic approach not only improved our internal processes but also enhanced our overall efficiency in handling HR tasks.",
                    TechnologyUsed="C#, .NET Core, Entity Framework, SQL Server, RESTful APIs, Postman, Swagger, GitHub, Visual Studio Code",
                    GithubLink="https://github.com/vinay366/HRMCodeFirstApproch",
                    ImageUrl="https://ondemand.bannerbear.com/signedurl/9K5qxXae32jEAGRDkj/image.jpg?modifications=W3sibmFtZSI6InJlcG8iLCJ0ZXh0IjoidmluYXkzNjYgLyAqYXBpLW1hd2EtYXBwKiJ9LHsibmFtZSI6ImRlc2MiLCJ0ZXh0IjoiQnVpbGQgQSBXaW5kb3dzIEZvcm1zIEFwcCBhbmQgdGhhdCBDbG9uZSBvZiB0aGUgUG9zdG1hbiBBUEkgYXBwLiBpdCBzaG91bGQgYmUgYWJsZSB0byBjYWxsIGEgZ2l2ZW4gQVBJIGFuZCBEaXNwbGF5IHRoZSByZXN1bHRzIGluIHRleHQgd2luZG93cy4ifSx7Im5hbWUiOiJhdmF0YXI1IiwiaGlkZSI6dHJ1ZX0seyJuYW1lIjoiYXZhdGFyNCIsImhpZGUiOnRydWV9LHsibmFtZSI6ImF2YXRhcjMiLCJoaWRlIjp0cnVlfSx7Im5hbWUiOiJhdmF0YXIyIiwiaGlkZSI6dHJ1ZX0seyJuYW1lIjoiYXZhdGFyMSIsImltYWdlX3VybCI6Imh0dHBzOi8vYXZhdGFycy5naXRodWJ1c2VyY29udGVudC5jb20vdS83ODUyMDMyOT92PTQifSx7Im5hbWUiOiJjb250cmlidXRvcnMiLCJ0ZXh0IjoidmluYXkzNjYifSx7Im5hbWUiOiJzdGFycyIsInRleHQiOiIwIn1d&s=b72f0b23d78db7a0b996d7c800954f4b16ff34eb91f08621555b7e04ad5bf396"
                },
                new Projects
                {
                    Title=" Postman Clone– APIMAWA",
                    Description="I developed a lightweight WinForms desktop application designed specifically for API testing, much like Postman. This app integrates HttpClient, allowing users to efficiently handle requests and responses while inspecting headers and payloads. It proves to be an invaluable tool for rapid development and testing of local REST APIs, streamlining the process and enhancing productivity. Whether you’re a seasoned developer or just starting out, this application makes testing APIs straightforward and accessible.",
                    TechnologyUsed="C#, WinForms, HttpClient, RESTful APIs, GitHub, Visual Studio",
                    GithubLink="https://github.com/vinay366/api-mawa-app",
                    ImageUrl="https://ondemand.bannerbear.com/signedurl/9K5qxXae32jEAGRDkj/image.jpg?modifications=W3sibmFtZSI6InJlcG8iLCJ0ZXh0IjoidmluYXkzNjYgLyAqSFJNQ29kZUZpcnN0QXBwcm9jaCoifSx7Im5hbWUiOiJkZXNjIiwidGV4dCI6IkluIG91ciByZWNlbnQgcHJvamVjdCwgd2UgZGV2ZWxvcGVkIFJFU1RmdWwgQVBJcyB0byBlZmZpY2llbnRseSBtYW5hZ2UgZW1wbG95ZWUgZGF0YSBhbmQgc3RyZWFtbGluZSBIUiB3b3JrZmxvd3MgdXNpbmcgLk5FVCBDb3JlIFdlYiBBUEkuIEJ5IGFkb3B0aW5nIGEgQ29kZS1GaXJzdCBhcHByb2FjaCB3aXRoIEVudGl0eSBGcmFtZXdvcmssIHdlIGVuc3VyZWQgdGhhdCBvdXIgZGF0YWJhc2Ugb3BlcmF0aW9ucyB3ZXJlIGJvdGggZWZmZWN0aXZlIGFuZCBlYXN5IHRvIG1hbmFnZS4gIn0seyJuYW1lIjoiYXZhdGFyNSIsImhpZGUiOnRydWV9LHsibmFtZSI6ImF2YXRhcjQiLCJoaWRlIjp0cnVlfSx7Im5hbWUiOiJhdmF0YXIzIiwiaGlkZSI6dHJ1ZX0seyJuYW1lIjoiYXZhdGFyMiIsImhpZGUiOnRydWV9LHsibmFtZSI6ImF2YXRhcjEiLCJpbWFnZV91cmwiOiJodHRwczovL2F2YXRhcnMuZ2l0aHVidXNlcmNvbnRlbnQuY29tL3UvNzg1MjAzMjk_dj00In0seyJuYW1lIjoiY29udHJpYnV0b3JzIiwidGV4dCI6InZpbmF5MzY2In0seyJuYW1lIjoic3RhcnMiLCJ0ZXh0IjoiMCJ9XQ&s=09b18038ffd5f9980980b283c76f4fddb2e829b39da73b57b07da7b294d64336"

                }
            };
            return View(projects);
        }
    }
}
