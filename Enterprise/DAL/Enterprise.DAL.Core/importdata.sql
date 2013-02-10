-- DELETE USERS
DELETE FROM EnterpriseDb.dbo.[User]
DBCC CHECKIDENT([User], RESEED, 1)

-- DELETE LOCATION
DELETE FROM EnterpriseDb.dbo.[Location]
DBCC CHECKIDENT([Location], RESEED, 1)

-- DELETE ORGANIZATION
DELETE FROM EnterpriseDb.dbo.[Organization]
DBCC CHECKIDENT([Organization], RESEED, 1)

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
