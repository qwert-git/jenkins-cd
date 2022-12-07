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
        
        stage('Deploy') {
            steps {
                sshPublisher(
                    publishers: [sshPublisherDesc(configName: 'kali1', transfers: [sshTransfer(cleanRemote: false, excludes: '', execCommand: 'mkdir command', execTimeout: 120000, flatten: false, makeEmptyDirs: false, noDefaultExcludes: false, patternSeparator: '[, ]+', remoteDirectory: '', remoteDirectorySDF: false, removePrefix: '', sourceFiles: '**/**')], usePromotionTimestamp: false, useWorkspaceInPromotion: false, verbose: false)])
            }
        }
    }
}