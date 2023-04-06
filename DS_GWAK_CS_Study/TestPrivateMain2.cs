using System;

// 외부에서 int 데이터 2개가 들어오고 이 2가지는 가공을 해서 private 멤버필드로 나눠갖게됨.
// 매개변수로 들어오는 2개의 데이터를 이용하여 private 멤버필드 sum(더한 값)과 mul(곱한 값)이 됨.
// 반대로, 값을 외부로 내보낼 때는 sum과 mul을 다시 더한 후 메서드를 통해서 내보내기

public class TestPrivate
{
	private int sum;
	private int mul;

	public void SetValue(int x, int y)
	{
		sum = x + y;
		mul = x * y;
	}

	public int GetValue()
	{
		int s = sum + mul;
		return s;
	}
}

public class TestPrivateMain2
{
	public static void Main()
	{
		TestPrivate tp = new TestPrivate();
		tp.SetValue(3, 5);
		int s = tp.GetValue();
		Console.WriteLine("두 수의 합과 곱을 다시 더한 값은 {0}이다.", s);
	}
}