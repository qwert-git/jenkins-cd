pipeline {
    agent any

    parameters {
        booleanParam(name:'executeTests', defaultValue: true, description: 'Run unit tests')
    }

    stages {
        stage ('Clean workspace') {
           steps {
                cleanWs()
            }
        }

        stage ('Git Checkout') {
            steps {
                git branch: 'master', credentialsId: 'c74a8eb0-95f8-477f-acbe-a9fabc077388', url: 'https://github.com/qwert-git/jenkins-cd.git'
            }
        }

        // checkout([$class: 'GitSCM', branches: [[name: '*/master']], extensions: [], userRemoteConfigs: [[credentialsId: 'c74a8eb0-95f8-477f-acbe-a9fabc077388', url: 'https://github.com/qwert-git/jenkins-cd.git']]])

        stage('Restore packages') {
            steps {
                sh "dotnet restore ${workspace}\\app\\DotNetApp.sln"
            }
        }

        stage('build') {
            steps {
                sh "dotnet publish ${workspace}\\app\\ -c Release -o ${workspace}\\app\\"
            }
        }
        
        stage('Unit Tests') {
            when{
                expression {
                    params.executeTests
                }
            }
            steps {
                echo 'testing..'
            }
        }
        
        stage('deploy') {
            steps {
                echo 'deploying..'
            }
        }
    }
}
