using ReportService.Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportService.Core.Repositories
{
    public class ReportRepository
    {
        public Report GetLastNotSentReport()
        {
            //Pobieranie z bazy danych ostatniego raportu

            return new Report
            {
                Id = 1,
                Title = "R/1/2020",
                Date = new DateTime(2020, 1, 1, 12, 0, 0),
                Positions = new List<ReportPosition>
                {
                    new ReportPosition
                    {
                        Id = 1,
                        ReportId = 1,
                        Title = "Position 1",
                        Description = "Description 1",
                        Value = 4311m,
                    },

                    new ReportPosition
                    {
                        Id = 2,
                        ReportId = 2,
                        Title = "Position 2",
                        Description = "Description 2",
                        Value = 432m,
                    },

                    new ReportPosition
                    {
                        Id = 3,
                        ReportId = 3,
                        Title = "Position 3",
                        Description = "Description 3",
                        Value = 69m,
                    }
                }
            };
        }

        public void ReportSent(Report report)
        {
            report.IsSend = true;
            //zapis w bazie danych
        }
    }
}
