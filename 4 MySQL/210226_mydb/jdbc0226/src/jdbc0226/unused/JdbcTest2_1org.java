package jdbc0226.unused;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class JdbcTest2_1org {
	static Connection con;
	static final String USER_ID = "root";
	static final String USER_PW = "1126";
	static final String DBNAME = "swup_mydb_210225";

	static String jdbcDriver = "com.mysql.cj.jdbc.Driver";
	static String dbUrl = "jdbc:mysql://localhost" + DBNAME
			+ "?autoReconnect=true&serverTimezone=UTC"; // 127.0.0.1
																										// computer

	public static void main(String[] args) {
		connectDB();
		closeDB();
	}

	public static void connectDB() {
		try {
			
			Class.forName(jdbcDriver).newInstance(); // 안전하지 않 취소선
			con = DriverManager.getConnection(dbUrl, USER_ID, USER_PW);

			if (con != null) {
				System.out.println("DB 접속 성공");
				System.out.println(con);
			}
		} catch (InstantiationException e) {
			e.printStackTrace();
		} catch (IllegalAccessException e) {
			e.printStackTrace();
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public static void closeDB() {
		try {
			con.close();
			System.out.println("DB 접속 해제");
			
			
			/*
			 * if (con != null) { con.close(); } else { } // c스타일, 런타임 오류(동작중)
			 */ 
			} catch (SQLException e) {
			e.printStackTrace();
		}
	}
}
