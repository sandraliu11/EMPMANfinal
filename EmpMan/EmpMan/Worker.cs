// Worker Class
// This is a node class (not inherited by any other class)
// Responsible for all processing related to a Worker
// Written in VB by Joseph Jupin Fall 2009
// Converted to CSharp by Frank Friedman Spring 2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// For serialization
using System.Runtime.Serialization.Formatters.Binary;

namespace EmpMan
{
    // Worker inherits the data and methods in Employee and Person
    // and can be a serialized to a binary file
    [Serializable()]
    class Worker : Employee
    {
        private Decimal HiddenWorkerPay; // Bonus amount
                                         // Parameterless constructor
        public Worker()
        {
            HiddenWorkerPay = 0m;
        } // end Worker parameterless constructor
          // Parameterized constructor (not used)
        public Worker(string name, string birthdate, string id, string jt, Decimal p
        ) : base(name, birthdate, id, jt)
        {
            HiddenWorkerPay = p;
        } // end Worker parametierized constructor
          // Accessor/mutator for salary
        public Decimal workerPay
        {
            get
            {
                return HiddenWorkerPay;
            } // end get
            set //(Decimal value)
            {
                HiddenWorkerPay = value;
            } // end get
        } // end Property
          // Accessor/mutator for bonus

          // Save data from form to object
        public override void Save(frmEmpMan f)
        {
            base.Save(f);
            workerPay = Convert.ToDecimal(f.txtWorkerPay.Text);
        } // end Save
          // Display data in object on form
        public override void Display(frmEmpMan f)
        {
            base.Display(f);
            f.txtWorkerPay.Text = workerPay.ToString();
        } // end Display

        // This toString function overrides the Employee toString
        // function. The base refers to the Employee because this class
        // inherits Employee by definition.
        public override string ToString()
        {
            string s = base.ToString() + "\n & ";
            s += "WorkerPay: " + HiddenWorkerPay.ToString();
            return s;
        } // end ToString
    }
}
