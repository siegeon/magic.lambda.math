
# Magic Lambda Math for .Net

[![Build status](https://travis-ci.org/polterguy/magic.lambda.math.svg?master)](https://travis-ci.org/polterguy/magic.lambda.math)

This project provides math functions to [Magic](https://github.com/polterguy/magic). More specifically, it provides the following
slots.

* __[math.multiply]__ - Multiplication
* __[math.divide]__ - Division
* __[math.add]__ - Addition
* __[math.subtract]__ - Subtraction
* __[math.modulo]__ - Modulo
* __[math.decrement]__ - Decrements a node's value, optionally by **[step]**, defaulting to 1
* __[math.increment]__ - Increments a node's value, optionally by **[step]**, defaulting to 1

All of the above slots also have async (wait.) overrides.

All of the above can be given any number of arguments, including as its value, and will treat the first argument as the _"base"_,
and performing the rest of the arguments self assigning the base as it proceeds. For instance, the following code will first divide
100 by 4, then divide that result by 5 again, resulting in 5.

```
math.divide:int:100
   :int:4
   :int:5
```

The value of the above __[math.divide]__ node after evaluating the above Hyperlambda will be 5.

All of the above slots will also evaluate the children collection as a lambda, before starting the actual math function,
allowing you to recursively raise signals to retrieve values that are supposed to be mathematically handled somehow.

## Incrementing and decrementing values

The above **[math.increment]** and **[math.decrement]** slots, will instead of yielding a result, inline modify the
value of the node(s) it is pointing to, assuming its value is an expression. In addition these two slots can take an
_optional_ **[step]** argument, allowing you to declare how much the incrementation/decrementation process should add/reduce
the original node's value by.

## License

Although most of Magic's source code is publicly available, Magic is _not_ Open Source or Free Software.
You have to obtain a valid license key to install it in production, and I normally charge a fee for such a
key. You can [obtain a license key here](https://servergardens.com/buy/).
Notice, 7 days after you put Magic into production, it will stop functioning, unless you have a valid
license for it.

* [Get licensed](https://servergardens.com/buy/)
