create proc usp_account
@username nvarchar(100) ,@password nvarchar(100)
as
begin
 select * from Account where username = @username and PassWord = @password
end