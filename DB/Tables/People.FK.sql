ALTER TABLE People ADD Constraint
                [FK_Person.PersonJob->Job]
                FOREIGN KEY (PersonJob)
                REFERENCES Jobs (ID)
                ON DELETE NO ACTION;
GO