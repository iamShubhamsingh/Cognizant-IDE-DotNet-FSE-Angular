select concat(customers.Cust_name,", your order will be delivered on ",orders.delivery_date) as Delivery_message
from customers,orders where customers.cust_id=orders.cust_id && customers.address like '%'
order by customers.Cust_name;