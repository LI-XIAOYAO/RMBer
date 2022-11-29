using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RMBer.Tests
{
    [TestClass()]
    public class RMBerTests
    {
        static RMBerTests()
        {
            RMBer.Config(formatterOptions =>
            {
                formatterOptions.Yuan = Yuan.元;
                formatterOptions.Zheng = Zheng.整;
            });
        }

        [TestMethod()]
        public void ToCapitalRMBDecimalTest()
        {
            const decimal number = 26_398_888;
            const decimal number1 = 26_398_888.8M;
            const decimal number2 = 26_398_888.88M;
            const decimal number3 = 1_564_561_565;
            const decimal number4 = -1_564_561_888;

            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元整", number.ToCapitalRMB());
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元捌角", number1.ToCapitalRMB());
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元捌角捌分", number2.ToCapitalRMB());
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍元整", number3.ToCapitalRMB());
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌元整", number4.ToCapitalRMB());

            Formatter formatter = new Formatter();
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元整", number.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元捌角", number1.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元捌角捌分", number2.ToCapitalRMB(formatter));
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍元整", number3.ToCapitalRMB(formatter));
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌元整", number4.ToCapitalRMB(formatter));

            formatter.Yuan = Yuan.元;
            formatter.Zheng = Zheng.正;
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元正", number.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元捌角", number1.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元捌角捌分", number2.ToCapitalRMB(formatter));
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍元正", number3.ToCapitalRMB(formatter));
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌元正", number4.ToCapitalRMB(formatter));

            formatter.Yuan = Yuan.圆;
            formatter.Zheng = Zheng.正;
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆正", number.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆捌角", number1.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆捌角捌分", number2.ToCapitalRMB(formatter));
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍圆正", number3.ToCapitalRMB(formatter));
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌圆正", number4.ToCapitalRMB(formatter));

            formatter.Yuan = Yuan.圆;
            formatter.Zheng = Zheng.整;
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆整", number.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆捌角", number1.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆捌角捌分", number2.ToCapitalRMB(formatter));
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍圆整", number3.ToCapitalRMB(formatter));
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌圆整", number4.ToCapitalRMB(formatter));

            formatter.Yuan = Yuan.圆;
            formatter.Zheng = Zheng.整;
            formatter.JiaoZheng = true;
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆整", number.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆捌角整", number1.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆捌角捌分", number2.ToCapitalRMB(formatter));
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍圆整", number3.ToCapitalRMB(formatter));
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌圆整", number4.ToCapitalRMB(formatter));
        }

        [TestMethod()]
        public void ToCapitalRMBDoubleTest()
        {
            const double number = 26_398_888;
            const double number1 = 26_398_888.8;
            const double number2 = 26_398_888.88;
            const double number3 = 1_564_561_565;
            const double number4 = -1_564_561_888;

            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元整", number.ToCapitalRMB());
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元捌角", number1.ToCapitalRMB());
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元捌角捌分", number2.ToCapitalRMB());
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍元整", number3.ToCapitalRMB());
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌元整", number4.ToCapitalRMB());

            Formatter formatter = new Formatter();
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元整", number.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元捌角", number1.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元捌角捌分", number2.ToCapitalRMB(formatter));
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍元整", number3.ToCapitalRMB(formatter));
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌元整", number4.ToCapitalRMB(formatter));

            formatter.Yuan = Yuan.元;
            formatter.Zheng = Zheng.正;
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元正", number.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元捌角", number1.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元捌角捌分", number2.ToCapitalRMB(formatter));
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍元正", number3.ToCapitalRMB(formatter));
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌元正", number4.ToCapitalRMB(formatter));

            formatter.Yuan = Yuan.圆;
            formatter.Zheng = Zheng.正;
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆正", number.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆捌角", number1.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆捌角捌分", number2.ToCapitalRMB(formatter));
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍圆正", number3.ToCapitalRMB(formatter));
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌圆正", number4.ToCapitalRMB(formatter));

            formatter.Yuan = Yuan.圆;
            formatter.Zheng = Zheng.整;
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆整", number.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆捌角", number1.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆捌角捌分", number2.ToCapitalRMB(formatter));
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍圆整", number3.ToCapitalRMB(formatter));
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌圆整", number4.ToCapitalRMB(formatter));

            formatter.Yuan = Yuan.圆;
            formatter.Zheng = Zheng.整;
            formatter.JiaoZheng = true;
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆整", number.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆捌角整", number1.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆捌角捌分", number2.ToCapitalRMB(formatter));
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍圆整", number3.ToCapitalRMB(formatter));
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌圆整", number4.ToCapitalRMB(formatter));
        }

        [TestMethod()]
        public void ToCapitalRMBIntTest()
        {
            const int number = 26_398_888;
            const int number3 = 1_564_561_565;
            const int number4 = -1_564_561_888;

            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元整", number.ToCapitalRMB());
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍元整", number3.ToCapitalRMB());
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌元整", number4.ToCapitalRMB());

            Formatter formatter = new Formatter();
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元整", number.ToCapitalRMB(formatter));
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍元整", number3.ToCapitalRMB(formatter));
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌元整", number4.ToCapitalRMB(formatter));

            formatter.Yuan = Yuan.元;
            formatter.Zheng = Zheng.正;
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元正", number.ToCapitalRMB(formatter));
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍元正", number3.ToCapitalRMB(formatter));
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌元正", number4.ToCapitalRMB(formatter));

            formatter.Yuan = Yuan.圆;
            formatter.Zheng = Zheng.正;
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆正", number.ToCapitalRMB(formatter));
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍圆正", number3.ToCapitalRMB(formatter));
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌圆正", number4.ToCapitalRMB(formatter));

            formatter.Yuan = Yuan.圆;
            formatter.Zheng = Zheng.整;
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆整", number.ToCapitalRMB(formatter));
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍圆整", number3.ToCapitalRMB(formatter));
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌圆整", number4.ToCapitalRMB(formatter));

            formatter.Yuan = Yuan.圆;
            formatter.Zheng = Zheng.整;
            formatter.JiaoZheng = true;
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆整", number.ToCapitalRMB(formatter));
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍圆整", number3.ToCapitalRMB(formatter));
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌圆整", number4.ToCapitalRMB(formatter));
        }

        [TestMethod()]
        public void ToCapitalRMBLongTest()
        {
            const long number = 26_398_888;
            const long number3 = 1_564_561_565;
            const long number4 = -1_564_561_888;

            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元整", number.ToCapitalRMB());
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍元整", number3.ToCapitalRMB());
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌元整", number4.ToCapitalRMB());

            Formatter formatter = new Formatter();
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元整", number.ToCapitalRMB(formatter));
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍元整", number3.ToCapitalRMB(formatter));
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌元整", number4.ToCapitalRMB(formatter));

            formatter.Yuan = Yuan.元;
            formatter.Zheng = Zheng.正;
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元正", number.ToCapitalRMB(formatter));
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍元正", number3.ToCapitalRMB(formatter));
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌元正", number4.ToCapitalRMB(formatter));

            formatter.Yuan = Yuan.圆;
            formatter.Zheng = Zheng.正;
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆正", number.ToCapitalRMB(formatter));
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍圆正", number3.ToCapitalRMB(formatter));
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌圆正", number4.ToCapitalRMB(formatter));

            formatter.Yuan = Yuan.圆;
            formatter.Zheng = Zheng.整;
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆整", number.ToCapitalRMB(formatter));
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍圆整", number3.ToCapitalRMB(formatter));
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌圆整", number4.ToCapitalRMB(formatter));

            formatter.Yuan = Yuan.圆;
            formatter.Zheng = Zheng.整;
            formatter.JiaoZheng = true;
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆整", number.ToCapitalRMB(formatter));
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍圆整", number3.ToCapitalRMB(formatter));
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌圆整", number4.ToCapitalRMB(formatter));
        }

        [TestMethod()]
        public void ToCapitalRMBStringTest()
        {
            const string number = "26398888";
            const string number1 = "26398888.8";
            const string number2 = "26398888.88";
            const string number3 = "1564561565";
            const string number4 = "-1564561888";

            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元整", number.ToCapitalRMB());
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元捌角", number1.ToCapitalRMB());
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元捌角捌分", number2.ToCapitalRMB());
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍元整", number3.ToCapitalRMB());
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌元整", number4.ToCapitalRMB());

            Formatter formatter = new Formatter();
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元整", number.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元捌角", number1.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元捌角捌分", number2.ToCapitalRMB(formatter));
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍元整", number3.ToCapitalRMB(formatter));
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌元整", number4.ToCapitalRMB(formatter));

            formatter.Yuan = Yuan.元;
            formatter.Zheng = Zheng.正;
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元正", number.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元捌角", number1.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元捌角捌分", number2.ToCapitalRMB(formatter));
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍元正", number3.ToCapitalRMB(formatter));
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌元正", number4.ToCapitalRMB(formatter));

            formatter.Yuan = Yuan.圆;
            formatter.Zheng = Zheng.正;
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆正", number.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆捌角", number1.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆捌角捌分", number2.ToCapitalRMB(formatter));
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍圆正", number3.ToCapitalRMB(formatter));
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌圆正", number4.ToCapitalRMB(formatter));

            formatter.Yuan = Yuan.圆;
            formatter.Zheng = Zheng.整;
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆整", number.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆捌角", number1.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆捌角捌分", number2.ToCapitalRMB(formatter));
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍圆整", number3.ToCapitalRMB(formatter));
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌圆整", number4.ToCapitalRMB(formatter));

            formatter.Yuan = Yuan.圆;
            formatter.Zheng = Zheng.整;
            formatter.JiaoZheng = true;
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆整", number.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆捌角整", number1.ToCapitalRMB(formatter));
            Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌圆捌角捌分", number2.ToCapitalRMB(formatter));
            Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍圆整", number3.ToCapitalRMB(formatter));
            Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌圆整", number4.ToCapitalRMB(formatter));
        }
    }
}