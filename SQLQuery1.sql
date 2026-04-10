IF NOT EXISTS (
SELECT stud_id FROM Students 
WHERE  last_name=N'Никифоров' AND first_name=N'Данила' AND middle_name=N'Владимирович' AND birth_date=N'1977-10-24' AND email=N'bazilik_spb@mail.ru' AND phone=N'+7(911)024-56-78' AND)
INSERT Students(last_name,first_name,middle_name,birth_date,email,phone,) VALUES (N'Никифоров',N'Данила',N'Владимирович',N'1977-10-24',N'bazilik_spb@mail.ru',N'+7(911)024-56-78',)