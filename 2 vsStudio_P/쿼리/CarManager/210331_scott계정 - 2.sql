SELECT cu.c_name, ca.car_model, ca.car_price, 
        se.se_name, d.d_date
from deal_t d, car_t ca, customer_t cu, seller_t se
where d.car_id=ca.car_id and d.c_id=cu.c_id 
and d.se_id=se.se_id;