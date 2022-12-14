// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlow.Selenium.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Demo")]
    public partial class DemoFeature
    {

        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Demo.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Demo", "\t\tAs a User,\n\t\tI can find information about libraries this demo uses", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Google Search - FluentAssertions")]
        [NUnit.Framework.CategoryAttribute("C001")]
        [NUnit.Framework.CategoryAttribute("smokeTest")]
        public virtual void GoogleSearch_FluentAssertions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Google Search - FluentAssertions", new string[] {
                        "C001",
                        "smokeTest"});
#line 6
            this.ScenarioSetup(scenarioInfo);
           
#line 7
            testRunner.Given("I am on \"http://www.google.com\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            

#line 8
            testRunner.When("I search for \"Fluent Assertions\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
            testRunner.And("select \"Fluent Assertions - Fluent Assertions\" in the search results", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
            testRunner.Then("I am presented with the \"Fluent Assertions - Fluent Assertions\" homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Google Search - SpecFlow")]
        [NUnit.Framework.CategoryAttribute("C002")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public virtual void GoogleSearch_SpecFlow()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Google Search - SpecFlow", new string[] {
                        "C002",
                        "regression"});
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
 testRunner.Given("I am on \"http://www.google.com\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
 testRunner.When("I search for \"SpecFlow\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.And("select \"SpecFlow\" in the search results", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.Then("I am presented with the \"SpecFlow - Binding Business Requirements to .NET Code\" h" +
                    "omepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Google Search - Selenium")]
        [NUnit.Framework.CategoryAttribute("C003")]
        [NUnit.Framework.CategoryAttribute("smokeTest")]
        public virtual void GoogleSearch_Selenium()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Google Search - Selenium", new string[] {
                        "C003",
                        "smokeTest"});
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
 testRunner.Given("I am on \"http://www.google.com\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
 testRunner.When("I search for \"Selenium\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.And("select \"Selenium - Web Browser Automation\" in the search results", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.Then("I am presented with the \"Selenium - Web Browser Automation\" homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Google Search - JetBrains Rider")]
        [NUnit.Framework.CategoryAttribute("C004")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public virtual void GoogleSearch_JetBrainsRider()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Google Search - JetBrains Rider", new string[] {
                        "C004",
                        "regression"});
#line 27
this.ScenarioSetup(scenarioInfo);
#line 28
 testRunner.Given("I am on \"http://www.google.com\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
 testRunner.When("I search for \"JetBrains Rider\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.And("select \"Rider: The Cross-Platform .NET IDE from JetBrains\" in the search results", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.Then("I am presented with the \"Rider: The Cross-Platform .NET IDE from JetBrains\" homep" +
                    "age", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
