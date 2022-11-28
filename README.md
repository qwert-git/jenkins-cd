# Continuose Delivery with Jenkins
The goal of this pet project is to setup simple CD pipeline with Jenkins.
The future pipeline should consists of next steps: build, unit tests, integration tests, deploy.

### Infrastructure
- docker compose file
- asp.net core app
- ms sql database


## How To
1. Create jenkins-master image
```
    cd /jenkins/master/
    docker build -t jenkins-master .
```

## Helpful References
Source of groovy scripts: https://github.com/CodeMazeBlog/docker-series/tree/docker-series-continuous-integration-jenkins-end/jenkins-docker/master
Guide to dotnet core CI with Jenkins: https://code-maze.com/ci-jenkins-docker/
