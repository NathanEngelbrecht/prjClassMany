using System;

namespace prjCovidVac {
    class Program {
        static void Main(string[] args) {
            capture cp = new capture();
            info i = new info();
            printout p = new printout();
            cp.getHospitalInfo();
            cp.getPatientInfo();
            p.printoutHospital();
            p.printoutPatients();
        }
    }
}
