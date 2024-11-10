using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface ITheme
    {
        string BackgroundColor { get; }
        string TextColor { get; }
        void ApplyTheme();
    }
}
