
public class ArrYeje3 {

	public static void main(String[] args) {
		int arr[][] = { //선언과 동시에 선언
				{1,2,3},
				{4,5,6},
				{7,8,9},
				{10,11,12}
			};
		
			for (int i = 0; i < 4; i++) {
				for (int j = 0; j < 3; j++) {
					System.out.print(arr[i][j]+"\t");
				}
				System.out.println();
			}System.out.println();
			
			int[][] arr2 = { //4행 3열, 이빠진 모양
					{1,2,3},
					{4,5},
					{6,7,8},
					{9}};
			for (int i = 0; i < arr2.length; i++) {
				for (int j = 0; j < arr2[i].length; j++) {
					System.out.print(arr2[i][j]+"\t");
				}
				System.out.println();
			}
		}
	}

