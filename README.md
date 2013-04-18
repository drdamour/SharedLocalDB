SharedLocalDB
=============

Project used to demonstrate how different projects in a solution can share the same local db.

This was generated to investigate the stack overflow issue @ http://stackoverflow.com/questions/15960535/how-to-share-a-localdb-instance-across-all-projects-in-a-solution/

As configured the ASP.NET MVC project will not be able to attach the mdf file it's looking for in App_Data because it's not there.  If you modify the web.config to add the ThingsContext connection string the Model.Test project will share the same DB instance with the WebApp.
