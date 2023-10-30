using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum TransformerType
    {
        Current,
        Voltage
    }

    /// <summary>
    /// Трансформатор
    /// </summary>
    public class Transformer
    {
        public string Number { get; init; }
        public DateOnly DateVerification { get; set; }
        public TransformerType TransformerType { get; init; }
        public decimal Coefficient { get; init; }

    }
}
