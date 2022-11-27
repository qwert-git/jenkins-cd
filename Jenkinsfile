pipeline {
    agent any

    parameters {
        booleanParam(name:'executeTests', defaultValue: true, description: 'Run unit tests')
    }

    stages {
        stage('build') {
            steps {
                echo 'building..'
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
