
# Magic Lambda Math for .Net

[![Build status](https://travis-ci.org/polterguy/magic.lambda.math.svg?master)](https://travis-ci.org/polterguy/magic.lambda.math)

This project provides magic functions to [Magic](https://github.com/polterguy/magic). More specifically, it provides the following
slots.

* __[\*]__ - Multiplication
* __[/]__ - Division
* __[+]__ - Addition
* __[-]__ - Subtraction
* __[%]__ - Modulo

All of the above can be given any number of arguments, including as its value, and will treat the first argument as the _"base"_,
and performing the rest of the arguments self assigning the base as it proceeds. For instance, the following code will first divide
100 by 4, then divide that result by 5 again, resulting in 5.

```
/:int:100
   :int:4
   :int:5
```

The value of the above __[/]__ node after evaluating the above Hyperlambda will be 5.

## License

Magic is licensed as Affero GPL. This means that you can only use it to create Open Source solutions.
If this is a problem, you can contact at thomas@gaiasoul.com me to negotiate a proprietary license if
you want to use the framework to build closed source code. This will allow you to use Magic in closed
source projects, in addition to giving you access to Microsoft SQL Server adapters, to _"crudify"_
database tables in MS SQL Server. I also provide professional support for clients that buys a
proprietary enabling license.
