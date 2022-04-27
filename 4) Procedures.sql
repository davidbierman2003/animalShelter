USE animal_medical;

#Inserts new record into the animal table.
DROP PROCEDURE IF EXISTS Insert_Values;
DELIMITER $
CREATE PROCEDURE Insert_Values(IN p_animal_name VARCHAR(100), IN p_kennel_num VARCHAR(20), in p_species VARCHAR(3), in p_birth_date DATE,
IN p_sex VARCHAR(10), IN p_altered BOOL, IN p_intake_date DATE)
BEGIN
	DECLARE species_int INT default NULL;
    
    IF p_species = "Dog" THEN
    SET species_int = 1;
	ELSEIF p_species = "Cat" THEN
	SET species_int = 2;
	END IF;
    INSERT INTO animal (animal_name, kennel_id, birth_date, species, sex, altered, intake_date) 
    VALUES (p_animal_name, 
    (SELECT kennel_ID FROM kennel WHERE kennel_description = p_kennel_num), 
    p_birth_date,species_int, p_sex, p_altered, p_intake_date);

END$
DELIMITER ;

CALL Insert_Values("Toby", "F-05", "cat", '2020-00-00', "male", 1, '2022-04-04');
CALL Insert_Values("Molly", "F-06", "Cat", '2019-10-05', "female", 0,Null);
CALL Insert_Values("Kevin", "F-07", "dog", '2015-01-00', "MALE", 1,NULL);
CALL Insert_Values("Fido", "F-08", "DOG", '2017-06-00', "Female", 1,NULL);

#Returns the last added record enabling users to confirm everything entered correctly.
DROP PROCEDURE IF EXISTS Check_Last_Animal;
DELIMITER $
CREATE PROCEDURE Check_Last_Animal()
BEGIN
	SELECT * FROM animal WHERE animal_id = LAST_INSERT_ID();
END$
DELIMITER ;

CALL Check_Last_Animal();

#Sets altered equal to true for the animal associated with the animal id passed to the function.
DROP PROCEDURE IF EXISTS Alter_Animal;
DELIMITER $
CREATE PROCEDURE Alter_Animal(IN p_animal_id INT)
BEGIN
	UPDATE animal SET altered = '1' WHERE animal_id = p_animal_id;
END$
DELIMITER ;

CALL Alter_Animal(Last_Insert_ID());
SELECT * FROM animal WHERE animal_id = Last_Insert_ID();