# 说明

一个底层使用string的数据类型，可以在基本类型(int, long, float, double, bool, string)之间进行相互转换.

# 使用

```c sharp
Any any = new Any(3.0f);
Debug.Log(any.IsFloat);
Debug.Log(ant.AsFloat);
any.AsInt = 2;
Debug.Log(any.IsInt);
Debug.Log(any.AsInt);
```

