using System.Collections.Generic;

namespace Assembly1
{
    public class Person
    {
        #region Properties

        public List<Person> Persons;
        protected internal string ID { get; set; }
        internal int Age { get; set; }
        public string FirstName { get; set; }
        public string LasName { get; set; }
        public string EmailAddress { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        #endregion

        #region Constructor

        public Person()
        {
            Persons = new List<Person>();
        }

        #endregion

        #region Methods

        public void AddPerson(Person p)
        {
            Persons.Add(p);
        }

        public void RemovePerson(string Id)
        {
            Persons.RemoveAll(x => x.ID == Id);
        }

        #endregion
    }
}