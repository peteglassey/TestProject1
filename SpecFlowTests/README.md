# SpecFlow tests

## Running the tests
You should just be able to run `dotnet test` from the root of the SpecFlowTests project

### Rider 
install the Rider SpecFlow plugin

### Visual Studio
install the SpecFlow extension

## Living Docs
to generate the test report in html, you need to install the livingdocs extension
`dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI`

run this command from the root of the SpecFlowTests project:
`livingdoc test-assembly .\bin\Debug\net8.0\SpecFlowTests.dll -t .\bin\Debug\net8.0\TestExecution.json --output ./output.html`
