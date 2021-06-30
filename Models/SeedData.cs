#define EmployeeName
#if EmployeeName
#region region_1 
using Employees.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EmployeesContext(
                serviceProvider.GetRequiredService<DbContextOptions<EmployeesContext>>()))
            {
               
                if (context.EmployeeInfo.Any())
                {
                    return;   
                }

                #region region1
                context.EmployeeInfo.AddRange(
                    new EmployeeInfo
                    {
                        EmployeeNum = 123,
                        EmployeeName = "Sibusiso",
                        EmployeeDate = DateTime.Parse("2019-2-20"),
                        Terminated = DateTime.Parse("2019-2-30"),
                        
                    },
                #endregion


                    new EmployeeInfo
                    {
                        EmployeeNum = 1234,
                        EmployeeName = "Carno",
                        EmployeeDate = DateTime.Parse("2019-2-10"),
                        Terminated = DateTime.Parse("2019-2-20"),
                    },

                    new EmployeeInfo
                    {
                        EmployeeNum = 1235,
                        EmployeeName = "Sibu",
                        EmployeeDate = DateTime.Parse("2020-2-21"),
                        Terminated = DateTime.Parse("2019-2-31"),
                        
                    },

                    new EmployeeInfo
                    {
                        EmployeeNum = 1236,
                        EmployeeName = "Jack",
                        EmployeeDate = DateTime.Parse("2019-2-15"),
                        Terminated = DateTime.Parse("2019-2-31"),
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
#endregion
#endif