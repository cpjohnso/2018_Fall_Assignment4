# 2018_Fall_Assignment4

No real change from what was submitted prior. 
I changed the api address for both GetSymbol() functions.
I dropped the original company and equity tables. These were built on different api tables that are not compatible with our algorithm.

Chris

Update 29Nov2018

Build works. Please make sure you delete all prior versions and only use this version.

Views:
Top5Sell View created.
AboutUs View created
GetHeadlines View is created

Models:
Headline Model is created. This model is built using the IEX trading api with the path set at stock/market/news

HomeController:
GetHeadlines() pull the top ten headlines from the IEX Trading News api using the GetHeadlines() function (IEXHandler)

IEXHandler:
GetHeadlines() pulls the top ten headlines and stores value in Headline Model

Additional notes:
Headline to DbContext
Because the Headline variables not not saved to the temp Headline table, the Refresh function does not clear this table. 
Becomes an issue if Symbols are loaded and dropped from the application and News is checked after first Symbol Save / Refresh cycle. 

Chris
