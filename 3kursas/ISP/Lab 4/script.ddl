#@(#) script.ddl

DROP TABLE IF EXISTS Gauna_grupe;
DROP TABLE IF EXISTS Eina_i_mentorius;
DROP TABLE IF EXISTS Gauna_vartotojas;
DROP TABLE IF EXISTS Eina_i_konsultacija;
DROP TABLE IF EXISTS Sutartys;
DROP TABLE IF EXISTS Skelbimas;
DROP TABLE IF EXISTS Pranesimas;
DROP TABLE IF EXISTS Isakymas;
DROP TABLE IF EXISTS Apklausa;
DROP TABLE IF EXISTS Veda;
DROP TABLE IF EXISTS Priklauso;
DROP TABLE IF EXISTS Dalyvauja;
DROP TABLE IF EXISTS Zinute;
DROP TABLE IF EXISTS Lankomumas;
DROP TABLE IF EXISTS Kontaktas;
DROP TABLE IF EXISTS Konsultacija;
DROP TABLE IF EXISTS Knyga;
DROP TABLE IF EXISTS Ivertis;
DROP TABLE IF EXISTS Irasas;
DROP TABLE IF EXISTS Imoka;
DROP TABLE IF EXISTS Burelis;
DROP TABLE IF EXISTS Vartotojas;
DROP TABLE IF EXISTS Paskaita;
DROP TABLE IF EXISTS Atsiskaitymas;
DROP TABLE IF EXISTS Vartotojo_Tipas;
DROP TABLE IF EXISTS Modulis;
DROP TABLE IF EXISTS Grupe;
DROP TABLE IF EXISTS Biblioteka;

CREATE TABLE Biblioteka
(
	vieta varchar (255),
	pavadinimas varchar (255),
	id int NOT NULL AUTO_INCREMENT,
	PRIMARY KEY(id)
);

CREATE TABLE Grupe
(
	pavadinimas varchar (255),
	id int NOT NULL AUTO_INCREMENT,
	PRIMARY KEY(id)
);

CREATE TABLE Modulis
(
	pavadinimas varchar (255),
	kodas varchar (255),
	reikalavimai varchar (255),
	aprasas varchar (255),
	PRIMARY KEY(kodas)
);

CREATE TABLE Vartotojo_Tipas
(
	id_Vartotojo_Tipas integer,
	name char (16) NOT NULL,
	PRIMARY KEY(id_Vartotojo_Tipas)
);
INSERT INTO Vartotojo_Tipas(id_Vartotojo_Tipas, name) VALUES(1, 'Administratorius');
INSERT INTO Vartotojo_Tipas(id_Vartotojo_Tipas, name) VALUES(2, 'Destytojas');
INSERT INTO Vartotojo_Tipas(id_Vartotojo_Tipas, name) VALUES(3, 'Studentas');

CREATE TABLE Atsiskaitymas
(
	data date,
	tema varchar (255),
	id int NOT NULL AUTO_INCREMENT,
	fk_Modulis varchar (255) NOT NULL,
	PRIMARY KEY(id),
	CONSTRAINT Turi FOREIGN KEY(fk_Modulis) REFERENCES Modulis (kodas)
);

CREATE TABLE Paskaita
(
	tema varchar (255),
	data date,
	id int NOT NULL AUTO_INCREMENT,
	fk_Modulis varchar (255) NOT NULL,
	PRIMARY KEY(id),
	CONSTRAINT Sudaro FOREIGN KEY(fk_Modulis) REFERENCES Modulis (kodas)
);

CREATE TABLE Vartotojas
(
	asmens_kodas varchar (255),
	vardas varchar (255),
	pavarde varchar (255),
	slaptazodis varchar (255),
	vartotojo_tipas integer,
	PRIMARY KEY(asmens_kodas),
	FOREIGN KEY(vartotojo_tipas) REFERENCES Vartotojo_Tipas (id_Vartotojo_Tipas)
);

CREATE TABLE Burelis
(
	pavadinimas varchar (255),
	aprasas varchar (255),
	vieta varchar (255),
	id int NOT NULL AUTO_INCREMENT,
	laikas datetime,
	fk_Vartotojas varchar (255) NOT NULL,
	PRIMARY KEY(id),
	CONSTRAINT VedaBurelis FOREIGN KEY(fk_Vartotojas) REFERENCES Vartotojas (asmens_kodas)
);

CREATE TABLE Imoka
(
	suma decimal,
	saskaitos_numeris varchar (255),
	paskirtis varchar (255),
	id int NOT NULL AUTO_INCREMENT,
	statusas int,
	data date,
	sumoketi_iki date,
	fk_Vartotojas varchar (255) NOT NULL,
	PRIMARY KEY(id),
	CONSTRAINT Atlieka FOREIGN KEY(fk_Vartotojas) REFERENCES Vartotojas (asmens_kodas)
);

CREATE TABLE Irasas
(
	data datetime,
	id int NOT NULL AUTO_INCREMENT,
	pavadinimas varchar (255),
	fk_Vartotojas varchar (255) NOT NULL,
	PRIMARY KEY(id),
	CONSTRAINT Sukuria FOREIGN KEY(fk_Vartotojas) REFERENCES Vartotojas (asmens_kodas)
);

CREATE TABLE Ivertis
(
	verte int,
	id int NOT NULL AUTO_INCREMENT,
	fk_Atsiskaitymas int (11) NOT NULL,
	fk_Vartotojas varchar (255) NOT NULL,
	PRIMARY KEY(id),
	CONSTRAINT AtsiskaitymasIs FOREIGN KEY(fk_Atsiskaitymas) REFERENCES Atsiskaitymas (id),
	CONSTRAINT Gaves FOREIGN KEY(fk_Vartotojas) REFERENCES Vartotojas (asmens_kodas)
);

CREATE TABLE Knyga
(
	autorius varchar (255),
	pavadinimas varchar (255),
	leidimo_metai date,
	fk_Biblioteka int NOT NULL,
	fk_Vartotojas varchar (255) NOT NULL,
	PRIMARY KEY(leidimo_metai, autorius, pavadinimas),
	CONSTRAINT TuriKnyga FOREIGN KEY(fk_Biblioteka) REFERENCES Biblioteka (id),
	CONSTRAINT Pasiema FOREIGN KEY(fk_Vartotojas) REFERENCES Vartotojas (asmens_kodas)
);

CREATE TABLE Konsultacija
(
	tema varchar (255),
	dalykas varchar (255),
	laikas datetime,
	vieta varchar (255),
	id int NOT NULL AUTO_INCREMENT,
	fk_Vartotojas varchar (255),
	PRIMARY KEY(id),
	CONSTRAINT VedaKonsultacija FOREIGN KEY(fk_Vartotojas) REFERENCES Vartotojas (asmens_kodas)
);

CREATE TABLE Kontaktas
(
	id_Kontaktas integer,
	fk_Vartotojas varchar (255) NOT NULL,
	PRIMARY KEY(id_Kontaktas),
	UNIQUE(fk_Vartotojas),
	CONSTRAINT Yra FOREIGN KEY(fk_Vartotojas) REFERENCES Vartotojas (asmens_kodas)
);

CREATE TABLE Lankomumas
(
	data date,
	id int NOT NULL AUTO_INCREMENT,
	fk_Vartotojas varchar (255) NOT NULL,
	fk_Paskaita int NOT NULL,
	PRIMARY KEY(id),
	CONSTRAINT Sekamas FOREIGN KEY(fk_Vartotojas) REFERENCES Vartotojas (asmens_kodas),
	CONSTRAINT Seka FOREIGN KEY(fk_Paskaita) REFERENCES Paskaita (id)
);

CREATE TABLE Zinute
(
	turinys varchar (255),
	data datetime,
	priedas varchar (255),
	id int NOT NULL AUTO_INCREMENT,
	fk_Vartotojas varchar (255) NOT NULL,
	PRIMARY KEY(id),
	CONSTRAINT Siuncia FOREIGN KEY(fk_Vartotojas) REFERENCES Vartotojas (asmens_kodas)
);

CREATE TABLE Dalyvauja
(
	fk_Modulis varchar (255),
	fk_Vartotojas varchar (255),
	PRIMARY KEY(fk_Modulis, fk_Vartotojas),
	CONSTRAINT Dalyvauja FOREIGN KEY(fk_Modulis) REFERENCES Modulis (kodas)
);

CREATE TABLE Priklauso
(
	fk_Vartotojas varchar (255),
	fk_Grupe int,
	PRIMARY KEY(fk_Vartotojas, fk_Grupe),
	CONSTRAINT Priklauso FOREIGN KEY(fk_Vartotojas) REFERENCES Vartotojas (asmens_kodas)
);

CREATE TABLE Veda
(
	fk_Modulis varchar (255),
	fk_Vartotojas varchar (255),
	PRIMARY KEY(fk_Modulis, fk_Vartotojas),
	CONSTRAINT VedaTable FOREIGN KEY(fk_Modulis) REFERENCES Modulis (kodas)
);

CREATE TABLE Apklausa
(
	nuoroda varchar (255),
	fk_Irasas int NOT NULL,
	PRIMARY KEY(fk_Irasas),
	UNIQUE(fk_Irasas),
	CONSTRAINT YraApklausa FOREIGN KEY(fk_Irasas) REFERENCES Irasas (id)
);

CREATE TABLE Isakymas
(
	turinys varchar (255),
	parasas varchar (255),
	data date,
	fk_Irasas int NOT NULL,
	PRIMARY KEY(fk_Irasas),
	UNIQUE(fk_Irasas),
	CONSTRAINT YraIsakymas FOREIGN KEY(fk_Irasas) REFERENCES Irasas (id)
);

CREATE TABLE Pranesimas
(
	turinys varchar (255),
	fk_Irasas int NOT NULL,
	PRIMARY KEY(fk_Irasas),
	UNIQUE(fk_Irasas),
	CONSTRAINT YraPranesimas FOREIGN KEY(fk_Irasas) REFERENCES Irasas (id)
);

CREATE TABLE Skelbimas
(
	turinys varchar (255),
	fk_Irasas int NOT NULL,
	PRIMARY KEY(fk_Irasas),
	UNIQUE(fk_Irasas),
	CONSTRAINT YraSkelbimas FOREIGN KEY(fk_Irasas) REFERENCES Irasas (id)
);

CREATE TABLE Sutartys
(
	data datetime,
	numeris varchar (255),
	turinys varchar (255),
	fk_Irasas int NOT NULL,
	PRIMARY KEY(fk_Irasas),
	UNIQUE(fk_Irasas),
	CONSTRAINT YraSutartis FOREIGN KEY(fk_Irasas) REFERENCES Irasas (id)
);

CREATE TABLE Eina_i_konsultacija
(
	fk_Konsultacija int,
	fk_Vartotojas varchar (255),
	PRIMARY KEY(fk_Konsultacija, fk_Vartotojas),
	CONSTRAINT Eina_i_konsultacija_c FOREIGN KEY(fk_Konsultacija) REFERENCES Konsultacija (id)
);

CREATE TABLE Gauna_vartotojas
(
	fk_Vartotojas varchar (255),
	fk_Zinute int,
	PRIMARY KEY(fk_Vartotojas, fk_Zinute),
	CONSTRAINT Gauna_vartotojas_c FOREIGN KEY(fk_Vartotojas) REFERENCES Vartotojas (asmens_kodas)
);

CREATE TABLE Eina_i_mentorius
(
	fk_Burelis int,
	fk_Vartotojas varchar (255),
	PRIMARY KEY(fk_Burelis, fk_Vartotojas),
	CONSTRAINT Eina_i_mentorius_c FOREIGN KEY(fk_Burelis) REFERENCES Burelis (id)
);

CREATE TABLE Gauna_grupe
(
	fk_Grupe int,
	fk_Zinute int,
	PRIMARY KEY(fk_Grupe, fk_Zinute),
	CONSTRAINT Gauna_grupe_c FOREIGN KEY(fk_Grupe) REFERENCES Grupe (id)
);
