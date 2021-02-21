import java.util.Scanner;

public class Munje_01 {

	public static void main(String[] args) {
//		------------------------------------------------
//		1. 최대 최소 구하기
//		N개의 정수를 입력받고, 그 중에서 최댓값과 최솟값을 출력하시오.
//		예시
//		3을 입력하면 숫자를 3개 입력받고 그 중에서 최대 최소를 출력하기
//		------------------------------------------------

		Scanner s = new Scanner(System.in);
		System.out.print("★숫자 몇개를 받겠습니까? ");
		int sutja = s.nextInt();
		int[] arr = new int[sutja];
		int i = 0;

		for (i = 0; i < arr.length; i++) {
			System.out.printf("%d번째 숫자입력: ", (i + 1));
			arr[i] = s.nextInt();
		}

		int max = arr[0];
		int min = arr[0];
		int minN = 1;
		int maxN = 1;
		for (i = 0; i < arr.length; i++) {
			if (max < arr[i]) {
				max = arr[i];
				maxN = i + 1;
			}
			if (min > arr[i]) {
				min = arr[i];
				minN = i + 1;
			}
		}
		System.out.printf("최대값은 %d, 최소값은 %d이다.", max, min);
		System.out.printf("최대값은 %d번째 수, 최소값은 %d번째 수이다.", maxN, minN);

//		------------------------------------------------
//		for (int i = 0; i < arr.length; i++) {
//			System.out.printf("%d번째 숫자입력: ", (i + 1));
//			arr[i] = s.nextInt();
//
//			max = arr[0];
//			min = arr[0];
//			
//			if (max < arr[i]) {
//				max = arr[i];
//			}
//			if (min > arr[i]) {
//				min = arr[i];
//			}
//		}
//		System.out.printf("최대값은 %d, 최소값은 %d이다.", max, min);
//		------------------------------------------------

//		검증
//		System.out.printf("arr 배열의 크기는 %d이다.",arr.length);

		s.close();
	}

}
