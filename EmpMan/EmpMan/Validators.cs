using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

// Validate all data entered through the form 
namespace EmpMan
{
    class Validators
    {
        // Constructor for validators object 
        public Validators()
        {
            // empty parameterless constructor
        }

        // Validates person ID for not blank, no letters, unique 
        public bool validatePersonID(string personID)
        {
            if (personID == "") // checks for no blank
            {
                if (ValidateIntsOnly(personID) == false)
                {
                    return false;
                }
                return false;
            }
            else if (ValidateIntsOnly(personID) == false) // checks for numbers only
            {
                if (personID == "")
                {
                    return false;
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        // Validates currency for decimal
        public bool validateCurrency(string currency)
        {
            if (currency == "") // checks for no blank
            {
                if (ValidateDecimalOnly(currency) == false)
                {
                    return false;
                }
                return false;
            }
            else if (ValidateDecimalOnly(currency) == false) // checks for numbers only
            {
                if (currency == "")
                {
                    return false;
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        // Validates person DOB for not blank, MM/DD/YYYY format, no ned nums or 00, 1900 < YYYY < Now, MM <= 12, DD < MaxDDbyMM +1
        public bool validateDate(string personDOB)
        {
            try
            {

                if (personDOB == "") //(!(Regex.IsMatch(personDOB, @"^[0-9-/-]+$")))
                {
                    return false;
                }
                else
                {
                    string[] personDOBArray = personDOB.Split('/');
                    DateTime maxDate = new DateTime(1900, 1, 1);
                    string enteredMonth = personDOBArray[0];
                    string enteredDay = personDOBArray[1];
                    string enteredYear = personDOBArray[2];
                    int enteredDayInt = Convert.ToInt32(enteredDay);
                    int enteredYearInt = Convert.ToInt32(enteredYear);
                    string maxDateString = String.Format("{0:M/d/yyyy}", maxDate);
                    string[] maxDateArray = maxDateString.Split('/');
                    string maxMonth = maxDateArray[0];
                    string maxDay = maxDateArray[1];
                    string maxYear = maxDateArray[2];
                    if (personDOBArray.Length != maxDateArray.Length)
                    {
                        return false;
                    }
                    else
                    {
                        if (enteredYearInt > 2018 || enteredYearInt < 1990)
                        {
                            if (validateDay(enteredMonth, enteredDayInt) == false)
                            {
                                return false;
                            }
                            return false;
                        }
                        else if (validateDay(enteredMonth, enteredDayInt) == false)
                        {
                            if (enteredYearInt > 2018 || enteredYearInt < 1990)
                            {
                                return false;
                            }
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }

            }
            catch
            {
                return false;
            }
        }

        // Validates search criteria for no blanks and no letters
        public bool validateInt(string searchCriteria)
        {
            if (searchCriteria == "") // checks for no blank
            {
                if (ValidateIntsOnly(searchCriteria) == false)
                {
                    return false;
                }
                return false;
            }
            else if (ValidateIntsOnly(searchCriteria) == false) // checks for numbers only
            {
                if (searchCriteria == "")
                {
                    return false;
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        // Validate string for not blank and no nums
        public bool validateString(string attribute)
        {
            if (attribute == "") // checks for no blank
            {
                if (!(Regex.IsMatch(attribute, @"^[A-Z-a-z- -]+$")))
                {
                    return false;
                }
                return false;
            }
            else if (!(Regex.IsMatch(attribute, @"^[A-Z-a-z- -]+$"))) // checks for letters only
            {
                if (attribute == "")
                {
                    return false;
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        // Checks for only ints 
        private bool ValidateIntsOnly(string integer)
        {
            int val;
            if (int.TryParse(integer, out val))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Checks for only ints 
        private bool ValidateDecimalOnly(string deci)
        {
            decimal val;
            if (decimal.TryParse(deci, out val))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Validates the max num of days in month per month
        private bool validateDay(string month, int enteredDay)
        {
            int maxDays;
            int minDays = 0;
            int maxMonths = 12;
            int minMonths = 1;
            int monthInt = Convert.ToInt32(month);

            // jan 31
            if (month == "1" || month == "01")
            {
                maxDays = 31;
                if (enteredDay > maxDays || enteredDay < minDays)
                {
                    return false;
                }
                return true;
            }
            // feb 28
            else if (month == "2" || month == "02")
            {
                maxDays = 28;
                if (enteredDay > maxDays || enteredDay < minDays)
                {
                    return false;
                }
                return true;
            }
            // mar 31
            else if (month == "3" || month == "03")
            {
                maxDays = 31;
                if (enteredDay > maxDays || enteredDay < minDays)
                {
                    return false;
                }
                return true;
            }
            // apr 30
            else if (month == "4" || month == "04")
            {
                maxDays = 30;
                if (enteredDay > maxDays || enteredDay < minDays)
                {
                    return false;
                }
                return true;
            }
            // may 31
            else if (month == "5" || month == "05")
            {
                maxDays = 31;
                if (enteredDay > maxDays || enteredDay < minDays)
                {
                    return false;
                }
                return true;
            }
            // jun 30
            else if (month == "6" || month == "06")
            {
                maxDays = 30;
                if (enteredDay > maxDays || enteredDay < minDays)
                {
                    return false;
                }
                return true;
            }
            // july 31
            else if (month == "7" || month == "07")
            {
                maxDays = 31;
                if (enteredDay > maxDays || enteredDay < minDays)
                {
                    return false;
                }
                return true;
            }
            // aug 31
            else if (month == "8" || month == "08")
            {
                maxDays = 31;
                if (enteredDay > maxDays || enteredDay < minDays)
                {
                    return false;
                }
                return true;
            }
            // sep 30
            else if (month == "9" || month == "09")
            {
                maxDays = 30;
                if (enteredDay > maxDays || enteredDay < minDays)
                {
                    return false;
                }
                return true;
            }
            // oct 31
            else if (month == "10" || month == "10")
            {
                maxDays = 31;
                if (enteredDay > maxDays || enteredDay < minDays)
                {
                    return false;
                }
                return true;
            }
            // nov 30
            else if (month == "11" || month == "11")
            {
                maxDays = 30;
                if (enteredDay > maxDays || enteredDay < minDays)
                {
                    return false;
                }
                return true;
            }
            // dec 31
            else if (month == "12" || month == "12")
            {
                maxDays = 31;
                if (enteredDay > maxDays || enteredDay < minDays)
                {
                    return false;
                }
                return true;
            }
            else if (monthInt > maxMonths || monthInt < minMonths)
            {
                return false;
            }
            return true;
        }

    }
}
