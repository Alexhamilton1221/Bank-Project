
/*Test Data*/

insert into Customer values('001','Test','Dummy',20,'780-111-222','111 Candy Cane Lane','Edmonton','Alberta','Canada','12-21-2001','1','1')
insert into Customer values('002','John','Doe',32,'780-333-444','222 Burrows Crecent','Calgary','Alberta','Canada','07-23-1987','2','2')

insert into Accounts values('001','Banking','1000.00','001')
insert into Accounts values('002','Investment','2000.00','001')
insert into Accounts values('003','Checking','1500.00','001')
insert into Accounts values('004','Checking','1850.00','002')
insert into Accounts values('005','Banking','2150.00','002')

insert into Bank_Transaction values('1',75,'01-12-2001','04-01-2001','true','001','001','deposit')
insert into Bank_Transaction values('2',120,'01-12-2002','04-01-2002','true','001','001','deposit')
insert into Bank_Transaction values('3',240,'09-01-2003','09-05-2003','true','001','002','deposit')
insert into Bank_Transaction values('4',240,'09-01-2004','09-05-2004','true','002','001','deposit')
insert into Bank_Transaction values('5',500,'09-01-2005','09-05-2005','false','001','001','deposit')
insert into Bank_Transaction values('6',100,'09-01-2006','09-05-2006','false','001','001','deposit')
insert into Bank_Transaction values('7',100,'09-01-2007','09-05-2007','false','001','001','deposit')
insert into Bank_Transaction values('8',120,'09-01-2008','09-05-2008','false','001','001','deposit')
