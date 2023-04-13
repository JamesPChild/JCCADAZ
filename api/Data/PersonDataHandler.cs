using System.Data.Common;
using System.Collections.Generic;
using System.Dynamic;
using api.Interfaces;
using api.Model;

namespace api.Data
{
    public class PersonDataHandler : IPersonDataHandler
    {
        private Database db;
        public PersonDataHandler(){
            db = new Database();
        }
        public void Delete(Person person)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Person person)
        {
            throw new System.NotImplementedException();
        }

        public List<Person> Select()
        {
            db.Open();
            string sql = "SELECT * FROM person";
            List<ExpandoObject> results = db.Select(sql);

            List<Person> people = new List<Person>();
            foreach(dynamic item in results){
                Person temp = new Person(){
                    ID = item.id,
                    FirstName = item.first_name,
                    LastName = item.last_name,
                    Major = item.major,
                    Minor = item.minor,
                    Pledge = item.pledge_class,
                    GraduatingSemester = item.graduation_semester,
                    GradSchool = item.university,
                    Employed = item.employed,
                    Position = item.position,
                    Company = item.company,
                    City = item.city,
                    Email = item.email,
                };
                people.Add(temp);
            }
            db.Close();
            return people;
        }

        public void Update(Person person)
        {
            throw new System.NotImplementedException();
        }
    }
}