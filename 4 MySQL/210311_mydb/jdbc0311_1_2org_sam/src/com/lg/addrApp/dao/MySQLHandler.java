package com.lg.addrApp.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import com.lg.addrApp.model.AddrBook;

public class MySQLHandler {// 메인에서 static영역이었음, static : 생성안해도 접근가능
	Connection con; // private 안 써도 됨 패키지 분리돼있어서
	Statement state;
	final String USER_ID = "root";
	final String USER_PW = "1126";
	final String DBNAME = "swup_mydb_210304";

	String jdbcDriver = "com.mysql.cj.jdbc.Driver";
	String dbUrl = "jdbc:mysql://localhost/" + DBNAME + "?validationQuery=select 1" + "&serverTimezone=UTC"; // 127.0.0.1

	public MySQLHandler() {
		connectDB();
	}

	private void connectDB() {
		try {
			Class.forName(jdbcDriver);
			con = DriverManager.getConnection(dbUrl, USER_ID, USER_PW);

			if (con != null) {
				state = con.createStatement();
				System.out.println("DB 접속 성공");
				// System.out.println(con);
			}
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public void closeDB() {
		try {
			state.close();
			con.close();
			System.out.println("DB 접속 해제");
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public void createTB() { // 무결성 == 정확한 값
		String query = "create table addrbook (" + "id INT(10) NOT NULL AUTO_INCREMENT," + "name VARCHAR(10) NOT NULL, "
				+ "age INT(3) NOT NULL, " + "tel VARCHAR(20) NOT NULL," + "address VARCHAR(40) NOT NULL, "
				+ "email VARCHAR(30) NULL," + "date DATETIME NOT NULL," + "PRIMARY KEY(id))";

		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			/*
			 * System.out.println(e.getSQLState()); System.out.println(e.getMessage());
			 * System.out.println(e.getErrorCode());
			 * System.out.println(e.getCause().toString());
			 */

			/*
			 * if (e.getErrorCode() == 1050) { System.out.println("테이블이 이미 존재함"); //
			 * System.out.println(e.getMessage()); }
			 */
			checkErr(e);
		}
	}

	public void dropTb() {
		String query = "drop table addrbook";

		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			checkErr(e);
		}
	}

	public void checkErr(SQLException e) {
		switch (e.getErrorCode()) {
		case 1050:
			System.out.println("테이블이 이미 존재함");
			break;

		case 1051:
			System.out.println("삭제할 테이블이 존재하지 않음");
			break;
		}
	}

	public void insertDB() {
		String query = "insert into addrbook values" + "(0,'홍길동',100,'010-1234-1234'," + "'여기저기 주소','hong@naver.com',"
				+ "now())"; // 명시 없을때는 값 다 넣어줌, t_user

		String name = "갈갈이"; // 속성명시, null 아닌 일부속성만 입력(변수로)
		int age = 200;
		String email = "muu@naver.com";
		String tel = "010-000-1234";
		String addr = "서울 대전 대구 부산";

		String query2 = String.format(
				"insert into addrbook(name, age, tel, address, email)" + " values('%s', %d, '%s','%s','%s')", name, age,
				tel, addr, email); // print f 같은 함수

		String query3 = "delete from addrbook where i_user>=30 &&i_user<=32";
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public void insertDB(AddrBook ab) {
		String query2 = String.format(
				"insert into addrbook(name, age, " + "tel, address, email, date)"
						+ " values('%s', %d, '%s','%s','%s',now())",
				ab.getName(), ab.getAge(), ab.getTel(), ab.getAddress(), ab.getEmail());
		try {
			state.executeUpdate(query2);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public void updateDB() {
		String query = "update addrbook set name='전우치' where name like '%길동'";
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public void updateDB(String seName, String fixName) {
		String query = String.format("update addrbook set name = '%s'" + " where name = '%s'", fixName, seName);
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public void deleteDB(String delName) {
		String query = String.format("delete from addrbook" + " where name = '%s'", delName);
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public void showDB() {
		String query = "select * from addrbook";
		try {
			ResultSet rs = state.executeQuery(query);

			if (rs != null) {
				rs = state.getResultSet();
				int n = 0;
				int index = 1;
				/*
				 * while (rs.next()) { System.out.print(n + "\t");
				 * System.out.print(rs.getString("id") + "\t");
				 * System.out.print(rs.getString("name") + "\t");
				 * System.out.print(rs.getString("age") + "\t");
				 * System.out.print(rs.getString("tel") + "\t");
				 * System.out.print(rs.getString("address") + "\t");
				 * System.out.print(rs.getString("email") + "\t");
				 * System.out.println(rs.getString(7)); }
				 */

				while (rs.next()) {
					System.out.print(index++ + "\t");
					System.out.print(rs.getString(n + 1) + "\t");
					System.out.print(rs.getString(2) + "\t");
					System.out.print(rs.getString(3) + "\t");
					System.out.print(rs.getString(4) + "\t");
					System.out.print(rs.getString(5) + "\t");
					System.out.print(rs.getString(6) + "\t");
					System.out.println(rs.getString(7));
				}
			}

		} catch (

		SQLException e) {
			e.printStackTrace();
		}

	}
}
