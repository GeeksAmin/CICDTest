ALTER TABLE Administrators ADD CONSTRAINT 
[FK_Administrator.Id->User] FOREIGN KEY (Id) 
REFERENCES Users (ID)
 ON DELETE CASCADE;


GO