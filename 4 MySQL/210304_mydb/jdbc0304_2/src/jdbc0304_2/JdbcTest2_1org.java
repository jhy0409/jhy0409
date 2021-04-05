package jdbc0304_2;

import java.util.Scanner;

public class JdbcTest2_1org {
	static final int CREATE_TABLE = 1;
	static final int DEL_TABLE = 2;
	static final int INSERT_DATA = 3;
	static final int VIEW_DATA = 4;
	static final int UPDATE_DATA = 5;

	static final int DEL_DATA = 6;
	static final int MAIN_EXIT = 7;

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		while (true) {
			switch (menu(s)) {
			case CREATE_TABLE:
				break;
			case DEL_TABLE:
				break;
			case INSERT_DATA:
				break;
			case VIEW_DATA:
				break;
			case UPDATE_DATA:
				break;

			case DEL_DATA:
				break;
			case MAIN_EXIT:
				System.out.println("프로그램 종료");
				s.close();
				System.exit(0);
				break;

			}
		}
	}

	public static int menu(Scanner s) {
		
		System.out.println("----------------------");
		System.out.println("  MySQL DB 관리 v1.0");
		System.out.println("----------------------");
		System.out.println("1. 테이블 생성");
		System.out.println("2. 테이블 삭제");
		System.out.println("3. 데이터 추가");
		System.out.println("4. 데이터 보기");
		System.out.println("5. 데이터 수정");
		System.out.println("6. 데이터 삭제");
		System.out.println("7. 종료");
		System.out.println("----------------------");

		System.out.print("메인 메뉴 선택 : ");
		return s.nextInt();
	}
}
