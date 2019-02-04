/*Create Database*/
create database PruebaJuanDavidMoreno;

/*CREATE TABLES*/

CREATE TABLE USERS(
ID_USER INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
NAME VARCHAR(25) NOT NULL,
LAST_NAME VARCHAR(35) NOT NULL,
CREATE_DATE DATETIME NOT NULL,
LAST_MODIFICATION DATETIME NOT NULL
);
GO

CREATE TABLE PARAMETER(
ID_PARAMETER INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
CODE VARCHAR NOT NULL,
NAME_PRODUCTO VARCHAR(50) NOT NULL,
CREATE_DATE DATETIME NOT NULL, 
LAST_MODIFICATION DATETIME NOT NULL,
);
GO

CREATE TABLE PARAMETER_ITEMS(
ID_PITEMS INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
ID_PARAMETER INT NOT NULL,
ID_USER INT NOT NULL,
TYPE_DATA VARCHAR(25) NOT NULL,
VALUE VARCHAR(50) NULL,
CREATE_DATE DATETIME NOT NULL, 
LAST_MODIFICATION DATETIME NOT NULL,
CONSTRAINT FK_ID_PARAMETER FOREIGN KEY (ID_PARAMETER) REFERENCES PARAMETER(ID_PARAMETER),
CONSTRAINT FK_ID_USER FOREIGN KEY (ID_USER) REFERENCES USERS(ID_USER)
);
GO

/*CREATE PROCEDURES*/

CREATE PROCEDURE SEARCH_PARAMETER
	@PI_IDPARAMETER INT = NULL,
	@PI_NAMEPRODUCT VARCHAR(50) = NULL
AS
BEGIN
	SELECT	P.CODE AS Codigo
			,P.NAME_PRODUCTO AS Nombre
			,PAI.TYPE_DATA AS Tipo_Dato
			,PAI.VALUE AS VALOR
			,PAI.LAST_MODIFICATION AS ULTIMA_MODIFICACION
	FROM	PARAMETER P
			LEFT JOIN PARAMETER_ITEMS PAI ON P.ID_PARAMETER = PAI.ID_PARAMETER 
	WHERE	P.CODE = @PI_IDPARAMETER
			OR P.NAME_PRODUCTO LIKE '%' + @PI_NAMEPRODUCT + '%'
END
GO

CREATE PROCEDURE EDIT_PARAMETER
	@PI_CODE INT,
	@PI_VALUE VARCHAR(255),
	@PI_LASTMODIFICATION DATETIME,
	@PI_IDUSER INT
AS
BEGIN

	DECLARE @vIDPARAMETER INT

	SELECT	@vIDPARAMETER = ID_PARAMETER
	FROM	PARAMETER
	WHERE	CODE = @PI_CODE


	UPDATE	PARAMETER
	SET		ID_USER = @PI_IDUSER
	WHERE	ID_PARAMETER = @vIDPARAMETER


	UPDATE	PARAMETER_ITEMS
	SET		VALUE = @PI_VALUE
			,LAST_MODIFICATION = @PI_LASTMODIFICATION
	FROM	PARAMETER P
			LEFT JOIN PARAMETER_ITEMS PAI ON P.ID_PARAMETER = PAI.ID_PARAMETER
	WHERE	P.ID_PARAMETER = @vIDPARAMETER

END
GO

/*insert tables*/

/*USERS*/

INSERT INTO USERS(NAME,LAST_NAME,CREATE_DATE,LAST_MODIFICATION)
VALUES('Juan','Moreno',GETDATE(),GETDATE())
GO

INSERT INTO USERS(NAME,LAST_NAME,CREATE_DATE,LAST_MODIFICATION)
VALUES('Gabriela','Monta�o',GETDATE(),GETDATE())
GO

INSERT INTO USERS(NAME,LAST_NAME,CREATE_DATE,LAST_MODIFICATION)
VALUES('David','Segura',GETDATE(),GETDATE())
GO

/*PARAMETERS*/

INSERT INTO PARAMETER(CODE,NAME_PRODUCTO,CREATE_DATE,LAST_MODIFICATION)
VALUES('O1','Numero intentos autenticacion',GETDATE(),GETDATE())
GO

INSERT INTO PARAMETER(CODE,NAME_PRODUCTO,CREATE_DATE,LAST_MODIFICATION)
VALUES('O2','Tiempo Cambio De Clave (Dias)',GETDATE(),GETDATE())
GO

INSERT INTO PARAMETER(CODE,NAME_PRODUCTO,CREATE_DATE,LAST_MODIFICATION)
VALUES('O3','Complejidad Clave',GETDATE(),GETDATE())
GO

/*PARAMETERS ITEMS*/

INSERT INTO PARAMETER_ITEMS(ID_PARAMETER,TYPE_DATA,VALUE,CREATE_DATE,LAST_MODIFICATION,ID_USER)
VALUES(1,'Entero','3',GETDATE(),GETDATE(),1)

INSERT INTO PARAMETER_ITEMS(ID_PARAMETER,TYPE_DATA,VALUE,CREATE_DATE,LAST_MODIFICATION,ID_USER)
VALUES(1,'Entero','30',GETDATE(),GETDATE(),1)

INSERT INTO PARAMETER_ITEMS(ID_PARAMETER,TYPE_DATA,VALUE,CREATE_DATE,LAST_MODIFICATION,ID_USER)
VALUES(1,'Expresi�n','d{1,6}[a-z].[!#$%&/()=?]',GETDATE(),GETDATE(),1)




ALTER TABLE PARAMETER_ITEMS ADD ID_USER INT

ALTER TABLE PARAMETER_ITEMS ADD FOREIGN KEY (ID_USER) REFERENCES USERS(ID_USER)

SELECT * FROM PARAMETER

drop table PARAMETER