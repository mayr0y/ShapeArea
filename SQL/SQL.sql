CREATE TABLE Product (Id INT PRIMARY KEY, name VARCHAR(20));
INSERT INTO Product VALUE (1, 'iPhone X'), (2, 'MacBook Pro'), (3, 'BMW');

CREATE TABLE Category (Id INT PRIMARY KEY, name VARCHAR(20));
INSERT INTO Category VALUE (1, 'Phone'), (2, 'Laptop'), (3, 'Apple product');

CREATE TABLE ProductCategory (Id_Product INT, Id_Category INT,
							FOREIGN KEY (Id_Product) REFERENCES Product(Id),
                            FOREIGN KEY (Id_Category) REFERENCES Category(Id),
                            PRIMARY KEY(Id_Product, Id_Category));

INSERT INTO ProductCategory VALUE (1, 1), (2, 2), (1, 3), (2, 3);

SELECT Product.name, Category.name FROM Product
LEFT JOIN ProductCategory ON Product.id = ProductCategory.Id_Product
LEFT JOIN Category ON ProductCategory.Id_Category = Category.id;

