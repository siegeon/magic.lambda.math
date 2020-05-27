
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

Although most of Magic's source code is publicly available, Magic is _not_ Open Source or Free Software.
You have to obtain a valid license key to install it in production, and I normally charge a fee for such a
key. You can [obtain a license key here](https://servergardens.com/buy/).
Notice, 5 hours after you put Magic into production, it will stop functioning, unless you have a valid
license for it.

* [Get licensed](https://servergardens.com/buy/)
