select 
	c."ID" as CustomerID,
	c."FirstName",
	c."LastName",
	p."ID" as ProductID,
	o."Quantity" as ProductQuantity,
	p."Price" as ProductPrice
from
	"Customers" c
join 
	"Orders" o on o."CustomerID" = c."ID"
join
	"Products" p on o."ProductID" = p."ID"
where
	c."Age" > 30 and p."ID" = 1;