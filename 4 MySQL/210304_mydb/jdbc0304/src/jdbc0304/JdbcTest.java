package jdbc0304;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class JdbcTest {
	static Connection con;
	static Statement state;
	static final String USER_ID = "root";
	static final String USER_PW = "1126";
	static final String DBNAME = "swup_mydb_210304";

	static String jdbcDriver = "com.mysql.cj.jdbc.Driver";
//	static String dbUrl = "jdbc:mysql://localhost" + DBNAME
//			+ "?autoReconnect=true&serverTimezone=UTC"; // 127.0.0.1
	static String dbUrl = "jdbc:mysql://localhost/" + DBNAME + "?validationQuery=select 1" + "&serverTimezone=UTC"; // 127.0.0.1
																													// computer

	static String line = "------------------------------------------------------------------------------------------";

	public static void main(String[] args) {
		connectDB();
		insertDB();
		showDB();
		closeDB();
	}

	public static void connectDB() {
		try {
			Class.forName(jdbcDriver);
			con = DriverManager.getConnection(dbUrl, USER_ID, USER_PW);

			if (con != null) {
				state = con.createStatement();
				System.out.printf("DB 접속 성공\n%s\n", line);
				// System.out.println(con);
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
			System.out.printf("%s\nDB 접속 해제", line);

			/*
			 * if (con != null) { con.close(); } else { } // c스타일, 런타임 오류(동작중)
			 */
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public static void insertDB() {
		String query = "insert into t_user values" + "(0,'홍길동',100,'hong@naver.com'," + "'010-1234-1234','여기저기 주소',"
				+ "now())"; // 명시 없을때는 값 다 넣어줌

		String name = "갈갈이"; // 속성명시, null 아닌 일부속성만 입력(변수로)
		int age = 200;
		String email = "muu@naver.com";
		String tel = "010-000-1234";
		String addr = "서울 대전 대구 부산";
		String query2 = String.format("insert into t_user(user_nm, user_age, " + "email, user_phone, user_addr)"
				+ " values('%s', %d, '%s','%s','%s')", name, age, email, tel, addr);

		String query3 = "delete from t_user where i_user>=30 &&i_user<=32";
		try {
			state.executeUpdate(query3);
		} catch (SQLException e) {
			e.printStackTrace();
		}

	}

	public static void showDB() {
		String query = "select * from t_user";
		try {
			ResultSet rs = state.executeQuery(query); // 행 정보 가져옴
			if (rs != null) {
				rs = state.getResultSet();
				int n = 0;
				while (rs.next()) {
					System.out.print(n + "\t");
					System.out.print(rs.getString("user_nm") + "\t");
					System.out.print(rs.getString("user_age") + "\t");
					System.out.print(rs.getString("email") + "\t");
					System.out.print(rs.getString("user_phone") + "\t");
					System.out.print(rs.getString("user_addr") + "\t");
					System.out.println(rs.getString(7));
					n++;
				}
				rs.close();
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
}
