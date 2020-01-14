using TechTalk.SpecFlow;
using System;
using NUnit.Framework;

namespace DotnetcoreTutorial.src.steps
{

  [Binding]
  public class ParametersSteps
  {

    string word;
    int count;
      [Given(@"the word '(.*)'")]
      public void GivenPrecondition(string theWord){
        this.word = theWord;
      }

      [When(@"i count its size")]
      public void WhenAction(){
        this.count = word.Length;
      }

     [Then(@"i get (.*)")]
      public void ThenTestableOutcome(int expectedResult){
          Assert.AreEqual(expectedResult, this.count);
      }
  }

}