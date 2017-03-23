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
namespace Mobiquity.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("LoginFeature", SourceFile="Features\\LoginFeature.feature", SourceLine=0)]
    public partial class LoginFeatureFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "LoginFeature.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "LoginFeature", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
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
        
        public virtual void LoginLogoutWithValidCreadentials(string email, string password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "login"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login/Logout with valid creadentials", @__tags);
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("Login page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.When(string.Format("\'{0}\' and \'{1}\' are entered and login button pressed", email, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
 testRunner.Then("User is successfully logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 8
 testRunner.And("User can logout", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Login/Logout with valid creadentials, somemail@gmail.com", new string[] {
                "login"}, SourceLine=11)]
        public virtual void LoginLogoutWithValidCreadentials_SomemailGmail_Com()
        {
            this.LoginLogoutWithValidCreadentials("somemail@gmail.com", "password", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Login/Logout with valid creadentials, email.with.dots@gm.ail.com", new string[] {
                "login"}, SourceLine=11)]
        public virtual void LoginLogoutWithValidCreadentials_Email_With_DotsGm_Ail_Com()
        {
            this.LoginLogoutWithValidCreadentials("email.with.dots@gm.ail.com", "password", ((string[])(null)));
#line hidden
        }
        
        public virtual void LoginWithInvalidCreadentials(string email, string password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "login"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login with invalid creadentials", @__tags);
#line 16
this.ScenarioSetup(scenarioInfo);
#line 17
 testRunner.Given("Login page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 18
 testRunner.When(string.Format("\'{0}\' and \'{1}\' are entered and login button pressed", email, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.Then("User sees error message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Login with invalid creadentials, invalidmail1", new string[] {
                "login"}, SourceLine=22)]
        public virtual void LoginWithInvalidCreadentials_Invalidmail1()
        {
            this.LoginWithInvalidCreadentials("invalidmail1", "password", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Login with invalid creadentials, invalidmail2@.com", new string[] {
                "login"}, SourceLine=22)]
        public virtual void LoginWithInvalidCreadentials_Invalidmail2_Com()
        {
            this.LoginWithInvalidCreadentials("invalidmail2@.com", "password", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Login with invalid creadentials, invalidmail3@gmail", new string[] {
                "login"}, SourceLine=22)]
        public virtual void LoginWithInvalidCreadentials_Invalidmail3Gmail()
        {
            this.LoginWithInvalidCreadentials("invalidmail3@gmail", "password", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Login with invalid creadentials, invalidmail4!#$%^&*()_@gmail.com", new string[] {
                "login"}, SourceLine=22)]
        public virtual void LoginWithInvalidCreadentials_Invalidmail4_Gmail_Com()
        {
            this.LoginWithInvalidCreadentials("invalidmail4!#$%^&*()_@gmail.com", "password", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
