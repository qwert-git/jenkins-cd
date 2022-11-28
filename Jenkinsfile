pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                // Get some code from a GitHub repository
                git 'https://github.com/qwert-git/jenkins-cd.git'
            }
        }
        
        stage('Build') {
            steps {
                dotnetBuild configuration: 'Release', workDirectory: './app/'
            }
        }
        
        stage('Unit Tests') {
            steps {
                dotnetTest configuration: 'Release', workDirectory: './tests/unit/'
            }
        }
        
        stage('Integration Tests') {
            steps {
                dotnetTest configuration: 'Release', workDirectory: './tests/integration/'
            }
        }
        
        stage('Publishing') {
            steps {
                dotnetPublish configuration: 'Release', outputDirectory: './published', selfContained: false, workDirectory: './app/'
            }
        }
        
        
    }
}