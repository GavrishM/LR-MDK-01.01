using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031225
{
    public class FixedSalaryEmployee : Employee //Создаем класс для сотрудников с фиксированной зарплатой в месяц
    {
        public double SalaryMounth;
        public int Mounth;
        public override double CalculateSalary()
        {
            double salary = 0;
            salary += SalaryMounth * Mounth;
            return salary;
        }
    }
}
