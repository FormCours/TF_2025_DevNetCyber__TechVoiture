CREATE TABLE [dbo].[Member]
(
	[Id] INT IDENTITY,
	[Email] VARCHAR(300) NOT NULL,
	[HashPassword] NVARCHAR(100) NOT NULL,
	[FirstName] VARCHAR(100) NULL,
	[LastName] VARCHAR(100) NULL,
	[RoleId] INT NOT NULL,
	CONSTRAINT [PK_Member] PRIMARY KEY ([Id]),
	CONSTRAINT [UK_Member_Email] UNIQUE ([Email]),
	CONSTRAINT [FK_MemberRole_Id] FOREIGN KEY ([RoleId])
	REFERENCES [MemberRole] ([Id])
)
