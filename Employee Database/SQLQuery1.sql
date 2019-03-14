create procedure [dbo].[AddDetail]
(
@Name nvarchar(50),
@Place nvarchar(50),
@DBO DateTime,
@Joining DateTime,
@BloodGroup nvarchar(50),
@Designation nvarchar(50),
@Email nvarchar(50),
@PhoneNo numeric(18,0),
@Bankname nvarchar(50),
@AccountNo numeric(18,0),
@Type nvarchar(50)
)
as
begin
Insert into Detail values(@Name,@Place,@DBO,@Joining,@BloodGroup,@Designation,@Email,@PhoneNo,@Bankname,@AccountNo,@Type)
End