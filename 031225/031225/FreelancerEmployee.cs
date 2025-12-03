using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031225
{
    public class FreelancerEmployee : Employee //Создаем класс для сотрудников на фрилансе
    {
        public double SalaryProject;
        public double NDFL;
        public override double CalculateSalary()
        {
            double salary = 0;
            salary += SalaryProject * (1 - NDFL);
            return salary;
        }
    }
}
