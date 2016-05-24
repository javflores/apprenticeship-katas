using TheShoppingBasket.Domain;
using Xunit;

namespace TheShoppingBasketTests.Domain
{
    public class MoneyShould
    {
        private readonly Money ZERO_POUNDS = new Money(0.0m);
        private readonly Money ONE_POUND = new Money(1.0m);
        private readonly Money TWO_POUNDS = new Money(2.0m);
        private readonly Money THREE_POUNDS = new Money(3.0m);
        private readonly Money FOUR_POUNDS = new Money(4.0m);

        [Fact]
        public void equal_to_zero_when_no_amount_is_provided()
        {
            Money money = new Money();

            Assert.Equal(ZERO_POUNDS, money);
        }

        [Fact]
        public void equal_to_another_money_if_amount_is_same()
        {
            Money money = ONE_POUND;
            Money anotherMoney = ONE_POUND;

            Assert.Equal(money, anotherMoney);
        }

        [Fact]
        public void not_equal_to_another_money_if_amount_is_different()
        {
            Money money = ONE_POUND;
            Money anotherMoney = TWO_POUNDS;

            Assert.NotEqual(money, anotherMoney);
        }

        [Fact]
        public void sum_two_moneys()
        {
            Money sum = ONE_POUND + TWO_POUNDS;

            Assert.Equal(THREE_POUNDS, sum);
        }

        [Fact]
        public void substract_two_moneys()
        {
            Money difference = TWO_POUNDS - ONE_POUND;

            Assert.Equal(ONE_POUND, difference);
        }

        [Fact]
        public void be_multipliable_by_integer()
        {
            Money twoTimes2 = TWO_POUNDS * 2;

            Assert.Equal(FOUR_POUNDS, twoTimes2);
        }

        [Fact]
        public void perform_fifty_percent()
        {
            Money fiftyPercentOf2 = TWO_POUNDS.FiftyPercent();

            Assert.Equal(ONE_POUND, fiftyPercentOf2);
        }

        [Fact]
        public void have_string_representation()
        {
            var moneyAsString = ONE_POUND.ToString();

            Assert.Equal("£1.00", moneyAsString);
        }
    }
}