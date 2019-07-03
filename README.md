# GamesErrorCode
游戏通用错误状态码。  

- 参考 HTTP状态码。
- 采用8位int类型常量。  
  例如：200 -0-11-00  
  HTTP状态码三位-预留位一位-SubCode2位-InstanceCode2位
- 缩写为GEC,使用时用常量 + 临时实例code。
  ```csharp
  public static class GEC
  {
      public const int Success = 20000000;
      public const int InternalServerError = 50000000;
  }

  public class Test
  {
      public int SomeMethodReturnGEC()
      {
          return GEC.InternalServerError + 1 ;
      }
  }
  ```
