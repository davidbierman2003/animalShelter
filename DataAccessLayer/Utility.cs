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
        public static AnimalMedical.animalDataTable GetAnimals()
        {
            AnimalMedical.animalDataTable dtAnimalTable = new AnimalMedical.animalDataTable();  //creating in memory table dtAnimalTable
            AnimalMedicalTableAdapters.animalTableAdapter animalAdater = new AnimalMedicalTableAdapters.animalTableAdapter(); //component used to fill the dtAnimalTable with the database Animal table data
            animalAdater.Fill(dtAnimalTable); //fill dtAnimalTable with the data stored in the databases Animal table 

            return dtAnimalTable; //return entire Animal table
        }


        public static void SaveAnimal(int AnimalID,string Name, int Sex, DateTime BirthDate, string MicroshipId, 
            DateTime DueOutDate, DateTime IntakeDate, string Notes, Decimal Weight, string Kennel, int SpeciesId)
        {
            //AnimalTable and the New Row technique to have new row inserted to the database.

            AnimalMedical.animalDataTable dtAnimalTable = new AnimalMedical.animalDataTable(); // creating in memory table dtAnimalTable
            AnimalMedicalTableAdapters.animalTableAdapter animalAdapter = new AnimalMedicalTableAdapters.animalTableAdapter();
            animalAdapter.Fill(dtAnimalTable);

            AnimalMedical.animalRow newAnimalRow = dtAnimalTable.NewanimalRow();

            newAnimalRow.animal_id = AnimalID;
            newAnimalRow.name = Name;
            newAnimalRow.sex = Sex;
            newAnimalRow.birthdate = BirthDate;
            newAnimalRow.microship_id = MicroshipId;
            newAnimalRow.due_out_date = DueOutDate;
            newAnimalRow.intake_date = IntakeDate;
            newAnimalRow.notes = Notes;
            newAnimalRow.weight = Weight;
            newAnimalRow.kennel = Kennel;
            newAnimalRow.species_id = SpeciesId;

            dtAnimalTable.AddanimalRow(newAnimalRow);

            animalAdapter.Update(dtAnimalTable);
            
        }
    }
}

