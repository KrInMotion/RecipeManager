USE RecipeDb
GO
DELETE FROM [dbo].[Category]
GO
SET IDENTITY_INSERT [dbo].[Category] ON
GO
INSERT INTO [dbo].[Category] (Id, Name) VALUES(1, N'Первые блюда')
GO
INSERT INTO [dbo].[Category] (Id, Name) VALUES(2, N'Вторые блюда')
GO
INSERT INTO [dbo].[Category] (Id, Name) VALUES(3, N'Закуски')
GO
INSERT INTO [dbo].[Category] (Id, Name) VALUES(4, N'Салаты')
GO
INSERT INTO [dbo].[Category] (Id, Name) VALUES(5, N'Соусы, кремы')
GO
INSERT INTO [dbo].[Category] (Id, Name) VALUES(6, N'Десерты')
GO
INSERT INTO [dbo].[Category] (Id, Name) VALUES(7, N'Выпечка')
GO
INSERT INTO [dbo].[Category] (Id, Name) VALUES(8, N'Соленья')
GO
INSERT INTO [dbo].[Category] (Id, Name) VALUES(9, N'Напитки')
GO
INSERT INTO [dbo].[Category] (Id, Name) VALUES(10, N'Рыба и морепродукты')
GO
INSERT INTO [dbo].[Category] (Id, Name) VALUES(11, N'Блины, оладьи, сырники')
GO
INSERT INTO [dbo].[Category] (Id, Name) VALUES(12, N'Хлеб')
GO
INSERT INTO [dbo].[Category] (Id, Name) VALUES(13, N'Диетические блюда')
GO
INSERT INTO [dbo].[Category] (Id, Name) VALUES(14, N'Вегетарианские блюда')
GO
INSERT INTO [dbo].[Category] (Id, Name) VALUES(99, N'Другое')
GO
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
