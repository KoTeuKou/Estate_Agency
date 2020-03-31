USE master 
GO 

IF EXISTS(SELECT * FROM sys.databases WHERE name='Users') 
BEGIN 
DROP DATABASE Users
END 
GO 

CREATE DATABASE Users
GO

USE Users
GO

CREATE TABLE [User](
	[IDUser] [int] IDENTITY(1,1) NOT NULL CONSTRAINT [PK_User] primary key,
	[Surname] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Patronymic] [varchar](50) NULL,
	[PhoneNumber] [varchar](15) NULL,
	[DateOfBirth] [date] NULL,
);


CREATE TABLE [Award](
	[IDAward] [int] IDENTITY(1,1) NOT NULL CONSTRAINT [PK_Awards] primary key,
	[Tittle] [varchar](100) NOT NULL,
);

CREATE TABLE [AwardsOfUser](
                         [IDAward] [int] NOT NULL,
                         [IDUser] [int] NOT NULL,
);

ALTER TABLE [AwardsOfUser]  WITH CHECK ADD  CONSTRAINT [FK_AwardsOfUser]
FOREIGN KEY([IDUser]) REFERENCES [User] ([IDUser])

ALTER TABLE [AwardsOfUser]  WITH CHECK ADD  CONSTRAINT [FK_AwardsOfUser2]
    FOREIGN KEY([IDAward]) REFERENCES [Award] ([IDAward])

GO
INSERT [User] 
([Surname], [Name], [Patronymic], [PhoneNumber], [DateOfBirth])
Values
('Лапушкин', 'Дмитрий', 'Алексеевич', '89372447924', '1999-11-25')
INSERT [Award]
([Tittle])
Values
('МАЛАДЧИНКА!')
INSERT [AwardsOfUser]
([IDAward], [IDUser])
Values
(1, 1)

GO
CREATE PROCEDURE [dbo].AddUser
	@Surname nvarchar(50),
    @Name nvarchar(50),
	@Patronymic nvarchar(50),
	@DateOfBirth datetime,
	@PhoneNumber nvarchar(12)
AS
BEGIN
	 INSERT INTO [User]([Surname], [Name], Patronymic, DateOfBirth, PhoneNumber)
		VALUES(@Surname, @Name, @Patronymic, @DateOfBirth, @PhoneNumber)
	 SELECT u.IDUser, u.[Name], u.Surname, u.DateOfBirth, u.Patronymic, u.PhoneNumber
	 FROM [User] u 
	 WHERE u.[IDUser] = SCOPE_IDENTITY()
END

GO
CREATE PROCEDURE [dbo].CreateAward
    @Tittle nvarchar(50)
AS
BEGIN
    INSERT INTO [Award]([Tittle])
    VALUES(@Tittle)
	SELECT a.IDAward, a.Tittle
	 FROM [Award] a 
	 WHERE a.IDAward = SCOPE_IDENTITY()
END

GO
CREATE PROCEDURE [dbo].SearchByName
	@Name [varchar](50)
AS
BEGIN
	 SELECT  u.IDUser, u.[Name], u.Surname, u.DateOfBirth, u.Patronymic, u.PhoneNumber
	 FROM [User] u 
	 WHERE u.[Name] = @Name
	 
END

GO
CREATE PROCEDURE [dbo].SearchBySurname
	@Surname [varchar](50)
AS
BEGIN
	 SELECT  u.IDUser, u.[Name], u.Surname, u.DateOfBirth, u.Patronymic, u.PhoneNumber
	 FROM [User] u 
	 WHERE u.Surname = @Surname
	 
END

GO
CREATE PROCEDURE [dbo].SearchByPatronymic
	@Patronymic [varchar](50)
AS
BEGIN
	 SELECT  u.IDUser, u.[Name], u.Surname, u.DateOfBirth, u.[Patronymic], u.PhoneNumber
	 FROM [User] u 
	 WHERE u.Patronymic = @Patronymic 
END

GO
CREATE PROCEDURE [dbo].SearchByPhone
	@PhoneNumber [varchar](15)
AS
BEGIN
	 SELECT  u.IDUser, u.[Name], u.Surname, u.DateOfBirth, u.Patronymic, u.PhoneNumber
	 FROM [User] u 
	 WHERE u.[PhoneNumber] = @PhoneNumber 
END

GO
CREATE PROCEDURE [dbo].EditUser
	@Name nvarchar(50),
	@Surname nvarchar(50),
	@Patronymic nvarchar(50),
	@DateOfBirth datetime,
	@PhoneNumber nvarchar(12),
	@Id int
AS
BEGIN
	 Update [User] 
	SET [Name] = @Name, 
		Surname = @Surname,
		Patronymic = @Patronymic, 
		DateOfBirth = @DateOfBirth,
		PhoneNumber = @PhoneNumber
	WHERE IDUser = @Id
	SELECT u.IDUser, u.[Name], u.Surname, u.DateOfBirth, u.Patronymic, u.PhoneNumber
	 FROM [User] u 
	 WHERE u.[IDUser] = @Id
END


GO
CREATE PROCEDURE [dbo].GetUserById
	@Id int
AS
BEGIN
	 SELECT u.IDUser, u.[Name], u.Surname, u.DateOfBirth, u.Patronymic, u.PhoneNumber
	 FROM [User] u 
	 WHERE u.[IDUser] = @Id
	 
END

GO
CREATE PROCEDURE [dbo].GetAllUsers
AS
BEGIN
	 SELECT *
	 FROM [User]  
END

GO
CREATE PROCEDURE [dbo].GetAllAwards
AS
BEGIN
    SELECT *
    FROM [Award]
END

GO
CREATE PROCEDURE [dbo].GetAllAwardsOfUser
	@IDUser int
AS
BEGIN
	 SELECT a.IDAward, a.Tittle
	 FROM [Award] a, [AwardsOfUser] aou
	 WHERE a.[IDAward] = aou.IDAward AND @IDUser = aou.IDUser
END

GO
CREATE PROCEDURE [dbo].DeleteById
	@Id int
AS
BEGIN
	 DELETE aou FROM [AwardsOfUser] aou WHERE aou.[IDUser] = @Id
	 DELETE u FROM [User] u WHERE u.[IDUser] = @Id
END
GO
CREATE PROCEDURE [dbo].AddAwardToUser
    @IDUser int,
    @IDAward int
AS 
BEGIN
    INSERT INTO [AwardsOfUser]([IDAward], [IDUser])
		VALUES(@IDAward, @IDUser)
	SELECT u.IDUser, u.[Name], u.Surname, u.DateOfBirth, u.Patronymic, u.PhoneNumber
	 FROM [User] u 
	 WHERE u.[IDUser] = @IDUser
END
GO
CREATE PROCEDURE [dbo].DeleteAward
	@Id int
AS
BEGIN
	 DELETE aou FROM [AwardsOfUser] aou WHERE aou.[IDAward] = @Id
	 DELETE a FROM [Award] a WHERE a.[IDAward] = @Id
END
GO

GO
CREATE PROCEDURE [dbo].GetAwardById
	@Id int
AS
BEGIN
	 SELECT a.IDAward, a.Tittle
	 FROM Award a 
	 WHERE a.IDAward = @Id
	 
END