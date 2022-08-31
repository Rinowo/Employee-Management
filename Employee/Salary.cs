using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Salary
    {
        public float basicSalary;
        public float hourRent;
        public float medicalAllowance;
        public float conveyance;

        double bsPercent;
        double hrPercent;
        double naPercent;
        double caPercent;

        public float overTime;
        public double overtimeRet;
        public double totalOverTimeRet;

        public double CalculateSalary(float bassicSalary)
        {
            this.bsPercent = 0.50;
            this.hrPercent = 0.20;
            this.naPercent = 0.25;
            this.caPercent = 0.05;

            this.basicSalary = bassicSalary;
            this.hourRent = Convert.ToInt32(bassicSalary * hourRent);

            this.medicalAllowance = Convert.ToInt32(bassicSalary * naPercent);
            this.conveyance = Convert.ToInt32(bassicSalary * caPercent);

            var totalSalary = this.basicSalary * this.hourRent + this.medicalAllowance + this.conveyance;

            return totalSalary;
        }

        public double CaculateOverTime(double overtime)
        {
            this.overTime = basicSalary;
            var nt = (((overTime / 30) / 8) * 2 * 8);
            return nt;
        }

        public Currency currency;
    }
    public enum Currency
    {
        USD, END, CNY, YEN, VND
    }
}
