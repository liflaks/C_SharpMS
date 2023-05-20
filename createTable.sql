CREATE TABLE doctors
(
	id INT PRIMARY KEY IDENTITY,
	name NVARCHAR(30),
	qualification NVARCHAR(30),
	isAcvtive int
)

CREATE TABLE operations
(
	id INT PRIMARY KEY IDENTITY,
	operName NVARCHAR(30),
	amount INT,
	operTime datetime,
	isAcvtive int
)

CREATE TABLE doctorsOperations
(
	id INT PRIMARY KEY IDENTITY,
	doctorId INT FOREIGN KEY REFERENCES doctors(id),
	operationId INT FOREIGN KEY REFERENCES operations(id),
	isAcvtive int
)