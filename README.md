# YouTrackSharp

![YouTrackSharp](https://github.com/maartenba/YouTrackSharp/raw/master/logo.png)

.NET Library to access YouTrack API.

For more information on YouTrack visit [jetbrains.com/youtrack](http://www.jetbrains.com/youtrack).

[![MyGet Build Status](https://www.myget.org/BuildSource/Badge/youtracksharp?identifier=9cb1066f-5a24-47b1-acf8-51d21bf2d5d8)](https://www.myget.org/)

## Getting started

First of all, install `YouTrackSharp` into your project using a NuGet client.

To communicate with a YouTrack server instance, we'll need a connection. It is recommended to always use [permanent tokens](https://www.jetbrains.com/help/youtrack/incloud/Manage-Permanent-Token.html) to authenticate against YouTrack, using the `BearerTokenConnection`. For YouTrack instances that do not have token support, `UsernamePasswordConnection` can be used.

```csharp
var connection = new BearerTokenConnection("https://ytsharp.myjetbrains.com/youtrack/", "perm:abcdefghijklmn");

// or:

var connection = new UsernamePasswordConnection("https://ytsharp.myjetbrains.com/youtrack/", "username", "password");
```

Once a connection is made, various services can be used. For example to get a list of projects the user has access to, the `ProjectsService` can be used:

```csharp
var projectsService = new connection.CreateProjectsService();
var projectsForCurrentUser = await projectsService.GetAccessibleProjects();
```

Other services are available as well, mapping to the [YouTrack REST API](https://www.jetbrains.com/help/youtrack/standalone/YouTrack-REST-API-Reference.html) endpoints and operations that are available.

## Supported YouTrack versions

YouTrack versions 2017.x and higher as well as YouTrack InCloud are officially supported by this library.

Some features will work with older versions of YouTrack as well but they are not officially suppported. For other YouTrack versions:

* YouTrack Standalone 7.0 - [use the 2.x branch](https://github.com/JetBrains/YouTrackSharp/tree/2.x) or [YouTrackSharp 2.x](https://www.nuget.org/packages/YouTrackSharp/)
* YouTrack Standalone 6.5 - [use the 2.x branch](https://github.com/JetBrains/YouTrackSharp/tree/2.x) or [YouTrackSharp 2.x](https://www.nuget.org/packages/YouTrackSharp/)
* YouTrack Standalone 6.0 - [use the 2.x branch](https://github.com/JetBrains/YouTrackSharp/tree/2.x) or [YouTrackSharp 2.x](https://www.nuget.org/packages/YouTrackSharp/)
* YouTrack Standalone 5.x - [use the 2.x branch](https://github.com/JetBrains/YouTrackSharp/tree/2.x) or [YouTrackSharp 2.x](https://www.nuget.org/packages/YouTrackSharp/)
* YouTrack Standalone 4.x - [use the 2.x branch](https://github.com/JetBrains/YouTrackSharp/tree/2.x) or [YouTrackSharp 2.x](https://www.nuget.org/packages/YouTrackSharp/)
* YouTrack Standalone 3.x - [use the 1.x branch](https://github.com/JetBrains/YouTrackSharp/tree/1.x) or [YouTrackSharp 1.x](https://www.nuget.org/packages/YouTrackSharp/)

Be aware that these older branches are frozen and bug fixes nor new feature development is done on them.