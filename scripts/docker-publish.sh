#!/bin/bash
DOCKER_ENV=''
DOCKER_TAG=''

case "$TRAVIS_BRANCH" in
  "master")
    DOCKER_ENV=production
    DOCKER_TAG=latest
    ;;
  "develop")
    DOCKER_ENV=development
    DOCKER_TAG=dev
    ;;    
esac

docker login -u $DOCKER_USERNAME -p $DOCKER_PASSWORD
docker build -f ./src/Sama.Api/Dockerfile.$DOCKER_ENV -t sama.api:$DOCKER_TAG ./src/Sama.Api
docker tag sama.api:$DOCKER_TAG $DOCKER_USERNAME/sama.api:$DOCKER_TAG
docker push $DOCKER_USERNAME/sama.api:$DOCKER_TAG