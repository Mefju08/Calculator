pipeline {
    

    environment {
        CONFIGURATION = "Release"
    }

    stages {
        stage("CleanUp") {
            steps {
                sh "dotnet clean"
            }
        }

        stage("Restore") {
            steps {
                sh "dotnet restore"
            }
        }

        stage("Build") {
            steps {
                sh "dotnet build Calculator/Calculator.csproj --configuration ${CONFIGURATION} --no-restore"
                sh "dotnet build Calculator.UnitTests/Calculator.UnitTests.csproj --configuration ${CONFIGURATION} --no-restore"
            }
        }

        stage("Unit Tests") {
            steps {
                sh "dotnet test Calculator.UnitTests/Calculator.UnitTests.csproj --no-build --no-restore --configuration ${CONFIGURATION}"
            }
        }
    }
}
