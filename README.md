# KarachiGas
 
#### ADD ACCOUNT DETAILS
```sh
CREATE PROCEDURE [dbo].[AddAccountDetail] (@AccId bigint, @PrevBalance money, @TxAmount money, @NewBalance money)
AS
INSERT INTO AccountDetail
VALUES (@AccId, @PrevBalance, @TxAmount, @NewBalance)
```

#### CreateParty
```sh
ALTER PROCEDURE [dbo].[CreateParty] (@AccId bigint, @Title nvarchar(50), @Address nvarchar(50), @Ntn nvarchar(50),@Phone nvarchar(50),@UserId bigint)
AS
INSERT INTO Party
VALUES (@AccId, @Title, @Address, @Ntn, @Phone, @UserId)
```

#### CreateRates
```sh
ALTER PROCEDURE [dbo].[CreateRates] (@Small money, @Medium money, @Large money, @UserId bigint)
AS
INSERT INTO Rates
VALUES (@Small, @Medium, @Large, (SELECT GETDATE()), @UserId)
```

#### CreateSale
```sh
ALTER PROCEDURE [dbo].[CreateSale] (@SaleType int, @RateId bigint, @Qtysmall numeric(18,0), @Qtymedium numeric(18,0), @Qtylarge numeric(18,0), @UserId bigint)
AS
INSERT INTO Sales
VALUES (@SaleType, (SELECT GETDATE()), @UserId)

DECLARE @SaleID bigint
SET @SaleID = (SELECT MAX(ID) FROM Sales)

INSERT INTO SaleData
VALUES (@SaleID, @RateId, @Qtysmall, @Qtymedium, @Qtylarge)
```

#### CreateUser
```sh
ALTER PROCEDURE [dbo].[CreateUser] (@Firstname nvarchar(50), @Lastname nvarchar(50), @Cnic nvarchar(50), @Phone nvarchar(50), @Email nvarchar(50))
AS
INSERT INTO Users
VALUES (@Firstname, @Lastname, @Cnic, @Phone, @Email)
```

#### DeleteCompany
```sh
ALTER PROCEDURE [dbo].[DeleteCompany] (@ID bigint)
AS
UPDATE Company
SET IsActive = 0
WHERE ID = @ID
```

#### DeleteParty
```sh
ALTER PROCEDURE [dbo].[DeleteParty] (@ID bigint)
AS
UPDATE Party
SET IsActive = 0
WHERE ID = @ID
```

#### DeleteUser
```sh
ALTER PROCEDURE [dbo].[DeleteUser] (@ID bigint)
AS
UPDATE Users
SET IsActive = 0
WHERE ID = @ID
```

#### FetchAccounts
```sh
ALTER PROCEDURE [dbo].[FetchAccounts] (@ID bigint)
AS
IF @ID = 0
SELECT * FROM Accounts WHERE IsActive = 1
ELSE
SELECT * FROM Accounts WHERE IsActive = 1 AND ID = @ID
```

#### FetchCompany
```sh
ALTER PROCEDURE [dbo].[FetchCompany] (@ID bigint)
AS
IF @ID = 0
SELECT * FROM Company WHERE IsActive = 1
ELSE
SELECT * FROM Company WHERE IsActive = 1 AND ID = @ID
```

#### FetchParty
```sh
ALTER PROCEDURE [dbo].[FetchParty] (@ID bigint)
AS
IF @ID = 0
SELECT * FROM Party WHERE IsActive = 1
ELSE
SELECT * FROM Party WHERE IsActive = 1 AND ID = @ID
```

#### FetchUser
```sh
ALTER PROCEDURE [dbo].[FetchUser] (@ID bigint)
AS
IF @ID = 0
SELECT * FROM Users WHERE IsActive = 1
ELSE
SELECT * FROM Users Where IsActive = 1 and ID = @ID
```

#### GetCylinderSummary
```sh
ALTER PROCEDURE [dbo].[GetCylinderSummary](@AccId bigint)
AS
SELECT CS.ID, A.Title, CS.Prevlarge, CS.Prevmedium, CS.Prevsmall, 
SD.Qtylarge, SD.Qtymedium, SD.Qtysmall, CS.Balsmall, CS.Balmedium, CS.Ballarge, CS.[Timestamp]
FROM CylinderSummary CS 
INNER JOIN Sales S ON S.ID = CS.SaleId
INNER JOIN SaleData SD ON SD.ID = S.ID
INNER JOIN Accounts A ON A.ID = S.AccId
WHERE A.ID = @AccId
```

#### UpdateAccount
```sh
ALTER PROCEDURE [dbo].[UpdateAccount] (@ID bigint, @TypeId int, @Title nvarchar(50))
AS
UPDATE Accounts
SET [Type] = @TypeId,
	Title = @Title,
	ModifiedOn = (SELECT GETDATE())
WHERE ID = @ID
```

#### UpdateCompany
```sh
ALTER PROCEDURE [dbo].[UpdateCompany] (@ID bigint, @Title nvarchar(50), @Address nvarchar(50), @Ntn nvarchar(50), @Phone nvarchar(50))
AS
UPDATE Company
SET Title = @Title,
	[Address] = @Address,
	Ntn = @Ntn,
	Phone = @Phone
WHERE ID = @ID
```

#### UpdateParty
```sh
ALTER PROCEDURE [dbo].[UpdateParty] (@ID bigint, @AccId bigint, @Title nvarchar(50), @Address nvarchar(50), @Ntn nvarchar(50),@Phone nvarchar(50),@UserId bigint)
AS
UPDATE Party
SET AccID = @AccId,
	Title = @Title, 
	[Address] = @Address,
	Ntn = @Ntn, 
	Phone = @Phone,
	UserId = @UserId
WHERE ID = @ID
```

#### UpdateUser
```sh
ALTER PROCEDURE [dbo].[UpdateUser] (@ID bigint, @Firstname nvarchar(50), @Lastname nvarchar(50), @Cnic nvarchar(50), @Phone nvarchar(50), @Email nvarchar(50))
AS
UPDATE Users
SET Firstname = @Firstname,
	Lastname = @Lastname,
	Cnic = @Cnic,
	Phone = @Phone,
	Email = @Email
WHERE ID = @ID
```



