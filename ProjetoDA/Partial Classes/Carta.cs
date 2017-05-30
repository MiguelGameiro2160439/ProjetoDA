using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    using System;
    using System.Collections.Generic;

    [Serializable]
    public partial class Card
    {
        public override string ToString()
        {
            return this.Name;
        }
    }
}
