using TechTalk.SpecFlow;
using System;
using NUnit.Framework;

namespace DotnetcoreTutorial.src.steps
{

  [Binding]
  public class NoregexSteps
  {
      [Given]
      public void some_stuff(){
          Console.WriteLine("some stuff");
      }

      [When()]
      public void some_action_is_performed(){
          Console.WriteLine("some action is performed");
      }

     [Then]
      public void something_should_happen(){
          Console.WriteLine("something should happen");
          Assert.IsTrue(true,"expected true but fund false");
      }
      
      /*  Given i type 'hi'
  When she count charaters
  Then we got 2
  */
      [Given()]
      public void i_type_WORD(string word)
      {
          this.word = word;
      }

      public string word { get; set; }

      [When]
      public void she_count_charaters()
      {
          Console.WriteLine("she count charaters");
      }

      [Then]
      public void we_got_NUMBER(int number)
      {
          Assert.AreEqual(number, this.word.Length);
      }
  }

}