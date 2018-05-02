#!/bin/bash

DATABASE_NAME="recipe"
ROLE_NAME="recipe"

for x in $(ls /tmp/data/users.csv);
do psql -d "$DATABASE_NAME" -h "$POSTGRES_PORT_5432_TCP_ADDR" -p "$POSTGRES_PORT_5432_TCP_PORT" -U postgres -c "COPY users(id,email,password,first_name,last_name) FROM '$x' DELIMITERS ',' CSV HEADER;"; done
echo "*** USERS DATA IMPORT COMPLETE ***"

for x in $(ls /tmp/data/recipes.csv);
do psql -d "$DATABASE_NAME" -h "$POSTGRES_PORT_5432_TCP_ADDR" -p "$POSTGRES_PORT_5432_TCP_PORT" -U postgres -c "COPY recipes(id,user_id,name,ingredients,instructions) FROM '$x' DELIMITERS ',' CSV HEADER;"; done
echo "*** RECIPE DATA IMPORT COMPLETE ***"
