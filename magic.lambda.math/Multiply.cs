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
    [Slot(Name = "*")]
    public class Multiply : ISlot
    {
        public void Signal(ISignaler signaler, Node input)
        {
            signaler.Signal("eval", input);
            dynamic sum = input.Children.First().Value;
            foreach (var idx in input.Children.Skip(1))
            {
                sum *= idx.GetEx<dynamic>();
            }
            input.Value = sum;
        }
    }
}
