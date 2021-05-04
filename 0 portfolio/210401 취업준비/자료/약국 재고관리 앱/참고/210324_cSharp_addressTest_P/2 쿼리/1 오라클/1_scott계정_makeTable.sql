DROP SEQUENCE seq_nc_id;
DROP TABLE namecard CASCADE CONSTRAINTS;


create table namecard (
    id number not null,
    name VARCHAR(10) not null,
    tel VARCHAR(20) not null, 
    email VARCHAR(30),
    address VARCHAR(50) not null, 
    CONSTRAINT pk_namecard_id PRIMARY key(id));
    
create sequence seq_nc_id INCREMENT by 1 START with 1;
