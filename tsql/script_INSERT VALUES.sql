USE RDL00001TrainingBesa
GO

SELECT * FROM Accounts
GO

/*
INSERT INTO Accounts (name, Address)
VALUES ('Banque Mondiale', 'Boulevard Bella'), 
('Premier Tech', 'Chemin Croche'), 
('Gouvernement', 'Rue Roan'), 
('IBM', 'Street Saraband')
GO
*/

SELECT * FROM Contacts
GO

/*
DECLARE @first UNIQUEIDENTIFIER = (SELECT Id FROM Accounts WHERE name = 'Banque Mondiale')
DECLARE @second UNIQUEIDENTIFIER = (SELECT Id FROM Accounts WHERE name = 'Premier Tech')
DECLARE @third UNIQUEIDENTIFIER = (SELECT Id FROM Accounts WHERE name = 'Gouvernement')
DECLARE @fourth UNIQUEIDENTIFIER = (SELECT Id FROM Accounts WHERE name = 'IBM')


INSERT INTO Contacts (AccountId, FirstName, LastName, Phone)
VALUES (@first, 'Sahra', 'Blackwood', '641 323-2323'),
(@second, 'Marah', 'Carey', '961 454-5454'),
(@third, 'Amy', 'Winehouse', '784 969-6969'),
(@fourth, 'Alica', 'Keys', '159 757-5757'),
(@second, 'Taylor', 'Swift', '557 818-1818'),
(@fourth, 'Katy', 'Perry', '652 535-3535')
*/