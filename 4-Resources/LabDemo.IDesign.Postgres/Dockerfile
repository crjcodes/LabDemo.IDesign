# the Postgres container is intended only for local development
# actual production deployment needs to be handled differently
# See docker's docs at https://www.docker.com/blog/how-to-use-the-postgres-docker-official-image/


FROM postgres
ENV POSTGRES_PASSWORD docker
ENV POSTGRES_DB world
COPY world.sql /docker-entrypoint-initdb.d/