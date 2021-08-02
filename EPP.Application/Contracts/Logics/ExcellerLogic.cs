using EPP.Application.Contracts.Data;
using EPP.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPP.Application.Contracts.Logics
{
    public class ExcellerLogic : IExcellerLogic
    {
        private readonly IEppDbContext _eppDbContext;
        public ExcellerLogic(IEppDbContext eppDbContext)
        {
            _eppDbContext = eppDbContext;
        }

        public List<ExcellerDto> GetAll()
        {
            return _eppDbContext.Excellers
            .Select(_ => new ExcellerDto
            {
                FirstName = _.FirstName,
                FatherName = _.FatherName,
                GrandFatherName = _.GrandFatherName,
                ContractSigningDate = _.ContractSigningDate,
                YearsOfExperience = _.YearsOfExperience,
                CreatedAt = _.CreatedAt,
                ModifiedAt = _.ModifiedAt
            }).ToList();
        }
    }
}
