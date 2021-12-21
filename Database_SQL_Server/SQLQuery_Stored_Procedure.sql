USE Library_System
GO

IF OBJECT_ID('DNUsers', 'P') IS NOT NULL
	DROP PROC dbo.DNUsers
GO

CREATE PROC [dbo].[DNUsers] 
	@Taikhoan nvarchar (20),
	@Matkhau nvarchar (20)
AS 
	BEGIN
	    SELECT *
		FROM dbo.UsersInformation
		WHERE
			users_account = @Taikhoan
			AND users_password = @Matkhau
	END
GO

IF OBJECT_ID('DNAdmin', 'P') IS NOT NULL
	DROP PROC dbo.DNAdmin
GO

CREATE PROC [dbo].[DNAdmin] 
	@Taikhoan nvarchar (20),
	@Matkhau nvarchar (20)
AS 
	BEGIN
	    SELECT *
		FROM dbo.UsersInformation
		WHERE
			users_account = @Taikhoan
			AND users_password = @Matkhau
	END
GO