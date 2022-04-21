create database if not exists shelter;
use shelter;
drop table if exists animalbreed;
drop table if exists animalcolor;
drop table if exists animal;
drop table if exists breed;
drop table if exists color;
drop table if exists species;
drop table if exists sex;
drop table if exists vaccine;
drop table if exists Note;
drop table if exists Medication;
drop table if exists Unit;


create table Species (
	species_id smallint unsigned primary key, 
    species_name varchar(50)
);

create table Sex (
	sex_id tinyint unsigned primary key, 
    sex_name varchar(8)
);

create table Animal (
	animal_id smallint unsigned primary key auto_increment,
    db_bridge_id char(7) unique,
    name varchar(50),
    sex tinyint unsigned,
    birthdate date,
    microchip_id varchar(16),
    due_out_date date,
    intake_date date,
    weight decimal(5,2),
    kennel varchar(20),
    altered boolean,
    foreign key (sex) references sex(sex_id)
);

alter table Animal auto_increment = 1000;

create table Breed (
	breed_id smallint unsigned primary key auto_increment,
    breed_name varchar(50) not null,
    species_id smallint unsigned
);

create table AnimalBreed (
	animal_id smallint unsigned,
    breed_id smallint unsigned,
    primary key (animal_id, breed_id),
    foreign key (animal_id) references animal (animal_id),
    foreign key (breed_id) references Breed (breed_id)
);

create table Color (
	color_id smallint unsigned primary key,
    color varchar(50) unique not null
);

create table AnimalColor (
	color_id smallint unsigned,
    animal_id smallint unsigned, 
    primary key (animal_id, color_id),
    foreign key (color_id) references color(color_id),
    foreign key (animal_id) references animal(animal_id)
);

create table Vaccine(
vaccine_id tinyint auto_increment primary key,
vaccine_name varchar(20)
);

create table Note (
    note_id SMALLINT UNSIGNED PRIMARY KEY,
    animal_id SMALLINT UNSIGNED,
    note_date DATE,
    note_details VARCHAR(255),
    FOREIGN KEY (animal_id) REFERENCES Animal (animal_id)
);

create table Unit (
    unit_id SMALLINT UNSIGNED PRIMARY KEY auto_increment,
    unit_name VARCHAR(10)
);

create table Medication (
    medication_id SMALLINT UNSIGNED PRIMARY KEY,
    medication_name VARCHAR(45),
    unit_id SMALLINT UNSIGNED,
    concentration VARCHAR(15),
    dose VARCHAR(110),
    FOREIGN KEY (unit_id) REFERENCES Unit (unit_id)
);


-- INSERT STATEMENTS

SET SQL_SAFE_UPDATES=0;
use shelter;
delete from animalbreed;
delete from animalcolor;
delete from animal;
delete from sex;
delete from species;
delete from breed;
delete from color;
DELETE FROM Unit;
DELETE FROM Medication;


insert into species values
  (0, "Dog"),
  (1, "Cat")
;

insert into sex values
  (0, "Male"),
  (1, "Female")
;

insert into animal (animal_id, db_bridge_id, name, sex, birthdate, due_out_date, kennel, microchip_id)
values
  (1 , 'A211396', "Paycheck", 0, '2020-1-1', '2022-3-18', 'A-01', '981020045319103'),
  (2 , 'A194068', "Aurora",  1, '2016-1-1', '2022-3-16', 'A-02', '839*768*257'),
  (3 , 'A199766', "Simba",  0, '2019-1-1', '2022-3-15', 'A-03', '981020031542500'),
  (4 , 'A211891', "Thor",  0, '2021-2-1', '2022-2-22', 'A-04', '981020039094689'),
  (5 , 'A212013', "Louie",  0, '2015-1-1', '2022-2-28', 'A-05', '982091062394014'),
  (6 , 'A188127', "Buddy",  0, '2016-1-1', '2022-2-24', 'A-06', '981020027153291'),
  (7 , 'A197766', "Jack",  0, '2019-1-1', '2022-3-8', 'A-07', '981020031197300'),
  (8 , 'A211869', "Jessie",  1, '2021-2-1', '2022-3-31', 'A-08', '981020045467771'),
  (9 , 'A212117', "Frank",  0, '2016-1-1', '2022-3-17', 'A-09', '981020000543942'),
  (10 , 'A212244', "Brona",  1, '2021-1-1', '2022-3-14', 'A-10', '981020045342453'),
  (11 , 'A212284', "Titan",  0, '2016-1-1', '2022-3-15', 'A-11', '981020015419874'),
  (12 , 'A212245', "Dalsky",  0, '2019-1-1', '2022-3-14', 'A-12', '981020045325884'),
  (13 , 'A212116', "Lika",  1, '2012-1-1', '2022-3-14', 'A-13', '985112003276062'),
  (14 , 'A212341', "Rufio",  0, '2021-5-1', '2022-3-15', 'A-14', '985113005252838'),
  (15 , 'A184279', "Moose",  0, '2017-1-1', '2022-3-14', 'A-16', '981020023252671'),
  (16 , 'A211797', "Pompadour",  0, '2020-1-1', '2022-2-25', 'H-01', '981020045455942'),
  (17 , 'A212334', "Shadow",  1, '2021-1-1', '2022-3-21', 'H-03', ''),
  (18 , 'A212362', "Chance",  1, '2020-1-1', '2022-3-23', 'H-05', '985141004549767'),
  (19 , 'A195932', "Tyson",  0, '2018-1-1', '2022-3-24', 'H-06', '981020045465077'),
  (20 , 'A211041', "Ziggy",  0, '2021-1-1', '2022-3-31', 'H-07', ''),
  (21 , 'A211768', "Sofia",  1, '2021-1-1', '2022-3-31', 'H-08', '981020045225002'),
  (22 , 'A212031', "Khan",  0, '2020-1-1', '2022-3-24', 'H-09', '981020045527837'),
  (23 , 'A212249', "Chaos",  0, '2015-1-1', '2022-3-23', 'H-10', null),
  (24 , 'A211635', "Sasha",  1, null, '2022-3-31', 'H-11', null),
  (25 , 'A211495', "Brutus",  0, '2020-9-1', '2022-3-24', 'H-14', '981020045363870'),
  (26 , 'A212293', "",  1, null, '2022-3-21', 'H-15', ''),
  (27 , 'A212335', "Blue",  0, '2020-9-1', '2022-3-23', 'H-16', 'Yes'),
  (28 , 'A212397', "",  1, null, '2022-3-23', 'H-17', ''),
  (29 , 'A212398', "",  0, null, '2022-3-23', 'H-17', ''),
  (30 , 'A210725', "Tatiana", 1, '2020-1-1', '2022-2-28', 'H-18', null),
  (31 , 'A212369', "Rip", 0, '2015-1-1', '2022-3-21', 'H-23', ''),
  (32 , 'A211348', "Graceful", 1, '2019-1-1', '2022-3-26', 'H-24', null),
  (33 , 'A212296', "Griffin", 0, null, '2022-3-29', 'H-26', null),
  (34 , 'A212429', "", 0, null, '2022-3-28', 'H-28', null),
  (35 , 'A207659', "Titus", 0, '2016-1-1', '2022-3-24', 'H-37', '839*259*304'),
  (36 , 'A211678', "Lobo", 0, '2019-1-1', '2022-1-27', 'H-38', '981020045358463'),
  (37 , 'A212396', "", 0, null, '2022-3-23', 'H-39', ''),
  (38 , 'A211955', "Leslie", 1, null, '2022-3-20', 'P-01', null),
  (39 , 'A212209', "Dotty", 1, '2021-5-1', '2022-3-21', 'P-04', ''),
  (40 , 'A212374', "", 0, null, '2022-3-22', 'P-08', ''),
  (41 , 'A212337', "", 0, '2021-11-1', '2022-3-22', 'P-12', ''),
  (42 , 'A212299', "Moose", 0, '2019-1-1', '2022-4-1', 'P-14', 'Yes'),
  (43 , 'A208488', "Rocky", 0, '2017-1-1', '2022-3-24', 'P-16', '981020043023718'),
  (44 , 'A212376', "", 0, '2021-1-1', '2022-3-24', 'Q-12', ''),
  (45 , 'A212375', "", null, null, '2022-3-23', 'Q-13', ''),
  (46 , 'A211098', "Finn", 0, '2019-1-1', '2022-3-22', 'Receiving', '985113002514512'),
  (47 , 'A211462', "Kevin", 0, '2020-10-1', '2022-1-6', 'A-01', '981020039856953'),
  (48 , 'A211228', "Bounce", 0, '2021-4-1', '2022-1-25', 'A-02', '981020045344755'),
  (49 , 'A199662', "Tish", 1, '2018-1-1', '2022-1-21', 'A-03', '981020031269641'),
  (50 , 'A211205', "Henry VIII", 0, '2021-2-1', '2021-12-27', 'A-04', '985113005064178'),
  (51 , 'A211460', "Captain Sniff", 0, '2020-12-1', '2022-1-7', 'A-05', '981020043428424'),
  (52 , 'A210735', "Jazz", 1, '2020-1-1', '2021-12-8', 'A-06', '985113005352220'),
  (53 , 'A211028', "Coalette", 1, '2020-12-1', '2021-12-8', 'A-07', '981020041697735'),
  (54 , 'A209547', "Lola", 1, '2020-9-1', '2021-12-28', 'A-08', '981020043676609'),
  (55 , 'A211408', "Jambalaya", 1, '2021-1-1', '2022-1-4', 'A-09', '9810210045327107'),
  (56 , 'A211406', "Vegas", 0, '2020-1-1', '2022-1-19', 'A-10', '981020031278454'),
  (57 , 'A211068', "Sugar Plum", 1, '2020-12-1', '2022-1-21', 'A-11', ''),
  (58 , 'A211607', "Sage", 1, '2021-4-1', '2022-1-21', 'A-12', '981020045316486'),
  (59 , 'A210593', "Britney", 1, '2020-1-1', '2022-1-18', 'A-13', '981020045357644'),
  (60 , 'A211427', "Sookie", 1, '2021-8-1', '2022-1-11', 'A-14', '981020045377046'),
  (61 , 'A211262', "Remi", 1, '2020-1-1', '2021-12-21', 'A-15', '956000013618083'),
  (62 , 'A211441', "Magic Marker", 0, '2019-1-1', '2022-1-12', 'C-02', ''),
  (63 , 'A211082', "Megora", 1, '2014-1-1', '2021-12-14', 'C-05', ''),
  (64 , 'A209265', "Salem", 1, '2020-1-1', '2022-1-20', 'C-08', '981020043673060'),
  (65 , 'A211466', "Bob the Wheat", 0, '2021-5-1', '2022-1-13', 'C-11', ''),
  (66 , 'A211486', "Oat Malk", 1, '2014-1-1', '2022-1-18', 'C-14', ''),
  (67 , 'A211530', "Mercury", 1, '2020-1-1', '2022-1-21', 'C-17', null),
  (68 , 'A211353', "Dumpling", 0, '2015-1-1', '2022-1-5', 'C-20', '982091062343625'),
  (69 , 'A211198', "Skye", 0, '2018-1-1', '2021-12-21', 'C-23', ''),
  (70 , 'A210164', "Ursula", 1, '2019-1-1', '2021-10-7', 'C-26', ''),
  (71 , 'A211290', "Darth Leia", 1, '2021-1-1', '2021-12-30', 'C-29', ''),
  (72 , 'A211233', "Wenidi Liji", 0, '2018-1-1', '2021-12-28', 'C-32', ''),
  (73 , 'A211245', "Mr Velvet", 0, '2018-1-1', '2021-12-28', 'C-35', ''),
  (74 , 'A211459', "", null, null, '2022-1-11', 'Cooler', ''),
  (75 , 'A211622', "", null, null, '2022-1-27', 'Cooler', ''),
  (76 , 'A211522', "Mama Cat", 1, '2011-1-1', '2022-1-11', 'Cooler', ''),
  (77 , 'A211526', "Anna", 1, '2009-1-1', '2022-1-11', 'Cooler', 'Yes'),
  (78 , 'A211556', "Sophie", 1, '2011-1-1', '2022-1-14', 'Cooler', '981020045527488'),
  (79 , 'A211543', "Whiskers", 0, '2006-1-1', '2022-1-13', 'E-1', ''),
  (80 , 'A211542', "Rip", 0, '2009-1-1', '2022-1-13', 'E-1', ''),
  (81 , 'A210904', "Spinner", 0, '2004-1-1', '2022-1-11', 'E-1', ''),
  (82 , 'A211519', "Moki", 1, '2013-1-1', '2022-1-11', 'E-1', ''),
  (83 , 'A211425', '', 0, null, '2022-1-6', 'E-1', '066*594*519'),
  (84 , 'A211376', 'Pepper', 1, '2003-1-1', '2021-12-29', 'E-1', ''),
  (85 , 'A124175', 'Abbie', 1, '2008-1-1', '2022-1-5', 'E-1', 'Yes'),
  (86 , 'A211545', '', 0, null, '2022-1-25', 'E-1', ''),
  (87 , 'A211547', 'Serentiy', 0, '2021-2-1', '2022-1-13', 'F-06', ''),
  (88 , 'A211529', 'Gus', 0, '2017-2-1', '2022-1-21', 'F-08', ''),
  (89 , 'A211409', 'Boots', 1, '2011-2-1', '2022-1-3', 'F-09', null),
  (90 , 'A211438', '', 1, null, '2022-1-11', 'F-10', null),
  (91 , 'A211143', 'Trudi', 1, null, '2022-1-20', 'F-23', ''),
  (92 , 'A211557', 'Tuna', 1, null, '2022-1-14', 'F-24', '981020031847647'),
  (93 , 'A210799', 'Lucy', 1, '2019-1-1', '2022-2-2', 'F-25', '981020045388305'),
  (94 , 'A210809', 'Clarinet', 1, '2018-1-1', '2022-1-21', 'F-26', null),
  (95 , 'A211639', '', null, null, '2022-1-24', 'G-04', null),
  (96 , 'A211593', '', null, null, '2022-2-10', 'G-05', null),
  (97 , 'A211637', '', null, null, '2022-1-24', 'G-06', null),
  (98 , 'A211617', '', null, null, '2022-1-31', 'G-13', ''),
  (99 , 'A211618', '', 0, null, '2022-1-31', 'G-13', ''),
  (100 , 'A211246', 'Goliath', 0, '2020-12-1', '2021-12-29', 'H-01', '981020045358164'),
  (101 , 'A211591', '', 0, null, '2022-1-27', 'H-02', ''),
  (102 , 'A211578', '', 0, '2012-1-1', '2022-1-27', 'H-04', ''),
  (103 , 'A211544', 'Berry Crepe', 1, '2021-3-1', '2022-1-27', 'H-05', '981020045379201'),
  (104 , 'A211569', '', 0, null, '2022-1-26', 'H-09', ''),
  (105 , 'A211627', 'Lola', 1, '2020-1-1', '2022-1-25', 'H-11', '981020045334343'),
  (106 , 'A211620', '', 1, null, '2022-1-31', 'H-12', ''),
  (107 , 'A210615', 'Bruno', 0, '2020-11-1', '2022-1-28', 'H-15', '981020041701414'),
  (108 , 'A211613', '', 0, null, '2022-1-31', 'H-16', ''),
  (109 , 'A211614', '', 0, null, '2022-1-31', 'H-17', ''),
  (110 , 'A211013', 'Aspen', 1, '2013-1-1', '2022-1-31', 'H-18', ''),
  (111 , 'A211451', 'Nala', 1, '2021-1-1', '2022-2-5', 'H-21', ''),
  (112 , 'A211549', 'Valor', 0, null, '2022-1-25', 'H-22', ''),
  (113 , 'A209008', 'Tank', 0, '2020-8-1', '2022-2-10', 'H-23', '981020043698926'),
  (114 , 'A211559', '', 0, null, '2022-1-25', 'H-25', null),
  (115 , 'A210997', 'Chente', 0, '2020-12-1', '2022-1-5', 'H-20', null),
  (116 , 'A185549', 'Loka', 1, '2016-1-1', '2021-12-20', 'Home Qua', '981020023226406'),
  (117 , 'A211611', 'Grizz', 0, null, '2022-1-29', 'Home Qua', null),
  (118 , 'A211499', 'Dottie', 1, '2015-1-1', '2022-1-18', 'Home Qua', '981020045380468'),
  (119 , 'A186463', 'Captain', 0, '2015-1-1', '2022-1-31', 'I-11', '956000004140503'),
  (120 , 'A211568', '', 1, null, '2022-1-26', 'I-12', null),
  (121 , 'A211554', '', 1, null, '2022-1-25', 'I-13', ''),
  (122 , 'A211595', '', null, null, '2022-1-27', 'I-14', ''),
  (123 , 'A211548', '', 0, null, '2022-1-24', 'I-15', ''),
  (124 , 'A211638', '', 1, null, '2022-2-1', 'I-36', null),
  (125 , 'A211636', '', 1, null, '2022-2-1', 'I-37', null),
  (126 , 'A211630', '', 0, null, '2022-1-31', 'I-39', null),
  (127 , 'A211604', '', null, null, '2022-1-28', 'I-43', ''),
  (128 , 'A197411', 'Ellie', 1, '2018-1-1', '2022-1-26', 'I-44', '981020025217682'),
  (129 , 'A211628', '', 1, '2021-1-1', '2022-2-1', 'I-45', ''),
  (130 , 'A211537', '', 0, null, '2022-1-24', 'I-46', ''),
  (131 , 'A211534', '', 0, null, '2022-1-21', 'I-47', ''),
  (132 , 'A211601', '', 0, null, '2022-1-27', 'I-48', ''),
  (133 , 'A211599', '', 0, null, '2022-1-27', 'I-49', ''),
  (134 , 'A211485', 'Frodo', 0, null, '2022-1-27', 'I-62', ''),
  (135 , 'A210287', 'Shirpa', 1, '2017-1-1', '2022-1-18', 'K-02', '981020045369324'),
  (136 , 'A173843', 'Mickey', 0, '2014-1-1', '2022-1-12', 'K-04', '981020017884502'),
  (137 , 'A211065', 'Arvid', 0, '2019-1-1', '2021-12-31', 'K-12', ''),
  (138 , 'A211455', 'Yooli', 1, '2019-1-1', '2022-1-24', 'K-20', '981020045332645'),
  (139 , 'A211382', 'Rollie-Pollie', 1, '2018-1-1', '2022-1-5', 'K-23', null),
  (140 , 'A211437', 'Hope', 1, '2017-1-1', '2022-1-4', 'K-30', ''),
  (141 , 'A211418', 'Noki', 1, '2017-1-1', '2022-1-11', 'K-41', null),
  (142 , 'A211436', 'Overdraft', 0, '2014-1-1', '2022-1-11', 'K-49', ''),
  (143 , 'A210728', 'Beef Stroganoff', 0, '2018-1-1', '2021-12-29', 'K-52', '985112011041354'),
  (144 , 'A211226', 'Lawn Mower', 0, '2018-1-1', '2021-12-27', 'K-61', ''),
  (145 , 'A211227', 'Leaf Blower', 1, '2018-1-1', '2021-12-27', 'K-61', ''),
  (146 , 'A211020', 'Purrsephone', 1, '2020-12-1', '2022-1-16', 'M-02', ''),
  (147 , 'A211594', 'Mr Puff', 0, null, '2022-1-27', 'M-03', ''),
  (148 , 'A211120', 'Chi-Chi', 1, '2017-1-1', '2022-1-16', 'M-04', ''),
  (149 , 'A211410', 'Geraldthy', 0, '2018-1-1', '2022-1-30', 'C-02', '981020045440311'),
  (150 , 'A211079', 'Mothman', 0, '2017-1-1', '2022-1-10', 'M-05', ''),
  (151 , 'A211177', 'Greenleigh', 1, '2018-1-1', '2021-12-20', 'M-06', ''),
  (152 , 'A211546', 'Spoon', 1, '2020-1-1', '2022-1-30', 'M-07', null),
  (153 , 'A210394', 'Bonnie', 1, '2017-1-1', '2022-1-18', 'Office', '981020045360493'),
  (154 , 'A211576', '', 0, null, '2022-1-27', 'P-01', null),
  (155 , 'A211597', '', 0, null, '2022-1-26', 'P-06', ''),
  (156 , 'A211631', '', 0, null, '2022-1-31', 'P-10', '981020013344354'),
  (157 , 'A210950', '', 0, null, '2021-12-3', 'Vet', null),
  (158 , 'A211288', 'Peanut', 0, '2015-1-1', '2021-12-22', 'X-01', '056*315*349'),
  (159 , 'A211504', 'Dr Dylan', 0, '2021-7-1', '2022-1-18', 'X-01', ''),
  (160 , 'A211505', 'Platypuss', 1, '2021-8-1', '2022-1-18', 'X-01', ''),
  (161 , 'A211511', 'Dentist Dave', 0, '2021-7-1', '2022-1-19', 'X-01', ''),
  (162 , 'A211512', 'Beaver the B', 1, '2021-8-1', '2022-1-19', 'X-01', ''),
  (163 , 'A212317', 'Barnabee', 1, '2020-1-1', '2022-2-20', 'C-02', ''),
  (164 , 'A212288', 'Butteflake', 1, '2017-1-1', '2022-3-17', 'C-14', ''),
  (165 , 'A211915', 'Zig Zag', 1, '2021-5-1', '2022-3-27', 'F-03', '981020045364182'),
  (166 , 'A211790', 'Lucky', 0, null, '2022-2-12', 'F-04', ''),
  (167 , 'A212378', '', 1, '2021-5-1', '2022-3-16', 'F-04', ''),
  (168 , 'A212115', 'Eiffel Tower', 0, '2019-1-1', '2022-3-7', 'F-08', ''),
  (169 , 'A212377', '', 1, '2021-7-1', '2022-3-7', 'F-09', ''),
  (170 , 'A212306', '', null, null, '2022-3-18', 'F-10', ''),
  (171 , 'A212401', 'Babygirl', 1, '2014-1-1', '2022-3-18', 'F-17', ''),
  (172 , 'A212387', '', 0, '2021-2-1', '2022-3-16', 'F-20', ''),
  (173 , 'A211575', 'Kenny', 0, '2016-1-1', '2022-3-19', 'F-22', ''),
  (174 , 'A212289', 'Sally', 1, '2017-1-1', '2022-3-17', 'F-23', ''),
  (175 , 'A211786', 'Sweetie Pie', 1, '2020-1-1', '2022-3-10', 'F-23', ''),
  (176 , 'A212278', 'Candace', 1, '2021-7-1', '2022-3-9', 'F-25', ''),
  (177 , 'A212092', 'Pork Chop', 1, '2021-1-1', '2022-3-4', 'F-26', ''),
  (178 , 'A212338', '', null, null, '2022-3-25', 'G-13', ''),
  (179 , 'A212385', '', 1, null, '2022-3-24', 'I-11', ''),
  (180 , 'A212322', '', 0, null, '2022-3-24', 'I-12', ''),
  (181 , 'A212395', 'Taz', 1, null, '2022-3-24', 'I-13', ''),
  (182 , 'A212327', 'Turtleneck', 0, '2021-1-1', '2022-3-21', 'I-14', ''),
  (183 , 'A212427', '', 0, null, '2022-3-28', 'I-15', ''),
  (184 , 'A212386', '', null, null, '2022-3-24', 'I-44', ''),
  (185 , 'A212390', '', null, null, '2022-3-24', 'I-45', ''),
  (186 , 'A212328', 'Socks', 0, null, '2022-3-21', 'I-45', ''),
  (187 , 'A212441', '', 1, null, '2022-3-28', 'I-46', ''),
  (188 , 'A212407', '', 0, null, '2022-3-25', 'I-47', ''),
  (189 , 'A212421', '', null, null, '2022-3-28', 'I-48', ''),
  (190 , 'A212323', '', 0, '2019-1-1', '2022-3-21', 'I-49', null),
  (191 , 'A212308', 'One-Eyed Will', 0, '2019-1-1', '2022-3-18', 'M-01', ''),
  (192 , 'A173248', 'Scrap', 0, '2016-1-1', '2022-3-25', 'M-02', '981020013400240'),
  (193 , 'A211858', 'Ellie', 1, '2019-1-1', '2022-3-13', 'M-04', '981020035561763'),
  (194 , 'A211889', 'Sideshow', 0, '2019-1-1', '2022-2-19', 'M-05', ''),
  (195 , 'A212227', 'Tapestry', 1, '2021-9-1', '2022-3-14', 'M-06', ''),
  (196 , 'A201956', 'Yuri', 0, '2020-1-1', '2022-3-17', 'Office', ''),
  (197 , 'A212433', '', null, null, '2022-3-17', 'Truck', '')
;

insert into breed (breed_id, breed_name, species_id)
values
  (1, "Labrador Retriever", 0),
  (2, "Queensland Heeler", 0),
  (3, "Siberian Husky", 0),
  (4, "Mix", 0),
  (5, "Aust Cattle Dog", 0),
  (6, "Amer Bulldog", 0),
  (7, "American Staff", 0),
  (8, "Boxer", 0),
  (9, "Staffordshire", 0),
  (10, "Bull Dog", 0),
  (11, "Germ Shepherd", 0),
  (12, "Border Collie", 0),
  (13, "Aust Shepherd", 0),
  (14, "Pit Bull", 0),
  (15, "Rottweiler", 0),
  (16, "Shih Tzu", 0),
  (17, "Maltese", 0),
  (18, "Chihuaha SH", 0),
  (19, "Manchester Terr", 0),
  (20, "Terrier", 0),
  (21, "Chow Chow", 0),
  (22, "Pomeranian", 0),
  (23, "Welsh Corgi Pem", 0),
  (24, "Poodle Stnd", 0),
  (25, "Irish Wolfhound", 0),
  (26, "Aust Kelpie", 0),
  (27, "Mastiff", 0),
  (28, "Eng Foxhound", 0),
  (29, "Queensland Heel", 0),
  (30, "Airedale Terr", 0),
  (31, "Domestic SH", 1),
  (32, "Domestic MH", 1),
  (33, "Abyssinian", 1),
  (34, "Domestic LH", 1),
  (35, "Pug", 0),
  (36, "Jack Russ Terr", 0),
  (37, "Siamese", 1),
  (38, "Chinese Sharpei", 0),
  (39, "Tr Walker Hound", 0),
  (40, "Great Dane", 0),
  (41, "Akbash", 0),
  (42, "Germn WH Point", 0),
  (43, "Bull Mastiff", 0),
  (44, "Dalmation", 0),
  (45, "Dachshund", 0),
  (46, "Ragdoll", 1),
  (47, "Yorkshire Terr", 0),
  (48, "Mix", 1)
;

insert into color (color_id, color)
values
  (1, "Yellow"),
  (2, "White"),
  (3, "Gray"),
  (4, "Red"),
  (5, "Brown Brindle"),
  (6, "Red Tick"),
  (7, "Tan"),
  (8, "Black"),
  (9, "Brown"),
  (10, "Fawn"),
  (11, "Champagne"),
  (12, "Buff"),
  (13, "Tricolor"),
  (14, "Dil Tortie"),
  (15, "Patch Tab"),
  (16, "Tortie"),
  (17, "Brn Tabby"),
  (18, "Gray Tabby"),
  (19, "Calico"),
  (20, "Lynx Pt"),
  (21, "Blk Tabby"),
  (22, "Org Tabby"),
  (23, "Blue Merle"),
  (24, "Liver"),
  (25, "Chocolate"),
  (26, "Crm Tabby"),
  (27, "Dil Calico"),
  (28, "Orange"),
  (29, "Choc Pt"),
  (30, "Blk Smoke")
;
        
INSERT INTO AnimalBreed (animal_id, breed_id)
VALUES
  (1, 29),
  (2, 3),
  (3, 3),
  (4, 1),
  (5, 3),
  (6, 6),
  (7, 1),
  (8, 7),
  (9, 8),
  (10, 7),
  (11, 9),
  (12, 3),
  (13, 8),
  (14, 5),
  (15, 7),
  (16, 5),
  (17, 11),
  (18, 12),
  (19, 7),
  (20, 11),
  (21, 13),
  (22, 9),
  (23, 14),
  (24, 5),
  (25, 1),
  (26, 7),
  (27, 3),
  (28, 16),
  (29, 16),
  (29, 13),
  (30, 11),
  (31, 11),
  (32, 11),
  (33, 7),
  (34, 14),
  (35, 7),
  (36, 11),
  (37, 3),
  (38, 18),
  (39, 18),
  (40, 16),
  (41, 20),
  (42, 21),
  (43, 22),
  (44, 22),
  (45, 24),
  (46, 25),
  (47, 26),
  (48, 5),
  (49, 43),
  (50, 1),
  (51, 28),
  (52, 29),
  (53, 1),
  (54, 8),
  (55, 1),
  (56, 9),
  (57, 11),
  (58, 20),
  (59, 7),
  (60, 2),
  (61, 43),
  (62, 31),
  (63, 31),
  (64, 31),
  (65, 32),
  (66, 31),
  (67, 31),
  (68, 33),
  (69, 31),
  (70, 31),
  (71, 32),
  (72, 34),
  (73, 31),
  (74, 31),
  (75, 20),
  (76, 31),
  (77, 27),
  (78, 35),
  (79, 31),
  (80, 1),
  (81, 18),
  (82, 3),
  (83, 31),
  (84, 16),
  (85, 1),
  (86, 31),
  (87, 31),
  (88, 31),
  (89, 31),
  (90, 32),
  (91, 31),
  (92, 31),
  (93, 37),
  (94, 31),
  (95, 31),
  (96, 31),
  (97, 31),
  (99, 31),
  (100, 31),
  (101, 38),
  (101, 7),
  (102, 39),
  (102, 8),
  (103, 7),
  (103, 3),
  (104, 11),
  (105, 41),
  (105, 1),
  (106, 5),
  (107, 42),
  (107, 24),
  (108, 43),
  (109, 30),
  (110, 43),
  (111, 7),
  (112, 11),
  (113, 9),
  (114, 1),
  (115, 11),
  (116, 6),
  (117, 3),
  (118, 44),
  (119, 31),
  (120, 31),
  (121, 31),
  (122, 31),
  (123, 34),
  (124, 31),
  (125, 31),
  (126, 31),
  (127, 32),
  (128, 31),
  (129, 31),
  (130, 34),
  (131, 31),
  (132, 31),
  (133, 45),
  (134, 31),
  (135, 31),
  (136, 31),
  (137, 31),
  (138, 46),
  (139, 31),
  (140, 31),
  (141, 31),
  (142, 31),
  (143, 31),
  (144, 32),
  (145, 32),
  (146, 31),
  (147, 31),
  (148, 34),
  (149, 32),
  (149, 31),
  (150, 32),
  (151, 32),
  (152, 31),
  (173, 31),
  (153, 31),
  (154, 18),
  (155, 35),
  (156, 47),
  (24, 3),
  (157, 1),
  (158, 31),
  (159, 31),
  (163, 31),
  (164, 31),
  (165, 32),
  (166, 31),
  (167, 31),
  (168, 31),
  (169, 32),
  (170, 31),
  (171, 31),
  (174, 31),
  (175, 31),
  (176, 31),
  (177, 31),
  (178, 31),
  (179, 34),
  (180, 31),
  (181, 31),
  (182, 31),
  (184, 31),
  (185, 31),
  (186, 34),
  (186, 32),
  (187, 31),
  (188, 31),
  (189, 31),
  (190, 31),
  (191, 32),
  (192, 31),
  (193, 31),
  (194, 32),
  (195, 31),
  (196, 32)
;

INSERT INTO animalcolor (color_id, animal_id)
VALUES
  (1, 1),
  (2, 1),
  (3, 2),
  (1, 2),
  (4, 3),
  (2, 3),
  (5, 4),
  (6, 5),
  (2, 6),
  (7, 6),
  (8, 7),
  (2, 7),
  (2, 8),
  (9, 8),
  (10, 9),
  (2, 9),
  (10, 10),
  (2, 10),
  (9, 11),
  (2, 11),
  (2, 12),
  (8, 12),
  (10, 13),
  (2, 13),
  (7, 14),
  (2, 14),
  (11, 15),
  (8, 16),
  (2, 16),
  (8, 17),
  (7, 18),
  (5, 19),
  (8, 21),
  (9, 21),
  (2, 22),
  (9, 22),
  (3, 23),
  (2, 23),
  (7, 24),
  (2, 24),
  (8, 25),
  (3, 26),
  (2, 26),
  (8, 27),
  (2, 27),
  (12, 28),
  (7, 28),
  (12, 29),
  (7, 29),
  (8, 30),
  (2, 30),
  (8, 31),
  (7, 31),
  (8, 32),
  (9, 32),
  (4, 33),
  (2, 33),
  (8, 34),
  (5, 35),
  (2, 35),
  (8, 36),
  (7, 36),
  (8, 37),
  (2, 37),
  (8, 38),
  (7, 38),
  (8, 39),
  (7, 39),
  (7, 40),
  (8, 40),
  (4, 41),
  (8, 42),
  (7, 43),
  (8, 44),
  (2, 44),
  (2, 45),
  (7, 46),
  (8, 47),
  (7, 47),
  (6, 48),
  (4, 48),
  (3, 49),
  (2, 49),
  (1, 50),
  (13, 51),
  (5, 52),
  (8, 53),
  (13, 54),
  (8, 55),
  (3, 56),
  (2, 56),
  (4, 57),
  (8, 57),
  (8, 58),
  (7, 58),
  (5, 59),
  (8, 60),
  (2, 60),
  (2, 61),
  (3, 61),
  (2, 62),
  (3, 62),
  (14, 63),
  (8, 64),
  (8, 65),
  (2, 65),
  (15, 66),
  (16, 67),
  (17, 68),
  (17, 69),
  (3, 70),
  (15, 71),
  (8, 72),
  (2, 72),
  (8, 73),
  (8, 74),
  (2, 74),
  (8, 75),
  (19, 76),
  (7, 77),
  (8, 77),
  (8, 78),
  (2, 78),
  (2, 79),
  (17, 79),
  (1, 80),
  (2, 81),
  (1, 81),
  (8, 82),
  (2, 82),
  (20, 83),
  (7, 84),
  (8, 85),
  (20, 86),
  (2, 87),
  (21, 87),
  (22, 88),
  (19, 89),
  (2, 89),
  (22, 90),
  (2, 90),
  (8, 91),
  (8, 92),
  (2, 92),
  (20, 93),
  (3, 94),
  (2, 94),
  (22, 95),
  (17, 96),
  (22, 97),
  (8, 99),
  (5, 100),
  (3, 101),
  (2, 101),
  (2, 102),
  (13, 102),
  (2, 103),
  (23, 103),
  (7, 104),
  (2, 104),
  (7, 105),
  (8, 105),
  (2, 106),
  (4, 107),
  (2, 107),
  (24, 108),
  (2, 108),
  (2, 109),
  (4, 110),
  (8, 20),
  (7, 20),
  (5, 111),
  (7, 112),
  (8, 112),
  (25, 113),
  (2, 113),
  (8, 114),
  (7, 115),
  (8, 115),
  (3, 116),
  (2, 116),
  (3, 117),
  (2, 117),
  (8, 118),
  (2, 118),
  (8, 119),
  (2, 119),
  (15, 120),
  (17, 121),
  (22, 122),
  (2, 122),
  (17, 123),
  (2, 123),
  (14, 124),
  (16, 125),
  (18, 126),
  (2, 126),
  (26, 127),
  (27, 128),
  (8, 129),
  (26, 130),
  (8, 131),
  (2, 131),
  (8, 132),
  (2, 132),
  (17, 133),
  (2, 133),
  (4, 134),
  (3, 135),
  (2, 135),
  (3, 136),
  (29, 138),
  (8, 139),
  (2, 139),
  (18, 140),
  (18, 141),
  (8, 142),
  (2, 142),
  (22, 143),
  (8, 144),
  (8, 145),
  (19, 146),
  (2, 147),
  (3, 147),
  (3, 148),
  (2, 149),
  (8, 149),
  (8, 150),
  (15, 151),
  (8, 152),
  (2, 152),
  (22, 173),
  (2, 173),
  (8, 153),
  (2, 153),
  (25, 154),
  (7, 154),
  (9, 155),
  (8, 155),
  (7, 156),
  (3, 156),
  (1, 24),
  (8, 157),
  (22, 158),
  (17, 159),
  (17, 163),
  (2, 164),
  (8, 164),
  (8, 165),
  (20, 166),
  (8, 167),
  (2, 167),
  (8, 168),
  (2, 168),
  (8, 169),
  (2, 169),
  (2, 170),
  (3, 170),
  (8, 171),
  (2, 171),
  (2, 174),
  (8, 174),
  (8, 175),
  (17, 176),
  (2, 176),
  (16, 177),
  (8, 178),
  (17, 179),
  (17, 180),
  (2, 180),
  (19, 181),
  (2, 181),
  (17, 182),
  (2, 182),
  (22, 183),
  (2, 183),
  (21, 184),
  (30, 185),
  (8, 186),
  (2, 186),
  (15, 184),
  (18, 188),
  (17, 189),
  (2, 189),
  (17, 190),
  (8, 191),
  (2, 191),
  (17, 192),
  (15, 193),
  (9, 194),
  (2, 194),
  (16, 195),
  (8, 196),
  (2, 137),
  (28, 137),
  (17, 98),
  (8, 172),
  (2, 172),
  (8, 197)
;

insert into vaccine (vaccine_name)
values 
  ("fvrcp initial"),
  ("fvrcp booster"),
  ("fvrcp 1 year"),
  ("rabies"),
  ("da2pp initial"),
  ("da2pp"),
  ("bordetella"),
  ("pyrantel")
;


INSERT INTO Unit (unit_name)
VALUES
("Capsule"),
("Tablet"),
("mL"),
("Powder"),
("Chew"),
("Ointment"),
("Oral Gel"),
("Drops")
;


INSERT INTO Medication (medication_id, medication_name, unit_id, concentration, dose) 
VALUES 
(1, "Amoxicillin", 1, "500 mg", "Dogs: 5mg/lb"),
(2, "Cephalexin", 1, "500 mg", "Dogs: 10-15mg/lb"),
(3, "Cephalexin", 1, "250 mg", "Dogs: 10-15mg/lb"),
(4, "Clindamycin", 2, "25 mg", "Dogs: 2.5-5mg/lb Cats: 2.5-5mg/lb"),
(5, "Clavamox Chewable", 2, "125 mg", "Dogs 6.25mg/lb Cats: 6.25mg/lb"),
(6, "Doxycyline", 2, "50 mg", "Dogs: 2.27mg/lb, Cats: 2.27mg/lb"),
(7, "Doxycyline", 3, "25 mg/mL", "Dogs: 2.27mg/lb, Cats: 2.27mg/lb"),
(8, "AmoxiDrop", 3, "50 mg/mL", "Dogs: 5mg/lb Cats: 50mg/cat or 5-10mg/lb"),
(9, "Carprofen", 1, "25 mg", "Dogs: 1mg/lb ROUND DOWN"),
(10, "Gabapentin", 1, "100 mg", "Dogs:4.5-9mg/lb Cats: 1.36-2.27mg/lb"),
(11, "Generic Joint Care", 4, "N/A", ""),
(12, "Senior Advanced Intestinal Support", 5, "", "1 chew / 40 lbs (3)"),
(13, "Doggie Dailes Probiotic", 5, "", "1 chew / 15 lbs (6)"),
(14, "Probiotics Every Day", 5, "", "1 chew / 30 lbs (3)"),
(15, "Fortiflora", 5, "45 mg?", "1 chew q24hr?"),
(16, "Cosquin for Cats", 1, "", "1 <10 lbs, 2 >= 10lb"),
(17, "Synacore for Cats", 4, "", ""),
(18, "Dasequin for Cats", 1, "", "1 <10 lbs, 2 >= 10lb"),
(19, "Hairball Remedy", 6, "", ""),
(20, "Viralys L-Lysine Supplement", 7, "", "Cats:<6m 0.65ml >6m: 1.25ml"),
(21, "Lactated Ringer Soln.", 3, "N/A", "Dogs: 5-10ml/lb,Cats: 5-10ml/lb, max 100-150ml"),
(22, "0.9% Sodium Chloride Inj", 3, "10 mL Syringe", "Dogs: 5-10ml/lb,Cats: 5-10ml/lb, max 100-150ml"),
(23, "Fatal Plus", 3, "", "1 mL/10 lb"),
(24, "Ketamine", 3, "TBD", "TBD"),
(25, "Acepromazine", 3, "TBD", "TBD"),
(26, "Renal K+ (Potassium Gluconate)", 4, "", "1 scoop/10 lbs"),
(27, "Denamarin Advanced", NULL, "", ""),
(28, "Pet Armor Ear Mite & Tick Treatment", NULL, "", ""),
(29, "Sentry EARMITE free", NULL, "", ""),
(30, "Odansetron", 2, "8 mg", "Dogs: 0.22-0.45mg/lb, Cats: 0.045-0.45mg/lb"),
(31, "Cerenia", 2, "24 mg", "Dogs: 0.9mg/lb Cats: 0.45mg/lb"),
(32, "Cerenia", 2, "16 mg", "Dogs: 0.9mg/lb Cats: 0.45mg/lb"),
(33, "Mirtazapine", 2, "15 mg", "Dogs:0.5-0.59mg/lb (don't exceed 30mg/dog/day)"),
(34, "Mirtaz", 6, "", "Cats >2lb :1.5 inch, Cats <2lb 3/4inch strip to 
inside of ear flap-alternate ears each admin-
WEAR GLOVES"),
(35, "Metronidazole", 2, "500 mg", "Cats and dogs: 4.5-6.8mg/lb"),
(36, "Famotidine", 2, "10 mg", "Cats and dogs: 0.227-0.5mg/lb"),
(37, "Tobramycin", 8, "", "Cats and dogs 1 drop"),
(38, "Neo Poly Dex", 8, "", "Cats and dogs:1 drop")
;