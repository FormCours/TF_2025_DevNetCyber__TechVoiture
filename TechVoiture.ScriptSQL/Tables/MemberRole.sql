create table [dbo].[MemberRole]
(
-- columns
	[Id] integer identity not null
,	[Name] nvarchar(20) not null
,	[Desc] nvarchar(500)
-- constraints
,	constraint [PK_MemberRole] primary key ([Id])
,	constraint [UK_MemberRole_Name] unique ([Name])
);
