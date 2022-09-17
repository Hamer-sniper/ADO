CREATE TABLE [dbo].[SQL_Table] (
    [Id]             INT IDENTITY(1,1) NOT NULL,
    [Фамилия]        NCHAR (50) NULL,
    [Имя]            NCHAR (50) NULL,
    [Отчество]       NCHAR (50) NULL,
    [Номер телефона] NCHAR (20) NULL,
    [Email]          NCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);