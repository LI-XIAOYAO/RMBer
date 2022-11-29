# RMBer
转换成大写人民币金额。

默认配置

> 默认 `new Formatter()` `元` `整`
````
// 全局配置
RMBer.Config(formatterOptions =>
{
    formatterOptions.Yuan = Yuan.元;
    formatterOptions.Zheng = Zheng.整;
});
````

Eg：
````
var number = 26_398_888;
var number1 = 26_398_888.8;
var number2 = 26_398_888.88;
var number3 = 1_564_561_565;
var number4 = -1_564_561_888;

// 默认 Format
Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元整", number.ToCapitalRMB());
Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元捌角", number1.ToCapitalRMB());
Assert.AreEqual("贰仟陆佰叁拾玖万捌仟捌佰捌拾捌元捌角捌分", number2.ToCapitalRMB());
Assert.AreEqual("壹拾伍亿陆仟肆佰伍拾陆万壹仟伍佰陆拾伍元整", number3.ToCapitalRMB());
Assert.AreEqual("负壹拾伍亿陆仟肆佰伍拾陆万壹仟捌佰捌拾捌元整", number4.ToCapitalRMB());

// Format 显示方式
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
````