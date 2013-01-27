-- USERS
DELETE FROM EnterpriseDb.dbo.[User]
DBCC CHECKIDENT([User], RESEED, 1)


-- LOCATION
DELETE FROM EnterpriseDb.dbo.[Location]
DBCC CHECKIDENT([Location], RESEED, 1)



-- ORGANIZATION
DELETE FROM EnterpriseDb.dbo.[Organization]
DBCC CHECKIDENT([Organization], RESEED, 1)
SET IDENTITY_INSERT [Organization] ON

INSERT INTO [EnterpriseDb].[dbo].[Organization]([OrganizationID], [Name], [Code], [TypeID], [StatusID])
(
	SELECT [idClient], [ClientName], [ClientCode], 3, 1 FROM [Ent-sql1.msionline.local].MSIEnterprise.dbo.Client
)
GO
SET IDENTITY_INSERT [Organization] OFF
GO


SET IDENTITY_INSERT [User] ON
-- INSERT USERS
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
          u.[FirstName],
          u.[LastName],
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


SET IDENTITY_INSERT [Location] ON
GO

-- LOAD LOCATION DATA



SET IDENTITY_INSERT [Location] OFF


GO 
