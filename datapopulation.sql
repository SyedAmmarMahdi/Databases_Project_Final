Insert into Client(idClient, client_name, email, [address], phone_number) values(1, 'Syed Ammar Mahdi', 'syed.ammar.mahdi@email.com', 'House#20, Street 15, Bahria Enclave, Islamabad', 03345115449)
Insert into Client(idClient, client_name, email, [address], phone_number) values(2, 'Maryam Ansar', 'maryam.ansar@email.com', 'House#20, Street 15, Bahria Enclave, Islamabad', 03333280993)
Insert into Client(idClient, client_name, email, [address], phone_number) values(3, 'Kunza Rizvi', 'kunza.rizvi@email.com', 'House#4, Street 44, Clifton Ave, Karachi', 03314566606)
Insert into Client(idClient, client_name, email, [address], phone_number) values(4, 'Maaz Saeed', 'maaz.saeed@email.com', 'Flat#19, Apartment B, Sea View Apartments, Karachi', 03312608808)

Insert into Animal(idanimal, Client_idClient, Pet_name, species, age, sex) values(1, 1, 'Ozzy', dog, 48, 'M')
Insert into Animal(idanimal, Client_idClient, Pet_name, species, age, sex) values(2, 2, 'Belle', dog, 96, 'F')
Insert into Animal(idanimal, Client_idClient, Pet_name, species, age, sex) values(3, 3, 'Baby', cat, 8, 'F')
Insert into Animal(idanimal, Client_idClient, Pet_name, species, age, sex) values(4, 3, 'Nala', cat, 2, 'M')

Insert into Vet(idVet, [name], qualification, gender, age) values(1, 'Aftab Ahmed', 'Dr.', 'M', 44)
Insert into Vet(idVet, [name], qualification, gender, age) values(2, 'Fatima Nadeem', 'Nurse.', 'F', 23)
Insert into Vet(idVet, [name], qualification, gender, age) values(3, 'Abeer Asif', 'Dr.', 'F', 30)
Insert into Vet(idVet, [name], qualification, gender, age) values(4, 'Amjad Khan', 'Vet Tech', 'M', 27)
Insert into Vet(idVet, [name], qualification, gender, age) values(5, 'Kabir Kumar', 'Intern', 'M', 22)

Insert into category(idcategory, category_name) values(1, 'Dog Food')
Insert into category(idcategory, category_name) values(2, 'Medicine')
Insert into category(idcategory, category_name) values(3, 'Litter')
Insert into category(idcategory, category_name) values(4, 'Toy')
Insert into category(idcategory, category_name) values(5, 'Accessory')



