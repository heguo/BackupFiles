免责声明：共享软件，增量备份工具，备份失败，数据丢失，作者不负任何责任。
程序源码在: https://github.com/heguo/BackupFiles.git
WinServer2003上测试通过，需要 .net framework 2.0 支持（通常都有）

cmd 执行下面这行指令，开始备份最近5天修改过的文件, 备份eoffice大概需要 3 分钟（不含压缩的时间）
BackupFiles.exe -run:true -from:d:\eoffice -to:e:\backupfiles\eoffice -day:5 -ip:logs -if:123efg >> e:\backupfiles\backupfiles.log

格式：
BackupFiles.exe -run:是否自动启动 -from:需备份的文件夹 -to:目标文件夹 -day:最近修改天数 -ip:忽略的文件夹名称1;名称2 -if:忽略的文件1;文件2 > backupfiles.log

参数说明：
run   自动执行备份，备份完成，自动关闭
from 待备份的文件夹
to      备份至目标文件夹
day   最近几天内修改的文件，0表示今天凌晨零时起计，1表示昨天凌晨零时起计
ip      备份过程中忽略掉的文件夹名称
if       备份过程中忽略掉的文件名， 如: abc;.log

附 backupfiles.bat 文件，放在 E:\backupfiles，
假设 eoffice 安装在 D:\eoffice，如果不是，修改此处为 eoffice 所在的文件夹，
假设 winrar 安装在 C:\Program Files (x86)\WinRAR，如果不是，修改此处为 WinRAR 安装的文件夹，
执行 backupfiles.bat，先停止 eoffice 和 MySql 服务，执行文件复制，
备份完成后在 e:\backupfiles\eoffice 有最新的文件，完成后启动 eoffice 和 MySql 服务，
可查看日志文件: e:\backupfiles\backupfiles.log
将 backupfiles.bat 设置为任务计划，实现每天自动备份。


有疑问联系作者: shuozi@sohu.com