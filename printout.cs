using System;

namespace prjCovidVac {
    class printout {
        info i = new info();
        public void printoutHospital() {
            Console.Clear();
            Console.WriteLine("HOSPITAL REPORT\n---------------------------------------------------");
            Console.WriteLine("Hospital Name: \t\t\t" + i.getHospital());
            Console.WriteLine("Hospital Address: \t\t" + i.getAddress());
            Console.WriteLine("Hospital Type: \t\t\t" + i.getType());
            Console.WriteLine("Hospital Province: \t\t" + i.getProvince());
            Console.WriteLine("---------------------------------------------------");
        }
        public void printoutPatients() {
            for(int x = 0; x < i.size(); x++ ) {
                Console.WriteLine("PATIENT: " + (x+1) + " REPORT\n---------------------------------------------------");
                Console.WriteLine("Patient ID: \t\t\t" + i.getID(x));
                Console.WriteLine("Patient Name: \t\t\t" + i.getName(x));
                Console.WriteLine("Patient Surname: \t\t" + i.getSurname(x));
                Console.WriteLine("Patient Referring Doctor: \t" + i.getRefDr(x));
                Console.WriteLine("Patient Blood Type: \t\t" + i.getBloodType(x));
                Console.WriteLine("Patient Allergies: \t\t" + i.getAllergies(x));
                Console.WriteLine("Patient had Covid?: \t\t" + i.getCovidPositive(x));
                Console.WriteLine("Patient Vaccine: \t\t" + i.getVaccine(x));
                Console.WriteLine("---------------------------------------------------");
            }
        }
    }
}