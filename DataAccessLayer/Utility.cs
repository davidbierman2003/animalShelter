﻿using System;
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
            //try { colorAdapter.Fill(dtColorTable); }
            //catch (Exception ex){
            //    foreach (AnimalMedical.colorRow dr in dtColorTable)
            //    {
            //        if (dr.HasErrors)
            //        {
            //            System.Diagnostics.Debug.Write("Row ");
            //            foreach (System.Data.DataColumn dc in dtColorTable.PrimaryKey)
            //                System.Diagnostics.Debug.Write(dc.ColumnName + ": '" + dr.ItemArray[dc.Ordinal] + "', ");
            //            System.Diagnostics.Debug.WriteLine(" has error: " + dr.RowError);
            //        }
            //    }
            //}

            return dtColorTable;
        }

        public static AnimalMedical.sexDataTable GetSexID()
        {
            AnimalMedical.sexDataTable dtSexTable = new AnimalMedical.sexDataTable();
            AnimalMedicalTableAdapters.sexTableAdapter sexAdapter = new AnimalMedicalTableAdapters.sexTableAdapter();
            sexAdapter.Fill(dtSexTable);

            return dtSexTable;
        }

        public static void SaveAnimal(int AnimalID,string Name, int Sex, DateTime BirthDate, string MicroshipId, 
            DateTime DueOutDate, DateTime IntakeDate, string Notes, Decimal Weight, string Kennel, int SpeciesId)
        {
            //AnimalTable and the New Row technique to have new row inserted to the database.

            AnimalMedical.animalDataTable dtAnimalTable = new AnimalMedical.animalDataTable(); // creating in memory table dtAnimalTable
            AnimalMedicalTableAdapters.animalTableAdapter animalAdapter = new AnimalMedicalTableAdapters.animalTableAdapter();
            animalAdapter.Fill(dtAnimalTable);

            AnimalMedical.animalRow newAnimalRow = dtAnimalTable.NewanimalRow();

            newAnimalRow.animal_id = (uint)AnimalID;
            newAnimalRow.name = Name;
            newAnimalRow.sex = (uint)Sex;
            newAnimalRow.birthdate = BirthDate;
            newAnimalRow.microchip_id = MicroshipId;
            newAnimalRow.due_out_date = DueOutDate;
            newAnimalRow.intake_date = IntakeDate;
            //newAnimalRow.notes = Notes;
            newAnimalRow.weight = Weight;
            newAnimalRow.kennel = Kennel;
            //newAnimalRow.species_id = SpeciesId;

            dtAnimalTable.AddanimalRow(newAnimalRow);

            animalAdapter.Update(dtAnimalTable);
            
        }
    }
}

