using TechTalk.SpecFlow;
using System;
using NUnit.Framework;

namespace DotnetcoreTutorial.src.steps
{

  [Binding]
  public class ParametersSteps
  {

    string _word;
    int _count;
      [Given(@"the word '(.*)'")]
      public void GivenPrecondition(string theWord){
        this._word = theWord;
      }

      [When(@"i count its size")]
      public void WhenAction(){
        this._count = _word.Length;
      }

     [Then(@"i get (.*)")]
      public void ThenTestableOutcome(int expectedResult){
          Assert.AreEqual(expectedResult, this._count);
      }
  }

}