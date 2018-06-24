FROM mysql/mysql-server:8.0 

ENV MYSQL_ROOT_PASSWORD=password

ENV MYSQL_DATABASE=library
ENV MYSQL_USER=library_admin
ENV MYSQL_PASSWORD=password

COPY Migration/* /docker-entrypoint-initdb.d/