using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031225
{
    public class HourlySalaryEmployee : Employee //Создаем класс для сотрудников с почасовой оплатой
    {
        public double SalaryHour;
        public int Hours;
        public int Overtime;

        public override double CalculateSalary()
        {
           double salary = 0;
            salary += SalaryHour * (Hours + Overtime * 2);
           return salary;
        }
    }
}
