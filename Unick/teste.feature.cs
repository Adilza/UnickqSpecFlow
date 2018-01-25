﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Unick
{
    using TechTalk.SpecFlow;
    using Autofac;
    using Autofac.Configuration;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Formulario de Contato")]
    [NUnit.Framework.ParallelizableAttribute()]
    public partial class FormularioDeContatoFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private OpenQA.Selenium.IWebDriver driver;
        
        private IContainer container;
        
        [NUnit.Framework.OneTimeSetUp()]
        public virtual void FeatureSetup()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new ConfigurationSettingsReader());
            container = builder.Build();
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Formulario de Contato", "\tEu como usuário, preciso contactar o prestador de serviço\r\n\tPara que seja necess" +
                    "ário um possível retorno\r\n\tPreciso preencher as informações corretamente.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDown()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            try {((Unickq.SpecFlow.Selenium.WebDriverGrid.PaidWebDriver) driver).UpdateTestResult();} catch (System.Exception) {}
            try {System.Threading.Thread.Sleep(50); driver.Quit(); } catch (System.Exception) {}
            driver = null;
            try {testRunner.ScenarioContext.Remove("Driver");} catch (System.NullReferenceException) {}
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            if(driver != null)
              testRunner.ScenarioContext.Add("Driver", driver);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
            testRunner.Given("que eu esteja no site jobmidia.com.br", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
            testRunner.When("eu navegar até a área do formulário de contato", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Preenchimento do formulario corretamente")]
        [NUnit.Framework.TestCaseAttribute("Chrome", Category="Chrome", TestName="PreenchimentoDoFormularioCorretamente with Chrome")]
        public virtual void PreenchimentoDoFormularioCorretamente(string browser)
        {
InitializeSeleniumBrowser(browser);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Preenchimento do formulario corretamente", new string[] {
                        "Browser:Chrome"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Nome",
                        "Email",
                        "Telefone",
                        "Mensagem"});
            table1.AddRow(new string[] {
                        "Franklin",
                        "franklinjob@hotmail.com",
                        "(21)991475281",
                        "Teste de Mensagem"});
            testRunner.When("informo todos os dados corretamente", ((string)(null)), table1, "Quando ");
            testRunner.And("clico em Enviar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
            testRunner.Then("o site ira informar a mensagem \'Sua mensagem foi enviada com sucesso.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
            this.ScenarioCleanup();
        }
        
        private void InitializeSeleniumBrowser(string browser)
        {
            driver = container.ResolveNamed<OpenQA.Selenium.IWebDriver>(browser);
        }
    }
}
#pragma warning restore
#endregion
