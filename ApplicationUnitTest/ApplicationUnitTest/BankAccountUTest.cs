using BankAccount;
using Moq;
using NUnit.Framework;
using System;

namespace ApplicationUnitTest
{
    [TestFixture]
    public class BankAccountUTest
    {
        SavingsAccount myaccount;
        [SetUp]
        public void Setup()
        {
           myaccount = new SavingsAccount(100);
        }
    /*    [Test]
        public void SavingsAccount_Deposit_ThrowExceptionNegative()
        {
            var ex=Assert.Throws<ArgumentException>(() => myaccount.deposit(-1));
            StringAssert.StartsWith("Deposit Amount Must be positive", ex.Message);
            
        }*/


      [Test]
       public void SavingAccount_Deposit_shouldIncreseBalance()
        {
            // Assert.That(2+2,Is.EqualTo(4));
            //  Assert.That(2 + 2, Is.EqualTo(5));
            // Assert.Inconclusive();
            // Assert.Fail("This is Fail");
            //  Assert.Warn("This does not looks good");//inconclusive

            //    Warn.If(2 + 2 != 5);
            //   Warn.If(5+5==10);
            // Warn.If(5 + 5 != 10);
            //  Warn.If(() => 2 + 2, Is.Not.EqualTo(5));
            //  Warn.If(() => 2 + 2, Is.Not.EqualTo(5).After(2000));


            //Arrange
        //    SavingsAccount myaccount = new SavingsAccount(100);


            //Act
            myaccount.deposit(100);
            //Assert
              Assert.That(myaccount.Balance, Is.EqualTo(200));

          //  Assert.Throws<ArgumentException>(() =>myaccount.deposit(-1));

        }

        [Test]

        public void SavingAccount_Withdraw_ShouldDecreasedBalance()
        {
            //Arrange
          //  SavingsAccount myaccount = new SavingsAccount(500);


            //Act
            myaccount.withdraw(100);


            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(myaccount.Balance, Is.EqualTo(0));
                Assert.That(myaccount.Balance, Is.LessThan(100));
            }


            );


        }


        [TestCase(60,true,40)]
        [TestCase(100, true, 0)]
        [TestCase(1000, false, 100)]



        public void SavingsAccount_withdraw_TestMultipleScenarios(int AmountToWithdraw,bool ShouldSucceed,int ExeceptionBalance)
        {
            var result = false;
            try
            {
                 result = myaccount.withdraw(AmountToWithdraw);
            }
            catch
            {
                result = false;
            }
           
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo(ShouldSucceed));
                Assert.That(ExeceptionBalance, Is.EqualTo(myaccount.Balance));


            }
            );
        }


       /* [Test]
        public void Test2()
        {
            Assert.Fail();
        }
        [Test]
        public void Test3()
        {
            throw new Exception();
        }*/





        [Test]
        public void SavingsAccount_Deposit_AlwaysApprovedUpdateBalance()
        {
            Mock<IApproveAuthority> approver = new Mock<IApproveAuthority>();

            approver.Setup(x => x.Approve(It.IsAny<string>())).Returns(true);
            myaccount = new SavingsAccount(100,approver.Object);

            myaccount.deposit(100);
            Assert.That(myaccount.Balance, Is.EqualTo(200));

         //   approver.Setup(x => x.Approve(It.IsAny<string>()));


                
        }
   
        [Test]
        public void SavingsAccount_Deposit_neverApproved_notUpdateBalance()
        {
            Mock<IApproveAuthority> approver = new Mock<IApproveAuthority>();

            approver.Setup(x => x.Approve(It.IsAny<string>())).Returns(false);
            myaccount = new SavingsAccount(100, approver.Object);

            myaccount.deposit(100);
            Assert.That(myaccount.Balance, Is.EqualTo(100));

        }



    }
  
}