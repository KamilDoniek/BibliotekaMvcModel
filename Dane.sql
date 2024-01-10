INSERT INTO Author ([FirstName],[LastName]) values ('Jan','Brzechwa');
INSERT INTO Author ([FirstName],[LastName]) values ('Władysław','Reymont');
INSERT INTO Author ([FirstName],[LastName]) values ('Walter','Isaacson');
INSERT INTO Author ([FirstName],[LastName]) values ('Dale','Carnegie');

INSERT INTO Book ([Title],[ISBN],[AuthorId]) values ('Kaczka dziwaczka','9788382073393',1);
INSERT INTO Book ([Title],[ISBN],[AuthorId]) values ('Brzechwa dzieciom','9283382073393',1);

INSERT INTO Book ([Title],[ISBN],[AuthorId]) values ('Chłopi','9183382213393',2);
INSERT INTO Book ([Title],[ISBN],[AuthorId]) values ('Wampir','1183382212393',2);

INSERT INTO Book ([Title],[ISBN],[AuthorId]) values ('Steve Jobs','2223382212393',3);
INSERT INTO Book ([Title],[ISBN],[AuthorId]) values ('Elon Musk','2123384212393',3);

INSERT INTO Book ([Title],[ISBN],[AuthorId]) values ('Jak zdobyć przyjaciół i zjednać sobie ludzi','2123442212393',4);

INSERT INTO dbo.[User]([FirstName],[LastName],[Email]) values ('Adrian','Nowak','adrianNowak@onet.pl');
INSERT INTO dbo.[User]([FirstName],[LastName],[Email]) values ('Wiktor','Nowak','WiktorNowak@wp.pl');
INSERT INTO dbo.[User]([FirstName],[LastName],[Email]) values ('Adrian','Opalski','adrianOpalski@onet.pl');
INSERT INTO dbo.[User] ([FirstName],[LastName],[Email]) values ('Jakun','Nowak','jakubNowak@wp.pl');

INSERT INTO LibraryCard([CardNumber],[ExpiryDate],[UserId]) values (1000000001,'2024-02-10',1);
INSERT INTO LibraryCard([CardNumber],[ExpiryDate],[UserId]) values (1000000002,'2024-02-10',2);