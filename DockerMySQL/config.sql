CREATE USER 'dba'@'%' IDENTIFIED BY '@MyPassword123';
GRANT ALL PRIVILEGES ON *.* TO 'dba'@'%' WITH GRANT OPTION;
flush privileges;
exit;