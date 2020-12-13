SET IDENTITY_INSERT [dbo].[Parlour] ON
INSERT INTO [dbo].[Parlour] ([Parlour_ID], [Parlour_Name], [Parlour_Address], [Contact_Number]) VALUES (1, N'Kess', N'Horton road', 228743788)
INSERT INTO [dbo].[Parlour] ([Parlour_ID], [Parlour_Name], [Parlour_Address], [Contact_Number]) VALUES (2, N'Kess', N'Norton road', 223532897)
INSERT INTO [dbo].[Parlour] ([Parlour_ID], [Parlour_Name], [Parlour_Address], [Contact_Number]) VALUES (3, N'Kess', N'claudylands', 2234565)
INSERT INTO [dbo].[Parlour] ([Parlour_ID], [Parlour_Name], [Parlour_Address], [Contact_Number]) VALUES (4, N'Kess', N'Auckland', 22345656)
INSERT INTO [dbo].[Parlour] ([Parlour_ID], [Parlour_Name], [Parlour_Address], [Contact_Number]) VALUES (5, N'Kess', N'wellington', 22456677)
INSERT INTO [dbo].[Parlour] ([Parlour_ID], [Parlour_Name], [Parlour_Address], [Contact_Number]) VALUES (6, N'Kess', N'Rotoura', 22342678)
SET IDENTITY_INSERT [dbo].[Parlour] OFF
SET IDENTITY_INSERT [dbo].[Beautician] ON
INSERT INTO [dbo].[Beautician] ([Beautician_ID], [Beautician_Name], [Contact_Number], [Joining_Date], [Salary], [ParlourID]) VALUES (1, N'Monika', 226774873, N'2020-12-17 00:00:00', 7687, 1)
INSERT INTO [dbo].[Beautician] ([Beautician_ID], [Beautician_Name], [Contact_Number], [Joining_Date], [Salary], [ParlourID]) VALUES (2, N'hetal', 99876567, N'2018-12-16 00:00:00', 1200, 1)
INSERT INTO [dbo].[Beautician] ([Beautician_ID], [Beautician_Name], [Contact_Number], [Joining_Date], [Salary], [ParlourID]) VALUES (3, N'keryan', 998767856, N'2016-12-15 00:00:00', 1400, 1)
INSERT INTO [dbo].[Beautician] ([Beautician_ID], [Beautician_Name], [Contact_Number], [Joining_Date], [Salary], [ParlourID]) VALUES (4, N'Neelam', 223435918, N'2017-12-09 00:00:00', 1200, 1)
INSERT INTO [dbo].[Beautician] ([Beautician_ID], [Beautician_Name], [Contact_Number], [Joining_Date], [Salary], [ParlourID]) VALUES (5, N'Vandana', 998765678, N'2015-12-09 00:00:00', 1200, 1)
INSERT INTO [dbo].[Beautician] ([Beautician_ID], [Beautician_Name], [Contact_Number], [Joining_Date], [Salary], [ParlourID]) VALUES (6, N'kunal', 998786767, N'2011-12-25 00:00:00', 1800, 1)
SET IDENTITY_INSERT [dbo].[Beautician] OFF
SET IDENTITY_INSERT [dbo].[Customer] ON
INSERT INTO [dbo].[Customer] ([Customer_ID], [Customer_Name], [Contact_Number], [Expenses], [ParlourID]) VALUES (2, N'Rahul', 22677889, 134, 1)
INSERT INTO [dbo].[Customer] ([Customer_ID], [Customer_Name], [Contact_Number], [Expenses], [ParlourID]) VALUES (3, N'Henna', 22677898, 234, 2)
INSERT INTO [dbo].[Customer] ([Customer_ID], [Customer_Name], [Contact_Number], [Expenses], [ParlourID]) VALUES (4, N'Ishu', 22566778, 120, 3)
INSERT INTO [dbo].[Customer] ([Customer_ID], [Customer_Name], [Contact_Number], [Expenses], [ParlourID]) VALUES (5, N'Anik', 22768789, 23, 4)
INSERT INTO [dbo].[Customer] ([Customer_ID], [Customer_Name], [Contact_Number], [Expenses], [ParlourID]) VALUES (6, N'Sanjay', 22677687, 10, 5)
INSERT INTO [dbo].[Customer] ([Customer_ID], [Customer_Name], [Contact_Number], [Expenses], [ParlourID]) VALUES (7, N'Bik', 22767898, 20, 6)
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Product] ON
INSERT INTO [dbo].[Product] ([Product_ID], [Product_Name], [Expiry_Date], [ParlourID]) VALUES (2, N'Hair Product', N'2021-01-08 00:00:00', 1)
INSERT INTO [dbo].[Product] ([Product_ID], [Product_Name], [Expiry_Date], [ParlourID]) VALUES (3, N'Body Product', N'2021-04-16 00:00:00', 2)
INSERT INTO [dbo].[Product] ([Product_ID], [Product_Name], [Expiry_Date], [ParlourID]) VALUES (4, N'Facewash', N'2021-02-20 00:00:00', 3)
INSERT INTO [dbo].[Product] ([Product_ID], [Product_Name], [Expiry_Date], [ParlourID]) VALUES (5, N'Hair spa', N'2021-04-21 00:00:00', 4)
INSERT INTO [dbo].[Product] ([Product_ID], [Product_Name], [Expiry_Date], [ParlourID]) VALUES (6, N'Body Wash', N'2021-08-26 00:00:00', 5)
INSERT INTO [dbo].[Product] ([Product_ID], [Product_Name], [Expiry_Date], [ParlourID]) VALUES (7, N'Rebonding Product', N'2021-03-19 00:00:00', 6)
SET IDENTITY_INSERT [dbo].[Product] OFF
