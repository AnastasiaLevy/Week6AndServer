using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DAL
/// </summary>
public class DAL
{


    public partial class Event
    {
        public Event()
        {
            this.Grades = new HashSet<Grade>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Schedule { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }
    }

    public partial class Grade
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public int EventId { get; set; }
        public int PeopleId { get; set; }

        public virtual Event Event { get; set; }
        public virtual Person Person { get; set; }
    }

    public partial class Lab
    {
        public Lab()
        {
            this.People = new HashSet<Person>();
        }

        public int Id { get; set; }
        public System.String Schedule { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }

    public partial class Person
    {
        public Person()
        {
            this.Grades = new HashSet<Grade>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public byte[] Picture { get; set; }
        public int LabId { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }
        public virtual Lab Lab { get; set; }
    }

}