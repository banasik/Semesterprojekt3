﻿CREATE TABLE SEMPRJ3 (
Forsøgsnavn NVARCHAR(20) NOT NULL,
Id BIGINT IDENTITY (1,1) NOT NULL PRIMARY KEY,
Datostempel DATETIME NOT NULL,
Blodtryksmåling VARBINARY (max) NOT NULL
)

