INSERT INTO USERS VALUES('JBloggs')

INSERT INTO Currencies VALUES('GBP')
INSERT INTO Currencies VALUES('USD')
INSERT INTO Currencies VALUES('AUD')
INSERT INTO Currencies VALUES('EUR')

DECLARE @gbp INT
DECLARE @usd INT
DECLARE @aud INT
DECLARE @eur INT

SET @gbp = (SELECT Id From Currencies WHERE CountryCode = 'GBP')
SET @usd = (SELECT Id From Currencies WHERE CountryCode = 'USD')
SET @aud = (SELECT Id FROM Currencies WHERE CountryCode = 'AUD')
SET @eur = (SELECT Id FROM Currencies WHERE CountryCode = 'EUR')

INSERT INTO ConversionRates VALUES(@gbp, @usd, '1.5472')
INSERT INTO ConversionRates VALUES(@gbp, @aud, '2.3179')
INSERT INTO ConversionRates VALUES(@gbp, @eur, '1.1293')