CREATE TABLE [inspection].[PropertyDamage]
(
[WorkOrderID] [int] NOT NULL,
[Vandalized] [bit] NULL,
[FireDamage] [bit] NULL,
[LiabilityHazard] [bit] NULL,
[StormDamage] [bit] NULL,
[FloodDamage] [bit] NULL,
[FreezeDamage] [bit] NULL,
[RoofLeak] [bit] NULL,
[Neglected] [bit] NULL,
[EarthquakeDamage] [bit] NULL,
[CityViolation] [bit] NULL,
[Mold] [bit] NULL,
[BrokenWindows] [bit] NULL,
[BurstPipes] [bit] NULL,
[StructuralDamage] [bit] NULL
) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Broken Windows', 'SCHEMA', N'inspection', 'TABLE', N'PropertyDamage', 'COLUMN', N'BrokenWindows'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Burst Pipes', 'SCHEMA', N'inspection', 'TABLE', N'PropertyDamage', 'COLUMN', N'BurstPipes'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - City Violation', 'SCHEMA', N'inspection', 'TABLE', N'PropertyDamage', 'COLUMN', N'CityViolation'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Earthquake Damage', 'SCHEMA', N'inspection', 'TABLE', N'PropertyDamage', 'COLUMN', N'EarthquakeDamage'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Fire Damage', 'SCHEMA', N'inspection', 'TABLE', N'PropertyDamage', 'COLUMN', N'FireDamage'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Flood Damage', 'SCHEMA', N'inspection', 'TABLE', N'PropertyDamage', 'COLUMN', N'FloodDamage'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Freeze Damage', 'SCHEMA', N'inspection', 'TABLE', N'PropertyDamage', 'COLUMN', N'FreezeDamage'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Liability Hazard', 'SCHEMA', N'inspection', 'TABLE', N'PropertyDamage', 'COLUMN', N'LiabilityHazard'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Mold Damage', 'SCHEMA', N'inspection', 'TABLE', N'PropertyDamage', 'COLUMN', N'Mold'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Neglected', 'SCHEMA', N'inspection', 'TABLE', N'PropertyDamage', 'COLUMN', N'Neglected'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Roof Leak', 'SCHEMA', N'inspection', 'TABLE', N'PropertyDamage', 'COLUMN', N'RoofLeak'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Storm Damage', 'SCHEMA', N'inspection', 'TABLE', N'PropertyDamage', 'COLUMN', N'StormDamage'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Structural Damage', 'SCHEMA', N'inspection', 'TABLE', N'PropertyDamage', 'COLUMN', N'StructuralDamage'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Vandalized', 'SCHEMA', N'inspection', 'TABLE', N'PropertyDamage', 'COLUMN', N'Vandalized'
GO

ALTER TABLE [inspection].[PropertyDamage] ADD CONSTRAINT [pk_propertydamage] PRIMARY KEY CLUSTERED  ([WorkOrderID]) ON [PRIMARY]
GO
