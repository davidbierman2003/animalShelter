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
        ///
        #region Get Data from Database
        public static AnimalMedical.unitDataTable GetUnit()
        {
            AnimalMedical.unitDataTable dtUnitTable = new AnimalMedical.unitDataTable(); // creating in memory table dtAnimalTable
            AnimalMedicalTableAdapters.unitTableAdapter unitAdapter = new AnimalMedicalTableAdapters.unitTableAdapter();
            unitAdapter.Fill(dtUnitTable);

            return dtUnitTable;
        }
        public static AnimalMedical.employeeDataTable GetEmployees()
        {
            AnimalMedical.employeeDataTable dtEmployeeTable = new AnimalMedical.employeeDataTable(); // creating in memory table dtAnimalTable
            AnimalMedicalTableAdapters.employeeTableAdapter employeeAdapter = new AnimalMedicalTableAdapters.employeeTableAdapter();
            employeeAdapter.Fill(dtEmployeeTable);

            return dtEmployeeTable;
        }
        public static AnimalMedical.vaccine_administration_logDataTable GetVaccineAdministration()
        {
            AnimalMedical.vaccine_administration_logDataTable dtVaccineAdminTable = new AnimalMedical.vaccine_administration_logDataTable();
            AnimalMedicalTableAdapters.vaccine_administration_logTableAdapter vaccineAdminAdapter = new AnimalMedicalTableAdapters.vaccine_administration_logTableAdapter();
            vaccineAdminAdapter.Fill(dtVaccineAdminTable);
            return dtVaccineAdminTable;
        }

        public static AnimalMedical.vaccineDataTable GetVaccine()
        {
            AnimalMedical.vaccineDataTable dtVaccines = new AnimalMedical.vaccineDataTable();
            AnimalMedicalTableAdapters.vaccineTableAdapter vaccineAdapter = new AnimalMedicalTableAdapters.vaccineTableAdapter();
            vaccineAdapter.Fill(dtVaccines);
            return dtVaccines;
        }
        public static AnimalMedical.medicationDataTable GetMedication()
        {
            AnimalMedical.medicationDataTable dtMedication = new AnimalMedical.medicationDataTable();
            AnimalMedicalTableAdapters.medicationTableAdapter medicalAdapter = new AnimalMedicalTableAdapters.medicationTableAdapter();
            medicalAdapter.Fill(dtMedication);
            return dtMedication;
        }

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
        public static AnimalMedical.admin_methodDataTable GetAdminMethod()
        {
            AnimalMedical.admin_methodDataTable dtAdminMethodTable = new AnimalMedical.admin_methodDataTable();
            AnimalMedicalTableAdapters.admin_methodTableAdapter adminMethodAdapter = new AnimalMedicalTableAdapters.admin_methodTableAdapter();
            adminMethodAdapter.Fill(dtAdminMethodTable);

            return dtAdminMethodTable;
        }
        public static AnimalMedical.medication_admin_methodDataTable GetMedicationAdminMethod()
        {
            AnimalMedical.medication_admin_methodDataTable dtMedsAdminMethodTable = new AnimalMedical.medication_admin_methodDataTable();
            AnimalMedicalTableAdapters.medication_admin_methodTableAdapter medAdminMethodAdapter = new AnimalMedicalTableAdapters.medication_admin_methodTableAdapter();
            medAdminMethodAdapter.Fill(dtMedsAdminMethodTable);

            return dtMedsAdminMethodTable;
        }
        public static AnimalMedical.kennelDataTable GetKennel()
        {
            AnimalMedical.kennelDataTable dtKennelTable = new AnimalMedical.kennelDataTable();
            AnimalMedicalTableAdapters.kennelTableAdapter kennelAdapter = new AnimalMedicalTableAdapters.kennelTableAdapter();
            kennelAdapter.Fill(dtKennelTable);

            return dtKennelTable;
        }
        //NOTE: CURRENT DATABASE DOES NOT HAVE A TABLE FOR GENDER
        //public static AnimalMedical.sexDataTable GetSexID()
        //{
        //    AnimalMedical.sexDataTable dtSexTable = new AnimalMedical.sexDataTable();
        //    AnimalMedicalTableAdapters.sexTableAdapter sexAdapter = new AnimalMedicalTableAdapters.sexTableAdapter();
        //    sexAdapter.Fill(dtSexTable);

        //    return dtSexTable;
        //}
        #endregion
        #region Save to Database
        public static void SaveVaccineAdmin(int animalId, int vaccine_id, int employee_id, DateTime dateGiven, DateTime nextDueDate)
        {
            AnimalMedical.vaccine_administration_logDataTable dtVaccineAdminTable = new AnimalMedical.vaccine_administration_logDataTable();
            AnimalMedicalTableAdapters.vaccine_administration_logTableAdapter vaccineAdminAdapter = new AnimalMedicalTableAdapters.vaccine_administration_logTableAdapter();
            vaccineAdminAdapter.Fill(dtVaccineAdminTable);

            AnimalMedical.vaccine_administration_logRow vaccineAdminRow = dtVaccineAdminTable.Newvaccine_administration_logRow();

            vaccineAdminRow.animal_id = animalId;
            vaccineAdminRow.vaccine_id = vaccine_id;
            vaccineAdminRow.employee_id = employee_id;
            vaccineAdminRow.date_given = dateGiven;
            vaccineAdminRow.next_date_due = nextDueDate;

            vaccineAdminRow.vaccine_log_ID = default;

            dtVaccineAdminTable.Addvaccine_administration_logRow(vaccineAdminRow);

            vaccineAdminAdapter.Update(dtVaccineAdminTable);


        }
        public static void SaveAnimal(string animalId,string name, string sex, DateTime birthdate, string microchipId, 
            DateTime dueOutDate, DateTime intakeDate, string notes, Decimal weight, int kennel, int speciesId, bool altered)
        {
            //AnimalTable and the New Row technique to have new row inserted to the database.

            AnimalMedical.animalDataTable dtAnimalTable = new AnimalMedical.animalDataTable(); // creating in memory table dtAnimalTable
            AnimalMedicalTableAdapters.animalTableAdapter animalAdapter = new AnimalMedicalTableAdapters.animalTableAdapter();
            animalAdapter.Fill(dtAnimalTable);

            AnimalMedical.animalRow newAnimalRow = dtAnimalTable.NewanimalRow();

            newAnimalRow.db_bridge_id = animalId;
            newAnimalRow.animal_name = name;
            newAnimalRow.sex = sex;
            newAnimalRow.birth_date = birthdate;
            newAnimalRow.micro_chip = microchipId;
            newAnimalRow.due_out_date = dueOutDate;
            newAnimalRow.intake_date = intakeDate;
            //newAnimalRow.notes = Notes;
            newAnimalRow.weight = (double)weight;
            newAnimalRow.kennel_id = kennel;
            //newAnimalRow.species_id = SpeciesId;
            newAnimalRow.altered = altered;

            //Setting the database ID number -- it is auto-increment but it needs to be set here, MySQL dosen't do it
            newAnimalRow.animal_id = default;

            dtAnimalTable.AddanimalRow(newAnimalRow);

            animalAdapter.Update(dtAnimalTable);
        }
        public static void SaveEmployee(int empId, string firstname, string lastname)
        {
            AnimalMedical.employeeDataTable dtEmpTable = new AnimalMedical.employeeDataTable();
            AnimalMedicalTableAdapters.employeeTableAdapter empAdapter = new AnimalMedicalTableAdapters.employeeTableAdapter();
            empAdapter.Fill(dtEmpTable);

            AnimalMedical.employeeRow newEmpRow = dtEmpTable.NewemployeeRow();
            newEmpRow.employee_id = empId;
            newEmpRow.firstname = firstname;
            newEmpRow.lastname = lastname;

            dtEmpTable.AddemployeeRow(newEmpRow);

            empAdapter.Update(dtEmpTable);
        }
        public static void SavePrescription(int animalId, int medicationId, string animaldose, int method, DateTime startdate, DateTime enddate, string staff, int frequencyid, string notes)
        {
            AnimalMedical.prescriptionDataTable dtPrescriptionTable = new AnimalMedical.prescriptionDataTable();
            AnimalMedicalTableAdapters.prescriptionTableAdapter prescriptionTableAdapter = new AnimalMedicalTableAdapters.prescriptionTableAdapter();
            prescriptionTableAdapter.Fill(dtPrescriptionTable);
            
            AnimalMedical.prescriptionRow newPrescription = dtPrescriptionTable.NewprescriptionRow();
            newPrescription.animal_id = animalId; //Note: this is the DATABASE animal ID, not the shelter A# id
            newPrescription.medication_id = medicationId;
            newPrescription.animal_specific_dose = animaldose;
            newPrescription.animal_specific_method_id = method;  
            newPrescription.start_date = startdate;
            newPrescription.end_date = enddate;
            newPrescription.assigned_staff = staff;
            newPrescription.notes = notes;
            newPrescription.frequency_id = frequencyid;

            newPrescription.prescription_id = default; //Database auto generates this number

            dtPrescriptionTable.AddprescriptionRow(newPrescription);
            prescriptionTableAdapter.Update(dtPrescriptionTable);
        }
        #endregion
        #region Delete from Database
        public static void DeleteEmployee(int rowindex)
        {
            AnimalMedical.employeeDataTable dtEmployeesTable = new AnimalMedical.employeeDataTable();
            AnimalMedicalTableAdapters.employeeTableAdapter empAdapter = new AnimalMedicalTableAdapters.employeeTableAdapter();
            empAdapter.Fill(dtEmployeesTable);

            dtEmployeesTable.Rows[rowindex].Delete();

            empAdapter.Update(dtEmployeesTable);
        }
        public static void DeleteAnimal(int rowindex)
        {
            AnimalMedical.animalDataTable dtAnimalTable = new AnimalMedical.animalDataTable();
            AnimalMedicalTableAdapters.animalTableAdapter animalAdapter = new AnimalMedicalTableAdapters.animalTableAdapter();
            animalAdapter.Fill(dtAnimalTable);

            dtAnimalTable.Rows[rowindex].Delete();

            animalAdapter.Update(dtAnimalTable);
        }
        #endregion
        #region Edit the Database
        public static void EditEmployee(int empId, string firstname, string lastname)
        {
            AnimalMedical.employeeDataTable dtEmpTable = new AnimalMedical.employeeDataTable();
            AnimalMedicalTableAdapters.employeeTableAdapter empAdapter = new AnimalMedicalTableAdapters.employeeTableAdapter();
            empAdapter.Fill(dtEmpTable);

            var rowToEdit = dtEmpTable.Where(x => x.employee_id == empId).ToList();

            rowToEdit[0].employee_id = empId;
            rowToEdit[0].firstname = firstname;
            rowToEdit[0].lastname = lastname;

            empAdapter.Update(dtEmpTable);
        }
        #endregion
    }
}

