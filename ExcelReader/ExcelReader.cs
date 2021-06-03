using ClosedXML.Excel;
using SC.API.Domain;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ExcelReader
{
    public class PlanReader : IExcelReader
    {
        public List<Aluno> LerExcel()
        {
            var xls = new XLWorkbook(@"C:\Users\USER\Documents\Cursos\Trovato\06 - SQL SERVER.xlsm");
            var planilha = xls.Worksheets.First(w => w.Name == "ALUNOS");
            var totalLinhas = planilha.Rows().Count();
            var alunos = new List<Aluno>();
            // primeira linha é o cabecalho
            for (int l = 2; l <= totalLinhas; l++)
            {
                var aluno = new Aluno(DateTime.Now, "GABS");
                aluno.IdAluno = int.Parse(planilha.Cell($"A{l}").Value.ToString());
                aluno.Nome = planilha.Cell($"B{l}").Value.ToString();
                aluno.DataNascimento = DateTime.Parse(planilha.Cell($"C{l}").Value.ToString());
                aluno.Sexo = char.Parse(planilha.Cell($"D{l}").Value.ToString());
                alunos.Add(aluno);
            }
            return alunos;
        }
    }
}