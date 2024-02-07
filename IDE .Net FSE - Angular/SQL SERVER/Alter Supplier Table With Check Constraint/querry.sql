ALTER TABLE Supplier
 ADD CONSTRAINT chk_Contact_Length
 CHECK (LEN(contact) = 10)
GO
