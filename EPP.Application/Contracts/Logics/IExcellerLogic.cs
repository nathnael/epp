using EPP.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace EPP.Application.Contracts.Logics
{
    public interface IExcellerLogic
    {
        List<ExcellerDto> GetAll();
    }
}
