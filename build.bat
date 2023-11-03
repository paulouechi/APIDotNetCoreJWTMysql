@echo off
echo Docker Config Network
docker network create --subnet=172.20.0.0/16 net-bridge
echo Create Container MySQL...
cd DockerMySQL
docker volume create mysql_data
docker build -t mysql-server .
docker run -d -p 13306:3306 -e MYSQL_ROOT_PASSWORD="@MyPassword123" --net net-bridge --ip 172.20.0.10 --name "mysql-server" -v mysql_data:/data -t mysql-server
echo Waiting loading MySQL...
timeout /t 30 /nobreak > NUL
docker exec -i mysql-server mysql -uroot -p@MyPassword123 mysql < config.sql
docker exec -i mysql-server mysql -uroot -p@MyPassword123 mysql < db.sql
echo Create Container API DOTNET...
cd ..\APIDotNetCoreJWTMysql
docker build -f APIDotNetCoreJWTMysql/Dockerfile -t api-donetcore-jwt-mysql .
docker run -d -p 5000:80 --name "api-donetcore-jwt-mysql" --net net-bridge --ip 172.20.0.5 -t api-donetcore-jwt-mysql
cd ..
