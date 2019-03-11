brief comments :

- the input file is Items.xml where parcels/order details are stored; please use it for other test data;
- the missing calculation rules( like #5 In order to award those who send multiple parcels, special discounts have beenintroduced.)
     will be added in Main function into the list of orderRules; as you'll see, having this framework it's very easy to do.
- all "magic numbers" related to business rules are used in CategoryDetails class where business rules are defined (except SpeedyShippingRule class);
- for the output ( IOrder/PriceDetails property ), normally separate class would be used but since it just print a text i used StringBuilder which does the job;

thank you for having a look at this task and i hope you'll like it.
please contact me if any other comments are needed, my email is vliubarski@gmail.com

kind regards.
vitali.
