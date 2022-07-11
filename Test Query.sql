
/*Random Test Queries*/

delete from Bank_Transaction where T_ID=001

delete from Bank_Transaction where T_ID='008'

select MAX(C_ID)+1 as C_ID from Customer

delete from Customer where C_ID!=001
delete from Accounts where A_ID=004
delete from Accounts where A_ID=004

alter table Customer alter column password datetime NOT NULL


select MAX(T_ID)+1 as T_ID from Bank_Transaction;
/*CREATE TABLE Accounts (
    A_ID nchar(50) NOT NULL,
    account_type nchar(50) NOT NULL,
    balance float NOT NULL,
	C_ID nchar(50) NOT NULL,
    PRIMARY KEY (A_ID),

	CONSTRAINT C_ID FOREIGN KEY (C_ID)
	    REFERENCES Customer(C_ID)

	);*/

	ALTER TABLE Accounts
ALTER COLUMN balance float;


	ALTER TABLE Bank_Transaction
ALTER COLUMN T_ID int;
	
	CREATE TABLE Bank_Transaction (
    T_ID int NOT NULL,
    cost int NOT NULL,
    date_initialized datetime NOT NULL,
	date_finalized datetime NOT NULL,
	is_completed nchar(50) NOT NULL,
	CH_ID nchar(50) NOT NULL,
	A_ID nchar(50) NOT NULL,
	trans_type nchar(50) NOT NULL,

    PRIMARY KEY (T_ID),
	CONSTRAINT CH_ID FOREIGN KEY (CH_ID)
	REFERENCES Customer(C_ID),
	CONSTRAINT A_ID FOREIGN KEY (A_ID)
	REFERENCES Accounts(A_ID)
	);


    /*FOREIGN KEY (C_ID) REFERENCES Customer(C_ID)*/
	/*C_ID nchar(50) FOREIGN KEY REFERENCES Customer(C_ID)*/
	ALTER TABLE Bank_Transaction
ADD trans_type nchar(50) NOT NULL;




	ALTER TABLE Bank_Transaction  
ADD CONSTRAINT C_ID FOREIGN KEY (C_ID)  
REFERENCES Customer (C_ID) ; 

select * from Customer
select * from Accounts
select * from Bank_Transaction

select C_ID from Customer where username='1' and password='1'

select cost from Bank_Transaction
select * from Bank_Transaction 

delete Bank_Transaction where T_ID>005

/*select * from Bank_Transaction where CH_ID={pub_C_ID}*/

select * from Customer


select * from Accounts
select * from Bank_Transaction

select * from Bank_Transaction as Bank where A_ID in
(select A_ID from Accounts as Acc where account_type='Banking' and Bank.CH_ID='001' and Bank.CH_ID=Acc.C_ID
) 


select * from Accounts
select * from Bank_Transaction

select * from Bank_Transaction as Bank where A_ID in
(select A_ID from Accounts as Acc where account_type='Banking' and Bank.CH_ID='001' and Bank.CH_ID=Acc.C_ID
) and is_completed='false'


select account_type from Accounts where C_ID='001'

select * from Bank_Transaction where A_ID in(
select A_ID from Accounts where account_type='Banking' and CH_ID='001' )

update Accounts set balance = balance+0 where C_ID=001 and account_type='Banking'
select * from Accounts

select balance from Accounts where C_ID=001 and account_type='Banking'


select A_ID from Accounts where C_ID=001 and account_type='Banking'

select * from Accounts
select balance from Accounts where C_ID=001 and account_type='Banking'

update Bank_Transaction set is_completed='true' where T_ID=008


select account_type from Accounts where A_ID=001



select * from Bank_Transaction;
select MAX(T_ID) as T_ID from Bank_Transaction;


delete from Bank_Transaction



select * from Customer
select * from Accounts
select * from Bank_Transaction

select MAX(T_ID)+1 as T_ID from Bank_Transaction;

select C_ID from Accounts where A_ID=005

delete from Customer where C_ID=004