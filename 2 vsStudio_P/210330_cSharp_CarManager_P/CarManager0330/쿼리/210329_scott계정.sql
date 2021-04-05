/*
INSERT into deal_t (d_id, d_date, se_id, c_id, car_id)
    (select deal_t_SEQ.nextval, sysdate, s.se_id, 
    cu.c_id, ca.car_id from 
    seller_t s, customer_t cu, car_t ca
    where s.se_id=cu.c_id and cu.c_id=ca.car_id);
*/

select distinct se_id * from deal_t where se_id=c_id;