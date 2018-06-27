@cd ..\..
docker-compose -f docker-compose.yml -f docker-compose.component-tests.yml -f docker-compose.component-tests.override.yml -p component stop --timeout 30