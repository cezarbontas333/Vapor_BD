# Vapor_BD
A C# + .NET + WinForms application for the Database course at UPB. It simulates a game launcher &amp; shop (not an actual game launcher).

### Details
This application tries to simulate a Steam client, complete with a store where to buy games, and a game library, for each user. Besides players, the
platform also has accounts for game publishers and store administrators, each with their own permissions to add, modify and delete games and/or users.
What's implemented as of now:
- Login page;
- Home page;
- Library of games;
- Store page with recommendations based on player choice and a search feature;
- Game page for purchase/presentation;
- Achievement tracking for each game

### Build instructions
This can be built using Visual Studio 2022, you'd need:
- .NET desktop developement
- Data storage and processing
- System.Data.SqlClient module

### To be done:
- Admin panel for user/game moderation;
- Publisher panel for adding new games;
- Shopping cart and purchase history;
