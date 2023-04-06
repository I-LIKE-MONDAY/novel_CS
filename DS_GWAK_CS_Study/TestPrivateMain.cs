using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

public class TestPrivate
{
	private int top_secret;

	public void SetWeight(int my_weight)
	{
		top_secret = my_weight;
	}

	public int GetWeight()
	{
		return top_secret;
	}
}// class

public class TestPrivateMain
{
	public static void Main()
	{
		int s;
		TestPrivate we = new TestPrivate();
		we.SetWeight(70);// 메서드의 매개변수를 이용한 private 값 셋팅
		s = we.GetWeight();// 메서드의 리턴을 이용하여 private 데이터 얻기 : 간접적으로 접근
		Console.WriteLine("private 멤버의 값은 : " + we.GetWeight());
		Console.WriteLine("private 멤버의 값은 : " + s);
		// private 멤버 필드 : 자료를 보호하기 위해서 public 메서드를 통해서만 접근이 가능하게 함
		// public 멤버메서드는 외부의 데이터를 내부로 할당하기 위해서는 매개변수를 이용하고, 외부로 반환하기 위해서는 리턴을 이용함
	}
}