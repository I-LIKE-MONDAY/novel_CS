using System;

// 값타입 매개변수 테스트
/*class TestValue
{
	static void CallByVal(int x)
	{
		x = 10000;
	}

	public static void Main()
	{
		int x1 = 10;
		CallByVal(x1);
		Console.WriteLine("Call-By-Value : {0}", x1);
		// 결과값 10
    }
}*/

class TestRef1
{
	static void CallByRef(ref int x)
	{
		x = 10000;
	}

	public static void Main()
	{
		int x1 = 10; // ref를 사용할 때는 반드시 초기화해야 함
		CallByRef(ref x1);
		Console.WriteLine("Call-By-Reference : {0}", x1);
	}
}