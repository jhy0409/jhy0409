
public class Yeje1 {

	public static void main(String[] args) {
		System.out.println("1부터 100까지 3의 배수만 출력");
		int value = 1;
		for (int i = 0; i < 10; i++) {
			for (int j = 0; j < 10; j++) {
				if (value % 3 == 0) {
					System.out.print(value++ + "\t");
				} else {
					value++;
					System.out.print("X\t");
				}

			}System.out.println();

		}

	}

}
