-- People Table ========================
CREATE TABLE People (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    NationalID nvarchar(200)  NOT NULL,
    FirstName nvarchar(200)  NOT NULL,
    LastName nvarchar(200)  NOT NULL,
    FatherName nvarchar(200)  NOT NULL,
    Age int  NOT NULL,
    PersonJob uniqueidentifier  NULL
);

