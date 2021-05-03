# What's the impact of this trainging?

* Grouping DI registration into a class library would be helpful for teams asking me to adopt their libraries.
  * When I'm asked to register something in IoC, then demand that team provide an extension method for adding their feature
  * Example: `services.AddIncentives()`.
  * Allows me to NOT have to question lines in the startup DI routines
  * Especially useful as delivered packages age
  * Those class libraries will probably need to use `TryAdd` routines so it doesn't harm the host
* Service Registration Methods using a func
  * What about passing a func to registration and include logging so I can know the func was ran which implies the object was requested
* Setting up console apps with a run method and adding DI
  * Refer to the section 8 - Console App
  * Using `run` method breaks up the work and makes it clearer with app functionality seperate from DI setup
  * `run` method approach could be a template for console projects
