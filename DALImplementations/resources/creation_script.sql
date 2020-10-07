USE [master]
GO

CREATE DATABASE [Estate_Agency]
    
USE [Estate_Agency]
GO
/****** Object:  Table [dbo].[City]    Script Date: 06.10.2020 15:59:59 ******/
SET ANSI_NULLS ON
    GO
SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[City](
    [id_city] [int] IDENTITY(1,1) NOT NULL,
    [city_name] [varchar](255) NOT NULL,
    CONSTRAINT [PK_City] PRIMARY KEY NONCLUSTERED
(
[id_city] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Contract_]    Script Date: 06.10.2020 15:59:59 ******/
SET ANSI_NULLS ON
    GO
SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[Contract_](
    [id_contract] [int] IDENTITY(1,1) NOT NULL,
    [id_realtor] [int] NOT NULL,
    [id_owner] [int] NOT NULL,
    [id_customer] [int] NOT NULL,
    [sale_or_rent] [varchar](4) NOT NULL,
    [contract_date] [date] NOT NULL,
    CONSTRAINT [PK_Contract_] PRIMARY KEY NONCLUSTERED
(
[id_contract] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Cottage]    Script Date: 06.10.2020 15:59:59 ******/
SET ANSI_NULLS ON
    GO
SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[Cottage](
    [id_cottage] [int] IDENTITY(1,1) NOT NULL,
    [cottage_number] [int] NOT NULL,
    [square_of_cottage] [float] NOT NULL,
    [num_of_floors] [int] NOT NULL,
    [num_of_rooms] [int] NOT NULL,
    [price] [int] NOT NULL,
    [id_street] [int] NOT NULL,
    [id_owner] [int] NOT NULL,
    CONSTRAINT [PK_Cottage] PRIMARY KEY NONCLUSTERED
(
[id_cottage] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Cottage_contract]    Script Date: 06.10.2020 15:59:59 ******/
SET ANSI_NULLS ON
    GO
SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[Cottage_contract](
    [id_contract] [int] NOT NULL,
    [id_cottage] [int] NOT NULL
) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Customer]    Script Date: 06.10.2020 15:59:59 ******/
SET ANSI_NULLS ON
    GO
SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[Customer](
    [id_customer] [int] IDENTITY(1,1) NOT NULL,
    [customer_name] [varchar](255) NOT NULL,
    [id_city_of_residence] [int] NOT NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY NONCLUSTERED
(
[id_customer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Flat]    Script Date: 06.10.2020 15:59:59 ******/
SET ANSI_NULLS ON
    GO
SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[Flat](
    [id_flat] [int] IDENTITY(1,1) NOT NULL,
    [flat_number] [int] NOT NULL,
    [floor_number] [int] NOT NULL,
    [square_of_flat] [float] NOT NULL,
    [num_of_rooms] [int] NOT NULL,
    [price] [int] NOT NULL,
    [id_owner] [int] NOT NULL,
    [id_house] [int] NOT NULL,
    CONSTRAINT [PK_Flat] PRIMARY KEY NONCLUSTERED
(
[id_flat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Flat_contract]    Script Date: 06.10.2020 15:59:59 ******/
SET ANSI_NULLS ON
    GO
SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[Flat_contract](
    [id_contract] [int] NOT NULL,
    [id_flat] [int] NOT NULL
) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[House]    Script Date: 06.10.2020 15:59:59 ******/
SET ANSI_NULLS ON
    GO
SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[House](
    [id_house] [int] IDENTITY(1,1) NOT NULL,
    [house_num] [int] NOT NULL,
    [num_of_floors] [int] NOT NULL,
    [id_street] [int] NOT NULL,
    CONSTRAINT [PK_HOUSE] PRIMARY KEY NONCLUSTERED
(
[id_house] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Owner_]    Script Date: 06.10.2020 15:59:59 ******/
SET ANSI_NULLS ON
    GO
SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[Owner_](
    [id_owner] [int] IDENTITY(1,1) NOT NULL,
    [owner_name] [varchar](255) NOT NULL,
    CONSTRAINT [PK_Owner_] PRIMARY KEY NONCLUSTERED
(
[id_owner] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Realtor]    Script Date: 06.10.2020 15:59:59 ******/
SET ANSI_NULLS ON
    GO
SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[Realtor](
    [id_realtor] [int] IDENTITY(1,1) NOT NULL,
    [realtor_name] [varchar](255) NOT NULL,
    CONSTRAINT [PK_Realtor] PRIMARY KEY NONCLUSTERED
(
[id_realtor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Street]    Script Date: 06.10.2020 15:59:59 ******/
SET ANSI_NULLS ON
    GO
SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[Street](
    [id_street] [int] IDENTITY(1,1) NOT NULL,
    [street_name] [varchar](255) NOT NULL,
    [id_city] [int] NOT NULL,
    CONSTRAINT [PK_Street] PRIMARY KEY NONCLUSTERED
(
[id_street] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
ALTER TABLE [dbo].[Contract_]  WITH NOCHECK ADD  CONSTRAINT [FK_Contract__Customer] FOREIGN KEY([id_customer])
    REFERENCES [dbo].[Customer] ([id_customer])
    GO
ALTER TABLE [dbo].[Contract_] CHECK CONSTRAINT [FK_Contract__Customer]
    GO
ALTER TABLE [dbo].[Contract_]  WITH NOCHECK ADD  CONSTRAINT [FK_Contract__Owner_] FOREIGN KEY([id_owner])
    REFERENCES [dbo].[Owner_] ([id_owner])
    GO
ALTER TABLE [dbo].[Contract_] CHECK CONSTRAINT [FK_Contract__Owner_]
    GO
ALTER TABLE [dbo].[Contract_]  WITH NOCHECK ADD  CONSTRAINT [FK_Contract__Realtor] FOREIGN KEY([id_realtor])
    REFERENCES [dbo].[Realtor] ([id_realtor])
    GO
ALTER TABLE [dbo].[Contract_] CHECK CONSTRAINT [FK_Contract__Realtor]
    GO
ALTER TABLE [dbo].[Cottage]  WITH NOCHECK ADD  CONSTRAINT [FK_Cottage_Owner_] FOREIGN KEY([id_owner])
    REFERENCES [dbo].[Owner_] ([id_owner])
    GO
ALTER TABLE [dbo].[Cottage] CHECK CONSTRAINT [FK_Cottage_Owner_]
    GO
ALTER TABLE [dbo].[Cottage]  WITH NOCHECK ADD  CONSTRAINT [FK_Cottage_Street] FOREIGN KEY([id_street])
    REFERENCES [dbo].[Street] ([id_street])
    GO
ALTER TABLE [dbo].[Cottage] CHECK CONSTRAINT [FK_Cottage_Street]
    GO
ALTER TABLE [dbo].[Cottage_contract]  WITH NOCHECK ADD  CONSTRAINT [FK_Cottage_contract_Contract_] FOREIGN KEY([id_contract])
    REFERENCES [dbo].[Contract_] ([id_contract])
    GO
ALTER TABLE [dbo].[Cottage_contract] CHECK CONSTRAINT [FK_Cottage_contract_Contract_]
    GO
ALTER TABLE [dbo].[Cottage_contract]  WITH NOCHECK ADD  CONSTRAINT [FK_Cottage_contract_Cottage] FOREIGN KEY([id_cottage])
    REFERENCES [dbo].[Cottage] ([id_cottage])
    GO
ALTER TABLE [dbo].[Cottage_contract] CHECK CONSTRAINT [FK_Cottage_contract_Cottage]
    GO
ALTER TABLE [dbo].[Customer]  WITH NOCHECK ADD  CONSTRAINT [FK_Customer_City] FOREIGN KEY([id_city_of_residence])
    REFERENCES [dbo].[City] ([id_city])
    GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_Customer_City]
    GO
ALTER TABLE [dbo].[Flat]  WITH NOCHECK ADD  CONSTRAINT [FK_Flat_House] FOREIGN KEY([id_house])
    REFERENCES [dbo].[House] ([id_house])
    GO
ALTER TABLE [dbo].[Flat] CHECK CONSTRAINT [FK_Flat_House]
    GO
ALTER TABLE [dbo].[Flat]  WITH NOCHECK ADD  CONSTRAINT [FK_Flat_Owner_] FOREIGN KEY([id_owner])
    REFERENCES [dbo].[Owner_] ([id_owner])
    GO
ALTER TABLE [dbo].[Flat] CHECK CONSTRAINT [FK_Flat_Owner_]
    GO
ALTER TABLE [dbo].[Flat_contract]  WITH NOCHECK ADD  CONSTRAINT [FK_Flat_contract_Contract_] FOREIGN KEY([id_contract])
    REFERENCES [dbo].[Contract_] ([id_contract])
    GO
ALTER TABLE [dbo].[Flat_contract] CHECK CONSTRAINT [FK_Flat_contract_Contract_]
    GO
ALTER TABLE [dbo].[Flat_contract]  WITH NOCHECK ADD  CONSTRAINT [FK_Flat_contract_Flat] FOREIGN KEY([id_flat])
    REFERENCES [dbo].[Flat] ([id_flat])
    GO
ALTER TABLE [dbo].[Flat_contract] CHECK CONSTRAINT [FK_Flat_contract_Flat]
    GO
ALTER TABLE [dbo].[House]  WITH NOCHECK ADD  CONSTRAINT [FK_House_Street] FOREIGN KEY([id_street])
    REFERENCES [dbo].[Street] ([id_street])
    GO
ALTER TABLE [dbo].[House] CHECK CONSTRAINT [FK_House_Street]
    GO
ALTER TABLE [dbo].[Street]  WITH NOCHECK ADD  CONSTRAINT [FK_Street_City] FOREIGN KEY([id_city])
    REFERENCES [dbo].[City] ([id_city])
    GO
ALTER TABLE [dbo].[Street] CHECK CONSTRAINT [FK_Street_City]
    GO
/****** Object:  StoredProcedure [dbo].[ADD_COTTAGE]    Script Date: 06.10.2020 15:59:59 ******/
SET ANSI_NULLS ON
    GO
SET QUOTED_IDENTIFIER ON
    GO

CREATE PROC [dbo].[ADD_COTTAGE]
@cottage_number int, @num_of_floors int, @square_of_cottage float,
@num_of_rooms int, @price int, @id_owner int, @id_street int
AS
INSERT INTO Cottage VALUES(@cottage_number, @num_of_floors, @square_of_cottage, @num_of_rooms, @price, @id_owner, @id_street)
SELECT id_cottage, cottage_number, num_of_floors, square_of_cottage, num_of_rooms, price, owner_name, street_name, city_name
FROM Cottage ctg INNER JOIN Owner_ o ON ctg.id_owner = o.id_owner
                 INNER JOIN Street st ON ctg.id_street = st.id_street
                 INNER JOIN City c ON st.id_city = c.id_city
WHERE ctg.id_cottage = SCOPE_IDENTITY()
    GO
/****** Object:  StoredProcedure [dbo].[ADD_FLAT]    Script Date: 06.10.2020 15:59:59 ******/
SET ANSI_NULLS ON
    GO
SET QUOTED_IDENTIFIER ON
    GO

CREATE PROC [dbo].[ADD_FLAT]
@flat_number int, @floor_number int, @square_of_flat float,
@num_of_rooms int, @price int, @id_owner int, @id_house int
AS
INSERT INTO Flat VALUES(@flat_number, @floor_number, @square_of_flat, @num_of_rooms, @price, @id_owner, @id_house)
SELECT id_flat, flat_number, floor_number, square_of_flat, num_of_rooms, price, owner_name, house_num, street_name, city_name
FROM Flat f INNER JOIN Owner_ o ON f.id_owner = o.id_owner
            INNER JOIN House h ON f.id_house = h.id_house
            INNER JOIN Street st ON h.id_street = st.id_street
            INNER JOIN City c ON st.id_city = c.id_city
WHERE f.id_flat = SCOPE_IDENTITY()
    GO
/****** Object:  StoredProcedure [dbo].[DELETE_COTTAGE]    Script Date: 06.10.2020 15:59:59 ******/
SET ANSI_NULLS ON
    GO
SET QUOTED_IDENTIFIER ON
    GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DELETE_COTTAGE]
    @id int
AS
BEGIN
    DELETE FROM Cottage WHERE id_cottage = @id
END
GO
/****** Object:  StoredProcedure [dbo].[DELETE_FLAT]    Script Date: 06.10.2020 15:59:59 ******/
SET ANSI_NULLS ON
    GO
SET QUOTED_IDENTIFIER ON
    GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DELETE_FLAT]
    @id int
AS
BEGIN
    DELETE FROM Flat WHERE id_flat = @id
END
GO
/****** Object:  StoredProcedure [dbo].[FIND_COTTAGE_BY_FILTERS]    Script Date: 06.10.2020 15:59:59 ******/
SET ANSI_NULLS ON
    GO
SET QUOTED_IDENTIFIER ON
    GO



CREATE PROC [dbo].[FIND_COTTAGE_BY_FILTERS]
	@num_of_floors_min int, @num_of_floors_max int,
	@sq_min float, @sq_max float,
	@num_of_rms_min int, @num_of_rms_max int,
	@price_min int, @price_max int,
	@num_of_cottage_min int, @num_of_cottage_max int,
	@city nvarchar, @street nvarchar
AS
SELECT id_cottage, cottage_number, num_of_floors, square_of_cottage, num_of_rooms, price, owner_name, street_name, city_name
FROM Cottage ctg INNER JOIN Owner_ o ON ctg.id_owner = o.id_owner
                 INNER JOIN Street st ON ctg.id_street = st.id_street
                 INNER JOIN City c ON st.id_city = c.id_city
WHERE ctg.id_street = ANY(
    SELECT id_street FROM Street WHERE street_name LIKE @street + '%' AND id_city = ANY(
        SELECT id_city FROM City WHERE city_name LIKE @city + '%'))
  AND num_of_floors >= @num_of_floors_min AND num_of_floors <= @num_of_floors_max AND
        square_of_cottage >= @sq_min AND square_of_cottage <= @sq_max AND
        num_of_rooms >= @num_of_rms_min AND num_of_rooms <= @num_of_rms_max AND
        cottage_number >= @num_of_cottage_min AND cottage_number <= @num_of_cottage_max AND
        price >= @price_min AND price <= @price_max
    GO
/****** Object:  StoredProcedure [dbo].[FIND_FLAT_BY_FILTERS]    Script Date: 06.10.2020 15:59:59 ******/
SET ANSI_NULLS ON
    GO
SET QUOTED_IDENTIFIER ON
    GO

CREATE PROC [dbo].[FIND_FLAT_BY_FILTERS]
	@fl_num_min int, @fl_num_max int,
	@sq_min float, @sq_max float,
	@num_of_rms_min int, @num_of_rms_max int,
	@price_min int, @price_max int,
	@num_of_house_min int,@num_of_house_max int,
	@city nvarchar, @street nvarchar
AS
SELECT id_flat, flat_number, floor_number, square_of_flat, num_of_rooms, price, owner_name, house_num, street_name, city_name
FROM Flat f INNER JOIN Owner_ o ON f.id_owner = o.id_owner
            INNER JOIN House h ON f.id_house = h.id_house
            INNER JOIN Street st ON h.id_street = st.id_street
            INNER JOIN City c ON st.id_city = c.id_city WHERE f.id_house = ANY(
    SELECT id_house FROM House WHERE house_num >= @num_of_house_min AND
            house_num <= @num_of_house_max AND id_street = ANY(
            SELECT id_street FROM Street WHERE street_name LIKE @street + '%' AND id_city = ANY(
                SELECT id_city FROM City WHERE city_name LIKE @city + '%')))
                                                          AND floor_number >= @fl_num_min AND floor_number <= @fl_num_max AND
        square_of_flat >= @sq_min AND square_of_flat <= @sq_max AND
        num_of_rooms >= @num_of_rms_min AND num_of_rooms <= @num_of_rms_max AND
        price >= @price_min AND price <= @price_max
    GO
/****** Object:  StoredProcedure [dbo].[GET_ALL_COTTAGES]    Script Date: 06.10.2020 15:59:59 ******/
SET ANSI_NULLS ON
    GO
SET QUOTED_IDENTIFIER ON
    GO

CREATE PROC [dbo].[GET_ALL_COTTAGES]
AS
SELECT id_cottage, cottage_number, num_of_floors, square_of_cottage, num_of_rooms, price, owner_name, street_name, city_name
FROM Cottage ctg INNER JOIN Owner_ o ON ctg.id_owner = o.id_owner
                 INNER JOIN Street st ON ctg.id_street = st.id_street
                 INNER JOIN City c ON st.id_city = c.id_city
    GO
/****** Object:  StoredProcedure [dbo].[GET_ALL_FLATS]    Script Date: 06.10.2020 15:59:59 ******/
SET ANSI_NULLS ON
    GO
SET QUOTED_IDENTIFIER ON
    GO
CREATE PROC [dbo].[GET_ALL_FLATS]
AS
SELECT id_flat, flat_number, floor_number, square_of_flat, num_of_rooms, price, owner_name, house_num, street_name, city_name
FROM Flat f INNER JOIN Owner_ o ON f.id_owner = o.id_owner
            INNER JOIN House h ON f.id_house = h.id_house
            INNER JOIN Street st ON h.id_street = st.id_street
            INNER JOIN City c ON st.id_city = c.id_city
    GO
