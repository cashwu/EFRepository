﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace EFRepository.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class NestedFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Nested.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Nested", "\tIn order to save nested data into the database\r\n\tAs a programmer\r\n\tI would like " +
                    "to save the data and it\'s child collection into database", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Nested")))
            {
                EFRepository.Tests.NestedFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add two level data into database should be success")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Nested")]
        public virtual void AddTwoLevelDataIntoDatabaseShouldBeSuccess()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add two level data into database should be success", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table1.AddRow(new string[] {
                        "1",
                        "TestData"});
#line 7
 testRunner.Given("I have nested datas", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table2.AddRow(new string[] {
                        "1",
                        "Level 2 Data"});
            table2.AddRow(new string[] {
                        "2",
                        "Level 2 Data 2"});
#line 10
 testRunner.And("the nested data with id \"1\" has level 2 data", ((string)(null)), table2, "And ");
#line 14
 testRunner.When("I use generic repository to add data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.And("I save the changes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table3.AddRow(new string[] {
                        "1",
                        "TestData"});
#line 16
 testRunner.Then("database should exists nested datas", ((string)(null)), table3, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table4.AddRow(new string[] {
                        "1",
                        "Level 2 Data"});
            table4.AddRow(new string[] {
                        "2",
                        "Level 2 Data 2"});
#line 19
 testRunner.And("database should exists nested level 2 datas", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Update nested data\'s child data which is exists in database should be success")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Nested")]
        public virtual void UpdateNestedDataSChildDataWhichIsExistsInDatabaseShouldBeSuccess()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update nested data\'s child data which is exists in database should be success", ((string[])(null)));
#line 24
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table5.AddRow(new string[] {
                        "1",
                        "TestData"});
#line 25
 testRunner.Given("database has nested datas", ((string)(null)), table5, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content",
                        "ParentId"});
            table6.AddRow(new string[] {
                        "1",
                        "Level 2 Data",
                        "1"});
            table6.AddRow(new string[] {
                        "2",
                        "Level 2 Data 2",
                        "1"});
#line 28
 testRunner.And("database has nested level 2 data", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table7.AddRow(new string[] {
                        "1",
                        "TestData"});
#line 32
 testRunner.And("I have nested datas", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content",
                        "ParentId"});
            table8.AddRow(new string[] {
                        "1",
                        "Level 2 Data",
                        "1"});
            table8.AddRow(new string[] {
                        "2",
                        "Level 2 Data 2222",
                        "1"});
#line 35
 testRunner.And("the nested data with id \"1\" has level 2 data", ((string)(null)), table8, "And ");
#line 39
 testRunner.And("Register nested data update hook in generic repository", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.When("I use generic repository update data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.And("I save the changes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table9.AddRow(new string[] {
                        "1",
                        "TestData"});
#line 42
 testRunner.Then("database should exists nested datas", ((string)(null)), table9, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table10.AddRow(new string[] {
                        "1",
                        "Level 2 Data"});
            table10.AddRow(new string[] {
                        "2",
                        "Level 2 Data 2222"});
#line 45
 testRunner.And("database should exists nested level 2 datas", ((string)(null)), table10, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Update 3 level nested data\'s child data which is exists in database should be suc" +
            "cess")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Nested")]
        public virtual void Update3LevelNestedDataSChildDataWhichIsExistsInDatabaseShouldBeSuccess()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update 3 level nested data\'s child data which is exists in database should be suc" +
                    "cess", ((string[])(null)));
#line 50
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table11.AddRow(new string[] {
                        "1",
                        "TestData"});
#line 51
 testRunner.Given("database has nested datas", ((string)(null)), table11, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content",
                        "ParentId"});
            table12.AddRow(new string[] {
                        "1",
                        "Level 2 Data",
                        "1"});
            table12.AddRow(new string[] {
                        "2",
                        "Level 2 Data 2",
                        "1"});
#line 54
 testRunner.And("database has nested level 2 data", ((string)(null)), table12, "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content",
                        "ParentId"});
            table13.AddRow(new string[] {
                        "1",
                        "Level 3 Data",
                        "1"});
            table13.AddRow(new string[] {
                        "2",
                        "Level 3 Data 2",
                        "1"});
#line 58
 testRunner.And("database has nested level 3 data", ((string)(null)), table13, "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table14.AddRow(new string[] {
                        "1",
                        "TestData"});
#line 62
 testRunner.And("I have nested datas", ((string)(null)), table14, "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content",
                        "ParentId"});
            table15.AddRow(new string[] {
                        "1",
                        "Level 2 Data",
                        "1"});
            table15.AddRow(new string[] {
                        "2",
                        "Level 2 Data 2",
                        "1"});
#line 65
 testRunner.And("the nested data with id \"1\" has level 2 data", ((string)(null)), table15, "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content",
                        "ParentId"});
            table16.AddRow(new string[] {
                        "1",
                        "Level 3 Data",
                        "1"});
            table16.AddRow(new string[] {
                        "2",
                        "Level 3 Data 2222",
                        "1"});
#line 69
 testRunner.And("the nested data with id \"1\" and nested level 2 data with id \"1\" has level 3 data", ((string)(null)), table16, "And ");
#line 73
 testRunner.And("Register nested data update hook in generic repository", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.When("I use generic repository update data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
 testRunner.And("I save the changes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table17.AddRow(new string[] {
                        "1",
                        "TestData"});
#line 76
 testRunner.Then("database should exists nested datas", ((string)(null)), table17, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table18.AddRow(new string[] {
                        "1",
                        "Level 2 Data"});
            table18.AddRow(new string[] {
                        "2",
                        "Level 2 Data 2"});
#line 79
 testRunner.And("database should exists nested level 2 datas", ((string)(null)), table18, "And ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table19.AddRow(new string[] {
                        "1",
                        "Level 3 Data"});
            table19.AddRow(new string[] {
                        "2",
                        "Level 3 Data 2222"});
#line 83
 testRunner.And("database should exists nested level 3 datas", ((string)(null)), table19, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Update nested data\'s parent data which is exists in database should be success")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Nested")]
        public virtual void UpdateNestedDataSParentDataWhichIsExistsInDatabaseShouldBeSuccess()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update nested data\'s parent data which is exists in database should be success", ((string[])(null)));
#line 88
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table20.AddRow(new string[] {
                        "1",
                        "TestData"});
#line 89
 testRunner.Given("database has nested datas", ((string)(null)), table20, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content",
                        "ParentId"});
            table21.AddRow(new string[] {
                        "1",
                        "Level 2 Data",
                        "1"});
            table21.AddRow(new string[] {
                        "2",
                        "Level 2 Data 2",
                        "1"});
#line 92
 testRunner.And("database has nested level 2 data", ((string)(null)), table21, "And ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table22.AddRow(new string[] {
                        "1",
                        "TestData Modified"});
#line 96
 testRunner.And("I have nested datas", ((string)(null)), table22, "And ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content",
                        "ParentId"});
            table23.AddRow(new string[] {
                        "1",
                        "Level 2 Data",
                        "1"});
            table23.AddRow(new string[] {
                        "2",
                        "Level 2 Data 2",
                        "1"});
#line 99
 testRunner.And("the nested data with id \"1\" has level 2 data", ((string)(null)), table23, "And ");
#line 103
 testRunner.And("Register nested data update hook in generic repository", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
 testRunner.When("I use generic repository update data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 105
 testRunner.And("I save the changes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table24.AddRow(new string[] {
                        "1",
                        "TestData Modified"});
#line 106
 testRunner.Then("database should exists nested datas", ((string)(null)), table24, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table25.AddRow(new string[] {
                        "1",
                        "Level 2 Data"});
            table25.AddRow(new string[] {
                        "2",
                        "Level 2 Data 2"});
#line 109
 testRunner.And("database should exists nested level 2 datas", ((string)(null)), table25, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
