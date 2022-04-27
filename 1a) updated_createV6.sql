DROP DATABASE IF EXISTS animal_medical;
CREATE DATABASE animal_medical;
USE animal_medical;

CREATE TABLE species (
	species_id INT PRIMARY KEY,
    species_name VARCHAR(255)
);

CREATE TABLE kennel (
	kennel_id INT PRIMARY KEY AUTO_INCREMENT,
    kennel_description VARCHAR(30)
    );
    

CREATE TABLE animal (
    animal_id INT AUTO_INCREMENT,
    db_bridge_id VARCHAR(20),
    kennel_id INT,
    animal_name VARCHAR(100),
    species INT,
    birth_date DATE,
    sex VARCHAR(10),
    altered BOOL,
    micro_chip VARCHAR(20),
    due_out_date DATE,
    intake_date DATE,
    weight DOUBLE,
    adopted BOOL,
    Active BOOL default TRUE,
    PRIMARY KEY (animal_id),
    FOREIGN KEY (species) REFERENCES species(species_id),
    FOREIGN KEY (kennel_ID) REFERENCES kennel(Kennel_id)
    );
    
CREATE TABLE breed (
	breed_id INT,
    breed_name VARCHAR(255),
    species_id INT,
    PRIMARY KEY (breed_id),
    FOREIGN KEY (species_id) REFERENCES species(species_id)
    );

    
CREATE TABLE animal_breed (
    animal_breed INT auto_increment,
    animal_id INT,
    Breed_id INT,
    PRIMARY KEY (animal_breed),
    FOREIGN KEY (animal_id)
        REFERENCES animal (animal_id)
        ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (breed_id)
        REFERENCES breed (breed_id)
        ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE color (
	color_id INT,
    color_name VARCHAR(255),
    color_option BOOL DEFAULT TRUE,
    PRIMARY KEY (color_id)
    );
    
CREATE TABLE animal_color (
	animal_color INT auto_increment,
    animal_ID INT,
    color_id INT,
    PRIMARY KEY (animal_color),
    FOREIGN KEY (animal_id)
		REFERENCES animal(animal_id)
        ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (color_id)
		REFERENCES color (color_id)
        ON DELETE CASCADE ON UPDATE CASCADE
);
CREATE TABLE notes(
	note_id INT auto_increment NOT NULL,
    animal_id INT,
    note_data DATE,
    note_details VARCHAR(255),
    PRIMARY KEY (note_id),
    FOREIGN KEY (animal_id)
		REFERENCES Animal (animal_id)
        ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE unit (
	unit_id INT NOT NULL auto_increment,
    unit_name VARCHAR(255),
    PRIMARY KEY (unit_id)
);

CREATE TABLE medication (
	medication_id INT NOT NULL auto_increment,
    medication_name VARCHAR(50),
    unit_id INT,
    concentration VARCHAR(50),
    dose VARCHAR(150),
    PRIMARY KEY (medication_id),
    FOREIGN KEY (unit_id)
		REFERENCES unit(unit_id)
);

CREATE TABLE vaccine(
	vaccine_id INT NOT NULL auto_increment,
    vaccine_name VARCHAR(25),
    lot_id VARCHAR(50),
    expiration DATE,
    concentration VARCHAR(50),
    PRIMARY KEY(vaccine_id)
);

CREATE TABLE admin_method (
	admin_method_id INT NOT NULL auto_increment,
    admin_method_name VARCHAR(255),
    PRIMARY KEY (admin_method_id)
);

CREATE TABLE medication_admin_method (
	medication_id INT NOT NULL,
    admin_method_id INT NOT NULL,
	FOREIGN KEY (medication_id)
        REFERENCES medication (medication_id),
    FOREIGN KEY (admin_method_id)
        REFERENCES admin_method (Admin_method_id)
);
CREATE TABLE employee(
	employee_id INT NOT NULL auto_increment,
    firstname VARCHAR(25) NOT NULL,
    lastname VARCHAR(25) NOT NULL,
    PRIMARY KEY (employee_id)
);
CREATE TABLE vaccine_administration_log(
	vaccine_log_ID INT NOT NULL auto_increment,
    animal_id INT NOT NULL,
    vaccine_id INT NOT NULL,
    employee_id INT NOT NULL,
    date_given DATE NOT NULL,
    next_date_due DATE NOT NULL,
    PRIMARY KEY (vaccine_log_id),
    FOREIGN KEY (animal_id)
		REFERENCES animal (animal_id)
        ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (vaccine_id)
		REFERENCES Vaccine (vaccine_id)
        ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (employee_id)
		REFERENCES employee (employee_id)
        ON DELETE RESTRICT ON UPDATE CASCADE
);
CREATE TABLE medication_administration_log(
	med_log_id INT NOT NULL auto_increment,
    animal_id INT NOT NULL,
    medication_id INT NOT NULL,
    employee_id INT NOT NULL,
    datetime_given DATETIME NOT NULL,
    PRIMARY KEY (med_log_id),
    FOREIGN KEY (animal_id)
		REFERENCES animal (animal_id)
        ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (medication_id)
		REFERENCES medication (medication_id)
        ON DELETE RESTRICT ON UPDATE CASCADE,
	FOREIGN KEY (employee_id)
		REFERENCES employee (employee_id)
        ON DELETE RESTRICT ON UPDATE CASCADE
);
/*Because the front end team is still trying to figure this table out, 
the entites can be null and desc will have a name: Desc_value (because
'DESC' is a key word) and will have a data type of: VARCHAR*/
CREATE TABLE frequency(
	frequency_id INT NOT NULL auto_increment,
    num_times INT,
    num_days INT,
    desc_value VARCHAR(255),
    PRIMARY KEY (frequency_id)
);
CREATE TABLE prescription (
	prescription_id INT NOT NULL  auto_increment,
    animal_id INT NOT NULL,
    medication_id INT NOT NULL,
    frequency_id INT NOT NULL,
    animal_specific_dose VARCHAR(10) NOT NULL,
    animal_specific_method_id INT NOT NULL,/*I am not sure if this is a foreign or not*/
    start_date DATE NOT NULL,
    end_date DATE,
    assigned_staff VARCHAR(100),
    notes VARCHAR(1000),
    PRIMARY KEY (prescription_id),
    FOREIGN KEY (animal_id)
		REFERENCES animal (animal_id)
        ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (medication_ID)
		REFERENCES medication (medication_id)
        ON DELETE RESTRICT ON UPDATE CASCADE,
	FOREIGN KEY (frequency_id)
		REFERENCES frequency (frequency_id)
        ON DELETE CASCADE ON UPDATE CASCADE
);


SELECT * FROM notes;
SELECT * FROM vaccine;
SELECT * FROM medication;
SELECT * FROM species;
SELECT * FROM color;
SELECT * FROM breed;
SELECT * FROM animal_color;
SELECT * FROM animal_breed;
SELECT * FROM animal;
SELECT * FROM unit;
SELECT * FROM admin_method;
SELECT * FROM medication_admin_method;
SELECT * FROM kennel;
SELECT * FROM employee;
SELECT * FROM vaccine_administration_log;
SELECT * FROM prescription;
SELECT * FROM medication_administration_log;
SELECT * FROM frequency;
