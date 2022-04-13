CREATE TABLE Accounts(

userName VARCHAR (50) NOT NULL UNIQUE,
passW VARCHAR (50) NOT NULL,
accountName VARCHAR (50) NOT NULL,
accNumber INT PRIMARY KEY IDENTITY(1210001,1) NOT NULL ,
accountEmail VARCHAR (60) NOT NULL,
accountBalance INT NOT NULL,
accountIsActive VARCHAR (5) NOT NULL,


);
select  accountName,userName, accNumber,accountEmail,accountBalance, accountIsActive  from Accounts where userName ='KHRYSTYNA';



select accountName,userName, accNumber,accountEmail,accountBalance, accountIsActive  from Accounts;

SELECT * FROM Accounts;

select userName,accountBalance FROM Accounts WHERE userName ='KHRYSTYNA' OR userName ='LEON02KIRA';

select  accNumber+accountBalance  from Accounts where userName ='KHRYSTYNA';

select  accountBalance  from Accounts where userName ='KHRYSTYNA';


INSERT INTO Accounts VALUES ('KHRYSTYNA', '123KR', 'KHRYSTYNA KRYZHANIVSKA', '123KR@gmail.com', '500', 'YES')
INSERT INTO Accounts VALUES ('JACK03', '123JK', 'JACK TEST', '123JT@gmail.com', '1500', 'YES')
INSERT INTO Accounts VALUES ('MARIA79', '123MA', 'MARIA LABA', 'MARY@gmail.com','5000', 'YES')
INSERT INTO Accounts VALUES ('OLEG007', '123OL', 'OLEG HAVRILOV', 'OLEGH@gmail.com', '450', 'YES')
INSERT INTO Accounts VALUES ('ANASTASIA', '123ANA', 'ANASTASIA LUCHKIV', 'LUCHKIV@gmail.com', '500', 'YES')




UPDATE Accounts SET accountName = 'MARIA LABA' WHERE userName = 'MARIA79';
drop table Accounts;


