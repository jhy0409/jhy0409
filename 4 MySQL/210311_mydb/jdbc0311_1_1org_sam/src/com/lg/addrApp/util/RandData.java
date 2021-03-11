package com.lg.addrApp.util;

import java.util.Random;

import com.lg.addrApp.model.AddrBook;

public class RandData {
	static String[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
	static int[] age = { 100, 200, 300, 400, 500 };
	static String[] tel = { "010-1111-1111", "010-2222-2222", "010-3333-3333", "010-4444-4444", "010-5555-5555" };
	static String[] address = { "대구시 동구 신천동", "서울시 동구 신천동", "부산시 동구 신천동", "인천시 동구 신천동", "대전시 동구 신천동" };
	static String[] email = { "hong@naver.com", "lee@naver.com", "kong@naver.com", "ppack@naver.com", "choi@naver.com" };

	Random r = new Random();

	public String getRName() {
		return name[r.nextInt(5)];
	}

	public int getRAge() {
		return age[r.nextInt(5)];
	}

	public String getRTel() {
		return tel[r.nextInt(5)];
	}

	public String getRAddr() {
		return address[r.nextInt(5)];
	}

	public String getREmail() {
		return email[r.nextInt(5)];
	}

	public AddrBook getABook() {
		return new AddrBook(getRName(), getRAge(), getRTel(), getRAddr(), getREmail());
	} // VO 밸류ㅇㅂ ㅇㅂ젝트, 의미없이 사용하는 클래스
}
