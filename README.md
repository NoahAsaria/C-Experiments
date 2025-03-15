# C# Experiments
This is my workspace for incrementally learning C# syntax and functionality. As I learn more about the language and the .NET platform, I will be adding simple implementations to this repository. The end goal is to refine these approaches to follow and truly understand best practices for working with the language.

Capabilities to implement:
- Authenticate and read from an API and download files. (KaggleAPIAccessor)

- Build data models to consume API requests and turn them into objects (KaggleAPIAccessor)

- Use LINQ to manipulate complicating data objects

- Connect the C# backend to a front end framework

- Process real-time data efficiently using websockets

- Process a variety of interesting file formats, including Blob, Graphs etc.

- Dependency injection

Completion Log:
1) Kaggle API Parser
- Authenticating and reading from the Kaggle API in a class format. Followed this tutorial: https://www.kaggle.com/discussions/general/52093 
- Changed the Newtonsoft JSON syntax to System.Text.Json syntax for parsing the JSON authorization token
- Added data models for nested JSON API responses, referenced: https://jeremyparnell.com/blog/best-practices-for-consuming-an-api/
- Added static class for storing kaggle query paths
