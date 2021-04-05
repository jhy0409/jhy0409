
drop table customer_t cascade constraints;
drop table car_t cascade constraints;
drop table seller_t cascade constraints;
drop table deal_t cascade constraints;

CREATE TABLE customer_t
(
    c_id       INT              NOT NULL, 
    c_name     VARCHAR2(10)     NOT NULL, 
    c_tel      VARCHAR2(20)     NOT NULL, 
    c_addr     VARCHAR2(50)     NOT NULL, 
    c_email    VARCHAR2(30)    NULL, 
    CONSTRAINT CUSTOMER_T_PK PRIMARY KEY (c_id)
);

CREATE SEQUENCE customer_t_SEQ
START WITH 1
INCREMENT BY 1;



CREATE TABLE car_t
(
    car_id         INT             NOT NULL, 
    car_model      VARCHAR2(10)    NOT NULL, 
    car_price      NUMBER          NOT NULL, 
    car_color      VARCHAR2(10)    NOT NULL, 
    car_company    VARCHAR2(10)    NOT NULL, 
    car_year       VARCHAR2(20)    NOT NULL, 
    CONSTRAINT CAR_T_PK PRIMARY KEY (car_id)
);

CREATE SEQUENCE car_t_SEQ
START WITH 1
INCREMENT BY 1;


CREATE TABLE seller_t
(
    se_id             INT             NOT NULL, 
    se_name           VARCHAR2(10)    NOT NULL, 
    se_tel            VARCHAR2(20)    NOT NULL, 
    se_email          VARCHAR2(20)    NULL, 
    se_jikwi          VARCHAR2(10)    NOT NULL, 
    se_office_name    VARCHAR2(20)    NOT NULL, 
    CONSTRAINT SELLER_T_PK PRIMARY KEY (se_id)
);

CREATE SEQUENCE seller_t_SEQ
START WITH 1
INCREMENT BY 1;


CREATE TABLE deal_t
(
    d_id      INT             NOT NULL, 
    d_date    VARCHAR2(10)    NOT NULL, 
    se_id     INT             NOT NULL, 
    c_id      INT             NOT NULL, 
    car_id    INT             NOT NULL, 
    CONSTRAINT DEAL_T_PK PRIMARY KEY (d_id)
);

CREATE SEQUENCE deal_t_SEQ
START WITH 1
INCREMENT BY 1;

ALTER TABLE deal_t
    ADD CONSTRAINT FK_deal_t_c_id_customer_t_c_id FOREIGN KEY (c_id)
        REFERENCES customer_t (c_id);

ALTER TABLE deal_t
    ADD CONSTRAINT FK_deal_t_car_id_car_t_car_id FOREIGN KEY (car_id)
        REFERENCES car_t (car_id);

ALTER TABLE deal_t
    ADD CONSTRAINT FK_deal_t_se_id_seller_t_se_id FOREIGN KEY (se_id)
        REFERENCES seller_t (se_id);
/*
INSERT INTO student_t (s_id, s_name, s_major) VALUES (student_t_SEQ.nextval, 's_name 01', 's_major 01');
INSERT INTO student_t (s_id, s_name, s_major) VALUES (student_t_SEQ.nextval, 's_name 02', 's_major 02');
INSERT INTO student_t (s_id, s_name, s_major) VALUES (student_t_SEQ.nextval, 's_name 03', 's_major 03');

INSERT INTO student_t (s_id, s_name, s_major) VALUES (student_t_SEQ.nextval, '홍길동', '컴퓨터과');
INSERT INTO student_t (s_id, s_name, s_major) VALUES (student_t_SEQ.nextval, '전우치', '경영학과');
INSERT INTO student_t (s_id, s_name, s_major) VALUES (student_t_SEQ.nextval, '신사임당', '관광과');

drop table customer_t cascade constraints;
*/



