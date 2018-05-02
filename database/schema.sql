CREATE USER recipe;
CREATE DATABASE recipe;
GRANT ALL PRIVILEGES ON DATABASE recipe TO recipe;

\c recipe;

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;
SET row_security = off;


--
--

CREATE TABLE users (
    id SERIAL NOT NULL,
    email text NOT NULL,
    password text NOT NULL,
    first_name text,
    last_name text,
    created timestamp without time zone DEFAULT now()
);

ALTER TABLE users OWNER TO "recipe";

--
--

CREATE TABLE recipes (
    id SERIAL NOT NULL,
    user_id integer NOT NULL,
    name text,
    ingredients text,
    instructions text,
    created timestamp without time zone DEFAULT now()
);

ALTER TABLE recipes OWNER TO "recipe";