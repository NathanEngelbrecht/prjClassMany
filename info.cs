using System;

namespace prjCovidVac {
    class info {
        //Special student variables
        private static int iSizeArray = 0;
        private static int iCounter = 0;


        private static String strHospital_Name;
        private static String strAddress;
        private static string bType; //privat or public hospital
        private static string cProvince;


        public void setHospital(string hosp) {
            strHospital_Name = hosp;
        }
        public string getHospital(){
            return strHospital_Name;
        }
        public void setAddress(string addr) {
            strAddress = addr;
        }
        public string getAddress() {
            return strAddress;
        }
        public void setType(string tp) {
            bType = tp;
        }
        public string getType() {
            return bType;
        }
        public void setProvince(string prov) {
            cProvince = prov;
        }
        public string getProvince() {
            return cProvince;
        }



        private static String[] ID_Number;
        private static String[] MedicalAid;
        private static String[] Name;
        private static String[] Surname;
        private static String[] RefDr;
        private static char[] BloodType;
        private static String[] Allergies;
        private static Boolean[] CovidPositive;
        private static String[] Vaccine;

        public void setArray(int num) {
            ID_Number = new string[num];
            MedicalAid = new string[num];
            Name = new string[num];
            Surname = new string[num];
            RefDr = new string[num];
            BloodType = new char[num];
            Allergies = new string[num];
            CovidPositive = new bool[num];
            Vaccine = new string[num];
            iSizeArray = num;
            Console.WriteLine("no. Patients: " + num);

        }
    
        public void addPerson(string strID, string strMedic, string name, string surname, string strRefdr, char bloodType, string strAllergies, bool bcovid, string strvac) {
            ID_Number[iCounter] = strID;
            MedicalAid[iCounter] = strMedic;
            Name[iCounter] = name;
            Surname[iCounter] = surname;
            RefDr[iCounter] = strRefdr;
            BloodType[iCounter] = bloodType;
            Allergies[iCounter] = strAllergies;
            CovidPositive[iCounter] = bcovid;
            Vaccine[iCounter] = strvac;
            iCounter++;
        }   
        public int size() { return iSizeArray; }  
        public int getiCounter() { return iCounter; }
        public string getID(int x) { return ID_Number[x]; }
        public string getMedic(int x) { return MedicalAid[x]; }
        public string getName(int x) { return Name[x]; }
        public string getSurname(int x) { return Surname[x]; }
        public string getRefDr(int x) { return RefDr[x]; }
        public char getBloodType(int x) {return BloodType[x]; }
        public string getAllergies(int x) {return Allergies[x]; }
        public Boolean getCovidPositive(int x) { return CovidPositive[x]; }
        public string getVaccine(int x) { return Vaccine[x]; }

    }
}