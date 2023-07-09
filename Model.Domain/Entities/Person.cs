using Model.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Model.Domain.Entities
{
    public sealed class Person
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Document { get; private set; }
        public string Phone { get; private set; }

        public Person(string document, string name, string phone)
        {
            Validation(document, name, phone);
        }

        public Person(int id, string document, string name, string phone)
        {
            DomainValidationException.When(id < 0, "Id deve ser maior que zero");
            Validation(document, name, phone);
        }
        private void Validation(string document, string name, string phone)
        {
            DomainValidationException.When(string.IsNullOrEmpty(name), "Name deve ser informado!");
            DomainValidationException.When(string.IsNullOrEmpty(document), "Document deve ser informado!");
            DomainValidationException.When(string.IsNullOrEmpty(phone), "Phone deve ser informado!");

            Name = name;
            Document = document;
            Phone = phone;
        }
    }
}
