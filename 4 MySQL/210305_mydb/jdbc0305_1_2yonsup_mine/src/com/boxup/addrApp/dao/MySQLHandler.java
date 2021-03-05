package com.boxup.addrApp.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import com.boxup.addrApp.model.AddrBook;

public class MySQLHandler {
	Connection con;
	Statement state;
	final String USER_ID = "root";
	final String USER_PW = "1126";
	final String DBNAME = "swup_mydb_210304";

	String jdbcDriver = "com.mysql.cj.jdbc.Driver";
	String dbUrl = "jdbc:mysql://localhost/" + DBNAME + "?validationQuery=select 1" + "&serverTimezone=UTC"; // 127.0.0.1

	public MySQLHandler() {
		connectDB();
	}

	public void connectDB() {
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
		String query = "create table AddrBook (" + "id INT(10) NOT NULL AUTO_INCREMENT," + "name VARCHAR(10) NOT NULL, "
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
		String query = "drop table AddrBook";

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

	public void showDB() {
		String query = "select * from addrbook";
		try {
			ResultSet rs = state.executeQuery(query);

			if (rs != null) {
				rs = state.getResultSet();
				int n = 0;
				while (rs.next()) {
					System.out.print(n + "\t");
					System.out.print(rs.getString("id") + "\t");
					System.out.print(rs.getString("name") + "\t");
					System.out.print(rs.getString("age") + "\t");
					System.out.print(rs.getString("tel") + "\t");
					System.out.print(rs.getString("address") + "\t");
					System.out.print(rs.getString("email") + "\t");
					System.out.println(rs.getString(7));
				}
				rs.close();
			}

		} catch (SQLException e) {
			e.printStackTrace();
		}

	}

	public void updData(String[] irum) {
		// 0번째 수정할, 1번째 수정이름
		// 같으면

		// 1번 이름으로 수정한다.
		String query = "update addrbook set name = '" + irum[1]
				+ "', age = 10, tel = '010-9999-0009', address = '주주주소 만촌동', email = 'emdkjf@naver.com' "
				+ "where name = '" + irum[0] + "'";

		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public void delData(int[] index1) {
		// TODO Auto-generated method stub
		
	}

}
