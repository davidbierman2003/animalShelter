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

        public static AnimalMedical.speciesDataTable GetSpecies()
        {
            AnimalMedical.speciesDataTable dtSpeciesTable = new AnimalMedical.speciesDataTable();
            AnimalMedicalTableAdapters.speciesTableAdapter speciesAdapter = new AnimalMedicalTableAdapters.speciesTableAdapter();
            speciesAdapter.Fill(dtSpeciesTable);

            return dtSpeciesTable;
        }

        public static AnimalMedical.breedDataTable GetBreed()
        {
            AnimalMedical.breedDataTable dtBreedTable = new AnimalMedical.breedDataTable();
            AnimalMedicalTableAdapters.breedTableAdapter breedAdapter = new AnimalMedicalTableAdapters.breedTableAdapter();
            breedAdapter.Fill(dtBreedTable);

            return dtBreedTable;
        }
        public static AnimalMedical.colorDataTable GetColors()
        {
            AnimalMedical.colorDataTable dtColorTable = new AnimalMedical.colorDataTable();
            AnimalMedicalTableAdapters.colorTableAdapter colorAdapter = new AnimalMedicalTableAdapters.colorTableAdapter();
            colorAdapter.Fill(dtColorTable);
            
            return dtColorTable;
        }

        public static AnimalMedical.sexDataTable GetSexID()
        {
            AnimalMedical.sexDataTable dtSexTable = new AnimalMedical.sexDataTable();
            AnimalMedicalTableAdapters.sexTableAdapter sexAdapter = new AnimalMedicalTableAdapters.sexTableAdapter();
            sexAdapter.Fill(dtSexTable);

            return dtSexTable;
        }

        public static void SaveAnimal(string animalId,string name, int sex, DateTime birthdate, string microchipId, 
            DateTime dueOutDate, DateTime intakeDate, string notes, Decimal weight, string kennel, int speciesId, bool altered)
        {
            //AnimalTable and the New Row technique to have new row inserted to the database.

            AnimalMedical.animalDataTable dtAnimalTable = new AnimalMedical.animalDataTable(); // creating in memory table dtAnimalTable
            AnimalMedicalTableAdapters.animalTableAdapter animalAdapter = new AnimalMedicalTableAdapters.animalTableAdapter();
            animalAdapter.Fill(dtAnimalTable);

            AnimalMedical.animalRow newAnimalRow = dtAnimalTable.NewanimalRow();

            newAnimalRow.db_bridge_id = animalId;
            newAnimalRow.name = name;
            newAnimalRow.sex = (byte)sex;
            newAnimalRow.birthdate = birthdate;
            newAnimalRow.microchip_id = microchipId;
            newAnimalRow.due_out_date = dueOutDate;
            newAnimalRow.intake_date = intakeDate;
            //newAnimalRow.notes = Notes;
            newAnimalRow.weight = weight;
            newAnimalRow.kennel = kennel;
            //newAnimalRow.species_id = SpeciesId;
            newAnimalRow.altered = altered;

            //Setting the database ID number -- it is auto-increment but it needs to be set here, MySQL dosen't do it
            newAnimalRow.animal_id = default;

            dtAnimalTable.AddanimalRow(newAnimalRow);

            animalAdapter.Update(dtAnimalTable);
        }
    }
}

