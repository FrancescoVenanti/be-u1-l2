using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    internal class Persona
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public string GetName()
        {
            return Name;
        }
        public string GetCognome()
        {
            return Surname;
        }
        public int GetAge()
        {
            return Age;
        }

        public string GetDetails()
        {
            return $"nome: {Name} Cognome: {Surname} eta': {Age}";
        }
        public Persona(string nome, string cognome, int age) { 
            this.Name = nome;
            this.Surname = cognome;
            this.Age = age;
        }
    }
}
