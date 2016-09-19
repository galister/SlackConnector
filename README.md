# SlackConnector 

This is a port of SlackConnector to .NET Core.
Works with this .NET Core port of websocket-sharp:
https://github.com/galister/websocket-sharp

SlackConnector initiates an open connection between you and the Slack servers. SlackConnector uses web-sockets to allow real-time messages to be received and handled within your application.

## History
This library was originally extracted MargieBot and has iterated on it's own to become testable and progress without being coupled to any one implementation. This library has been built for [noobot](http://github.com/noobot/noobot), however it can easily be used in any project due to it's decoupling.


## Installation
 
```
Install-Package SlackConnector
```


## Usage

``` cs
ISlackConnector connector = new SlackConnector.SlackConnector();
ISlackConnection connection = await connector.Connect(slackKey);
connection.OnMessageReceived += MessageReceived;
connection.OnConnectionStatusChanged += ConnectionStatusChanged;
```

##Features

 - Async by default
 - Easy setup
 - Real-time communication
 - Supports default proxies
 - Unit tested
