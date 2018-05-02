# Dockerfile
FROM postgres:9.6

RUN mkdir -p /tmp/data/

# Add schema file, get ran on docker run
ADD schema.sql /docker-entrypoint-initdb.d/
ADD script.sh /docker-entrypoint-initdb.d/

ADD *.csv /tmp/data/