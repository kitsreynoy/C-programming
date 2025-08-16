select * from Books; 
select * from Authors;

--update Authors set AuthorID = 21 where AuthorID = 20;

SELECT 
    b.Title,
    b.Genre,
    a.FirstName + ' ' + a.LastName AS Author,
    a.Country
FROM Books b
JOIN Authors a ON b.AuthorID = a.AuthorID;


SELECT 
    a.FirstName + ' ' + a.LastName AS Author,
    b.Title
FROM Authors a
LEFT JOIN Books b ON a.AuthorID = b.AuthorID;


