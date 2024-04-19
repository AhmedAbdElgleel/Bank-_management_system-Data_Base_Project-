CREATE TABLE  accounts (
  email varchar(50) UNIQUE,
  password varchar(30) NOT NULL,
  accountType int NOT NULL,
  username varchar(30) primary key,
);

select * from accounts;
select * from balancetable;
select * from employees;
select * from accounts;

CREATE TABLE  balancetable (
  username varchar(30), 
  balance float  NOT NULL ,
  CONSTRAINT FK_BalanceTable_accounts_email FOREIGN KEY (username) REFERENCES accounts (username),
)

CREATE TABLE clienttable (
  id_client int identity(1,1)  primary key,
  username varchar(30) not null,
  fname varchar(100) not null,
  dateOfBirth varchar(15),
  gender char(10) not null,
  telephone varchar(15) not null,
  house int not null,
  street varchar(30) not null,
  neighbourhood varchar(30) not null,
  city varchar(20) not null,
  country varchar(20) not null,
  zipcode varchar(10) not null,
  mobile varchar(30) not null,
  nationality varchar(50) not null,
  social_status char(10) not null,
  spouceName varchar(30) not null,
  birthPlace varchar(50),
  CONSTRAINT FK_clienttable_accounts_email  FOREIGN KEY (username) REFERENCES accounts (username)
);

CREATE TABLE employees (
  id_employees int identity(1,1) primary key,
  username varchar(30) not null,
  fname varchar(100) not null,
  dateOfBirth varchar(15),
  gender char(10) not null,
  telephone varchar(15) not null,
  house int not null,
  street varchar(30) not null,
  neighbourhood varchar(30) not null,
  city varchar(20) not null,
  country varchar(20) not null,
  zipcode varchar(10) not null,
  mobile varchar(30) not null,
  nationality varchar(50) not null,
  social_status char(10) not null,
  spouceName varchar(30) not null,
  birthPlace varchar(50),
  CONSTRAINT FK_employees_accounts_email  FOREIGN KEY (username) REFERENCES accounts (username)
);

CREATE TABLE   manager (
  id_maneger int identity(1,1) primary key,
  id_emp int foreign key references employees(id_employees),
);

CREATE TABLE transactiontable (
  id_bankBalance int identity(1,1) primary key  ,
  username1 varchar(30) not null,
  username2 varchar(30) not null,
  amount int NOT NULL,
  dateOfTransaction varchar(15) NOT NULL,
  CONSTRAINT FK_transactiontable_transactiontable_accountNo FOREIGN KEY (username1) REFERENCES accounts (username),
  CONSTRAINT FK_transactiontable_transactiontable_accountNoRecipient FOREIGN KEY (username2) REFERENCES accounts (username),
  );

  create table leon_types
  (
   leon_ID int identity(1,1) primary key,
   leon_ammount int not null,
   leon_no_of_dues int not null --الاقساط
  );

  create table leons
  (
  leon_number int identity(1,1) primary key,
  leon_ID int not null,
  username varchar(30) not null,
  due_amount int not null,
  start_date date not null,
  end_date date not null,
  constraint fk_leons_idclient foreign key (username) references accounts(username),
  Constraint fk_leons_leonid foreign key (leon_ID) references leon_types(leon_ID),
	);

  create table investment_types
  (
   investment_ID int identity(1,1) primary key,
   investment_ammount int not null,
   investment_profit_percentage float not null
  );

 create table investments
  (
  investment_number int identity(1,1) primary key,
  investment_ID int not null,
  userid int not null,
  startdate date not null,
  enddate date not null,
  Constraint fk_investments_idclient foreign key (userid) references clienttable(id_client),
  constraint fk_investments_investmenttypes foreign key (investment_ID) references investment_types(investment_ID)
 );

  create table issues
  (
   issue_ID int identity(1,1) primary key,
   username varchar(30) not null,
   issue_details varchar(200) not null,
  constraint fk_issues_idclient foreign key (username) references accounts(username),
  );

  create table relatives_accounts
  (
  relative_ID int identity(1,1) primary key,
  relative_name varchar(100) not null,
  username varchar(30) not null,
  max_ammount int not null,
  max_withdraw int not null,
  id_client int not null,
  constraint fk_relatives_clientid foreign key (id_client) references clienttable(id_client),
  constraint fk_relatives_username foreign key (username) references accounts(username)
  );




insert into manager (id_emp) values (15);

--for display all manger data
select *
from employees as e join manager as m 
on e.id_employees=m.id_emp join accounts as a 
on a.username=e.username;

--for display all clients data
select* 
from accounts as a join clienttable as c
on a.username=c.username;

--for display all employee data not a manger
select * 
from accounts as a join employees as e
on a.username= e.username
--where a.accountType  = 2 or a.accountType=1 ;
where a.accountType not in (3);

INSERT INTO accounts (email, password, accountType, username)
VALUES
	('gello@gmail.com','111111',3,'ahmaaad'),            --3 manger
   ('ahmed@gmail.com', '123456', 2, 'ahmed'),			--2	clinet
   ('fatima@hotmail.com', 'abc123', 2, 'fatima'),    --1 employee
   ('mohammed@yahoo.com', 'password', 2, 'mohammed'),
   ('noura@outlook.com', 'secure123', 2, 'noura'),
   ('omar@gmail.com', 'qwerty', 2, 'omar'),
   ('sara@hotmail.com', 'letmein', 2, 'sara'),
   ('ali@yahoo.com', 'changeme', 2, 'ali'),
   ('layla@outlook.com', 'hello123', 2, 'layla'),
   ('hassan@gmail.com', 'iloveyou', 1, 'hassan'),
   ('fawzia@hotmail.com', 'welcome1', 1, 'fawzia'),
   ('amr@yahoo.com', 'egypt123', 1, 'amr'),
   ('nada@hotmail.com', 'egypt456', 1, 'nada'),
   ('youssef@gmail.com', 'egypt789', 1, 'youssef'),
   ('samira@yahoo.com', 'egyptabc', 1, 'samira'),
   ('tarek@hotmail.com', 'egyptdef', 1, 'tarek'),
   ('nadia@gmail.com', 'egyptxyz', 1, 'nadia'),
   ('hamza@gmail.com', '123456', 1, 'hamza'),
   ('asmaa@hotmail.com', 'abc123', 1, 'asmaa'),
   ('atef@yahoo.com', 'password', 1, 'atef'),
   ('gaser@outlook.com', 'secure123', 1, 'gaser'),
   ('lina@gmail.com', 'qwerty', 1, 'lina');



INSERT INTO clienttable (username, fname, dateOfBirth, gender, telephone, house, street, neighbourhood, city, country, zipcode, mobile, nationality, social_status, spouceName, birthPlace)
VALUES
   ('ahmed', 'Ahmed Salah', '1990-01-01', 'Male', '+201112345678', 10, 'Mohamed Farid St.', 'Downtown', 'Cairo', 'Egypt', '12345', '+201211111111', 'Egyptian', 'Married', 'hamada', 'Cairo'),
   ('fatima', 'Fatima Ali', '1995-05-05', 'Female', '+201011111111', 20, 'Talaat Harb St.', 'Garden City', 'Cairo', 'Egypt', '67890', '+201122222222', 'Egyptian', 'Single', 'fatota', 'Alexandria'),
   ('mohammed', 'Mohammed Ahmed', '1985-03-15', 'Male', '+201012345678', 30, 'Abbas Al-Akkad St.', 'Nasr City', 'Cairo', 'Egypt', '54321', '+201233333333', 'Egyptian', 'Married', 'hamoda', 'Giza'),
   ('noura', 'Noura Khalid', '1992-08-10', 'Female', '+201099999999', 40, 'Mohandeseen St.', 'Mohandeseen', 'Giza', 'Egypt', '54678', '+201255555555', 'Egyptian', 'Divorced', 'nono', 'Cairo'),
   ('omar', 'Omar Hassan', '1998-12-31', 'Male', '+201055555555', 50, 'El-Salam St.', 'El-Salam City', 'Cairo', 'Egypt', '34567', '+201277777777', 'Egyptian', 'Single', 'amoor', 'Ismailia'),
   ('sara', 'Sara Mahmoud', '2000-01-20', 'Female', '+201066666666', 60, 'Abu Bakr St.', 'Mansoura', 'Dakahlia', 'Egypt', '98765', '+201299999999', 'Egyptian', 'Married', 'sasa', 'Mansoura'),
   ('ali', 'Ali Ahmed', '1994-06-20', 'Male', '+201077777777', 70, 'Mohamed Naguib St.', 'El-Mahalla El-Kubra', 'Gharbia', 'Egypt', '23456', '+201288888888', 'Egyptian', 'Single', 'alilo', 'Tanta'),
   ('layla', 'Layla Omar', '1993-09-12', 'Female', '+201088888888', 80, 'El-Gomhoreya St.', 'Kafr El-Sheikh', 'Kafr El-Sheikh', 'Egypt', '45678', '+201211111111', 'Egyptian', 'Married', 'lola', 'Kafr El-Sheikh');




INSERT INTO employees (username, fname, dateOfBirth, gender, telephone, house, street, neighbourhood, city, country, zipcode, mobile, nationality, social_status, spouceName, birthPlace)
VALUES('hassan', 'Hassan Ali', '1978-12-01', 'Male', '+201099999999', 90, 'El-Sadat St.', 'Luxor', 'Luxor', 'Egypt', '56789', '+201244444444', 'Egyptian', 'Widowed', 'sehs', 'Luxor'),
   ('fawzia', 'Fawzia Hussein', '1980-05-01', 'Female', '+201010101010', 100, 'El-Galaa St.', 'El-Mansoura', 'Dakahlia', 'Egypt', '54321', '+201211111111', 'Egyptian', 'Married', 'fozi', 'El-Mansoura'),
   ('amr', 'Amr Mohamed', '1997-02-28', 'Male', '+201020202020', 110, 'El-Salam St.', 'El-Salam City', 'Cairo', 'Egypt', '34567', '+201277777777', 'Egyptian', 'Single', 'amora', 'Ismailia'),
   ('nada', 'Nada Ahmed', '1982-09-30', 'Female', '+201030303030', 120, 'El-Mahalla St.', 'Tanta', 'Gharbia', 'Egypt', '23456', '+201288888888', 'Egyptian', 'Widowed', 'noda', 'Tanta'),
   ('youssef', 'youssef Ahmed', '1969-12-20', 'Male', '', 120, 'sherif St.', 'Tanta', 'Gharbia', 'Egypt', '23456', '+201288888888', 'Egyptian', 'Widowed', 'sofi', 'kaliobia'),
   ('samira', 'samira wael', '1982-03-10', 'Female', '+201201903429', 130, 'haram St.', 'Tanta', 'Gharbia', 'Egypt', '23456', '+201288881234', 'Egyptian', 'Widowed', 'samara', 'giza'),
   ('tarek', 'tarek sherif', '1969-01-01', 'Male', '+201030999999', 140, 'shehab St.', 'Tanta', 'Gharbia', 'Egypt', '23456', '+201288888813', 'Egyptian', 'Widowed', 'taroka', 'matarya'),
   ('nadia', 'Nadia salah', '1952-02-20', 'Female', '+201008866545', 150, 'faisal St.', 'Tanta', 'Gharbia', 'Egypt', '23456', '+201288888800', 'Egyptian', 'Widowed', 'dada', 'Tanta'),
('hamza', 'hamza wael', '1992-11-21', 'Male', '+201030222220', 160, 'El wady St.', 'Tanta', 'Gharbia', 'Egypt', '23456', '+201288888811', 'Egyptian', 'Widowed', 'hamzon', 'sina'),
('asmaa', 'asmaa abdalah', '1989-12-30', 'Female', '+201061532533', 170, '45 St.', 'Tanta', 'Gharbia', 'Egypt', '23456', '+201288888822', 'Egyptian', 'Widowed', 'samsimo', 'sohag'),
('atef', 'atef abdalah', '1990-03-30', 'Male', '+201030986523', 180, 'forat St.', 'Tanta', 'Gharbia', 'Egypt', '23456', '+201288888833', 'Egyptian', 'Widowed', 'awatef', 'aswan'),
('gaser', 'gaser kazem', '1966-01-02', 'Male', '+201030302231', 190, 'okasha St.', 'Tanta', 'Gharbia', 'Egypt', '23456', '+201288888844', 'Egyptian', 'Widowed', 'gasora', 'alexandria'),
('lina', 'lina hamza', '1982-01-10', 'Female', '+201003322032', 199, 'abogabal St.', 'Tanta', 'Gharbia', 'Egypt', '23456', '+201288888855', 'Egyptian', 'Widowed', 'linoo', 'Tanta');

insert into employees(username,fname,zipcode,telephone,street,spouceName,social_status,neighbourhood,nationality,mobile,house,gender,dateOfBirth,country,city,birthPlace) 
			  values('ahmaaad','amer gello','23456','+02154946479','elnasr','shamy','Single','Egypt','Egypt','0100044777',14789,'Male','1966-01-10','Cairo','nasr','Egypt');
select id_employees,fname
from employees
where username='ahmaaad';



INSERT INTO balancetable 
VALUES
('ahmed',5010),
('fatima',10150),
('mohammed',125000),
('noura',1000),
('omar',990),
('sara',100000),
('ali',9000),
('layla',10000);

INSERT INTO balancetable 
VALUES
('hassan',5010),
('amr',125000),
('nada',1000),
('youssef',990),
('samira',100000),
('tarek',9000),
('nadia',10000),
('hamza',14444),
('asmaa',177),
('atef',1478),
('gaser',7878),
('ahmaaad',1546479),
('lina',77897);







INSERT INTO transactiontable
VALUES
('mohammed','ahmed',5000,'no date'),
('sara','ali',5000,'no date'),
('layla','omar',1000,'no date');