using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
	public static class Sort
	{
		public static List<int> MergeSort(List<int> tergetList)
		{
			int length = tergetList.Count;//対象の長さ
			int mid = length / 2; //真ん中をとる

			if (length == 1) return tergetList; //要素一つなら帰る
			
			List<int> leftList = MergeSort( tergetList.GetRange(0,mid));
			List<int> rightList = MergeSort( tergetList.GetRange(mid, length-mid));
			
			List<int> mergedList = new List<int>();

			while (leftList.Count != 0 && rightList.Count != 0)
			{
				if (leftList[0] < rightList[0])
				{
					mergedList.Add(leftList[0]);
					leftList.RemoveAt(0);
				}
				else
				{
					mergedList.Add(rightList[0]);
					rightList.RemoveAt(0);
				}
			}

			if (leftList.Count > 0)
			{
				mergedList.AddRange(leftList);
			}
			else
			{
				mergedList.AddRange(rightList);
			}

			return mergedList;

		}
	}
}
