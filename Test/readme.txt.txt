
程序提供源码，源码在: https://github.com/heguo/BackupFiles.git
备份失败，作者不负任何责任。
WinServer2003上测试通过
需要 .net framework 2.0 支持（通常都有）
cmd 执行下面这行指令，开始备份最近5天修改过的文件,eoffice大概需要 3 分钟
BackupFiles.exe -run:true -from:d:\eoffice -to:e:\backupfiles\eoffice -day:5 -ip:logs -if:123efg >> e:\backupfiles\backupfiles.log

格式：
BackupFiles.exe -run:是否自动启动 -from:需备份的文件夹 -to:目标文件夹 -day:最近修改天数 -ip:忽略的文件夹名称1;名称2 -if:忽略的文件1;文件2 > backupfiles.log

参数说明：
run 表示自动执行备份，备份完成，自动关闭
from 表示eoffice安装的文件夹
to 表示备份至目标文件夹
day 表示几天内修改的文件
ip 表示备份过程中忽略掉的文件夹名称
if 表示备份过程中忽略掉的文件名 如: abc;.log

附 backupfiles.bat 文件，放在 E:\backupfiles，
假设 eoffice 安装在 D:\eoffice，如果不是修改 eoffice 所在的文件夹，
执行 backupfiles.bat，先停止 eoffice 和 MySql 服务，执行文件复制，完成后启动 eoffice 和 MySql 服务
备份完成后在 e:\backupfiles\eoffice 有最新的文件，
可查看日志文件: e:\backupfiles\backupfiles.log
将 backupfiles.bat 设置为任务计划，可实现每天自动备份。


有疑问联系作者: shuozi@sohu.com