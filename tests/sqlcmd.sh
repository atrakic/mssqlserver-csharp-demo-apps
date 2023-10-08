#!/usr/bin/env bash
DB="${1}"
PASS="${2}"
docker exec -it "$DB" /opt/mssql-tools/bin/sqlcmd \
  -S localhost -U SA -P '${PASS}'