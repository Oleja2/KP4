UPDATE [User]
SET Login = CONVERT(varchar(64),
HASHBYTES('MD5',Login),2)

UPDATE [User]
SET Password = CONVERT(varchar(64),
HASHBYTES('MD5',Password),2)

SELECT * FROM [User]