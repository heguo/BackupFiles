net stop eoffice
net stop mysql
e:
cd E:\backupfiles
BackupFiles.exe -run:true -from:d:\eoffice -to:e:\backupfiles\eoffice -day:5 -ip:logs -if:123efg >> e:\backupfiles\backupfiles.log
net start mysql
net start eoffice
c:
cd C:\Program Files (x86)\WinRAR
rar a E:\backupfiles\eoffice.rar E:\backupfiles\eoffice

set Today=%date:~0,4%%date:~5,2%%date:~8,2%
ren E:\backupfiles\eoffice.rar %Today%eoffice.rar

pause