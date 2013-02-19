CREATE TABLE [inspection].[PropertyDamage]
(
[WorkOrderID] [int] NOT NULL,
[Vandalized] [int] NULL,
[FireDamage] [int] NULL,
[LiabilityHazard] [int] NULL,
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
[Comments] [varchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[StructuralDamage] [bit] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [inspection].[PropertyDamage] ADD CONSTRAINT [pk_propertydamage] PRIMARY KEY CLUSTERED  ([WorkOrderID]) ON [PRIMARY]
GO
