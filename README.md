Question # 1 Design the solution for this case study 			(25 Marks) 
Coronavirus disease 2019 (COVID-19) is defined as an illness caused by a novel coronavirus now called severe acute respiratory syndrome-2. Most people who fall sick with COVID-19 will experience mild to moderate symptoms and recover without special treatment.








Proposed Database Tables Description

1. Departments
QUERY
create table Departments (
department_name varchar(30) primary key not null,
department_location varchar(30),
facilities_available varchar(50)
);

DATA IN Departments TABLE











2. Doctor Registration (All Doctors)
QUERY

create table All_Doctors (
	D_Id varchar(25) primary key not null,
department_name varchar(30) foreign key (department_name) references Departments				(department_name)
	);

DATA IN All_Doctors TABLE






3. Doctor Registration (Registered Doc)
QUERY

create table Registered_Doc (
	D_Id varchar(25) foreign key (D_Id) references All_Doctors (D_Id),
	D_Name varchar(30) primary key not null,
	qualification varchar(30),
	D_Address varchar(50),
	D_Ph_num varchar (15),
	D_Sal int,
	D_DOJ date
	);

DATA IN Registered_Doc TABLE








4. Register Patient Details
QUERY

create table Register_Patient_Details (
	MR_no varchar(50) primary key not null,
	P_First_name varchar(30),
	P_Last_name varchar(30),
	P_Father_name varchar(30),
	P_Date_Of_Birth date,
	P_Place_Of_Birth varchar(30),
	P_Blood_Group varchar(10),
	P_Present_Address varchar(50),
	P_Permanent_Address varchar(50),
	P_Destrict varchar(30),
	P_Tehsil varchar(30),
	P_State varchar(30),
	P_Cast varchar(30),
	P_Edu_Details varchar(50),
	P_CNIC varchar(20),
	P_Prm_Cnt_Num varchar(20),
	P_Mbl_Num varchar(20),
	P_Email varchar(30),
	P_City varchar(30),
	P_Gender varchar(10),
	P_Picture varbinary(max),
	P_Att_Name varchar(30),
	P_Att_Lst_Name varchar(30),
	P_Att_Fat_Name varchar(30),
	P_Att_Cnt_Num varchar(20),
	P_Att_Blood_Group varchar(10),
	P_D_Name varchar(30) foreign key (P_D_Name) references Registered_Doc (D_Name),
	P_Diagnosis varchar(50),
	P_Department varchar(30) foreign key (P_Department) references Departments (department_name)
	);



DATA IN Register_Patient_Details TABLE




5. Patient Checkup
QUERY
create table Patient_Checkup (
	MR_no varchar(50) foreign key (MR_no) references Register_Patient_Details (MR_no),
	D_Id varchar(25) foreign key (D_Id) references All_Doctors (D_Id),
	Date_Of_Checkup date
);
DATA IN Patient_Checkup TABLE













6. Admit patient
QUERY
create table Admit_Patient (
	MR_no varchar(50) foreign key (MR_no) references Register_Patient_Details (MR_no),
	Adv_Pay int,
	Mode_Pay varchar(30),
	Room_Num varchar(10),
	department_name varchar(30) foreign key (department_name) references Departments (department_name),
	Date_Of_Adm date,
	Int_Con varchar(50),
	Diagnosis varchar(50),
	Treatment varchar(50),
	No_Of_Doc int,
	P_Att_Name varchar(30)
);
DATA IN Admit_Patient TABLE












7. Signs/Symptoms Details
QUERY
create table Symptoms_Details (
	MR_no varchar(50) foreign key (MR_no) references Register_Patient_Details (MR_no),
	Dry_Cough bit,
	Fever bit,
	Chest_Pain bit,
	Shortness_Of_Breath bit,
	Fatigue bit,
	Headache bit,
	Vomiting bit,
	Loss_Of_Smell bit,
	Loss_Of_Taste bit,
	Diarrhea bit
);
DATA IN Symptoms_Details TABLE














8. Recovered Patient
QUERY
create table Recovered_Patient (
	MR_no varchar(50) foreign key (MR_no) references Register_Patient_Details (MR_no),
	D_Name varchar(30) foreign key (D_Name) references Registered_Doc (D_Name),
	Date_Of_Adm date,
	Date_Of_Dis date,
	Willing_For_Plasma_Donation bit
);
DATA IN Recovered_Patient TABLE
select Recovered_Patient.MR_no "PATIENT NUMBER", Register_Patient_Details.P_First_Name "PATIENT NAME",
Register_Patient_Details.P_Last_Name "LAST NAME", Register_Patient_Details.P_Father_Name "FATHER NAME", 
Register_Patient_Details.P_City "CITY", Register_Patient_Details.P_Blood_Group "BLOOD GROUP", 
Recovered_Patient.D_Name "DOCTOR", Recovered_Patient.Date_Of_Adm "ADMISSION DATE", 
Recovered_Patient.Date_Of_Dis "DISCHARGE DATE", Recovered_Patient.Willing_For_Plasma_Donation 
"PLASMA WILLING" from Recovered_Patient inner join Register_Patient_Details on 
Register_Patient_Details.MR_no = Recovered_Patient.MR_no where 
Recovered_Patient.MR_no = 'PTQASIMCOVIDRWP-05';


Question 2 Short Question in light of above case study. 		               (5) 
Construct the ER- Diagram of the above scenario. 
Note: (Hand drawn Diagram should be added into your assignment. Compare your Hand drawn Diagram with system generated ER and Class diagram and identify the short comings)

ANSWER: The difference/short comings was not that much as the ER diagram that is Hand Drawn and the system generated Diagram are conveying the same result. And the Primary Key and Foreign Key both of them are same as they were expected at first.






