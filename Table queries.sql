create database cafe_management_system;

-- Create Guest_Customer table
CREATE TABLE Guest_Customer (
    ID INT PRIMARY KEY,
    Name VARCHAR(255),
    Contact_Info VARCHAR(255)
);

-- Create Registered_Customer table
CREATE TABLE Registered_Customer (
    ID INT PRIMARY KEY,
    Name VARCHAR(255),
    Contact_Info VARCHAR(255),
    Username VARCHAR(255),
    Password VARCHAR(255),
    LoyaltyProgram_ID INT FOREIGN KEY REFERENCES Loyalty_Program(ID)
);

-- Create Feedback table
CREATE TABLE Feedback (
    ID INT IDENTITY(1,1),
    Rating INT,
    Date_Submitted VARCHAR (255),
    Comment VARCHAR(1000),
    Customer_ID INT FOREIGN KEY REFERENCES Registered_Customer(ID)
);


-- Create Loyalty_Program table
CREATE TABLE Loyalty_Program (
    ID INT PRIMARY KEY,
    Tier_Level VARCHAR(50),
    Points INT,
    Expiry_Date VARCHAR (255)
);

-- Create Report table
CREATE TABLE Report (
    ID INT PRIMARY KEY,
    Report_Name VARCHAR(255),
    Report_Type VARCHAR(50)
);

-- Create Menu table
CREATE TABLE Menu (
    ID INT PRIMARY KEY,
    Item_Name VARCHAR(255),
    Description VARCHAR(1000),
    Category VARCHAR(50),
    Price DECIMAL(10, 2),
    Allergens VARCHAR(255),
    Calories INT,
    Macronutrients VARCHAR(255)
);

-- Create CafeManager_Report table
CREATE TABLE CafeManager_Report (
    CafeManager_ID INT FOREIGN KEY REFERENCES Cafe_Manager(ID),
    Report_ID INT FOREIGN KEY REFERENCES Report(ID),
    PRIMARY KEY (CafeManager_ID, Report_ID)
);

-- Create Order table

CREATE TABLE Ordertbl (
    ID INT IDENTITY(1,1),
    Status VARCHAR(50),
    Special_Instruction VARCHAR(1000),
    Total_Amount INT,
    RCustomer_ID INT FOREIGN KEY REFERENCES Registered_Customer(ID) NULL,
	UCustomer_ID INT FOREIGN KEY REFERENCES Guest_Customer(ID) NULL,
    Menu_ID INT FOREIGN KEY REFERENCES Menu(ID),
    Inventory_ID INT FOREIGN KEY REFERENCES Inventory(ID),
);

-- Create Order_Items table
CREATE TABLE Order_Items (
    ID INT IDENTITY(1,1),
    Items VARCHAR(255),
    Items_Quantity INT,
    PRIMARY KEY (ID, Items)
);

-- Create Cashier table
CREATE TABLE Cashier (
    ID INT PRIMARY KEY,
    FName VARCHAR(255),
	pass int,
	Email VARCHAR(255),
	Salary MONEY,
    Contact_Info VARCHAR(255),
    Hire_Date VARCHAR(255),   
);



-- Create Inventory table
CREATE TABLE Inventory (
    ID INT PRIMARY KEY,
    Item_Name VARCHAR(255),
    Quantity INT NULL,
    Expiry_Date VARCHAR(50) NULL,
	menuID INT FOREIGN KEY REFERENCES Menu(ID) ON DELETE CASCADE
);


-- Create CafeManager_Cashier table
CREATE TABLE CafeManager_Cashier (
    CafeManager_ID INT FOREIGN KEY REFERENCES Cafe_Manager(ID),
    Cashier_ID INT FOREIGN KEY REFERENCES Cashier(ID),
    PRIMARY KEY (CafeManager_ID, Cashier_ID)
);

-- Create CafeManager_Feedback table
CREATE TABLE CafeManager_Feedback (
    CafeManager_ID INT FOREIGN KEY REFERENCES Cafe_Manager(ID),
    Feedback_ID INT FOREIGN KEY REFERENCES Feedback(ID),
    PRIMARY KEY (CafeManager_ID, Feedback_ID)
);

CREATE TABLE [dbo].[Manager] (
    [Mid]    INT          NOT NULL,
    [Fname]  VARCHAR (50) NOT NULL,
    [Lname]  VARCHAR (50) NOT NULL,
    [memail] VARCHAR (50) NOT NULL,
    [mpass]  VARCHAR (50) NOT NULL,
    [mExp]   VARCHAR (50) NOT NULL,
    [mCont]  VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Mid] ASC)
);

-- Create Trigger
GO
CREATE TRIGGER BeforeInsert_Manager
ON Manager
AFTER INSERT
AS
BEGIN
    -- Check if memail is unique
    IF (SELECT COUNT(*) FROM Manager M INNER JOIN INSERTED I ON M.memail = I.memail) > 0
    BEGIN
        print 'Email address must be unique.'
        RETURN;
    END;

    -- If memail is unique, you can add additional logic or validation checks here
END;


--Trigger 2
GO
CREATE TRIGGER BeforeInsert_Registered_Customer
ON Registered_Customer
INSTEAD OF INSERT
AS
BEGIN
    -- Check if LoyaltyProgram_ID is not NULL
    IF (SELECT COUNT(*) FROM INSERTED WHERE LoyaltyProgram_ID IS NULL) > 0
    BEGIN
        Print 'LoyaltyProgram_ID cannot be NULL'
        RETURN;
    END;

    -- If LoyaltyProgram_ID is not NULL, proceed with the insertion
    INSERT INTO Registered_Customer (ID, Name, Contact_Info, Username, Password, LoyaltyProgram_ID)
    SELECT ID, Name, Contact_Info, Username, Password, LoyaltyProgram_ID FROM INSERTED;
END

--Trigger 3
-- Create Trigger
GO
CREATE TRIGGER BeforeInsert_Cashier
ON Cashier
AFTER INSERT
AS
BEGIN
    -- Check if Salary is not negative
    IF (SELECT COUNT(*) FROM INSERTED WHERE Salary < 0) > 0
    BEGIN
        print'Salary cannot be negative.'
        RETURN;
    END;

    -- If Salary is not negative, proceed with the insertion
    -- You can add additional logic or validation checks if needed

END;