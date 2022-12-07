# Continuose Delivery with Jenkins
The goal is to setup simple CD pipeline with Jenkins for .NET Core application.
We wanna create a pipeline which will build an app, start unit and integration tests, and deploy it to the remove server.

## Structure of the Project
app -> default dotnet application as sample to build and deploy

tests -> samples for unit and integration tests, just some tests with 100% passing

Jenkinsfile -> pipeline script

docker-compose -> starts up Jenkins with all required settings

## Run Jenkins 
1. With the docker compose
```
    docker compose up -d
```

Or build the image with the commands
```
    cd /jenkins_with_dotnet/
    docker build -t jenkins .
```

## Pipeline Setup
Pipeline was set up based on the script. The script itself could be found in the Jenkinsfile at the root of the project.
It consists of Checkout, Build, Unit Tests, Integration Tests, Publishing steps.

## Plagins
To create this project, we had to install additional plugins
* .NET SDK Support
* Publish Over SSH

## Helpful References
Source of groovy scripts: https://github.com/CodeMazeBlog/docker-series/tree/docker-series-continuous-integration-jenkins-end/jenkins-docker/master
Guide to dotnet core CI with Jenkins: https://code-maze.com/ci-jenkins-docker/
