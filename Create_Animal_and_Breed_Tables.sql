USE animal_shelter;

CREATE TABLE Animal (
    animal_id INT NOT NULL,
    name VARCHAR(50),
    sex INT,
    birthdate DATE,
    microship_id VARCHAR(15),
    due_out_date DATE,
    intake_date DATE,
    notes VARCHAR(255),
    weight DECIMAL(5 , 2 ),
    kennel VARCHAR(20),
    species_id INT,
    PRIMARY KEY (animal_id)
);

CREATE TABLE AnimalBreed (
    breed_id INT NOT NULL,
    animal_id INT NOT NULL,
    PRIMARY KEY (breed_id , animal_id),
    FOREIGN KEY (animal_id)
        REFERENCES Animal (animal_id),
    FOREIGN KEY (breed_id)
        REFERENCES Breed (breed_id)
);

CREATE TABLE Breed (
    breed_id INT NOT NULL,
    breed_name VARCHAR(50),
    PRIMARY KEY (breed_id)
);