using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMan
{
    // Employee inherits the data and methods in Person
    // and can be a serialized to a binary file
    [Serializable()]
    class Employee : Person
    {
        private String HiddenEmployeeJobTitle;

        // constructor with parameters
        public Employee (string name, string birthdate, string id, string jt) : base(name, birthdate, id)
        {
            HiddenEmployeeJobTitle = jt;
        }

        public Employee()
        {
            HiddenEmployeeJobTitle = "";
        } // end Person Non-parameterized Constructor

        // Accessor/mutator for job title
        public String employeeJobTitle
        {
            get
            {
                return HiddenEmployeeJobTitle;
            } // end get
            set //(Decimal value)
            {
                HiddenEmployeeJobTitle = value;
            } // end get
        } // end Property

        // Save data from form to object
        public override void Save(frmEmpMan f)
        {
            base.Save(f);
            employeeJobTitle = Convert.ToString(f.txtWorkerTitle.Text);
        } // end Save
          // Display data in object on form
        public override void Display(frmEmpMan f)
        {
            base.Display(f);
            f.txtWorkerTitle.Text = employeeJobTitle.ToString();
        } // end Display

          // This toString function overrides the Person toString
          // function. The base refers to the Person because this class
          // inherits Person by definition.
        public override string ToString()
        {
            string s = base.ToString() + "\n ";
            s += " EmployeeJobTitle: &" + HiddenEmployeeJobTitle.ToString();
            return s;
        } // end ToString
    }
}
