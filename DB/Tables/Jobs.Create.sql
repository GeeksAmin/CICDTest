-- Jobs Table ========================
CREATE TABLE Jobs (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Name nvarchar(200)  NOT NULL,
    Type bit  NOT NULL,
    [Level] int  NOT NULL
);

