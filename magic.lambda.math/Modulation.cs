/*
 * Magic, Copyright(c) Thomas Hansen 2019, thomas@gaiasoul.com, all rights reserved.
 * See the enclosed LICENSE file for details.
 */

using magic.node;
using magic.signals.contracts;
using magic.lambda.math.utilities;

namespace magic.lambda.math
{
    /// <summary>
    /// [%] slot for performing division.
    /// </summary>
    [Slot(Name = "math.modulo")]
    public class Modulation : ISlot
    {
        /// <summary>
        /// Slot implementation.
        /// </summary>
        /// <param name="signaler">Signaler that raised the signal.</param>
        /// <param name="input">Arguments to slot.</param>
        public void Signal(ISignaler signaler, Node input)
        {
            signaler.Signal("eval", input);
            dynamic sum = Utilities.GetBase(input);
            foreach (var idx in Utilities.AllButBase(input))
            {
                sum %= idx;
            }
            input.Value = sum;
        }
    }
}
