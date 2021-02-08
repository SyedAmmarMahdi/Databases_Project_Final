CREATE TABLE Client (
  idClient INTEGER  NOT NULL   IDENTITY ,
  client_name INTEGER    ,
  email INTEGER    ,
  address INTEGER    ,
  phone number INTEGER      ,
PRIMARY KEY(idClient));
GO




CREATE TABLE transaction (
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




CREATE TABLE animal (
  idanimal INTEGER  NOT NULL   IDENTITY ,
  Client_idClient INTEGER  NOT NULL  ,
  name VARCHAR(255)    ,
  species VARCHAR(45)    ,
  age INTEGER    ,
  sex VARCHAR(20)      ,
PRIMARY KEY(idanimal, Client_idClient)  ,
  FOREIGN KEY(Client_idClient)
    REFERENCES Client(idClient));
GO


CREATE INDEX animal_FKIndex1 ON animal (Client_idClient);
GO


CREATE INDEX IFK_Rel_10 ON animal (Client_idClient);
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
  Vet_idVet INTEGER  NOT NULL  ,
  animal_Client_idClient INTEGER  NOT NULL  ,
  animal_idanimal INTEGER  NOT NULL  ,
  fees INTEGER  NOT NULL    ,
PRIMARY KEY(idappointment)    ,
  FOREIGN KEY(animal_idanimal, animal_Client_idClient)
    REFERENCES animal(idanimal, Client_idClient),
  FOREIGN KEY(Vet_idVet)
    REFERENCES Vet(idVet));
GO


CREATE INDEX appointment_FKIndex1 ON appointment (animal_idanimal, animal_Client_idClient);
GO
CREATE INDEX appointment_FKIndex2 ON appointment (Vet_idVet);
GO


CREATE INDEX IFK_Rel_15 ON appointment (animal_idanimal, animal_Client_idClient);
GO
CREATE INDEX IFK_Rel_16 ON appointment (Vet_idVet);
GO


CREATE TABLE transaction_has_item (
  transaction_idtransaction INTEGER  NOT NULL  ,
  item_iditem INTEGER  NOT NULL  ,
  appointment_idappointment INTEGER  NOT NULL  ,
  quantity INTEGER      ,
PRIMARY KEY(transaction_idtransaction, item_iditem, appointment_idappointment)      ,
  FOREIGN KEY(transaction_idtransaction)
    REFERENCES transaction(idtransaction),
  FOREIGN KEY(item_iditem)
    REFERENCES item(iditem),
  FOREIGN KEY(appointment_idappointment)
    REFERENCES appointment(idappointment));
GO


CREATE INDEX transaction_has_item_FKIndex1 ON transaction_has_item (transaction_idtransaction);
GO
CREATE INDEX transaction_has_item_FKIndex2 ON transaction_has_item (item_iditem);
GO
CREATE INDEX transaction_has_item_FKIndex3 ON transaction_has_item (appointment_idappointment);
GO


CREATE INDEX IFK_Rel_05 ON transaction_has_item (transaction_idtransaction);
GO
CREATE INDEX IFK_Rel_06 ON transaction_has_item (item_iditem);
GO
CREATE INDEX IFK_Rel_08 ON transaction_has_item (appointment_idappointment);
GO



