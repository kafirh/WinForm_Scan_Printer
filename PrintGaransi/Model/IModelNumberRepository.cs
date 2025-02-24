using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPackingLabel.Model
{
    public interface IModelNumberRepository
    {
        GaransiModel GetByModelCode(GaransiModel model);
    }
}
