CREATE DATABASE Library_System
GO

--DROP DATABASE Library_System

USE Library_System
GO

/*Table Admins
===============================*/
CREATE TABLE Admins
(
	admin_id		BIGINT IDENTITY(0,1),
	admin_name		NVARCHAR(100)		NOT NULL,
	admin_phone		VARCHAR(20)			NOT NULL,
	admin_user		VARCHAR(20)	UNIQUE	NOT NULL,
	admin_password	VARCHAR(20)			NOT NULL,
	PRIMARY KEY	(admin_id)
)
GO

/*Table StudentID
==============================*/
CREATE TABLE StudentID
(
	student_id		INT				NOT NULL,
	student_name	NVARCHAR(100)	NOT NULL,
	student_email	VARCHAR(50)		NOT NULL
	PRIMARY KEY (student_id)
)
GO

/*Table Users Information
=============================*/
CREATE TABLE UsersInformation
(
	number			BIGINT IDENTITY(0,1)	NOT NULL,
	users_id		INT					NOT NULL,	
	users_name		NVARCHAR(100)		NOT NULL,
	users_email		VARCHAR(50)			NOT NULL,
	users_phone		VARCHAR(20)			NOT NULL,
	users_district	NVARCHAR(MAX)		NOT NULL,
	users_city		NVARCHAR(MAX)		NOT NULL,	
	users_account	VARCHAR(20) UNIQUE	NOT NULL,
	users_password	VARCHAR(20)			NOT NULL
	PRIMARY KEY (users_id)
)
GO

/*Table Borrowers
==============================*/
CREATE TABLE Borrowers
(
	borrower_number			BIGINT IDENTITY(0,1)	NOT NULL,
	student_id				INT					NOT NULL,
	book_id					BIGINT					NOT NULL,
	qtt_borrow				INT					NOT NULL,
	date_of_borrow			DATETIME			NOT NULL,
	date_of_appoint_return	DATETIME			NOT NULL,
	date_of_return			DATETIME			NULL,
	note					NVARCHAR(100)		NULL
	PRIMARY KEY (borrower_number)
)
GO

/*Table Books Store
=================================*/
CREATE TABLE BooksStore
(
	book_id				BIGINT	IDENTITY(0,1)	NOT NULL,
	book_name			NVARCHAR(MAX)		NOT NULL,
	author_id			BIGINT					NOT NULL,
	category_id			BIGINT					NOT NULL,
	publisher_name		NVARCHAR(MAX)		NOT NULL,
	quantity			INT					NOT NULL,
	available_quantity	INT					NULL,	
	PRIMARY KEY (book_id)
)
GO	

/*Table Authors
=================================*/
CREATE TABLE Authors
(
	author_id	BIGINT	IDENTITY(0,1)	NOT NULL,
	author_name NVARCHAR(MAX)		NOT NULL,
	nationality NVARCHAR(100)		NULL,
	PRIMARY KEY (author_id)
)
GO

/*Table Categories
=================================*/
CREATE TABLE Categories
(
	category_id		BIGINT	IDENTITY(0,1)	NOT NULL,
	category_name	NVARCHAR(MAX)		NOT NULL,
	PRIMARY KEY (category_id)
)
GO

/*Insert into table Admins
------2 values-----------
==============================*/
INSERT INTO dbo.Admins
(
    admin_name,
    admin_phone,
    admin_user,
    admin_password
)
VALUES
(   N'Dương Thị Xuân Giang', -- admin_name - nvarchar(100)
    '0967312381',  -- admin_phone - varchar(20)
    'xuangiangAD',  -- admin_user - varchar(20)
    'xuangiangAD'   -- admin_password - varchar(20)
    )
GO

INSERT INTO dbo.Admins
(
    admin_name,
    admin_phone,
    admin_user,
    admin_password
)
VALUES
(   N'Mai Nguyễn Xuân Kiều', -- admin_name - nvarchar(100)
    '0395901301',  -- admin_phone - varchar(20)
    'xuankieuAD',  -- admin_user - varchar(20)
    'xuankieuAD'   -- admin_password - varchar(20)
    )
GO

/*Insert into StudentID
------------50 values---------------
=====================================*/
INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052000,   -- student_id - int
    N'Trần Thị Ngọc Bích', -- student_name - nvarchar(100)
    '1954052000bich@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052001,   -- student_id - int
    N'Nguyễn Thúy An', -- student_name - nvarchar(100)
    '1954052001an@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052002,   -- student_id - int
    N'Đinh Thục Thanh', -- student_name - nvarchar(100)
    '1954052002thanh@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052003,   -- student_id - int
    N'Nguyễn Ngọc Mai', -- student_name - nvarchar(100)
    '1954052003mai2ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052004,   -- student_id - int
    N'Nguyễn Thanh Thảo', -- student_name - nvarchar(100)
    '1954052004thao@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052005,   -- student_id - int
    N'Nguyễn Trần Thùy Anh', -- student_name - nvarchar(100)
    '1954052005anh@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052006,   -- student_id - int
    N'Lê Uyển Nhi', -- student_name - nvarchar(100)
    '1954052006nhi@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052007,   -- student_id - int
    N'Lê Trần Khánh Quỳnh', -- student_name - nvarchar(100)
    '1954052007qunh@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052008,   -- student_id - int
    N'Phạm Anh Minh', -- student_name - nvarchar(100)
    '1954052008minh@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052009,   -- student_id - int
    N'Đặng Ðăng Khoa', -- student_name - nvarchar(100)
    '1954052009khoa@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052010,   -- student_id - int
    N'Đỗ Đan Hạ', -- student_name - nvarchar(100)
    '1954052010ha@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052011,   -- student_id - int
    N'Đỗ Cát Tiên', -- student_name - nvarchar(100)
    '1954052011tien@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052012,   -- student_id - int
    N'Đỗ Hạnh Ngân', -- student_name - nvarchar(100)
    '1954052012ngan@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052013,   -- student_id - int
    N'Hoàng Trần Tố Như', -- student_name - nvarchar(100)
    '1954052013nhu@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052014,   -- student_id - int
    N'Hoàng Đỗ Lê Vy', -- student_name - nvarchar(100)
    '1954052014vy@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052015,   -- student_id - int
    N'Vũ Hạ Tuyết Mai', -- student_name - nvarchar(100)
    '1954052015mai@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052016,   -- student_id - int
    N'Vũ Ngọc Giáng Uyên', -- student_name - nvarchar(100)
    '1954052016uyen@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052017,   -- student_id - int
    N'Ma Đình Hào', -- student_name - nvarchar(100)
    '1954052017hao@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052018,   -- student_id - int
    N'Đinh Hoàng Quý Bình', -- student_name - nvarchar(100)
    '1954052018binh@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052019,   -- student_id - int
    N'Vương Bảo Khương', -- student_name - nvarchar(100)
    '1954052019khuong@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052020,   -- student_id - int
    N'Trần Bình Trí Việt', -- student_name - nvarchar(100)
    '1954052020viet@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052021,   -- student_id - int
    N'Nguyễn Văn Mạnh Tường', -- student_name - nvarchar(100)
    '1954052021tuong@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052022,   -- student_id - int
    N'Nguyễn Hoàng Bảo Long', -- student_name - nvarchar(100)
    '1954052022long@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052023,   -- student_id - int
    N'Vũ An Tường', -- student_name - nvarchar(100)
    '1954052023tuong@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052024,   -- student_id - int
    N'Phạm Vũ Đức Duy', -- student_name - nvarchar(100)
    '1954052024duy@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052025,   -- student_id - int
    N'Phạm Đình Đức Thắng', -- student_name - nvarchar(100)
    '1954052025thang@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052026,   -- student_id - int
    N'Lê Hữu Phước', -- student_name - nvarchar(100)
    '1954052026phuoc@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052027,   -- student_id - int
    N'Nguyễn Trường Thành An', -- student_name - nvarchar(100)
    '1954052027an@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052028,   -- student_id - int
    N'Nguyễn Chí Kiên', -- student_name - nvarchar(100)
    '1954052028kien@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052029,   -- student_id - int
    N'Nguyễn Anh Minh', -- student_name - nvarchar(100)
    '1954052029minh@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052030,   -- student_id - int
    N'Nguyễn Đức Thanh', -- student_name - nvarchar(100)
    '1954052030thanh@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052031,   -- student_id - int
    N'Nguyễn Hoàng Tuyền Lâm', -- student_name - nvarchar(100)
    '1954052031lam@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052032,   -- student_id - int
    N'Đinh Tuyết Ngân', -- student_name - nvarchar(100)
    '1954052032ngan@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052033,   -- student_id - int
    N'Đoàn Yến Ngọc', -- student_name - nvarchar(100)
    '1954052033ngoc@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052034,   -- student_id - int
    N'Lê Trần Duy Sang', -- student_name - nvarchar(100)
    '1954052034sang@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052035,   -- student_id - int
    N'Đỗ Lê Thành Thái', -- student_name - nvarchar(100)
    '1954052035thai@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052036,   -- student_id - int
    N'Nguyễn Lê Thanh Nguyên', -- student_name - nvarchar(100)
    '1954052036nguyen@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052037,   -- student_id - int
    N'Hoàng Bích Ngọc', -- student_name - nvarchar(100)
    '1954052037ngoc@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052038,   -- student_id - int
    N'Lý Quỳnh Châu', -- student_name - nvarchar(100)
    '1954052038chau@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052039,   -- student_id - int
    N'Ngô Gia An', -- student_name - nvarchar(100)
    '1954052039an@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052040,   -- student_id - int
    N'Nguyễn Bình An', -- student_name - nvarchar(100)
    '1954052040an@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052041,   -- student_id - int
    N'Nguyễn Đông Quân', -- student_name - nvarchar(100)
    '1954052041quan@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052042,   -- student_id - int
    N'Nguyễn Đức Trí', -- student_name - nvarchar(100)
    '1954052042tri@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052043,   -- student_id - int
    N'Nguyễn Hoàng Lệ Băng', -- student_name - nvarchar(100)
    '1954052043bang@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052044,   -- student_id - int
    N'Nguyễn Khánh Giang', -- student_name - nvarchar(100)
    '1954052044giang@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052045,   -- student_id - int
    N'Đặng Hạ Vy', -- student_name - nvarchar(100)
    '1954052045vy@Ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052046,   -- student_id - int
    N'Lê Nguyệt Cát', -- student_name - nvarchar(100)
    '1954052046cat@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052047,   -- student_id - int
    N'Đỗ Nguyễn Quỳnh Trâm', -- student_name - nvarchar(100)
    '1954052047tram@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052048,   -- student_id - int
    N'Trần Duy Vương Anh', -- student_name - nvarchar(100)
    '1954052048anh@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052049,   -- student_id - int
    N'Trần Đình Phúc Khang', -- student_name - nvarchar(100)
    '1954052049khang@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

INSERT INTO dbo.StudentID
(
    student_id,
    student_name,
    student_email
)
VALUES
(   1954052050,   -- student_id - int
    N'Phạm Quốc Tường An', -- student_name - nvarchar(100)
    '1954052050an@ou.edu.vn'   -- student_email - varchar(50)
    )
GO

/*Insert into Users Information
------------20 values---------------
=====================================*/
INSERT INTO dbo.UsersInformation
(
    users_id,
    users_name,	
    users_email,
    users_phone,
    users_district,
    users_city,
    users_account,
    users_password
)
VALUES
(   1954052000,   -- users_id - int
    N'Trần Thị Ngọc Bích', -- users_name - nvarchar(100)
	'1954052000bich@ou.edu.vn',  -- users_email - varchar(50)
    '0335347774',  -- users_phone - varchar(20)    
    N'Gò Vấp', -- users_district - nvarchar(max)
    N'TP HCM', -- users_city - nvarchar(max)
    'ngocbichSV',  -- users_account - varchar(20)
    'ngocbichSV'  -- users_password - varchar(20)
    )
GO

INSERT INTO dbo.UsersInformation
(
    users_id,
    users_name,
	users_email,
    users_phone,    
    users_district,
    users_city,
    users_account,
    users_password
)
VALUES
(   1954052001,   -- users_id - int
    N'Nguyễn Thúy An', -- users_name - nvarchar(100)
	'1954052001an@ou.edu.vn',  -- users_email - varchar(50)
    '0364104884',  -- users_phone - varchar(20)    
    N'Gò Vấp', -- users_district - nvarchar(max)
    N'TP HCM', -- users_city - nvarchar(max)
    'thuyanSV',  -- users_account - varchar(20)
    'thuyanSV'  -- users_password - varchar(20)
    )
GO

INSERT INTO dbo.UsersInformation
(
    users_id,
    users_name,    
    users_email,
	users_phone,
    users_district,
    users_city,
    users_account,
    users_password
)
VALUES
(   1954052002,   -- users_id - int
    N'Đinh Thục Thanh', -- users_name - nvarchar(100)
	'1954052002thanh@ou.edu.vn',  -- users_email - varchar(50)
    '0354126661',  -- users_phone - varchar(20)    
    N'Bình Thạnh', -- users_district - nvarchar(max)
    N'TP HCM', -- users_city - nvarchar(max)
    'thucthanhSV',  -- users_account - varchar(20)
    'thucthanhSV'  -- users_password - varchar(20)
    )
GO

INSERT INTO dbo.UsersInformation
(
    users_id,
    users_name,
	users_email,
    users_phone,    
    users_district,
    users_city,
    users_account,
    users_password
)
VALUES
(   1954052003,   -- users_id - int
    N'Nguyễn Ngọc Mai', -- users_name - nvarchar(100)
	'1954052003mai@ou.edu.vn',  -- users_email - varchar(50)
    '0353079299',  -- users_phone - varchar(20)    
    N'Quận 12', -- users_district - nvarchar(max)
    N'TP HCM', -- users_city - nvarchar(max)
    'ngocmaiGV',  -- users_account - varchar(20)
    'ngocmaiGV'  -- users_password - varchar(20)
    )
GO

INSERT INTO dbo.UsersInformation
(
    users_id,
    users_name,
	users_email,
    users_phone,    
    users_district,
    users_city,
    users_account,
    users_password
)
VALUES
(   1954052004,   -- users_id - int
    N'Nguyễn Thanh Thảo', -- users_name - nvarchar(100)
	'1954052004thao@ou.edu.vn',  -- users_email - varchar(50)
    '0373164639',  -- users_phone - varchar(20)    
    N'Phú Nhuận', -- users_district - nvarchar(max)
    N'TP HCM', -- users_city - nvarchar(max)
    'thanhthaoGV',  -- users_account - varchar(20)
    'thanhthaoGV'  -- users_password - varchar(20)
    )
GO

INSERT INTO dbo.UsersInformation
(
    users_id,
    users_name,
	users_email,
    users_phone,    
    users_district,
    users_city,
    users_account,
    users_password
)
VALUES
(   1954052005,   -- users_id - int
    N'Nguyễn Trần Thùy Anh', -- users_name - nvarchar(100)
	'1954052005anh@ou.edu.vn',  -- users_email - varchar(50)
    '0347047227',  -- users_phone - varchar(20)    
    N'Phú Nhuận', -- users_district - nvarchar(max)
    N'TP HCM', -- users_city - nvarchar(max)
    'thuyanhSV',  -- users_account - varchar(20)
    'thuyanhSV'  -- users_password - varchar(20)
    )
GO

INSERT INTO dbo.UsersInformation
(
    users_id,
    users_name,
	users_email,
    users_phone,    
    users_district,
    users_city,
    users_account,
    users_password
)
VALUES
(   1954052006,   -- users_id - int
    N'Lê Uyển Nhi', -- users_name - nvarchar(100)
	'1954052006nhi@ou.edu.vn',  -- users_email - varchar(50)
    '0355985098',  -- users_phone - varchar(20)    
    N'Tân Bình', -- users_district - nvarchar(max)
    N'TP HCM', -- users_city - nvarchar(max)
    'uyennhiSV',  -- users_account - varchar(20)
    'uyennhiSV'   -- users_password - varchar(20)
    )
GO

INSERT INTO dbo.UsersInformation
(
    users_id,
    users_name,
	users_email,
    users_phone,    
    users_district,
    users_city,
    users_account,
    users_password
)
VALUES
(   1954052007,   -- users_id - int
    N'Lê Trần Khánh Quỳnh', -- users_name - nvarchar(100)
	'1954052007quynh@ou.edu.vn',  -- users_email - varchar(50)
    '0336278127',  -- users_phone - varchar(20)    
    N'Tân Bình', -- users_district - nvarchar(max)
    N'TP HCM', -- users_city - nvarchar(max)
    'khanhquynhSV',  -- users_account - varchar(20)
    'khanhquynhSV'   -- users_password - varchar(20)
    )
GO

INSERT INTO dbo.UsersInformation
(
    users_id,
    users_name,
	users_email,
    users_phone,    
    users_district,
    users_city,
    users_account,
    users_password
)
VALUES
(   1954052008,   -- users_id - int
    N'Phạm Anh Minh', -- users_name - nvarchar(100)
	'1954052008minh@ou.edu.vn',  -- users_email - varchar(50)
    '0386567411',  -- users_phone - varchar(20)    
    N'Bình Thạnh', -- users_district - nvarchar(max)
    N'TP HCM', -- users_city - nvarchar(max)
    'anhminhSV',  -- users_account - varchar(20)
    'anhminhSV'   -- users_password - varchar(20)
    )
GO

INSERT INTO dbo.UsersInformation
(
    users_id,
    users_name,
	users_email,
    users_phone,    
    users_district,
    users_city,
    users_account,
    users_password
)
VALUES
(   1954052009,   -- users_id - int
    N'Đặng Ðăng Khoa', -- users_name - nvarchar(100)
	'1954052009khoa@ou.edu.vn',  -- users_email - varchar(50)
    '0397207866',  -- users_phone - varchar(20)    
    N'Quận 12', -- users_district - nvarchar(max)
    N'TP HCM', -- users_city - nvarchar(max)
    'dangkhoaGV',  -- users_account - varchar(20)
    'dangkhoaGV'   -- users_password - varchar(20)
    )
GO

INSERT INTO dbo.UsersInformation
(
    users_id,
    users_name,
	users_email,
    users_phone,    
    users_district,
    users_city,
    users_account,
    users_password
)
VALUES
(   1954052010,   -- users_id - int
    N'Đỗ Đan Hạ', -- users_name - nvarchar(100)
	'1954052010ha@ou.edu.vn',  -- users_email - varchar(50)
    '0326469268',  -- users_phone - varchar(20)    
    N'Gò Vấp', -- users_district - nvarchar(max)
    N'TP HCM', -- users_city - nvarchar(max)
    'danhaSV',  -- users_account - varchar(20)
    'danhaSV'   -- users_password - varchar(20)
    )
GO

INSERT INTO dbo.UsersInformation
(
    users_id,
    users_name,
	users_email,
    users_phone,    
    users_district,
    users_city,
    users_account,
    users_password
)
VALUES
(   1954052011,   -- users_id - int
    N'Đỗ Cát Tiên', -- users_name - nvarchar(100)
	'1954052011tien@ou.edu.vn',  -- users_email - varchar(50)
    '0345122253',  -- users_phone - varchar(20)    
    N'Gò Vấp', -- users_district - nvarchar(max)
    N'TP HCM', -- users_city - nvarchar(max)
    'cattienSV',  -- users_account - varchar(20)
    'cattienSV'   -- users_password - varchar(20)
    )
GO

INSERT INTO dbo.UsersInformation
(
    users_id,
    users_name,
	users_email,
    users_phone,    
    users_district,
    users_city,
    users_account,
    users_password
)
VALUES
(   1954052012,   -- users_id - int
    N'Đỗ Hạnh Ngân', -- users_name - nvarchar(100)
	'1954052012ngan@ou.edu.vn',  -- users_email - varchar(50)
    '0348626245',  -- users_phone - varchar(20)    
    N'Tân Bình', -- users_district - nvarchar(max)
    N'TP HCM', -- users_city - nvarchar(max)
    'hanhnganSV',  -- users_account - varchar(20)
    'hanhnganSV'   -- users_password - varchar(20)
    )
GO

INSERT INTO dbo.UsersInformation
(
    users_id,
    users_name,
	users_email,
    users_phone,    
    users_district,
    users_city,
    users_account,
    users_password
)
VALUES
(   1954052013,   -- users_id - int
    N'Hoàng Trần Tố Như', -- users_name - nvarchar(100)
	'1954052013nhu@ou.edu.vn',  -- users_email - varchar(50)
    '0865278280',  -- users_phone - varchar(20)    
    N'Phú Nhuận', -- users_district - nvarchar(max)
    N'TP HCM', -- users_city - nvarchar(max)
    'tonhuSV',  -- users_account - varchar(20)
    'tonhuSV'   -- users_password - varchar(20)
    )
GO

INSERT INTO dbo.UsersInformation
(
    users_id,
    users_name,
	users_email,
    users_phone,    
    users_district,
    users_city,
    users_account,
    users_password
)
VALUES
(   1954052014,   -- users_id - int
    N'Hoàng Đỗ Lê Vy', -- users_name - nvarchar(100)
	'1954052014vy@ou.edu.vn',  -- users_email - varchar(50)
    '0866445775',  -- users_phone - varchar(20)    
    N'Quận 10', -- users_district - nvarchar(max)
    N'TP HCM', -- users_city - nvarchar(max)
    'levySV',  -- users_account - varchar(20)
    'levySV'   -- users_password - varchar(20)
    )
GO

INSERT INTO dbo.UsersInformation
(
    users_id,
    users_name,
	users_email,
    users_phone,    
    users_district,
    users_city,
    users_account,
    users_password
)
VALUES
(   1954052015,   -- users_id - int
    N'Vũ Hạ Tuyết Mai', -- users_name - nvarchar(100)
	'1954052015mai@ou.edu.vn',  -- users_email - varchar(50)
    '0353626079',  -- users_phone - varchar(20)    
    N'Gò Vấp', -- users_district - nvarchar(max)
    N'TP HCM', -- users_city - nvarchar(max)
    'tuyetmaiGV',  -- users_account - varchar(20)
    'tuyetmaiGV'   -- users_password - varchar(20)
    )
GO

INSERT INTO dbo.UsersInformation
(
    users_id,
    users_name,
	users_email,
    users_phone,    
    users_district,
    users_city,
    users_account,
    users_password
)
VALUES
(   1954052016,   -- users_id - int
    N'Vũ Ngọc Giáng Uyên', -- users_name - nvarchar(100)
	'1954052016uyen@ou.edu.vn',  -- users_email - varchar(50)
    '0389286086',  -- users_phone - varchar(20)    
    N'Bình Thạnh', -- users_district - nvarchar(max)
    N'TP HCM', -- users_city - nvarchar(max)
    'gianguyenGV',  -- users_account - varchar(20)
    'gianguyenGV'   -- users_password - varchar(20)
    )
GO

INSERT INTO dbo.UsersInformation
(
    users_id,
    users_name,
	users_email,
    users_phone,    
    users_district,
    users_city,
    users_account,
    users_password
)
VALUES
(   1954052017,   -- users_id - int
    N'Ma Đình Hào', -- users_name - nvarchar(100)
	'1954052017hao@ou.edu.vn',  -- users_email - varchar(50)
    '0384171566',  -- users_phone - varchar(20)    
    N'Gò Vấp', -- users_district - nvarchar(max)
    N'TP HCM', -- users_city - nvarchar(max)
    'dinhhaoGV',  -- users_account - varchar(20)
    'dinhhaoGV'   -- users_password - varchar(20)
    )
GO

INSERT INTO dbo.UsersInformation
(
    users_id,
    users_name,
	users_email,
    users_phone,    
    users_district,
    users_city,
    users_account,
    users_password
)
VALUES
(   1954052018,   -- users_id - int
    N'Đinh Hoàng Quý Bình', -- users_name - nvarchar(100)
	'1954052018binh@ou.edu.vn',  -- users_email - varchar(50)
    '0393428842',  -- users_phone - varchar(20)    
    N'Phú Nhuận', -- users_district - nvarchar(max)
    N'TP HCM', -- users_city - nvarchar(max)
    'quybinhSV',  -- users_account - varchar(20)
    'quybinhSV'   -- users_password - varchar(20)
    )
GO

INSERT INTO dbo.UsersInformation
(
    users_id,
    users_name,
	users_email,
    users_phone,    
    users_district,
    users_city,
    users_account,
    users_password
)
VALUES
(   1954052019,   -- users_id - int
    N'Vương Bảo Khương', -- users_name - nvarchar(100)
	'1954052019khuong@ou.edu.vn',  -- users_email - varchar(50)
    '0357849871',  -- users_phone - varchar(20)    
    N'Tân Bình', -- users_district - nvarchar(max)
    N'TP HCM', -- users_city - nvarchar(max)
    'baokhuongSV',  -- users_account - varchar(20)
    'baokhuongSV'   -- users_password - varchar(20)
    )
GO

/*Insert into Categories
-----------15 values-----------------
====================================*/
INSERT INTO dbo.Categories
(
    category_name
)
VALUES
(N'Tâm lý - Kỹ năng sống' -- category_name - nvarchar(max)
    )
GO

INSERT INTO dbo.Categories
(
    category_name
)
VALUES
(N'Văn hóa - Nghệ thuật' -- category_name - nvarchar(max)
    )
GO

INSERT INTO dbo.Categories
(
    category_name
)
VALUES
(N'Khoa học - Kỹ thuật' -- category_name - nvarchar(max)
    )
GO

INSERT INTO dbo.Categories
(
    category_name
)
VALUES
(N'Tài liệu học tập - Giáo trình' -- category_name - nvarchar(max)
    )
GO

INSERT INTO dbo.Categories
(
    category_name
)
VALUES
(N'Lịch sử' -- category_name - nvarchar(max)
    )
GO

INSERT INTO dbo.Categories
(
    category_name
)
VALUES
(N'Tài chính - Chứng khoán' -- category_name - nvarchar(max)
    )
GO

INSERT INTO dbo.Categories
(
    category_name
)
VALUES
(N'Kỹ năng học tập - Làm việc' -- category_name - nvarchar(max)
    )
GO

INSERT INTO dbo.Categories
(
    category_name
)
VALUES
(N'Khám phá bí ẩn' -- category_name - nvarchar(max)
    )
GO

INSERT INTO dbo.Categories
(
    category_name
)
VALUES
(N'Marketing - Bán hàng' -- category_name - nvarchar(max)
    )
GO

INSERT INTO dbo.Categories
(
    category_name
)
VALUES
(N'Nông - Lâm - Ngư' -- category_name - nvarchar(max)
    )
GO

INSERT INTO dbo.Categories
(
    category_name
)
VALUES
(N'Học ngoại ngữ' -- category_name - nvarchar(max)
    )
GO

INSERT INTO dbo.Categories
(
    category_name
)
VALUES
(N'Kiến trúc - Xây dựng' -- category_name - nvarchar(max)
    )
GO

INSERT INTO dbo.Categories
(
    category_name
)
VALUES
(N'Y học - Sức khỏe' -- category_name - nvarchar(max)
    )
GO

INSERT INTO dbo.Categories
(
    category_name
)
VALUES
(N'Triết học' -- category_name - nvarchar(max)
    )
GO

INSERT INTO dbo.Categories
(
    category_name
)
VALUES
(N'Thư viện pháp luật' -- category_name - nvarchar(max)
    )
GO

/*Insert into Authors
-----------33 values---------------
====================================*/
INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Nguyễn Hiến Lê', -- author_name - nvarchar(max)
    N'Việt Nam'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Steve Chandler', -- author_name - nvarchar(max)
    N'Mỹ'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Trần Khánh Chương', -- author_name - nvarchar(max)
    N'Việt Nam'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Loverance And Wood', -- author_name - nvarchar(max)
    N'Không xác định'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Lê Xuân Diệm', -- author_name - nvarchar(max)
    N'Việt Nam'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Phan Thành Long', -- author_name - nvarchar(max)
    N'Việt Nam'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Amarasiri Weeraratne', -- author_name - nvarchar(max)
    N'Không xác định'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Trần Thuý', -- author_name - nvarchar(max)
    N'Việt Nam'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Nguyễn Duy Thanh', -- author_name - nvarchar(max)
    N'Việt Nam'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Bùi Ngọc Toàn', -- author_name - nvarchar(max)
    N'Việt Nam'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Katrin Himmler', -- author_name - nvarchar(max)
    N'Đức'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Nguyễn Quang Hưng', -- author_name - nvarchar(max)
    N'Việt Nam'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Donald R. Keough', -- author_name - nvarchar(max)
    N'Mỹ'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Liaquat Ahamed', -- author_name - nvarchar(max)
    N'Mỹ'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Brian Tracy', -- author_name - nvarchar(max)
    N'Mỹ'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Nguyễn Gia Linh', -- author_name - nvarchar(max)
    N'Việt Nam'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Paul Johnson', -- author_name - nvarchar(max)
    N'Anh'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Tuấn Minh', -- author_name - nvarchar(max)
    N'Việt Nam'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Đinh Thị Thúy Hằng', -- author_name - nvarchar(max)
    N'Việt Nam'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Al Ries', -- author_name - nvarchar(max)
    N'Mỹ'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Chu Thị Thơm', -- author_name - nvarchar(max)
    N'Việt Nam'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Nguyễn Thị Minh Phương', -- author_name - nvarchar(max)
    N'Việt Nam'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Kiên Trần', -- author_name - nvarchar(max)
    N'Việt Nam'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Lê Chí Cương', -- author_name - nvarchar(max)
    N'Việt Nam'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'ZIM', -- author_name - nvarchar(max)
    N'Chưa xác định'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Ngô Huy Nam', -- author_name - nvarchar(max)
    N'Việt Nam'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Nguyễn Thị Hường', -- author_name - nvarchar(max)
    N'Việt Nam'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Trần Đức Thọ', -- author_name - nvarchar(max)
    N'Việt Nam'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Mel Thomson', -- author_name - nvarchar(max)
    N'Chưa xác định'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Trương Lập Văn', -- author_name - nvarchar(max)
    N'Việt Nam'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Quốc Hội Việt Nam', -- author_name - nvarchar(max)
    N'Việt Nam'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Lê Thị Hoài Thu', -- author_name - nvarchar(max)
    N'Việt Nam'  -- nationality - nvarchar(100)
    )
GO

INSERT INTO dbo.Authors
(
    author_name,
    nationality
)
VALUES
(   N'Adam Khoo', -- author_name - nvarchar(max)
    N'Singapore'  -- nationality - nvarchar(100)
    )
GO


/*Insert into Books Store
-------------41 values--------------
=====================================*/
INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Tay trắng làm nên', -- book_name - nvarchar(max)
    0,   -- author_id - int
    0,   -- category_id - int
    N'NXB Văn hóa thông tin', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    5    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Ý cao tình đẹp', -- book_name - nvarchar(max)
    0,   -- author_id - int
    0,   -- category_id - int
    N'NXB Tổng hợp TP HCM', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    5    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Những vấn đề của thời đại', -- book_name - nvarchar(max)
    0,   -- author_id - int
    1,   -- category_id - int
    N'Không xác định', -- publisher_name - nvarchar(max)
    2,   -- quantity - int
    2    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Mười lăm gương phụ nữ', -- book_name - nvarchar(max)
    0,   -- author_id - int
    0,   -- category_id - int
    N'NXB Tổng hợp TP HCM', -- publisher_name - nvarchar(max)
    3,   -- quantity - int
    3    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Cách làm chủ số phận bạn', -- book_name - nvarchar(max)
    1,   -- author_id - int
    0,   -- category_id - int
    N'NXB Phụ nữ', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    5    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Các Nền Văn Minh Thế Giới: Hy Lạp', -- book_name - nvarchar(max)
    3,   -- author_id - int
    1,   -- category_id - int
    N'NXB Mỹ thuật', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    5    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Khảo Cổ Học Ở Thành Phố Hồ Chí Minh', -- book_name - nvarchar(max)
    4,   -- author_id - int
    1,   -- category_id - int
    N'Không xác định', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    5    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Einstein Và Vũ Trụ', -- book_name - nvarchar(max)
    5,   -- author_id - int
    2,   -- category_id - int
    N'Trung tâm học liệu - Bộ Giáo dục', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    5    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Học Thuyết Darwin, Phật Giáo Và Thiên Chúa Giáo', -- book_name - nvarchar(max)
    6,   -- author_id - int
    2,   -- category_id - int
    N'Nguyễn Kim Vỹ', -- publisher_name - nvarchar(max)
    1,   -- quantity - int
    1    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Chuẩn Đoán Bằng Mạch Chẩn Và Thiệt Chẩn', -- book_name - nvarchar(max)
    7,   -- author_id - int
    3,   -- category_id - int
    N'', -- publisher_name - nvarchar(max)
    3,   -- quantity - int
    3    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Tổ Chức Xây Dựng Công Trình', -- book_name - nvarchar(max)
    8,   -- author_id - int
    3,   -- category_id - int
    N'NXB Xây dựng', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    5    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Các Nguyên Lý Quản Lý Dự Án', -- book_name - nvarchar(max)
    9,   -- author_id - int
    3,   -- category_id - int
    N'NXB Giao thông vận tải', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    5    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Anh Em Nhà Himmler', -- book_name - nvarchar(max)
    10,   -- author_id - int
    4,   -- category_id - int
    N'NXB Thế giới', -- publisher_name - nvarchar(max)
    3,   -- quantity - int
    3    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Dấu Ấn Của Nhà Báo Nguyễn Ái Quốc - Hồ Chí Minh Trong Cách Mạng Giải Phóng Dân Tộc', -- book_name - nvarchar(max)
    11,   -- author_id - int
    4,   -- category_id - int
    N'NXB Thông tin và Truyền thông', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    5    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'10 Điều Răn Về Những Thất Bại Trong Kinh Doanh', -- book_name - nvarchar(max)
    12,   -- author_id - int
    5,   -- category_id - int
    N'NXB Trẻ', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    5    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Những Ông Trùm Tài Chính', -- book_name - nvarchar(max)
    13,   -- author_id - int
    5,   -- category_id - int
    N'NXB Alphabooks', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    5    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Thuật Quản Lý Thời Gian', -- book_name - nvarchar(max)
    14,   -- author_id - int
    6,   -- category_id - int
    N'NXB Alphabooks', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    5    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Cuộc Đời Và Tính Cách Con Người', -- book_name - nvarchar(max)
    15,   -- author_id - int
    6,   -- category_id - int
    N'NXB Lao động xã hội', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    5    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Lịch Sử Do Thái, Tủi Nhục Và Vinh Quang', -- book_name - nvarchar(max)
    16,   -- author_id - int
    7,   -- category_id - int
    N'Không xác định', -- publisher_name - nvarchar(max)
    3,   -- quantity - int
    3    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Ánh Sáng Khoa Học Kỹ Thuật', -- book_name - nvarchar(max)
    16,   -- author_id - int
    7,   -- category_id - int
    N'NXB Lao động', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    5    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Thăm Dò Vũ Trụ', -- book_name - nvarchar(max)
    16,   -- author_id - int
    7,   -- category_id - int
    N'NXB Lao động', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    5    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Những Bí Mật Về Thế Giới Thực Vật', -- book_name - nvarchar(max)
    16,   -- author_id - int
    7,   -- category_id - int
    N'NXB Lao động', -- publisher_name - nvarchar(max)
    3,   -- quantity - int
    3    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Pr – Lý Luận Và Ứng Dụng', -- book_name - nvarchar(max)
    17,   -- author_id - int
    8,   -- category_id - int
    N'NXB Alphabooks', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    5    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Ngành PR Việt Nam', -- book_name - nvarchar(max)
    17,   -- author_id - int
    8,   -- category_id - int
    N'Không xác định', -- publisher_name - nvarchar(max)
    3,   -- quantity - int
    3    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Định Hướng Tập Trung', -- book_name - nvarchar(max)
    18,   -- author_id - int
    8,   -- category_id - int
    N'NXB Tổng hợp TP HCM', -- publisher_name - nvarchar(max)
    3,   -- quantity - int
    3    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'An Toàn Lao Động Trong Thuỷ Lợi', -- book_name - nvarchar(max)
    19,   -- author_id - int
    9,   -- category_id - int
    N'NXB Lao động', -- publisher_name - nvarchar(max)
    3,   -- quantity - int
    3    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Biện Pháp Sử Dụng Thuốc Bảo Vệ Thực Vật An Toàn – Hiệu Quả', -- book_name - nvarchar(max)
    20,   -- author_id - int
    9,   -- category_id - int
    N'NXB Hà Nội', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    5    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Hướng Dẫn Tự Học IELTS 8.5', -- book_name - nvarchar(max)
    21,   -- author_id - int
    10,   -- category_id - int
    N'Không xác định', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    4    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Anh Văn Chuyên Ngành Cơ Khí', -- book_name - nvarchar(max)
    22,   -- author_id - int
    10,   -- category_id - int
    N'NXB Đại học Quốc gia TP HCM', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    4    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Understanding Vocab For IELTS Speaking', -- book_name - nvarchar(max)
    23,   -- author_id - int
    10,   -- category_id - int
    N'NXB Dân trí', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    4    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Cẩm Nang Giúp Bạn Xây Nhà', -- book_name - nvarchar(max)
    24,   -- author_id - int
    11,   -- category_id - int
    N'NXB Xây dựng', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    4    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Cây Rau Dinh Dưỡng Trong Bữa Ăn Gia Đình', -- book_name - nvarchar(max)
    25,   -- author_id - int
    12,   -- category_id - int
    N'NXB Thanh Hóa', -- publisher_name - nvarchar(max)
    3,   -- quantity - int
    2    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Bệnh Loãng Xương Ở Người Cao Tuổi', -- book_name - nvarchar(max)
    26,   -- author_id - int
    12,   -- category_id - int
    N'NXB Y học', -- publisher_name - nvarchar(max)
    3,   -- quantity - int
    3    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Triết Học Tôn Giáo', -- book_name - nvarchar(max)
    27,   -- author_id - int
    13,   -- category_id - int
    N'Chưa xác định', -- publisher_name - nvarchar(max)
    1,   -- quantity - int
    0    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Lý - Triết Học Phương Đông', -- book_name - nvarchar(max)
    28,   -- author_id - int
    13,   -- category_id - int
    N'NXB Khoa học xã hội', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    5    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Luật Biển Việt Nam', -- book_name - nvarchar(max)
    29,   -- author_id - int
    14,   -- category_id - int
    N'NXB Chính trị Quốc gia', -- publisher_name - nvarchar(max)
    10,   -- quantity - int
    10   -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Ảnh Hưởng Của Thương Mại Tự Do Đến Nhân Quyền', -- book_name - nvarchar(max)
    30,   -- author_id - int
    14,   -- category_id - int
    N'NXB Hồng Đức', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    5    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Tính - Tinh Hoa Về Các Phạm Trù Triết Học Trung Quốc', -- book_name - nvarchar(max)
    23,   -- author_id - int
    13,   -- category_id - int
    N'NXB Khoa học xã hội', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    5    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Bí Quyết Tay Trắng Thành Triệu Phú', -- book_name - nvarchar(max)
    31,   -- author_id - int
    5,   -- category_id - int
    N'NXB Phụ nữ', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    5    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'Làm Chủ Tư Duy, Thay Đổi Vận Mệnh', -- book_name - nvarchar(max)
    31,   -- author_id - int
    0,   -- category_id - int
    N'NXB Phụ nữ', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    5    -- available_quantity - int
    )
GO

INSERT INTO dbo.BooksStore
(
    book_name,
    author_id,
    category_id,
    publisher_name,
    quantity,
    available_quantity
)
VALUES
(   N'22 Quy Luật Bất Biến Trong Marketing', -- book_name - nvarchar(max)
    18,   -- author_id - int
    8,   -- category_id - int
    N'NXB Trẻ', -- publisher_name - nvarchar(max)
    5,   -- quantity - int
    5    -- available_quantity - int
    )
GO

/*Insert into Borrowers
------------20 values----------------
=====================================*/
INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052000,         -- student_id - int
    0,         -- book_id - int
    1,         -- qtt_borrow - int
    '2020-09-10 08:35:00', -- date_of_borrow - datetime
    '2020-10-10 08:00:00', -- date_of_appoint_return - datetime
    '2020-09-15 15:00:00', -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052000,         -- student_id - int
    5,         -- book_id - int
    1,         -- qtt_borrow - int
    '2020-09-10 08:35:10', -- date_of_borrow - datetime
    '2020-10-10 08:00:00', -- date_of_appoint_return - datetime
    '2020-09-15 15:02:00', -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052000,         -- student_id - int
    10,         -- book_id - int
    1,         -- qtt_borrow - int
    '2020-09-10 08:35:40', -- date_of_borrow - datetime
    '2020-10-10 08:00:00', -- date_of_appoint_return - datetime
    '2020-09-15 15:05:00', -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052002,         -- student_id - int
    0,         -- book_id - int
    1,         -- qtt_borrow - int
    '2020-09-10 10:00:00', -- date_of_borrow - datetime
    '2020-10-10 08:00:00', -- date_of_appoint_return - datetime
    '2020-09-16 18:00:00', -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052002,         -- student_id - int
    15,         -- book_id - int
    1,         -- qtt_borrow - int
    '2020-09-10 10:01:00', -- date_of_borrow - datetime
    '2020-10-10 08:00:00', -- date_of_appoint_return - datetime
    '2020-09-16 18:02:00', -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052003,         -- student_id - int
    15,         -- book_id - int
    1,         -- qtt_borrow - int
    '2020-09-10 10:30:00', -- date_of_borrow - datetime
    '2020-10-10 08:00:00', -- date_of_appoint_return - datetime
    '2020-09-16 19:02:00', -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052015,         -- student_id - int
    20,         -- book_id - int
    1,         -- qtt_borrow - int
    '2020-09-12 08:30:00', -- date_of_borrow - datetime
    '2020-10-12 08:00:00', -- date_of_appoint_return - datetime
    '2020-09-17 14:12:00', -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052015,         -- student_id - int
    15,         -- book_id - int
    1,         -- qtt_borrow - int
    '2020-09-12 08:31:00', -- date_of_borrow - datetime
    '2020-10-12 08:00:00', -- date_of_appoint_return - datetime
    '2020-09-17 14:13:00', -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052015,         -- student_id - int
    3,         -- book_id - int
    1,         -- qtt_borrow - int
    '2020-09-12 08:32:00', -- date_of_borrow - datetime
    '2020-10-12 08:00:00', -- date_of_appoint_return - datetime
    '2020-09-17 14:15:00', -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052015,         -- student_id - int
    7,         -- book_id - int
    1,         -- qtt_borrow - int
    '2020-09-12 08:33:00', -- date_of_borrow - datetime
    '2020-10-12 08:00:00', -- date_of_appoint_return - datetime
    '2020-09-17 14:16:00', -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052012,         -- student_id - int
    6,         -- book_id - int
    1,         -- qtt_borrow - int
    '2020-10-10 16:00:00', -- date_of_borrow - datetime
    '2020-11-09 08:00:00', -- date_of_appoint_return - datetime
    '2020-10-19 10:00:00', -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052012,         -- student_id - int
    8,         -- book_id - int
    1,         -- qtt_borrow - int
    '2020-10-10 16:01:00', -- date_of_borrow - datetime
    '2020-11-09 08:00:00', -- date_of_appoint_return - datetime
    '2020-10-19 10:02:00', -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052012,         -- student_id - int
    22,         -- book_id - int
    1,         -- qtt_borrow - int
    '2020-10-10 16:02:00', -- date_of_borrow - datetime
    '2020-11-09 08:00:00', -- date_of_appoint_return - datetime
    '2020-10-19 10:05:00', -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052019,         -- student_id - int
    33,         -- book_id - int
    1,         -- qtt_borrow - int
    '2020-10-27 17:10:00', -- date_of_borrow - datetime
    '2020-11-26 09:00:00', -- date_of_appoint_return - datetime
    '2020-11-02 09:10:00', -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052019,         -- student_id - int
    21,         -- book_id - int
    1,         -- qtt_borrow - int
    '2020-10-27 17:11:00', -- date_of_borrow - datetime
    '2020-11-26 09:00:00', -- date_of_appoint_return - datetime
    '2020-11-02 09:11:00', -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052010,         -- student_id - int
    23,         -- book_id - int
    1,         -- qtt_borrow - int
    '2020-11-19 15:00:00', -- date_of_borrow - datetime
    '2020-12-19 09:00:00', -- date_of_appoint_return - datetime
    '2020-11-27 11:00:00', -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052014,         -- student_id - int
    28,         -- book_id - int
    1,         -- qtt_borrow - int
    '2020-12-15 13:07:01', -- date_of_borrow - datetime
    '2021-01-14 09:00:00', -- date_of_appoint_return - datetime
    '2020-12-22 10:33:00', -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052014,         -- student_id - int
    30,         -- book_id - int
    1,         -- qtt_borrow - int
    '2020-12-15 13:08:03', -- date_of_borrow - datetime
    '2021-01-14 09:00:00', -- date_of_appoint_return - datetime
    '2020-12-22 10:34:00', -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052012,         -- student_id - int
    40,         -- book_id - int
    1,         -- qtt_borrow - int
    '2020-12-13 19:00:00', -- date_of_borrow - datetime
    '2021-01-12 10:00:00', -- date_of_appoint_return - datetime
    '2020-12-18 18:00:00', -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052012,         -- student_id - int
    26,         -- book_id - int
    1,         -- qtt_borrow - int
    '2020-12-13 19:02:00', -- date_of_borrow - datetime
    '2021-01-12 10:00:00', -- date_of_appoint_return - datetime
    '2020-12-18 18:03:00', -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052015,         -- student_id - int
    25,         -- book_id - int
    1,         -- qtt_borrow - int
    '2021-01-22 09:33:00', -- date_of_borrow - datetime
    '2021-02-21 10:00:00', -- date_of_appoint_return - datetime
    '2021-01-26 14:13:00', -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052015,         -- student_id - int
    22,         -- book_id - int
    1,         -- qtt_borrow - int
    '2021-01-22 09:34:00', -- date_of_borrow - datetime
    '2021-02-21 10:00:00', -- date_of_appoint_return - datetime
    '2021-01-26 14:15:00', -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052007,         -- student_id - int
    15,         -- book_id - int
    1,         -- qtt_borrow - int
    '2021-02-20 15:00:10', -- date_of_borrow - datetime
    '2021-03-22 14:00:00', -- date_of_appoint_return - datetime
    NULL, -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052007,         -- student_id - int
    28,         -- book_id - int
    1,         -- qtt_borrow - int
    '2021-02-20 15:02:10', -- date_of_borrow - datetime
    '2021-03-22 14:00:00', -- date_of_appoint_return - datetime
    NULL, -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052017,         -- student_id - int
    38,         -- book_id - int
    1,         -- qtt_borrow - int
    '2021-03-26 19:00:00', -- date_of_borrow - datetime
    '2021-04-25 15:00:00', -- date_of_appoint_return - datetime
    '2021-04-06 16:56:00', -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052017,         -- student_id - int
    40,         -- book_id - int
    1,         -- qtt_borrow - int
    '2021-04-12 11:00:12', -- date_of_borrow - datetime
    '2021-05-12 16:00:00', -- date_of_appoint_return - datetime
    '2021-04-19 17:46:00', -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052017,         -- student_id - int
    32,         -- book_id - int
    1,         -- qtt_borrow - int
    '2021-04-12 11:05:00', -- date_of_borrow - datetime
    '2021-05-12 16:00:00', -- date_of_appoint_return - datetime
    '2021-04-16 13:00:00', -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052014,         -- student_id - int
    29,         -- book_id - int
    1,         -- qtt_borrow - int
    '2021-05-14 14:20:22', -- date_of_borrow - datetime
    '2021-06-13 15:00:00', -- date_of_appoint_return - datetime
    NULL, -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052014,         -- student_id - int
    30,         -- book_id - int
    1,         -- qtt_borrow - int
    '2021-05-14 14:22:00', -- date_of_borrow - datetime
    '2021-06-13 15:00:00', -- date_of_appoint_return - datetime
    NULL, -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052014,         -- student_id - int
    31,         -- book_id - int
    1,         -- qtt_borrow - int
    '2021-05-14 14:25:00', -- date_of_borrow - datetime
    '2021-06-13 16:00:00', -- date_of_appoint_return - datetime
    NULL, -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052011,         -- student_id - int
    34,         -- book_id - int
    1,         -- qtt_borrow - int
    '2021-06-01 18:01:00', -- date_of_borrow - datetime
    '2021-07-01 15:30:00', -- date_of_appoint_return - datetime
    NULL, -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

INSERT INTO dbo.Borrowers
(
    student_id,
    book_id,
    qtt_borrow,
    date_of_borrow,
    date_of_appoint_return,
    date_of_return,
    note
)
VALUES
(   1954052011,         -- student_id - int
    32,         -- book_id - int
    1,         -- qtt_borrow - int
    '2021-06-01 15:00:00', -- date_of_borrow - datetime
    '2021-07-01 17:00:00', -- date_of_appoint_return - datetime
    NULL, -- date_of_return - datetime
    N''        -- note - nvarchar(100)
    )
GO

/*Create FOREIGN KEY
=====================*/
ALTER TABLE dbo.BooksStore
	ADD CONSTRAINT fk_BooksStore_Categories
	FOREIGN KEY (category_id)
	REFERENCES dbo.Categories (category_id)
GO

ALTER TABLE dbo.BooksStore
	ADD CONSTRAINT fk_BooksStore_Authors
	FOREIGN KEY (author_id)
	REFERENCES dbo.Authors (author_id)
GO

ALTER TABLE dbo.Borrowers
	ADD CONSTRAINT fk_Borrowers_StudentID
	FOREIGN KEY (student_id)
	REFERENCES dbo.StudentID (student_id)
GO

ALTER TABLE dbo.Borrowers
	ADD CONSTRAINT fk_Borrowers_BooksStore
	FOREIGN KEY (book_id)
	REFERENCES dbo.BooksStore (book_id)
GO

ALTER TABLE dbo.UsersInformation
	ADD CONSTRAINT fk_UserInform_StudentID
	FOREIGN KEY (users_id)
	REFERENCES dbo.StudentID(student_id)
GO
