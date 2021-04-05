/*
CREATE TABLE student_t
(
    s_id       INT             NOT NULL, 
    s_name     VARCHAR2(20)    NOT NULL, 
    s_major    VARCHAR2(20)    NOT NULL, 
    CONSTRAINT STUDENT_T_PK PRIMARY KEY (s_id)
);

CREATE SEQUENCE student_t_SEQ
START WITH 1
INCREMENT BY 1;



CREATE TABLE subject_t
(
    sub_id        INT             NOT NULL, 
    sub_name      VARCHAR2(20)    NOT NULL, 
    sub_hakjum    VARCHAR2(20)    NOT NULL, 
    CONSTRAINT SUBJECT_T_PK PRIMARY KEY (sub_id)
);

CREATE SEQUENCE subject_t_SEQ
START WITH 1
INCREMENT BY 1;

CREATE TABLE add_t
(
    s_id      INT    NOT NULL, 
    sub_id    INT    NOT NULL, 
    CONSTRAINT ADD_T_PK PRIMARY KEY (s_id, sub_id)
);

ALTER TABLE add_t
    ADD CONSTRAINT FK_add_t_s_id_student_t_s_id FOREIGN KEY (s_id)
        REFERENCES student_t (s_id);

ALTER TABLE add_t
    ADD CONSTRAINT FK_add_t_sub_id_subject_t_sub_ FOREIGN KEY (sub_id)
        REFERENCES subject_t (sub_id);


INSERT INTO student_t (s_id, s_name, s_major) VALUES (student_t_SEQ.nextval, 's_name 01', 's_major 01');
INSERT INTO student_t (s_id, s_name, s_major) VALUES (student_t_SEQ.nextval, 's_name 02', 's_major 02');
INSERT INTO student_t (s_id, s_name, s_major) VALUES (student_t_SEQ.nextval, 's_name 03', 's_major 03');

*/



INSERT INTO student_t (s_id, s_name, s_major) VALUES (student_t_SEQ.nextval, '홍길동', '컴퓨터과');
INSERT INTO student_t (s_id, s_name, s_major) VALUES (student_t_SEQ.nextval, '전우치', '경영학과');
INSERT INTO student_t (s_id, s_name, s_major) VALUES (student_t_SEQ.nextval, '신사임당', '관광과');
