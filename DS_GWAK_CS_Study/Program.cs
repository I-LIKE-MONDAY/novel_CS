using System;
using System.Threading.Channels;
using System.Xml;

public class Family
{
	public int age;
	public long height;
	private float weight; // private
}// class

public class AccessTest
{
	public static void Main()
	{
		Family sister = new Family(); // 메모리가 생성된 상태
		sister.age = 100;
		sister.height = 170L;
		//sister.weight = 67.0F; // 에러 발생 : private는 클래스 내부에서만 사용
	}
}


