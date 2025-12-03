using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031225
{
    public abstract class Employee //Создаем абстрактный класс для сотрудников
    {
        public int Id;
        public string FullName;
        public string Email;

        public abstract double CalculateSalary();
    }
}
