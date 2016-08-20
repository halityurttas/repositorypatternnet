CREATE TABLE [dbo].[Student] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (50) NOT NULL,
    [SurName]   NVARCHAR (50) NOT NULL,
    [Classroom] NVARCHAR (5)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

