# knockout-test

## Requirements

* [VS-Code](https://code.visualstudio.com/) text editor
* [node](https://nodejs.org/en/download/)
* NPM which is bundled with node.
* Webpack 
    * use NPM to install [webpack](https://webpack.js.org/guides/installation/)


## Setup

* Clone or download this repo https://github.com/localOrganization/knockout-test
* run `npm Install`
* Start debugging in VS-Code 
   * VS-Code > Debug > Start Debugging (F5) 

## Task

* Create a local api method to consume the service
   * http://api.wunderground.com/api/14bbd739ef370568/forecast10day/q/OR/Sisters.json
* Add a new menu item for 10 Day Forecast
* Create a view with cards using the SimpleForecast
    * Display the current conditions
      * High Temp
      * Low Temp
      * Forecast Icon
      * Average Wind
      * Average Humitity
      * Current Conditions
      * Bonus: Display precipitation in inches for snow or rain where applicable
      
* Optionally: The project has an existing C# model that maps to the JSON response [10DayForecast](/blob/master/Models/10DayForecast.cs). 

