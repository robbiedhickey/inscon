
-- DELETE USERS
DELETE FROM EnterpriseDb.dbo.[User]
DBCC CHECKIDENT([User], RESEED, 1)

-- DELETE LOCATION
DELETE FROM EnterpriseDb.dbo.[Location]
DBCC CHECKIDENT([Location], RESEED, 1)

-- DELETE ORGANIZATION
DELETE FROM EnterpriseDb.dbo.[Organization]
DBCC CHECKIDENT([Organization], RESEED, 1)

-- DELETE LOOKUP
DELETE FROM [EnterpriseDb].[generic].[Lookup]
WHERE OldId is not null

-- DELETE LOOKUP GROUP
DELETE FROM [EnterpriseDb].[generic].[LookupGroup]
WHERE OldId is not null

-- INSERT LOOKUP GROUP
INSERT INTO [EnterpriseDb].[generic].[LookupGroup]
(
  [Name],
  [OldID]
)
  (SELECT LookupCategoryName,
          idLookupCategory
   FROM   MSIEnterprise.dbo.LookupCategory
   WHERE  idLookupCategory != 25
          AND LookupCategoryName NOT LIKE '%Claim%')


-- INSERT LOOKUP VALUES
INSERT INTO [EnterpriseDb].[generic].[Lookup]
(
  [LookupGroupID],
  [Value],
  [OldID]
)
  (SELECT lg.LookupGroupID,
          l.LookupDescription,
          l.idLookup
   FROM   MSIEnterprise.dbo.[Lookup] l
          INNER JOIN EnterpriseDb.generic.LookupGroup lg
                  ON lg.OldID = l.idLookupCategory)

GO 




-- INSERT ORGANIZATION
SET IDENTITY_INSERT [Organization] ON
INSERT INTO [EnterpriseDb].[dbo].[Organization]
(
  [OrganizationID],
  [Name],
  [Code],
  [TypeID],
  [StatusID]
)
  (SELECT [idClient],
          [ClientName],
          [ClientCode],
          3,
          1
   FROM   [Ent-sql1.msionline.local].MSIEnterprise.dbo.Client)

GO
SET IDENTITY_INSERT [Organization] OFF
GO

-- INSERT USERS
SET IDENTITY_INSERT [User] ON
INSERT INTO [EnterpriseDb].[dbo].[User]
(
  [UserID],
  [OrganizationID],
  [FirstName],
  [LastName],
  [Title],
  [StatusID]
)
  (SELECT DISTINCT
          u.idUser,
          o.OrganizationID,
          LTRIM(RTRIM(UPPER(u.[FirstName]))),
          LTRIM(RTRIM(UPPER(u.[LastName]))),
          NULL,
          CASE
            WHEN u.Activated = 0 THEN 9
            ELSE 8
          END AS 'Status'
   FROM   [Ent-sql1.msionline.local].MSIEnterprise.dbo.Users u
          INNER JOIN [Ent-sql1.msionline.local].MSIEnterprise.dbo.AuthorizedPerson ap
                  ON ap.idUser = u.idUser
          INNER JOIN [Ent-sql1.msionline.local].MSIEnterprise.dbo.Client c
                  ON c.idClient = ap.idclient
          INNER JOIN EnterpriseDb.dbo.Organization o
                  ON o.OrganizationID = c.idclient
   WHERE  u.Deleted != 1)

GO
SET IDENTITY_INSERT [User] OFF
GO

-- LOAD LOCATION DATA
SET IDENTITY_INSERT [Location] ON
INSERT INTO EnterpriseDb.dbo.Location
(
  [LocationID],
  [OrganizationID],
  [Name],
  [Code],
  [TypeID]
)
  (SELECT d.idDepartment,
          o.OrganizationID,
          LTRIM(RTRIM(UPPER(d.DepartmentName))),
          LTRIM(RTRIM(UPPER(d.DeptCode))),
          10 -- TYPE DEPARTMENT
   FROM   MSIEnterprise.dbo.Department d
          INNER JOIN EnterpriseDb.dbo.Organization o
                  ON o.OrganizationID = d.idClient)

GO
SET IDENTITY_INSERT [Location] OFF
GO

-- DELETE ASSET DATA
DELETE FROM [Asset]
DBCC CHECKIDENT([Asset], RESEED, 1)

-- INSERT ASSET DATA
SET IDENTITY_INSERT [Asset] ON
INSERT INTO [EnterpriseDb].[dbo].[Asset]
(
  [AssetID],
  [OrganizationID],
  [TypeID],
  [AssetNumber],
  [LoanNumber],
  [LoanTypeID],
  [MortgagorName],
  [MortgagorPhone],
  [HudCaseNumber],
  [ConveyanceDate],
  [FirstTimeVacantDate]
)
  (SELECT l.idLoan,
          l.idClient,
          30,
          NULL,
          LTRIM(RTRIM(l.LoanNumber)),
          IsNull(dbo.GetNewLookupValue(l.LoanType), 176),-- 176 = UNKNOWN
          LTRIM(RTRIM(l.Mortgagor)),
          NULL,
          NULL,
          NULL,
          (SELECT TOP 1 i.FirstVacantDate
           FROM   MSIEnterprise.dbo.WorkOrder w
                  INNER JOIN MSIEnterprise.dbo.Loan ll
                          ON ll.idLoan = w.idLoan
                  INNER JOIN MSIEnterprise.dbo.Inspection i
                          ON i.idWorkOrder = w.idWorkOrder
           WHERE  w.idLoan = l.idLoan
                  AND i.FirstTimeVacant = 1)
   FROM   MSIEnterprise.dbo.[Loan] l)

GO

SET IDENTITY_INSERT [Asset] OFF 



-- DELETE LOCATION
DELETE FROM [EnterpriseDb].[generic].[AddressLocation]

DELETE FROM EnterpriseDb.generic.[AddressUse]
DBCC CHECKIDENT([EnterpriseDb.generic.AddressUse], RESEED, 1)

DELETE FROM EnterpriseDb.generic.[Address]
DBCC CHECKIDENT([EnterpriseDb.generic.Address], RESEED, 1)
GO

-- INSERT ASSET ADDRESS
IF OBJECT_ID (N'TempAddetAddressTable', N'U') IS NOT NULL
  DROP TABLE dbo.TempAddetAddressTable;

SELECT DISTINCT
       l.LoanNumber,
       l.idClient,
       24                           AS 'EntityID',
       dbo.CleanAddress(w.Address1) AS 'Address',
       w.City                       AS 'City',
       w.[State]                    AS 'State',
       w.ZipCode                    AS 'Zip'
INTO   TempAddetAddressTable
FROM   MSIEnterprise.dbo.Loan l
       LEFT OUTER JOIN MSIEnterprise.dbo.WorkOrder w
                    ON w.idLoan = l.idLoan
       INNER JOIN EnterpriseDb.dbo.Asset a
               ON a.LoanNumber = l.LoanNumber
                  AND a.OrganizationID = l.idClient
ORDER  BY l.idClient,
          l.LoanNumber,
          dbo.CleanAddress(w.Address1)

INSERT INTO [EnterpriseDb].[generic].[Address]
(
  [ParentID],
  [EntityID],
  [Street],
  [City],
  [State],
  [Zip]
)
  (SELECT a.AssetID,
          t.EntityID,
          t.[Address],
          t.City,
          t.[State],
          t.Zip
   FROM   TempAddetAddressTable t
          INNER JOIN EnterpriseDb.dbo.Asset a
                  ON t.LoanNumber = a.LoanNumber
                     AND a.OrganizationID = t.idClient
                     
    WHERE t.[Address] IS NOT NULL
    )


  
GO

IF OBJECT_ID (N'TempAddetAddressTable', N'U') IS NOT NULL
  DROP TABLE dbo.TempAddetAddressTable;

GO 

-- CLEAR ADDRESSUSE TABLE
DELETE FROM [EnterpriseDb].[generic].[AddressUse]

-- INSERT ADDRESS USE
INSERT INTO [EnterpriseDb].[generic].[AddressUse]
(
  [AddressID],
  [TypeID]
)
  (SELECT AddressID,
          27
   FROM   enterpriseDb.generic.[Address])

GO 

--- UPDATE MORTGAGOR PHONE FROM INSPECTION TABLE
UPDATE EnterpriseDb.dbo.Asset
SET    MortgagorPhone = (SELECT DISTINCT TOP 1
                                i.BorrowerHomePhone
                         FROM   MSIEnterprise.dbo.Inspection i
                                INNER JOIN MSIEnterprise. dbo.WorkOrder w
                                        ON w.idWorkOrder = i.idWorkOrder
                                INNER JOIN MSIEnterprise.dbo.Loan l
                                        ON l.idLoan = w.idLoan
                                INNER JOIN MSIEnterprise.dbo.Client c
                                        ON c.idClient = l.idClient
                                INNER JOIN EnterpriseDb.dbo.Asset a
                                        ON a.LoanNumber = l.LoanNumber
                                           AND a.OrganizationID = l.idClient
                         WHERE  a.AssetID = AssetID)

GO

UPDATE EnterpriseDb.dbo.Asset
SET    MortgagorPhone = LTRIM(RTRIM(MortgagorPhone))

GO

UPDATE EnterpriseDb.dbo.Asset
SET    MortgagorPhone = NULL
WHERE  LEN(MortgagorPhone) < 10

GO 


