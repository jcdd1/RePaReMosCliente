using ResCliCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResCliCore.Common.Interface
{
    public interface IManejoResiduosServiceInt
    {
        Task<List<DataInputDto>> ObtenerResiduos();
    }
}
