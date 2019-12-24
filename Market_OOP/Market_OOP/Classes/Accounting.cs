using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_OOP
{
    class Accounting
    {
        private readonly DateTime startDate;
        private DateTime date = new DateTime();
        private double amountOfMoney;
        private double moneyFromThisDay;
        private List<double> historyOfProfit = new List<double>();
        //private List<int> 

        public Accounting()
        {
            date = DateTime.Today;
            startDate = DateTime.Today;
        }

        public DateTime CurrentDate
        {
            get { return date; }
        }

        public double AmountOfMoney
        {
            get { return amountOfMoney+moneyFromThisDay; }
        }

        public double MoneyFromThisDay
        {
            get { return moneyFromThisDay; }
        }

        public void AddDay()
        {
            amountOfMoney += moneyFromThisDay;
            historyOfProfit.Add(moneyFromThisDay);
            moneyFromThisDay = 0;
            date = date.AddDays(1);
        }

        public void AddProfit(double money)
        {
            moneyFromThisDay += money;
        }

        public double CountProfit(DateTime firstDate, DateTime lastDate)
        {
            if (firstDate.Date > CurrentDate.Date)
            {
                return -1;
            }

            if (lastDate.Date < firstDate.Date)
            {
                var tmp = firstDate;
                firstDate = lastDate;
                lastDate = tmp;
            }

            if (lastDate.Date > CurrentDate.Date)
            {
                lastDate = CurrentDate;
            }
            
            if(firstDate.Date < startDate.Date)
            {
                firstDate = startDate;
            }

            double sumProfit = 0;

            var daysToSum = lastDate.Date - firstDate.Date;
            var daysFromStart = firstDate.Date - startDate.Date;

            for(int i = 0; i <= daysToSum.Days; i++)
            {
                sumProfit += historyOfProfit[i + daysFromStart.Days];
            }

            return sumProfit;
        }

        public double CountProfit(DateTime date)
        {
            if (date.Date == CurrentDate.Date)
            {
                return this.MoneyFromThisDay;
            }

            if(date.Date > DateTime.Today.Date || date.Date < startDate.Date)
            {
                return 0;
            }

            TimeSpan period = date.Date - this.startDate.Date;

            return historyOfProfit[period.Days];
        }

        public double CountProfit(int countOfLastDays)//?
        {
            countOfLastDays = Math.Min(countOfLastDays, historyOfProfit.Count);

            double sumProfit = 0;
            var period = this.CurrentDate.Date - this.startDate.Date;

            for(int i = 1; i <= countOfLastDays; i++)
            {
                sumProfit += historyOfProfit[period.Days - i];
            }

            sumProfit += moneyFromThisDay;

            return sumProfit;
        }
    }
}
