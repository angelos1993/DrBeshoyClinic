﻿USE DrBeshoyClinic
GO
ALTER TABLE Patients ADD CreatedOn DATETIME NULL
GO
ALTER TABLE TreatmentDescriptions ALTER COLUMN Description NVARCHAR(200) NOT NULL
GO
ALTER TABLE Patients ALTER COLUMN Job NVARCHAR(200) NOT NULL
GO