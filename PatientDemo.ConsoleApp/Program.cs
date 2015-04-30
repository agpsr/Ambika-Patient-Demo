using PatientDemo.Domain.Entities;
using System;
using PatientDemo.Domain.Enums;

namespace PatientDemo.ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var address = new Address
			{
			AddressLine1 = "1 West Street", 
		    AddressLine2 = "Tuffley", 
		    PostTown = "Gloucester", 
		    County = "Gloucestershire", 
		    Postcode = "GL4 ONA" 
			};
			
            var myPatient = new Patient  
			 { 
              Surname = "Smith", 
              Forename = "John", 
			  Gender = Gender.Male, 
 	          Height = 1.75f, 
 		      Weight = 75.00f, 
              HomeAddress = address, 
			  DateOfBirth = Convert.ToDateTime("2009/11/09")
            }; 

           Console.WriteLine(myPatient.ToString()); 
           Console.WriteLine(myPatient.HomeAddress.ToString()); 
		   Console.WriteLine(myPatient.Age);
           Console.ReadKey(); 
        } 
    } 
 } 
				
