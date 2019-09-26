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
    [Slot(Name = "+")]
    public class Plus : ISlot
    {
        public void Signal(ISignaler signaler, Node input)
        {
            signaler.Signal("eval", input);
            input.Value = input.Children.Sum(x => x.GetEx<dynamic>());
        }
    }
}
