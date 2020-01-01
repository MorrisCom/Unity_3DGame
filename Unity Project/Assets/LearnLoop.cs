using UnityEngine;

public class LearnLoop : MonoBehaviour
{
	private void Start()
	{
		//條件成立時執行一次
		if (true)
		{

		}
		int count = 0;
		//While 迴圈
		//while (布林值){敘述}
		while (count < 5)
		{
			count++;
			print("迴圈執行" + count);
		}
	}
	
}
