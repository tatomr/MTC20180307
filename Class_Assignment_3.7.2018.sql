USE AdventureWorks2012

GO
CREATE PROCEDURE sp_VendorsAddresses
AS
BEGIN
SELECT v.Name, v.PreferredVendorStatus, a.AddressLine1, a.City, p.name [State]
	   ,a.PostalCode
FROM purchasing.vendor v
INNER JOIN person.BusinessEntityAddress ea ON v.BusinessEntityID = ea.BusinessEntityID
INNER JOIN person.[Address] a ON ea.AddressID = a.AddressID
INNER JOIN person.StateProvince p ON a.StateProvinceID = p.StateProvinceID
END

