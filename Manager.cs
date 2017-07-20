using System;
using System.Collections.Generic;


namespace ConsoleApplication1
{
    enum Manager
    {
        //Должности и кол-во часов отработанных за месяц
        Manager=195,
        Developer=220,
        Accountant=190,
        Secretary=185,
        Junior=190,
        Cleaner=180
    }

    class BonusCheck
    {
        //метод true/false на проверку давать бонус или нет
        public bool Bonus(Manager man, int hours)
        {
            if ((int)man < hours)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
