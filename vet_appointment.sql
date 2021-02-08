CREATE TABLE Client (
  idClient INTEGER  NOT NULL   IDENTITY ,
  client_name VARCHAR(256)  NOT NULL  ,
  email VARCHAR(256)  NOT NULL  ,
  address VARCHAR(256)  NOT NULL  ,
  phone_number INTEGER  NOT NULL    ,
PRIMARY KEY(idClient));
GO




CREATE TABLE client_transaction (
  idtransaction INTEGER  NOT NULL   IDENTITY   ,
PRIMARY KEY(idtransaction));
GO




CREATE TABLE Vet (
  idVet INTEGER  NOT NULL   IDENTITY ,
  name VARCHAR(255)    ,
  qualification VARCHAR(45)    ,
  gender VARCHAR    ,
  age INTEGER      ,
PRIMARY KEY(idVet));
GO




CREATE TABLE category (
  idcategory INTEGER  NOT NULL   IDENTITY ,
  category_name VARCHAR(255)  NOT NULL    ,
PRIMARY KEY(idcategory));
GO




CREATE TABLE Animal (
  idanimal INTEGER  NOT NULL   IDENTITY ,
  Client_idClient INTEGER  NOT NULL  ,
  Pet_name VARCHAR(255)    ,
  species VARCHAR(45)  NOT NULL  ,
  age INTEGER    ,
  sex VARCHAR(20)  NOT NULL    ,
PRIMARY KEY(idanimal, Client_idClient)  ,
  FOREIGN KEY(Client_idClient)
    REFERENCES Client(idClient));
GO


CREATE INDEX animal_FKIndex1 ON Animal (Client_idClient);
GO


CREATE INDEX IFK_Rel_10 ON Animal (Client_idClient);
GO


CREATE TABLE item (
  iditem INTEGER  NOT NULL   IDENTITY ,
  category_idcategory INTEGER  NOT NULL  ,
  item_name VARCHAR(255)  NOT NULL  ,
  price INTEGER  NOT NULL  ,
  expiry_date DATE    ,
  weight INTEGER      ,
PRIMARY KEY(iditem)  ,
  FOREIGN KEY(category_idcategory)
    REFERENCES category(idcategory));
GO


CREATE INDEX item_FKIndex1 ON item (category_idcategory);
GO


CREATE INDEX IFK_Rel_07 ON item (category_idcategory);
GO


CREATE TABLE appointment (
  idappointment INTEGER  NOT NULL   IDENTITY ,
  Vet_idVet INTEGER    ,
  Animal_Client_idClient INTEGER  NOT NULL  ,
  animal_idanimal INTEGER  NOT NULL  ,
  fees INTEGER    ,
  app_date DATE  NOT NULL    ,
PRIMARY KEY(idappointment)    ,
  FOREIGN KEY(Animal_idanimal, Animal_Client_idClient)
    REFERENCES Animal(idanimal, Client_idClient),
  FOREIGN KEY(Vet_idVet)
    REFERENCES Vet(idVet));
GO


CREATE INDEX appointment_FKIndex1 ON appointment (Animal_Client_idClient);
GO
CREATE INDEX appointment_FKIndex2 ON appointment (Vet_idVet);
GO


CREATE INDEX IFK_Rel_15 ON appointment (Animal_idanimal, Animal_Client_idClient);
GO
CREATE INDEX IFK_Rel_16 ON appointment (Vet_idVet);
GO


CREATE TABLE transaction_has_item (
  client_transaction_idtransaction INTEGER  NOT NULL  ,
  item_iditem INTEGER  NOT NULL  ,
  appointment_idappointment INTEGER  NOT NULL  ,
  quantity INTEGER      ,
PRIMARY KEY(client_transaction_idtransaction, item_iditem, appointment_idappointment)      ,
  FOREIGN KEY(client_transaction_idtransaction)
    REFERENCES client_transaction(idtransaction),
  FOREIGN KEY(item_iditem)
    REFERENCES item(iditem),
  FOREIGN KEY(appointment_idappointment)
    REFERENCES appointment(idappointment));
GO


CREATE INDEX transaction_has_item_FKIndex1 ON transaction_has_item (client_transaction_idtransaction);
GO
CREATE INDEX transaction_has_item_FKIndex2 ON transaction_has_item (item_iditem);
GO
CREATE INDEX transaction_has_item_FKIndex3 ON transaction_has_item (appointment_idappointment);
GO


CREATE INDEX IFK_Rel_05 ON transaction_has_item (client_transaction_idtransaction);
GO
CREATE INDEX IFK_Rel_06 ON transaction_has_item (item_iditem);
GO
CREATE INDEX IFK_Rel_08 ON transaction_has_item (appointment_idappointment);
GO



