﻿USE master
GO
CREATE DATABASE store_management
GO
USE [store_management]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[categoryID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NULL,
	[createdAt] [datetime] NULL,
	[updatedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[categoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[customerID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NULL,
	[address] [nvarchar](100) NULL,
	[phone] [char](12) NULL,
	[createdAt] [datetime] NULL,
	[updatedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[customerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[orderID] [int] IDENTITY(1,1) NOT NULL,
	[amount] [bigint] NULL,
	[totalAmount] [bigint] NULL,
	[createdAt] [datetime] NULL,
	[updatedAt] [datetime] NULL,
	[customerID] [int] NOT NULL,
	[userID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[orderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[orderID] [int] NOT NULL,
	[productID] [int] NOT NULL,
	[price] [bigint] NULL,
	[quantity] [int] NULL,
	[discount] [int] NULL,
	[createdAt] [datetime] NULL,
	[updatedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[orderID] ASC,
	[productID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[productID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NULL,
	[stockOnHand] [int] NULL,
	[price] [bigint] NULL,
	[thumb] [varchar](100) NULL,
	[createdAt] [datetime] NULL,
	[updatedAt] [datetime] NULL,
	[categoryID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[productID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockIn](
	[productID] [int] NOT NULL,
	[supplierID] [int] NOT NULL,
	[quantity] [int] NULL,
	[createdAt] [datetime] NULL,
	[updatedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[productID] ASC,
	[supplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[supplierID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NULL,
	[address] [nvarchar](100) NULL,
	[createdAt] [datetime] NULL,
	[updatedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[supplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[userID] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](20) NULL,
	[password] [varchar](100) NULL,
	[role] [varchar](10) NULL,
	[fullname] [nvarchar](100) NULL,
	[address] [nvarchar](100) NULL,
	[position] [nvarchar](100) NULL,
	[phone] [char](12) NULL,
	[createdAt] [datetime] NULL,
	[updatedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Customer] ON 

SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Order] ON 


SET IDENTITY_INSERT [dbo].[Order] OFF

SET IDENTITY_INSERT [dbo].[Product] ON 

SET IDENTITY_INSERT [dbo].[Product] OFF
SET IDENTITY_INSERT [dbo].[Supplier] ON 

SET IDENTITY_INSERT [dbo].[Supplier] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([userID], [username], [password], [role], [fullname], [address], [position], [phone], [createdAt], [updatedAt]) VALUES (1, N'admin', N'12345', N'admin', N'Hồ Xuân Lộc', N'Hà Nội', N'Tổng giám đốc', N'0981726364  ', CAST(N'2025-05-18T21:57:02.167' AS DateTime), CAST(N'2025-05-18T22:00:09.650' AS DateTime))
INSERT [dbo].[User] ([userID], [username], [password], [role], [fullname], [address], [position], [phone], [createdAt], [updatedAt]) VALUES (2, N'employee', N'12345', N'staff', N'Đặng Minh Kiên', N'Nam Định', N'Nhân viên', N'0937125352  ', CAST(N'2025-05-18T21:59:05.250' AS DateTime), CAST(N'2025-05-18T21:59:05.250' AS DateTime))
SET IDENTITY_INSERT [dbo].[User] OFF
ALTER TABLE [dbo].[Product] ADD  DEFAULT ((0)) FOR [stockOnHand]
GO
ALTER TABLE [dbo].[Product] ADD  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([customerID])
REFERENCES [dbo].[Customer] ([customerID])
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([userID])
REFERENCES [dbo].[User] ([userID])
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([orderID])
REFERENCES [dbo].[Order] ([orderID])
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([productID])
REFERENCES [dbo].[Product] ([productID])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([categoryID])
REFERENCES [dbo].[Category] ([categoryID])
GO
ALTER TABLE [dbo].[StockIn]  WITH CHECK ADD FOREIGN KEY([productID])
REFERENCES [dbo].[Product] ([productID])
GO
ALTER TABLE [dbo].[StockIn]  WITH CHECK ADD FOREIGN KEY([supplierID])
REFERENCES [dbo].[Supplier] ([supplierID])
GO

-- Cập nhật ngày tháng trong bảng OrderDetail
UPDATE [dbo].[OrderDetail]
SET [createdAt] = DATEADD(YEAR, 4, [createdAt]),
    [updatedAt] = DATEADD(YEAR, 4, [updatedAt])
WHERE [createdAt] < '2022-01-01'

-- Cập nhật ngày tháng trong bảng Order
UPDATE [dbo].[Order]
SET [createdAt] = DATEADD(YEAR, 4, [createdAt]),
    [updatedAt] = DATEADD(YEAR, 4, [updatedAt])
WHERE [createdAt] < '2022-01-01'

-- Cập nhật ngày tháng trong bảng Product
UPDATE [dbo].[Product]
SET [createdAt] = DATEADD(YEAR, 4, [createdAt]),
    [updatedAt] = DATEADD(YEAR, 4, [updatedAt])
WHERE [createdAt] < '2022-01-01'

-- Cập nhật ngày tháng trong bảng StockIn
UPDATE [dbo].[StockIn]
SET [createdAt] = DATEADD(YEAR, 4, [createdAt]),
    [updatedAt] = DATEADD(YEAR, 4, [updatedAt])
WHERE [createdAt] < '2022-01-01'

-- Cập nhật ngày tháng trong bảng Supplier
UPDATE [dbo].[Supplier]
SET [createdAt] = DATEADD(YEAR, 4, [createdAt]),
    [updatedAt] = DATEADD(YEAR, 4, [updatedAt])
WHERE [createdAt] < '2022-01-01'

-- Cập nhật ngày tháng trong bảng Customer
UPDATE [dbo].[Customer]
SET [createdAt] = DATEADD(YEAR, 4, [createdAt]),
    [updatedAt] = DATEADD(YEAR, 4, [updatedAt])
WHERE [createdAt] < '2022-01-01'

-- Cập nhật ngày tháng trong bảng Category
UPDATE [dbo].[Category]
SET [createdAt] = DATEADD(YEAR, 4, [createdAt]),
    [updatedAt] = DATEADD(YEAR, 4, [updatedAt])
WHERE [createdAt] < '2022-01-01'

-- Cập nhật thông tin người dùng
UPDATE [dbo].[User]
SET [fullname] = N'Hồ Xuân Lộc'
WHERE [userID] = 1

UPDATE [dbo].[User]
SET [fullname] = N'Đặng Minh Kiên'
WHERE [userID] = 2

-- Cập nhật ngày tháng trong bảng User
UPDATE [dbo].[User]
SET [createdAt] = DATEADD(YEAR, 4, [createdAt]),
    [updatedAt] = DATEADD(YEAR, 4, [updatedAt])
WHERE [createdAt] < '2022-01-01'

-- Xóa dữ liệu cũ theo thứ tự để tránh vi phạm ràng buộc khóa ngoại
DELETE FROM [dbo].[OrderDetail]
DELETE FROM [dbo].[Order]
DELETE FROM [dbo].[StockIn]
DELETE FROM [dbo].[Product]
DELETE FROM [dbo].[Customer]
DELETE FROM [dbo].[Supplier]
DELETE FROM [dbo].[Category]
DELETE FROM [dbo].[User]

-- Tạo lại dữ liệu với ngày tháng mới
SET IDENTITY_INSERT [dbo].[Category] ON 
SET IDENTITY_INSERT [dbo].[Category] OFF

SET IDENTITY_INSERT [dbo].[User] ON 
INSERT [dbo].[User] ([userID], [username], [password], [role], [fullname], [address], [position], [phone], [createdAt], [updatedAt]) VALUES (1, N'admin', N'12345', N'admin', N'Hồ Xuân Lộc', N'Hà Nội', N'Tổng giám đốc', N'0981726364  ', CAST(N'2025-05-18T21:57:02.167' AS DateTime), CAST(N'2025-05-18T22:00:09.650' AS DateTime))
INSERT [dbo].[User] ([userID], [username], [password], [role], [fullname], [address], [position], [phone], [createdAt], [updatedAt]) VALUES (2, N'employee', N'12345', N'staff', N'Đặng Minh Kiên', N'Nam Định', N'Nhân viên', N'0937125352  ', CAST(N'2025-05-18T21:59:05.250' AS DateTime), CAST(N'2025-05-18T21:59:05.250' AS DateTime))
SET IDENTITY_INSERT [dbo].[User] OFF

SET IDENTITY_INSERT [dbo].[Customer] ON 
SET IDENTITY_INSERT [dbo].[Customer] OFF

SET IDENTITY_INSERT [dbo].[Supplier] ON 
SET IDENTITY_INSERT [dbo].[Supplier] OFF

SET IDENTITY_INSERT [dbo].[Product] ON 
SET IDENTITY_INSERT [dbo].[Product] OFF


SET IDENTITY_INSERT [dbo].[Order] ON 
SET IDENTITY_INSERT [dbo].[Order] OFF
