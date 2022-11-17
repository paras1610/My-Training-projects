using DBDemo1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBDemo1.Data
{
    public interface IContactRepository
    {
        void Save(Contact ContactToSave);
    }
}
