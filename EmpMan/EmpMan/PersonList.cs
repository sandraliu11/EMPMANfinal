using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMan
{
    [Serializable()]
    public class PersonList
    {
        public List<Person> HiddenPersonList = new List<Person> ();

        //Parameterless constructor for PersonList object 
        public PersonList()
        {
        }

        // Count each time a person is added into the list 
        public int Count()
        {
            return HiddenPersonList.Count();
        }

        // Add new person into person list 
        public void add(Person p)
        {
            HiddenPersonList.Add(p);
        }

        public Person search(string id)
        {
            foreach (Person p in HiddenPersonList)
            {
                if (p.personID == id)
                {
                    return p;
                }
            }
            return null;
        }

        public void searchAndDelete(string id)
        {
            int count = -1;
            foreach (Person p in HiddenPersonList)
            {
                count++;
                if (p.personID == id)
                {
                    HiddenPersonList.RemoveAt(count);
                    break;
                }
            }
        }

        public string printList()
        {
            string personListString = "";
            foreach (Person p in HiddenPersonList)
            {
                personListString += "ID: " + Convert.ToString(p.personID) + " Type: " + Convert.ToString(p.GetType()) + "\n";
            }
            return personListString;
        }
    }
}
