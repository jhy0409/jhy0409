package jdbc0304_2;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Random;
import java.util.Scanner;

public class JdbcTest2_2mine { // 1. mySQL 커넥터 등록 / 2. DB접속, 해제 추가 / 3. 기능별 구현
	static final int CREATE_TABLE = 1;
	static final int DEL_TABLE = 2;
	static final int INSERT_DATA = 3;
	static final int INSERT_RAND_DATA = 4;
	static final int VIEW_DATA = 5;

	static final int UPDATE_DATA = 6;
	static final int DEL_DATA = 7;
	static final int MAIN_EXIT = 8;

	public static void main(String[] args) {
		connectDB();
		Scanner s = new Scanner(System.in);
		Random r = new Random();
		while (true) {
			switch (menu(s)) {
			case CREATE_TABLE:
				makeTable(s);
				break;
			case DEL_TABLE:
				delTable(s);
				break;
			case INSERT_DATA:
				insertDB(s);
				break;
			case INSERT_RAND_DATA:
				insertRandDB(r, s);
				break;
			case VIEW_DATA:
				showDB(s);
				break;

			case UPDATE_DATA:
				editDB(s);
				break;
			case DEL_DATA:
				delDB(s);
				break;
			case MAIN_EXIT:
				closeDB();
				s.close();
				System.out.println("프로그램 종료");
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
		System.out.println("4. 랜덤 데이터 추가");
		System.out.println("5. 데이터 보기\n");
		System.out.println("6. 데이터 수정");
		System.out.println("7. 데이터 삭제");
		System.out.println("8. 종료");
		System.out.println("----------------------");

		System.out.print("메인 메뉴 선택 : ");
		return s.nextInt();
	}

	public static void delDB(Scanner s) { // 7. 데이터 삭제
		System.out.print("\n테이블 선택 : ");
		String tableName = s.next();
		System.out.println("----------------------");
		System.out.println("삭제할 id범위 입력");
		System.out.println("----------------------");
		System.out.println("1. 범위 삭제");
		System.out.println("2. 개별 삭제");
		System.out.println("----------------------");
		System.out.print("메뉴 선택 : ");
		int menuNum = s.nextInt();
		String query = "";
		switch (menuNum) {
		case 1:
			System.out.print("최소 값 id 1 : ");
			int idNo1 = s.nextInt();
			System.out.print("최대 값 id 2 : ");
			int idNo2 = s.nextInt();

			query = "delete from " + tableName + " where i_user >= " + idNo1 + " && i_user <= " + idNo2;
			try {
				state.executeUpdate(query);
			} catch (SQLException e) {
				e.printStackTrace();
			}
			break;

		case 2:
			System.out.print("삭제할 id입력 : ");
			idNo1 = s.nextInt();
			query = "delete from " + tableName + " where i_user = " + idNo1;
			try {
				state.executeUpdate(query);
			} catch (SQLException e) {
				e.printStackTrace();
			}
			break;
		default:
			System.out.println("잘못된 입력입니다\n");
			break;
		}
	}

	public static void editDB(Scanner s) { // 6. 데이터 수정
		System.out.println("----------------------");
		System.out.println("    수정할 메뉴 목록");
		System.out.println("----------------------");
		System.out.println("1. 이름");
		System.out.println("2. 나이");
		System.out.println("3. 메일");
		System.out.println("4. 전화");
		System.out.println("5. 주소");
		System.out.println("----------------------");
		System.out.print("수정할 테이블 : ");
		String tbName = s.next();
		System.out.print("수정할 id 입력 : ");
		String editId = s.next();
		System.out.print("수정할 항목 : ");
		int menuN = s.nextInt();
		String hangmoK = "";
		String contents = "";
		int age = 0;
		switch (menuN) {
		case 1:
			hangmoK = "user_nm";
			System.out.print("이름 입력 : ");
			contents = s.next();
			break;
		case 2:
			hangmoK = "user_age";
			System.out.print("나이 입력 : ");
			age = s.nextInt();
			break;
		case 3:
			hangmoK = "email";
			System.out.print("메일 입력 : ");
			contents = s.next();
			break;
		case 4:
			hangmoK = "user_phone";
			System.out.print("전화 입력 : ");
			contents = s.next();
			break;
		case 5:
			hangmoK = "user_addr";
			System.out.print("주소 입력 : ");
			contents = s.next();
			break;
		}

		if (menuN == 2) {
			String query = "update " + tbName + " set " + hangmoK + " = " + age + " where i_user = " + editId;
			try {
				state.executeUpdate(query);
			} catch (SQLException e) {
				e.printStackTrace();
			}
		} else {
			String query = "update " + tbName + " set " + hangmoK + " = '" + contents + "' where i_user = " + editId;
			try {
				state.executeUpdate(query);
			} catch (SQLException e) {
				e.printStackTrace();
			}
		}
	}

	public static void showDB(Scanner s) { // 5. 데이터 보기

		System.out.print("조회할 테이블명 : ");
		String tbName = s.next();

		String query = "select * from " + tbName;
		try {
			ResultSet rs = state.executeQuery(query);
			if (rs != null) {
				rs = state.getResultSet();
				int n = 0;
				System.out.println(
						"-------------------------------------------------------------------------------------------------");
				System.out.print("번호\t아이디\t이름\t나이\t메일\t\t전화\t\t주소\t\t생성일시\n");
				System.out.println(
						"-------------------------------------------------------------------------------------------------");
				while (rs.next()) {

					System.out.print(n + "\t");
					System.out.print(rs.getString("i_user") + "\t");
					System.out.print(rs.getString("user_nm") + "\t");
					System.out.print(rs.getString("user_age") + "\t");
					System.out.print(rs.getString("email") + "\t");

					System.out.print(rs.getString("user_phone") + "\t");
					System.out.print(rs.getString("user_addr") + "\t");
					System.out.println(rs.getString(7));
					n++;
				}
				System.out.println(
						"-------------------------------------------------------------------------------------------------\n");
				rs.close();
			}

		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public static void insertRandDB(Random r, Scanner s) { // 4. 랜덤 데이터 추가
		String name[] = { "파차하", "타하카", "자파하", "차카타", "타카하" };
		int age[] = { 10, 20, 30, 40, 50 };
		String email[] = { "aaa@a.com", "bbb@example.com", "ccc@daum.net", "dd@google.com", "efg@naver.com" };
		String phone[] = { "010-1111-1111", "010-2222-2222", "010-3333-3333", "010-4444-4444", "010-5555-5555" };
		String addr[] = { "서울 평리 1동", "대전 평리 1동", "대구 평리 1동", "부산 평리 1동", "경기도 평리 1동" };

		System.out.print("데이터 추가할 테이블명 : ");
		String tableName = s.next();
		System.out.print("랜덤 생성 개수 : ");
		int su = s.nextInt();

		for (int i = 0; i < su; i++) {
			String query = String.format(
					"insert into " + tableName + "(user_nm, user_age," + "email, user_phone, user_addr)"
							+ " values('%s',%d,'%s','%s','%s')",
					name[r.nextInt(5)], age[r.nextInt(5)], email[r.nextInt(5)], phone[r.nextInt(5)],
					addr[r.nextInt(5)]);
			try {
				state.executeUpdate(query);
			} catch (SQLException e) {
				e.printStackTrace();
			}
		}
		System.out.printf("[ %d ]개가 생성 완료되었음\n", su);
	}

	public static void insertDB(Scanner s) { // 3. 데이터 추가, 테이블조회, 선택 테이블에 추가
		System.out.println("----------------------");
		System.out.print("데이터 추가할 테이블명 : ");
		String tableName = s.next();
		System.out.println("----------------------");
		System.out.println(" 데이터 입력 ");
		System.out.print("이름 : ");
		String name = s.next();
		System.out.print("나이 : ");
		int age = s.nextInt();
		System.out.print("메일 : ");
		String email = s.next();
		System.out.print("전화 : ");
		String phone = s.next();
		System.out.print("주소 : ");
		String addr = s.next();

		String query = String.format("insert into " + tableName + "(user_nm, user_age,"
				+ "email, user_phone, user_addr)" + " values('%s',%d,'%s','%s','%s')", name, age, email, phone, addr);
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public static void delTable(Scanner s) { // 2. 테이블 삭제
		String query2 = "SELECT TABLE_NAME FROM information_schema.TABLES WHERE TABLE_SCHEMA = '" + DBNAME + "'";

		System.out.println("----------------------");
		System.out.println("     현재 테이블 목록");
		System.out.println("----------------------");
		try {
			ResultSet rs = state.executeQuery(query2);
			if (rs != null) {
				rs = state.getResultSet();
				while (rs.next()) {
					System.out.println(rs.getString(1));
				}
			}
		} catch (SQLException e1) {
			e1.printStackTrace();
		}

		System.out.print("삭제할 테이블명 : ");
		String delName = s.next();
		String query = "drop table " + delName;
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			e.printStackTrace();
		}

		System.out.printf("[ %s ] 테이블이 삭제 되었습니다. \n", delName);
		System.out.println("----------------------");
		System.out.println("     현재 테이블 목록");
		System.out.println("----------------------");
		try {
			ResultSet rs = state.executeQuery(query2);
			if (rs != null) {
				rs = state.getResultSet();
				while (rs.next()) {
					System.out.println(rs.getString(1));
				}
			}
		} catch (SQLException e1) {
			e1.printStackTrace();
		}
	}

	public static void makeTable(Scanner s) { // 1. 테이블 생성
		System.out.print("테이블 명 : ");
		String tableName = s.next();

		String query = "create table " + tableName + " (" + "i_user int NOT NULL AUTO_INCREMENT,"
				+ "user_nm varchar(10), " + "user_age int DEFAULT NULL," + "email varchar(20),"
				+ "user_phone varchar(20)," + "user_addr varchar(50),"
				+ "r_dt datetime NOT NULL DEFAULT CURRENT_TIMESTAMP," + " PRIMARY KEY (i_user))";
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	static Connection con;
	static Statement state;
	static final String USER_ID = "root";
	static final String USER_PW = "0000";
	static final String DBNAME = "swup_mydb_210304";

	static String jdbcDriver = "com.mysql.cj.jdbc.Driver";
	static String dbUrl = "jdbc:mysql://localhost/" + DBNAME + "?validationQuery=select 1" + "&serverTimezone=UTC";

	public static void connectDB() {
		try {
			Class.forName(jdbcDriver);
			con = DriverManager.getConnection(dbUrl, USER_ID, USER_PW);

			if (con != null) {
				state = con.createStatement();
				System.out.println("접속 성공");
			}
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public static void closeDB() {
		try {
			state.close();
			con.close();
		} catch (SQLException e) {
			e.printStackTrace();
		}
		System.out.println("접속 해제");
	}

}
