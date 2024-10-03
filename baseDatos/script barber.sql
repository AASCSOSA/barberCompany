CREATE DATABASE barberShop
USE barberShop

--Actualizar la disponibilidad del barbero con un metodo.
CREATE TABLE barber (
	idBarber INT PRIMARY KEY IDENTITY,
	nameBarber VARCHAR (20) NOT NULL,
	fatherLastName VARCHAR(10) NOT NULL,
	motherLastName VARCHAR(10),  
	contactNumber VARCHAR(10),
	availabilityBarber BIT
);

CREATE TABLE userBarber(
	idUser INT PRIMARY KEY IDENTITY,
	nameUser VARCHAR (20) NOT NULL,
	fatherLastName VARCHAR(10) NOT NULL,
	motherLastName VARCHAR(10),  
	contactNumber VARCHAR(10)
);

CREATE TABLE serviceBarber(
	idService INT PRIMARY KEY IDENTITY,
	nameService VARCHAR (30) NOT NULL,  
	descriptionService VARCHAR(50) NOT NULL,
	serviceCost DECIMAL(4, 2) NOT NULL
);

CREATE TABLE citation(
	idCitation INT PRIMARY KEY IDENTITY,
	dateCitation DATE NOT NULL,
	hourCitation TIME NOT NULL
);

CREATE TABLE serviceUser(
	idServiceUser INT PRIMARY KEY IDENTITY,
	idBarber INT,
	idUser INT,
	idService INT,
	idCitation INT,
	
	FOREIGN KEY (idBarber) REFERENCES barber(idBarber),
	FOREIGN KEY (idUser) REFERENCES userBarber(idUser),
	FOREIGN KEY (idService) REFERENCES serviceBarber(idService),
	FOREIGN KEY (idCitation) REFERENCES citation(idCitation)
);
