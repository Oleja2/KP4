BACKUP DATABASE Hotel
	TO DISK = 'G:\�������� 4 ����\
				Backup\Hotel_BackUp.bak'


RESTORE HEADERONLY
		FROM DISK = 'Hotel_BackUp.bak'

RESTORE DATABASE Hotel
		FROM DISK = 'Hotel_BackUp.bak'
		WITH FILE = 1
