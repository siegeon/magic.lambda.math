/*
 * Magic, Copyright(c) Thomas Hansen 2019 - thomas@gaiasoul.com
 * Licensed as Affero GPL unless an explicitly proprietary license has been obtained.
 */

using System;
using System.Linq;
using System.Collections.Generic;
using magic.node;
using magic.node.extensions;
using magic.signals.contracts;

namespace magic.lambda
{
    [Slot(Name = "-")]
    public class Subtract : ISlot
    {
        public void Signal(ISignaler signaler, Node input)
        {
            signaler.Signal("eval", input);
            input.Value = input.Children.First().GetEx<dynamic>() - input.Children.Skip(1).Sum(x => x.GetEx<dynamic>());
        }
    }
}
