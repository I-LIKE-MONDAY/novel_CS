using System;

class RefSample
{
	public int mycom = 0;
	public int yourcom = 0;
}

public class RefSampleMAin
{
	public static void Main()
	{
		RefSample rs = null; // 변수 선언
		rs = new RefSample(); // 메모리 생성
	}
}
