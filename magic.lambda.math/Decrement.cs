/*
 * Magic, Copyright(c) Thomas Hansen 2019, thomas@servergardens.com, all rights reserved.
 * See the enclosed LICENSE file for details.
 */

using System.Linq;
using magic.node;
using magic.node.extensions;
using magic.signals.contracts;

namespace magic.lambda.math
{
    /// <summary>
    /// [decrement] slot for decrementing some value, optionally by a [step] argument.
    /// </summary>
    [Slot(Name = "math.decrement")]
    public class Decrement : ISlot
    {
        /// <summary>
        /// Slot implementation.
        /// </summary>
        /// <param name="signaler">Signaler that raised the signal.</param>
        /// <param name="input">Arguments to slot.</param>
        public void Signal(ISignaler signaler, Node input)
        {
            signaler.Signal("eval", input);
            var step = GetStep(input);
            foreach (var idx in input.Evaluate())
            {
                idx.Value = idx.Get<dynamic>() - step;
            }
        }

        #region [ -- Private helper methods -- ]

        dynamic GetStep(Node input)
        {
            return input.Children.FirstOrDefault()?.Value ?? 1;
        }

        #endregion
    }
}
