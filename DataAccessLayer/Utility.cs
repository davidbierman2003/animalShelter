using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    /// <summary>
    /// Used to access the animal_medical database
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// GetAnimal: returns all data from the Animal table
        /// </summary>
        public static AnimalMedical.animalDataTable GetAnimal() 
        {
            AnimalMedical.animalDataTable dtAnimalTable = new AnimalMedical.animalDataTable();  //creating in memory table dtAnimalTable
            AnimalMedicalTableAdapters.animalTableAdapter animalAdater = new AnimalMedicalTableAdapters.animalTableAdapter(); //component used to fill the dtAnimalTable with the database Animal table data
            animalAdater.Fill(dtAnimalTable); //fill dtAnimalTable with the data stored in the databases Animal table 

            return dtAnimalTable; //return entire Animal table
        }
    }
}
