BEGIN TRAN
insert into Drivers (Name) VALUES
    ('John Doe'),
    ('Jane Doe')
COMMIT TRAN

BEGIN TRAN
insert into Cars (Brand, [Name], [Description], DriverId) VALUES 
    ('Volvo', 'V40', 'Small station wagon', 1),
    ('Volvo', 'V60', 'Medium sized station wagon', 2),
    ('Volvo', 'V90', 'Big station wagon', 2),
    ('Volvo', 'S40', 'Small sedan', 1),
    ('Volvo', 'S60', 'Medium sized sedan', 2),
    ('Volvo', 'S90', 'Big sedan', 1)
COMMIT TRAN