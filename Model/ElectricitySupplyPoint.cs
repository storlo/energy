using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Точка поставки электроэнергии
    /// </summary>
    internal class ElectricitySupplyPoint
    {
        public string Name { get; init; }
        public decimal Capacity { get; set; }
    }
}
