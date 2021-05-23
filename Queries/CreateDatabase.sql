IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Attendant] (
    [AttendantID] int NOT NULL IDENTITY,
    [Phone] nvarchar(20) NULL,
    CONSTRAINT [PK_Attendant] PRIMARY KEY ([AttendantID])
);
GO

CREATE TABLE [Driver] (
    [DriverID] int NOT NULL IDENTITY,
    [Phone] nvarchar(20) NULL,
    CONSTRAINT [PK_Driver] PRIMARY KEY ([DriverID])
);
GO

CREATE TABLE [Routes] (
    [RouteID] int NOT NULL IDENTITY,
    [DriverID] int NOT NULL,
    [AttendantID] int NOT NULL,
    [NrOfSeats] nvarchar(10) NOT NULL,
    [StartAdress] nvarchar(50) NOT NULL,
    [EndAdress] nvarchar(50) NOT NULL,
    [ETA] nvarchar(10) NULL,
    [PickupPoints] nvarchar(max) NULL,
    [ImageName] nvarchar(max) NULL,
    CONSTRAINT [PK_Routes] PRIMARY KEY ([RouteID]),
    CONSTRAINT [FK_Routes_Attendant_AttendantID] FOREIGN KEY ([AttendantID]) REFERENCES [Attendant] ([AttendantID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Routes_Driver_DriverID] FOREIGN KEY ([DriverID]) REFERENCES [Driver] ([DriverID]) ON DELETE CASCADE
);
GO

CREATE TABLE [AssignAttendant] (
    [AssignAttendantID] int NOT NULL IDENTITY,
    CONSTRAINT [PK_AssignAttendantID] PRIMARY KEY ([AssignAttendantID]),
    CONSTRAINT [FK_Routes_Route_RouteID] FOREIGN KEY ([RouteID]) REFERENCES [Route] ([RouteID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Routes_Attendant_AttendantID] FOREIGN KEY ([AttendantID]) REFERENCES [Attendant] ([AttendantID]) ON DELETE CASCADE,
);
GO

CREATE INDEX [IX_Routes_AttendantID] ON [Routes] ([AttendantID]);
GO

CREATE INDEX [IX_Routes_DriverID] ON [Routes] ([DriverID]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210523220836_first', N'5.0.6');
GO

COMMIT;
GO

