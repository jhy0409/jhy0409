/*
SELECT * FROM namecard WHERE id LIKE 5;
SELECT * FROM namecard WHERE NAME LIKE '_가_' ORDER BY NAME desc;
DELETE FROM namecard WHERE id = 7; 
UPDATE namecard SET phone ='999-9999-9999' WHERE NAME ='아자차'; -- 8번까지
*/


SELECT * FROM namecard JOIN userinfo WHERE namecard.name = userinfo.name;