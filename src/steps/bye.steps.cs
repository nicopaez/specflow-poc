using TechTalk.SpecFlow;
using System;
using NUnit.Framework;

namespace DotnetcoreTutorial.src.steps
{

  [Binding]
  public class ByeSteps
  {
      [Given(@"it is raining")]
      public void GivenPrecondition(){
          Console.WriteLine("it is raining");
      }

      [When(@"i go out")]
      public void WhenAction(){
          Console.WriteLine("i go out");
      }

     [Then(@"i get wet")]
      public void ThenTestableOutcome(){
          Console.WriteLine("i get we");
          Assert.IsTrue(true,"expected true but fund false");
      }
  }

}