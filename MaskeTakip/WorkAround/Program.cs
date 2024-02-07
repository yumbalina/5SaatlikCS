// See https://aka.ms/new-console-template for more information
using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using System.Runtime.InteropServices;
using System.Text;

Person person1 = new Person();
person1.FirstName = "CEM";
person1.LastName = "GÖRENER";
person1.DateOfBirth = 1998;
person1.NationalIdentity = 11111111111;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);