Stub for quick web services testing

1. WebServices project - web project which defines the WCF Service

2. Enable CORS in Application_BeginRequest of global.asax in WebServices project. 
   CORS will still not work if service hosted on IIS (as opposed to IISExpress). 
   For that, make entries under <system.webServer> -> <httpProtocol> -> <customHeaders> in web.config

3. WebServices.SelfHost - Console App to Self Host the WCF Service defined in WebServices project
   Has a reference to WebServices project. Add endpoint entries to App.Config

   To be able run this app and self host, either run VS.Net as Administrator or even better add permissions 
   to allow the webserver/port combo by issuing below in an elevated command prompt

   netsh http add urlacl url=http://+:3001/WebServices user=desktop-comp\a

4. WebServices.Client - class library with a service reference to web service

5. WebServices.Client.Test - Test project for testing web service. Has a reference to WebServices.Clients

