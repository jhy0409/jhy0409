/*
INSERT into deal_t values (
deal_t_SEQ.nextval,
sysdate, 
(select s.se_id from seller_t s, customer_t cu 
    where cu.c_id=s.se_id),
(select cu.c_id from customer_t cu, car_t ca 
    where ca.car_id=cu.c_id),
(select ca.car_id from car_t ca, customer_t cu 
    where cu.c_id=ca.car_id));
*/

INSERT into deal_t values (
deal_t_SEQ.nextval,
sysdate, 
(select s.se_id, cu.c_id, ca.car_id from 
    seller_t s, customer_t cu, car_t ca
    where cu.c_id=s.se_id and ca.car_id=cu.c_id and cu.c_id=ca.car_id));