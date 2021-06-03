using SC.API.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelReader
{
    public interface IExcelReader
    {
        List<Aluno> LerExcel();
    }
}
