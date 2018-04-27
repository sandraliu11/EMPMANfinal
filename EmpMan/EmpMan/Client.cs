using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMan
{
    // Client inherits the data and methods in Person
    // and can be a serialized to a binary file
    [Serializable()]
    class Client : Person
    {
        private String HiddenClientType;

        // constructor with parameters
        public Client(string name, string birthdate, string id, string ct) : base(name, birthdate, id)
        {
            HiddenClientType = ct;
        }

        public Client()
        {
            HiddenClientType = "";
        } // end Person Non-parameterized Constructor

        // Accessor/mutator for client type
        public String clientType
        {
            get
            {
                return HiddenClientType;
            } // end get
            set //(Decimal value)
            {
                HiddenClientType = value;
            } // end get
        } // end Property

        // Save data from form to object
        public override void Save(frmEmpMan f)
        {
            base.Save(f);
            clientType = Convert.ToString(f.txtClientType.Text);
        } // end Save

          // Display data in object on form
        public override void Display(frmEmpMan f)
        {
            base.Display(f);
            f.txtClientType.Text = clientType.ToString();
        } // end Display

        // This toString function overrides the Person toString
        // function. The base refers to the Person because this class
        // inherits Person by definition.
        public override string ToString()
        {
            string s = base.ToString() + "\n ";
            s += " ClientType: &" + HiddenClientType.ToString();
            return s;
        } // end ToString
    }
}
