CREATE TABLE funkcje_bialek (
id_funkcji INTEGER NOT NULL,
nazwa VARCHAR(20),
opis VARCHAR(200),
zrodlo VARCHAR(100)
);
ALTER TABLE funkcje_bialek ADD CONSTRAINT funkcje_bialek_pk PRIMARY KEY (
id_funkcji );
CREATE TABLE kompleksy (
id_kompleksu INTEGER NOT NULL,
nazwa VARCHAR(20),
opis VARCHAR(200),
zrodlo VARCHAR(100)
);
ALTER TABLE kompleksy ADD CONSTRAINT kompleksy_pk PRIMARY KEY ( id_kompleksu );
CREATE TABLE reakcje (
id_reakcji INTEGER NOT NULL,
nazwa VARCHAR(20),
opis VARCHAR(200),
zrodlo VARCHAR(100)
);
ALTER TABLE reakcje ADD CONSTRAINT reakcje_pk PRIMARY KEY ( id_reakcji );
CREATE TABLE relation_1 (
-- ERROR: Column name length exceeds maximum allowed length(30)
sekwencje_bialkowe_id_sekwencji INTEGER NOT NULL,
szlaki_biochemiczne_id_szlaku INTEGER NOT NULL
);
ALTER TABLE relation_1 ADD CONSTRAINT relation_1_pk PRIMARY KEY (
sekwencje_bialkowe_id_sekwencji,
szlaki_biochemiczne_id_szlaku );
CREATE TABLE relation_2 (
-- ERROR: Column name length exceeds maximum allowed length(30)
sekwencje_bialkowe_id_sekwencji INTEGER NOT NULL,
reakcje_id_reakcji INTEGER NOT NULL
);
ALTER TABLE relation_2 ADD CONSTRAINT relation_2_pk PRIMARY KEY (
sekwencje_bialkowe_id_sekwencji,
reakcje_id_reakcji );
CREATE TABLE relation_3 (
-- ERROR: Column name length exceeds maximum allowed length(30)
sekwencje_bialkowe_id_sekwencji INTEGER NOT NULL,
kompleksy_id_kompleksu INTEGER NOT NULL
);
ALTER TABLE relation_3 ADD CONSTRAINT relation_3_pk PRIMARY KEY (
sekwencje_bialkowe_id_sekwencji,
kompleksy_id_kompleksu );
CREATE TABLE relation_4 (
-- ERROR: Column name length exceeds maximum allowed length(30)
sekwencje_bialkowe_id_sekwencji INTEGER NOT NULL,
funkcje_bialek_id_funkcji INTEGER NOT NULL
);
ALTER TABLE relation_4 ADD CONSTRAINT relation_4_pk PRIMARY KEY (
sekwencje_bialkowe_id_sekwencji,
funkcje_bialek_id_funkcji );
CREATE TABLE sekwencje_bialkowe (
id_sekwencji INTEGER NOT NULL,
nazwa VARCHAR(20),
ncbi_id VARCHAR(20),
uniprot_id VARCHAR(20),
sekwencja VARCHAR(8000),
id_funkcji INTEGER
);
ALTER TABLE sekwencje_bialkowe ADD CONSTRAINT sekwencje_bialkowe_pk PRIMARY
KEY ( id_sekwencji );
CREATE TABLE szlaki_biochemiczne (
id_szlaku INTEGER NOT NULL,
nazwa VARCHAR(20),
opis VARCHAR(200),
zrodlo VARCHAR(100)
);
ALTER TABLE szlaki_biochemiczne ADD CONSTRAINT szlaki_biochemiczne_pk PRIMARY
KEY ( id_szlaku );
-- ERROR: FK name length exceeds maximum allowed length(30)
ALTER TABLE relation_1
ADD CONSTRAINT relation_1_sekwencje_bialkowe_fk FOREIGN KEY (
sekwencje_bialkowe_id_sekwencji )
REFERENCES sekwencje_bialkowe ( id_sekwencji );