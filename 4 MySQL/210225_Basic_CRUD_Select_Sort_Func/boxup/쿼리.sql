/*
SELECT user_nm, user_age FROM t_user WHERE i_user>3;

SELECT i_user, user_nm, user_age FROM t_user ORDER BY i_user asc;

SELECT * FROM namecard JOIN t_user;

-- 안되는 코드
SELECT * FROM namecard JOIN t_user ON namecard.name = t_user.user_nm;
SET namecard.name = '아길동?' WHERE namecard.name='이길동' AND namecard.tel='222';

DELETE FROM t_user WHERE i_user = 17;
UPDATE t_user SET email = 'ssss.com' WHERE i_user = 16;
*/

UPDATE t_user SET email = 'ssss.com' WHERE i_user = 16;