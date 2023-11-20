SELECT Product.[name], ProductType.[Name], Category.[Name]  FROM Product
LEFT JOIN ProductType ON ProductType.ProdId = Product.id
JOIN Category ON Category.Id =  Product.CategotyId
